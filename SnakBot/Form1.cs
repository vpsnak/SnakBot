using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Data.SQLite;
using System.Threading;
using System.Timers;
using MetroFramework.Forms;
using TwitchLib.Events.Client;
using TwitchLib.Models.Client;
using TwitchLib.Models.API;
using TwitchLib;

namespace SnakBot
{
    public partial class SnakBot : MetroForm
    {
        #region Variables
        List<string> BannedWords = new List<string> { "test1", "test2" };
        //IniFile SettingsIni = new IniFile(@"C:\Users\xxxvp\Documents\Visual Studio 2015\Projects\SnakBot\SnakBot\Settings.ini");

        private const string botUsername = "snakb0t";
        private const string botAccessToken = "oauth:w4amqjjv6iwoe1jffwct8oji9u2n8j";
        private const string room = "vpsnak";
        private string channel = room;
        private const string clientID = "nitwcpgtb3gppv3n334xflom1oiwdoi";
        private const string accessToken = "ulrl3uw85a0qlfwrsj8hpp1ejzbhra";
        private List<Language> Languages = new List<Language> {
            new Language("English", "en"),
            new Language("中文","zh"),
            new Language("日本語", "ja"),
            new Language("한국어", "ko"),
            new Language("Español", "es"),
            new Language("Français", "fr"),
            new Language("Deutsch", "de"),
            new Language("Italiano", "it"),
            new Language("Português", "pt"),
            new Language("Svenska", "sv"),
            new Language("Norsk", "no"),
            new Language("Dansk", "da"),
            new Language("Nederlands", "nl"),
            new Language("Suomi", "fi"),
            new Language("Polski", "pl"),
            new Language("Ελληνικά", "el"),
            new Language("Русский", "ru"),
            new Language("Türkçe", "tr"),
            new Language("Čeština", "cs"),
            new Language("Slovenčina", "sk"),
            new Language("Magyar", "hu"),
            new Language("العربية", "ar"),
            new Language("Български", "bg"),
            new Language("ภาษาไทย", "th"),
            new Language("Tiếng Việt", "vi"),
            new Language("American Sign Language", "asl"),
            new Language("Other", "other")
        };
        public TwitchClient client = new TwitchClient(new ConnectionCredentials(botUsername, botAccessToken), room);
        public ApiRequest customApi = new ApiRequest(clientID, accessToken);

        DataManager dbData = new DataManager(new SQLFile(Environment.CurrentDirectory + @"\Users.db"), room.ToLower());
        PointSystem pointSys = new PointSystem();
        #endregion

        private void joinChannel(string channel)
        {
            client.JoinChannel(channel);
        }
        private void leaveChannel(string channel)
        {
            client.LeaveChannel(channel);
        }
        private void sendChatMessage(string message)
        {
            client.SendMessage(client.GetJoinedChannel(channel), message);
        }
        private void sendWhisper(string username, string message)
        {
            client.SendWhisper(username, message);
        }
        private void replyWhisper(string message)
        {
            client.ReplyWhisper(message);
        }
        private void timeoutViewer(string username, UInt16 time, string reason = "")
        {
            client.TimeoutUser(client.GetJoinedChannel(channel), username, TimeSpan.FromSeconds(time), reason);
        }
        private void banViewer(string username, string reason = "")
        {
            client.BanUser(client.GetJoinedChannel(channel), username, reason);
        }
        private void refreshModerators()
        {
            client.GetChannelModerators(client.GetJoinedChannel(channel));
        }

        private void clientConnected(object sender, OnConnectedArgs e)
        {
            //chatAccess("Client connected to Twitch!");
        }
        private void clientJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            //chatAccess($"Client joined channel: {e.Channel}");
        }
        private void clientOnMessageRecieved(object sender, OnMessageReceivedArgs e)
        {
            chatText(String.Format(e.ChatMessage.DisplayName + ": " + e.ChatMessage.Message));
            //{e.ChatMessage.Badges}
            //chatAccess($"[{e.ChatMessage.Channel}] {e.ChatMessage.Username}: {e.ChatMessage.Message}");
        }
        private void clientViewerLeft(object sender, OnViewerLeftArgs e)
        {
            dbData.db.openSqlConnection();
            dbData.UnloadViewer(e.Username);
            dbData.db.closeSqlConnection();

            LiveViewerSearch.AutoCompleteCustomSource.Remove(e.Username);
            ViewerListView.VirtualListSize = dbData.viewerDictionary.Count();
        }
        private void clientViewerJoined(object sender, OnViewerJoinedArgs e)
        {
            if (dbData.FindViewer(e.Username) == null)
            {
                dbData.db.openSqlConnection();
                dbData.LoadViewer(e.Username);
                dbData.db.closeSqlConnection();

                LiveViewerSearch.AutoCompleteCustomSource.Add(e.Username); // thema
                ViewerListView.VirtualListSize = dbData.viewerDictionary.Count();
            }
        }
        private void clientModeratorsRecieved(object sender, OnModeratorsReceivedArgs e)
        {
            dbData.moderatorList.Clear();
            foreach (string moderator in e.Moderators)
                dbData.moderatorList.Add(moderator);
        }

        public void chatText(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(chatText), new object[] { text });
                return;
            }
            Chat.Text += text + "\n";
        }

        /*
        Chat Events:
        OnIncorrectLogin - Fires when an invalid login is returned by Twitch
		OnConnected - Fires on listening and after joined channel, returns username and channel
		OnDisconnected - Fires when TwitchClient disconnects.
		OnMessageReceived - Fires when new chat message arrives, returns ChatMessage
		OnNewSubscriber - Fires when new subscriber is announced in chat, returns Subscriber
		OnReSubscriber - Fires when existing subscriber resubscribes, returns ReSubscriber
		OnChannelStateChanged - Fires when channel state is changed
		-OnViewerJoined - New viewer/chatter joined the chat channel room.
		-OnViewerLeft - Viewer/chatter left (PARTed) the chat channel.
		OnChatCommandReceived - Fires when command (uses custom command identifier) is received.
		OnMessageSent - Fires when a chat message is sent.
		OnUserStateChanged - Fires when a user state is received.
		OnModeratorJoined - Fires when a moderator joins chat (not necessarily real time)
		OnModeratorLeft - Fires when a moderator leaves chat (not necessarily real time)
		OnHostLeft - Fires when a hosted channel goes offline
		OnExistingUsersDetected - Fires when list of users message is received from Twitch (generally when entering the room)
		OnHostingStarted - Fires when someone begins hosting the channel the client is connected to.
		OnHostingStopped - Fires when someone that is hosting channel that client is connected to, stops.
		OnChatCleared - Fires when a moderator sends a clear chat command (channel).
		OnViewerTimedout - Fires when client detects a viewer was timedout (moderator, viewer, timeout duration, timeout reason, channel).
		OnViewerBanned - Fires when client detects a viewer was banned (moderator, viewer, ban reason, channel).
		-OnModeratorsReceived - Fires when a list of moderators is returned by Twitch (this happens by calling GetChannelModerators in the client).
        OnChatColorChanged - Fires when confirmation is received from Twitch that chat color has been successfully changed.
        
        Whisper Events:
        OnWhisperReceived - Fires when a new whisper message is received, returns WhisperMessage
        OnWhisperCommandReceived - Fires when command (uses custom command identifier) is received.
        OnWhisperSent - Fires when a whisper is sent.

        irc debug
        client.OnReadLineTest("entire IRC string goes here");
        https://github.com/swiftyspiffy/TwitchLib
        */
        private void LiveViewersUpdate()
        {
            dbData.db.conn.Open();
            Chat.Text += "Viewlist update...\n";
            pointSys.gainPoints(dbData.viewerDictionary);
            //dbData.DisplayViewers(ViewerListView);

            ViewerListView.Refresh();
            dbData.db.conn.Close();
        }
        private async void SnakBot_Load(object sender, EventArgs e)
        {
            client.OnConnected += clientConnected;
            client.OnJoinedChannel += clientJoinedChannel;
            client.OnMessageReceived += clientOnMessageRecieved;
            client.OnViewerJoined += clientViewerJoined;
            client.OnViewerLeft += clientViewerLeft;
            client.OnModeratorsReceived += clientModeratorsRecieved;
            client.Connect();
            TwitchApi.SetClientId(clientID);
            TwitchApi.SetAccessToken(accessToken);

            string usersTable = "CREATE TABLE IF NOT EXISTS [users] ([name] CHARACTER(25) NOT NULL PRIMARY KEY,[rank] CHARACTER(25) default UNRANKED,[points] DOUBLE default 0,[hours] INT default 0);";
            string ranksTable = "CREATE TABLE IF NOT EXISTS [ranks] ([name] CHARACTER(25) NOT NULL PRIMARY KEY,[pointsReq] DOUBLE default 0,[hoursReq] INT default 0);";

            StreamLanguage.DataSource = new BindingSource(Languages, null);
            StreamLanguage.DisplayMember = "lang";
            StreamLanguage.ValueMember = "langCode";

            dbData.db.conn.Open();
            dbData.db.runSQL(usersTable + ranksTable);
            dbData.LoadRanks();
            refreshModerators();
            dbData.LoadViewers(await TwitchApi.GetChatters(channel));
            ViewerListView.Refresh();
            LiveViewerSearch.AutoCompleteCustomSource.AddRange(dbData.viewerDictionary.Keys.ToArray());
            List<GameByPopularityListing>popularGames = await TwitchApi.GetGamesByPopularity(30);
            StreamGame.AutoCompleteCustomSource.AddRange(popularGames.Select(game => game.Game.Name).ToArray());
            ViewerListView.VirtualListSize = dbData.viewerDictionary.Count();
            dbData.DisplayRanks(RankListView);
            dbData.db.conn.Close();
            LiveViewersTimer.Start();
            //pointSys.refreshRank(dbData.FindViewer("vpsnak"), dbData.rankList);
            DashboardRefreshTimer_Tick(null, null);
        }

        private void SnakBot_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbData.db.openSqlConnection();
            dbData.RefreshRanks();
            //must save viewers
            dbData.UnloadViewers();
            dbData.db.closeSqlConnection();
            Environment.Exit(0);
        }
        public SnakBot()
        {
            InitializeComponent();
            /*var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            *///points,first follow,1st time in stream,is sub,ranks,hours watched,
              //db users -stats -points+rank -ranks
              //db settings -currency
              //db commands -settings -command
              //db 
              //dbData.db.openSqlConnection();
              //for(int i = 0; i < 3000; i++)
              //    dbData.db.runSQL("INSERT INTO users(name, rank, points, hours) values('test" + i + "','rank" + i%6 + "', " + i%1000 + ", " + i%500 + ");");

            //           dbData.db.closeSqlConnection();


            /*  SQLiteDataReader reader = usersDB.readSQL("SELECT * FROM users WHERE name='test33a3';"); //returns a connection you must close
              while (reader.Read())
              {
                  Chat.Text += $"{reader["name"] + ": " + reader["Rank"] + "-" + reader["points"] + "-" + reader["hours"]}\n";
              }*/
            //for (int i = 0; i < 6; i++)
            //    dbData.db.runSQL("INSERT INTO ranks(name,pointsReq,hoursReq) values('rank" + i + "'," + i * 1000 + "," + i * 1 + ");");

        }
        private void Chat_TextChanged(object sender, EventArgs e)
        {
            Chat.SelectionStart = Chat.Text.Length;
            Chat.ScrollToCaret();
        }
        private void LiveViewersTimer_Tick(object sender, EventArgs e)
        {
            LiveViewersUpdate();
        }
        //old message handler
        private void message()
        {
            /*if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(message));
            else
            {
                string[] separator = new string[] { "#" + this.channel + " :" };
                string[] singleSep = new string[] { ":","!" };

                if (readData.Contains("PRIVMSG"))
                {
                    string username = readData.Split(singleSep, StringSplitOptions.None)[1];
                    string message = readData.Split(separator, StringSplitOptions.None)[1];

                    if (BannedWordFilter(username, message))
                        return;

                    if (message[0] == '!')
                        commands(username, message);

                    Chat.Text += username + ":" + message + Environment.NewLine;

                    int ChatLines = Chat.Lines.Count();
                    if (ChatLines > 51)
                    {
                        var foos = new List<string>(Chat.Lines);
                        foos.RemoveAt(0);
                        Chat.Lines = foos.ToArray();
                    }
                }
                if (readData.Contains("PING"))
                    PingResponse();
                //Chat.Text += readData.ToString() + Environment.NewLine;
            }*/
        }
        //old command handler
        private void commands(string username, string message)
        {
           /* string command = message.Split(new[] { ' ', '!' }, StringSplitOptions.None)[1]; //! validation for commands

            switch (command.ToLower())
            {
                case "test":
                    sendChatMessage("tost");
                    break;
                case "give": //give vpsnak 100
                    bool isOP = true;
                    if (isOP)
                    {
                        string toUser = message.Split(new string[] { " " }, StringSplitOptions.None)[1];
                        if (toUser == username)
                            break;
                        if (toUser[0] == '@')
                            toUser = toUser.Split(new[] { '@' }, StringSplitOptions.None)[1];
                        string pointsToGive = message.Split(new string[] { " " }, StringSplitOptions.None)[2];
                        double pointsToTransfer = 0;
                        bool validNumber = double.TryParse(pointsToGive.Split(new[] { ' ' }, StringSplitOptions.None)[0], out pointsToTransfer);
                        if (!validNumber) break;
                        if(pointsToTransfer > 0)
                        {
                            //EditPoints(toUser, pointsToTransfer);
                            SaveSetting("General", "Points", 5);
                            sendChatMessage("Points added!");
                        }
                    }
                    break;
                default:
                    break;
            }*/
        }
        private bool BannedWordFilter(string username, string message)
        {
            foreach (string word in BannedWords)
            {
                if (message.Contains(word))
                {
                    string command = "/timeout " + username + "10";
                    sendChatMessage(command);
                    sendChatMessage(username + " has been timed out cause you have said a bad word.");
                    return true;
                }
            }
            return false;
        }
        private void SaveSetting(string Section, string Setting, Int16 value)
        {
            //Int16 settingValue = 0;
            try
            {
             /*   string[] separator = new string[] { @"\r\n" };
                Setting = Setting.Trim().ToLower();
                string settingName = SettingsIni.IniReadValue(Section, Setting); //setting name
                settingValue = Convert.ToInt16(value);

                //setting validation 2 arrays Defaults, Current
                if (settingValue > 0)
                    SettingsIni.IniWriteValue(Section, Setting, settingValue.ToString());
                if (settingValue < 0)
                    SettingsIni.IniWriteValue(Section, Setting, "0");*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //setting array me ta defaults
            }
        }
        private string LoadSetting(string Section, string Setting)
        {
            //all settigs has num values
            //string settingValue = SettingsIni.IniReadValue(Section, Setting);
            //return settingValue;
            return null;
        }
        
        //search + context
        #region list context menu + context menu functions
        //search users box
        private void LiveViewerSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var selection = ViewerListView.FindItemWithText(LiveViewerSearch.Text);
                if (selection != null)
                {
                    ViewerListView.EnsureVisible(selection.Index);
                    selection.Selected = true;
                }
                LiveViewerSearch.Clear();
            }
        }
        private void LiveViewerSearch_Enter(object sender, EventArgs e)
        {
            LiveViewerSearch.Clear();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditViewer editViewer = new EditViewer(dbData.FindViewer(ViewerListView.SelectedItems[0].Text));
            editViewer.Show();
        }
        //context menu
        private void ViewerListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (ViewerListView.FocusedItem.Bounds.Contains(e.Location) == true)
                    UserContextMenu.Show(Cursor.Position);
        }
        private void MenuAddPoints5_Click(object sender, EventArgs e)
        {
            pointSys.addPoints(dbData.FindViewer(ViewerListView.SelectedItems[0].Text), 5);
        }
        private void MenuAddPoints50_Click(object sender, EventArgs e)
        {
            pointSys.addPoints(dbData.FindViewer(ViewerListView.SelectedItems[0].Text), 50);
        }
        private void MenuAddPoints100_Click(object sender, EventArgs e)
        {
            pointSys.addPoints(dbData.FindViewer(ViewerListView.SelectedItems[0].Text), 100);
        }
        private void MenuCustomAddPoints_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                double amount = Convert.ToDouble(MenuCustomAddPoints.Text);
                if (amount > 0)
                    pointSys.addPoints(dbData.FindViewer(ViewerListView.SelectedItems[0].Text), amount);
                else
                    MessageBox.Show("Points must be positive", "Add points Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MenuCustomAddPoints.Clear();
                UserContextMenu.Close();
            }
        }
        //pause timer while context on
        private void UserContextMenu_Opening(object sender, CancelEventArgs e)
        {
            LiveViewersTimer.Stop();
        }
        private void UserContextMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            LiveViewersTimer.Start();
        }
        private void MenuRemovePoints5_Click(object sender, EventArgs e)
        {
            pointSys.removePoints(dbData.FindViewer(ViewerListView.SelectedItems[0].Text), 5);
        }
        private void MenuRemovePoints50_Click(object sender, EventArgs e)
        {
            pointSys.removePoints(dbData.FindViewer(ViewerListView.SelectedItems[0].Text), 50);
        }
        private void MenuRemovePoints100_Click(object sender, EventArgs e)
        {
            pointSys.removePoints(dbData.FindViewer(ViewerListView.SelectedItems[0].Text), 100);
        }
        private void MenuCustomRemovePoints_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                double amount = Convert.ToDouble(MenuCustomRemovePoints.Text);
                if (amount > 0)
                    pointSys.removePoints(dbData.FindViewer(ViewerListView.SelectedItems[0].Text), amount);
                else
                    MessageBox.Show("Points must be positive", "Add points Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MenuCustomRemovePoints.Clear();
                UserContextMenu.Close();
            }
        }
        #endregion

        private void ChatMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                sendChatMessage(ChatMessageBox.Text);
                ChatMessageBox.Clear();
            }
        }
        private void RankSaveButton_Click(object sender, EventArgs e)
        {
            //get textbox variables
            //add to listview
            //add to database
            Rank temp = new Rank(RankNameTextBox.Text, Convert.ToDouble(PointsReqTextBox.Text), Convert.ToInt32(HoursReqTextBox.Text));
            temp.isNew = true;
            dbData.rankList.Add(temp);
            //if exists -> update, if update -> update users with this rank
            ListViewItem itemToAdd = new ListViewItem(temp.name);
            itemToAdd.SubItems.Add(temp.pointsReq.ToString());
            itemToAdd.SubItems.Add(temp.hoursReq.ToString());
            RankListView.Items.Add(itemToAdd);
            dbData.db.openSqlConnection();
            dbData.SaveRanks();
            dbData.db.closeSqlConnection();
        }
        private void RankListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (RankListView.FocusedItem.Bounds.Contains(e.Location) == true)
                    RankContextMenu.Show(Cursor.Position);
        }
        private async void DashboardRefreshTimer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(
            //delay, uptime, averagefps, broadcaster language filter, broadcaste check box 

            StreamGame.Text = (await TwitchApi.GetTwitchChannel(channel)).Game;
            StreamTitle.Text = (await TwitchApi.GetTwitchChannel(channel)).Status;
            string langCode = (await TwitchApi.GetTwitchChannel(channel)).BroadcasterLanguage;
            StreamLanguage.SelectedValue = langCode;
            if (await TwitchApi.BroadcasterOnline(channel) != false)
                StreamViewers.Text = (await TwitchApi.GetTwitchStream(channel)).Viewers.ToString();
            else
                StreamViewers.Text = "Stream Offline";
            StreamFollowers.Text = (await TwitchApi.GetTwitchChannel(channel)).Followers.ToString();

        }

        private async void StreamUpdate_Click(object sender, EventArgs e)
        {
            //TwitchApi.UpdateStreamTitleAndGame(StreamTitle.Text, StreamGame.Text, channel);
            await ApiRequest.UpdateStreamDashboard(StreamTitle.Text, StreamGame.Text, StreamLanguage.SelectedValue.ToString(), StreamBrodacasterLanguage.Checked.ToString(), channel);
            
            //client.SendRaw();
            //broadcaster_language to the request
            // ISO 639-1 
            //["ar","bg","cs","da","de","el","en","es","es-mx","fi","fr","hu","it","ja","ko","nl","no","pl","pt","pt-br","ru","sk","sv","th","tr","vi","zh-cn","zh-tw"]
            //Basically sent a PUT request to https://tmi.twitch.tv/api/channels/CHANNEL_NAME_HERE with a token that has the chat_login scope and set the broadcaster_language_enabled value in the form data body to true/false
        }

        private void ViewerListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            //Caching is not required but improves performance on large sets.
            //To leave out caching, don't connect the CacheVirtualItems event 
            //and make sure myCache is null.

            //check to see if the requested item is currently in the cache
            if (dbData.viewerDictionary != null && e.ItemIndex < dbData.viewerDictionary.Count)
            {
                //A cache hit, so get the ListViewItem from the cache instead of making a new one.
                
                ListViewItem temp = new ListViewItem(dbData.viewerList[e.ItemIndex].name);
                temp.SubItems.Add(dbData.viewerList[e.ItemIndex].rank.name);
                temp.SubItems.Add(dbData.viewerList[e.ItemIndex].points.ToString());
                temp.SubItems.Add(dbData.viewerList[e.ItemIndex].hours.ToString());
                e.Item = temp;
            }
            else
            {
                //A cache miss, so create a new ListViewItem and pass it back.
                //int x = e.ItemIndex * e.ItemIndex;
                ListViewItem temp = new ListViewItem("Error user");
                temp.SubItems.Add("0");
                temp.SubItems.Add("0");
                temp.SubItems.Add("0");
                e.Item = temp;
            }
        }
        
        private void ViewerListView_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            //We've gotten a search request.
            //In this example, finding the item is easy since it's
            //just the square of its index.  We'll take the square root
            //and round.
            int b = Array.FindIndex(dbData.viewerList, n => n.name.Contains(e.Text));
            if(b >= 0)
                e.Index = b;
            //If e.Index is not set, the search returns null.
            //Note that this only handles simple searches over the entire
            //list, ignoring any other settings.  Handling Direction, StartIndex,
            //and the other propertwaies of SearchForVirtualItemEventArgs is up
            //to this handler.
        }

        private async void StreamGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (StreamGame.Text.Length == 3)
            {
                List<Game> results = await TwitchApi.SearchGames(StreamGame.Text);
                if (results.Count > 0)
                    StreamGame.AutoCompleteCustomSource.AddRange(results.Select(game => game.Name).ToArray());
            }
        }
    }

    class DataManager
    {
        public List<Rank> rankList { get; } = new List<Rank>();
        public Dictionary<string, Viewer> viewerDictionary { get; }
        public Viewer[] viewerList { set;  get; }
        public List<string> moderatorList { get; } = new List<string> { };
        public SQLFile db;
        public string channel { get; }
        public static string defaultRankName = "Unranked";
        public Rank defaultRank = new Rank(defaultRankName, 0, 0);

        public DataManager(SQLFile db, string channel)
        {
            this.db = db;
            this.channel = channel;
            viewerDictionary = new Dictionary<string, Viewer>();
        }
        public void LoadRanks()//load ranks from db to the list
        {
            rankList.Clear();
            rankList.Add(defaultRank);
            SQLiteDataReader reader = db.readSQL("SELECT * FROM ranks;");
            while (reader.Read())
                rankList.Add(new Rank(reader.GetString(0), reader.GetDouble(1), reader.GetInt32(2)));
            reader.Dispose();
        }
        public void RefreshRanks()//save ranks to db
        {
            //must handle default rank
            foreach (Rank rank in rankList)
                if (rank.isNew == true)
                    db.runSQL("INSERT INTO ranks VALUES('" + rank.name + "'," + rank.pointsReq + "," + rank.hoursReq + ");");
                else
                    if (rank.edited)
                        db.runSQL("UPDATE ranks SET name='" + rank.name + "', pointsReq=" + rank.pointsReq + ", hoursReq=" + rank.hoursReq + "WHERE name='" + rank.name + "';");
        }
        public void SaveRanks()
        {
            //deleted must rank check
            foreach (Rank rank in rankList)
                if (rank.isNew == true)
                {
                    db.runSQL("INSERT INTO ranks VALUES('" + rank.name + "'," + rank.pointsReq + "," + rank.hoursReq + ");");
                    rank.isNew = false;
                }
                else
                {
                    if (rank.edited == true)
                    {
                        db.runSQL("UPDATE ranks SET name='" + rank.name + "', pointsReq=" + rank.pointsReq + ", hoursReq=" + rank.hoursReq + "WHERE name='" + rank.name + "';");
                        rank.edited = false;
                    }
                }
        }
        public void LoadViewers(List<Chatter> LiveViewers)
        {
            foreach (Chatter viewer in LiveViewers)
                LoadViewer(viewer.Username, false, true);
            viewerList = viewerDictionary.Values.ToArray();
        }
        public void LoadViewer(string viewer, bool isOP = false, bool onLoad = false)
        {
            if (moderatorList.Contains(viewer))
                isOP = true;
            SQLiteDataReader reader = db.readSQL("SELECT * FROM users WHERE name='" + viewer + "';");
            if (!reader.HasRows)
            {
                reader.Dispose();
                db.runSQL("INSERT INTO users VALUES('" + viewer + "','" + defaultRank.name + "'," + 0 + "," + 0 + ");");
                viewerDictionary.Add(viewer, new Viewer(viewer, defaultRank, 0, 0, isOP));
            }
            else
            {
                reader.Read();
                Rank temp = FindRank(reader.GetString(1));
                if (temp == null)
                    viewerDictionary.Add(reader.GetString(0), new Viewer(reader.GetString(0), defaultRank, reader.GetDouble(2), reader.GetInt32(3), isOP));
                else
                    viewerDictionary.Add(reader.GetString(0), new Viewer(reader.GetString(0), temp, reader.GetDouble(2), reader.GetInt32(3), isOP));
                reader.Dispose();
            }
            if(onLoad == false)
                viewerList = viewerDictionary.Values.ToArray();
        }
        public void UnloadViewers()
        {
            foreach (Viewer viewer in viewerDictionary.Values)
                UnloadViewer(viewer, true);
            viewerDictionary.Clear();
        }
        public void UnloadViewer(string viewer, bool Save = false)
        {
            Viewer getViewer = FindViewer(viewer);
            if (getViewer != null)
                if (getViewer.rank != null)
                    db.runSQL("UPDATE users SET rank='" + getViewer.rank + "', points='" + getViewer.points + "', hours='" + getViewer.hours + "' WHERE name='" + getViewer.name + "';");
                else
                    db.runSQL("UPDATE users SET rank='" + defaultRank.name + "', points='" + getViewer.points + "', hours='" + getViewer.hours + "' WHERE name='" + getViewer.name + "';");
            if (Save == false)
                viewerDictionary.Remove(getViewer.name);
        }
        public void UnloadViewer(Viewer viewer, bool Save = false)
        {
            if (viewer.rank != null)
                db.runSQL("UPDATE users SET rank='" + viewer.rank + "', points='" + viewer.points + "', hours='" + viewer.hours + "' WHERE name='" + viewer.name + "';");
            else
                db.runSQL("UPDATE users SET rank='" + defaultRank.name + "', points='" + viewer.points + "', hours='" + viewer.hours + "' WHERE name='" + viewer.name + "';");
            if(Save == false)
                viewerDictionary.Remove(viewer.name);
        }
        public Rank FindRank(string rankName) //search in loaded ranks
        {
            foreach(Rank rank in rankList)
                if (rank.isRank(rankName))
                    return rank;
            return null;
        }
        public Viewer FindViewer(string viewerName) //search in loaded users
        {
            Viewer foundViewer;
            if (!viewerDictionary.TryGetValue(viewerName, out foundViewer))
                return null;
            return foundViewer;
        }
        public Rank ValidateRank(Rank rank)
        {
            if (rank.name != "")
                return null;
            if (rank.pointsReq < 0)
                return null;
            if (rank.hoursReq < 0)
                return null;
            return rank;
        }
        public Viewer ValidateViewer(Viewer viewer)
        {
            if (viewer.name != "")
                return null;
            if (viewer.rank == null)
                return null;
            if (viewer.points < 0)
                return null;
            if (viewer.hours < 0)
                return null;
            return viewer;
        }
        public void DisplayViewers(RichTextBox box)
        {
            box.Clear();
            foreach (KeyValuePair<string, Viewer> viewer in viewerDictionary)
                box.Text += "Key: " + viewer.Key + " Values:" + viewer.Value.points + "--" + viewer.Value.hours + "\n";
        }
        public void DisplayViewers(ListBox box)
        {
            box.Items.Clear();
            foreach (KeyValuePair<string, Viewer> viewer in viewerDictionary)
                box.Items.Add(viewer.Key.PadRight(25 - viewer.Key.Length) + "\t" + viewer.Value.points + "--" + viewer.Value.hours);
        }
        public void DisplayViewers(ListView box)
        {
           /* box.Items.Clear();
            foreach (KeyValuePair<string, Viewer> viewer in viewerDictionary) {
                if (viewer.Value.isOP == true)
                {
                    ListViewItem temp = new ListViewItem(viewer.Key);
                    temp.SubItems.Add(viewer.Value.rank.name.ToString());
                    temp.SubItems.Add(viewer.Value.points.ToString());
                    temp.SubItems.Add(viewer.Value.hours.ToString());
                    box.Items.Add(temp);
                    viewer.Value.isOP = true;
                    box.Groups[0].Items.Add(temp);
                }
                else
                {
                    ListViewItem temp = new ListViewItem(viewer.Key);
                    temp.SubItems.Add(viewer.Value.rank.name.ToString());
                    temp.SubItems.Add(viewer.Value.points.ToString());
                    temp.SubItems.Add(viewer.Value.hours.ToString());
                    box.Items.Add(temp);
                    box.Groups[1].Items.Add(temp);
                }
            }*/
        }
        public void DisplayRanks(ListView box)
        {
            box.Items.Clear();
            foreach (Rank rank in rankList)
            {
                ListViewItem temp = new ListViewItem(rank.name);
                temp.SubItems.Add(rank.pointsReq.ToString());
                temp.SubItems.Add(rank.hoursReq.ToString());
                box.Items.Add(temp);
            }
        }
    }
    class Command
    {
        public string name;
        public Permission permission;
        public string output;
        public Command()
        {

        }
    }
    public class Permission
    {
        public Permission()
        {

        }
    }
}
//INSERT INTO ranks values('testrank',6000,0);
//UPDATE ranks SET name='newrank' WHERE name='testrank'