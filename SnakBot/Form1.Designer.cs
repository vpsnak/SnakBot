namespace SnakBot
{
    partial class SnakBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Moderators", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Viewers", System.Windows.Forms.HorizontalAlignment.Left);
            this.UserContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddPoints = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddPoints5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddPoints50 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddPoints100 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCustomAddPoints = new System.Windows.Forms.ToolStripTextBox();
            this.MenuRemovePoints = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRemovePoints5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRemovePoints50 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRemovePoints100 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCustomRemovePoints = new System.Windows.Forms.ToolStripTextBox();
            this.RankSaveButton = new System.Windows.Forms.Button();
            this.HoursReqTextBox = new System.Windows.Forms.TextBox();
            this.PointsReqTextBox = new System.Windows.Forms.TextBox();
            this.RankListView = new System.Windows.Forms.ListView();
            this.RankName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RankPointsReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RankHoursReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RankContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LiveViewersTimer = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.DashboardTab = new System.Windows.Forms.TabPage();
            this.DashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.StreamLanguage = new MetroFramework.Controls.MetroComboBox();
            this.FollowerCountIcon = new System.Windows.Forms.PictureBox();
            this.ViewerCountIcon = new System.Windows.Forms.PictureBox();
            this.StreamUpdate = new MetroFramework.Controls.MetroButton();
            this.StreamFollowers = new MetroFramework.Controls.MetroLabel();
            this.StreamViewers = new MetroFramework.Controls.MetroLabel();
            this.StreamBrodacasterLanguage = new MetroFramework.Controls.MetroCheckBox();
            this.StreamGame = new MetroFramework.Controls.MetroTextBox();
            this.StreamTitle = new MetroFramework.Controls.MetroTextBox();
            this.ChatMessageBox = new MetroFramework.Controls.MetroTextBox();
            this.LiveViewerSearch = new MetroFramework.Controls.MetroTextBox();
            this.ViewerListView = new MetroFramework.Controls.MetroListView();
            this.ViewerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewerRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewerPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewerHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chat = new System.Windows.Forms.RichTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.RankNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DashboardRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.CommandsTab = new MetroFramework.Controls.MetroTabPage();
            this.UserContextMenu.SuspendLayout();
            this.RankContextMenu.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.DashboardTab.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FollowerCountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewerCountIcon)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserContextMenu
            // 
            this.UserContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.UserContextMenu.Name = "UserContextMenu";
            this.UserContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.UserContextMenu.ShowItemToolTips = false;
            this.UserContextMenu.Size = new System.Drawing.Size(95, 26);
            this.UserContextMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.UserContextMenu_Closed);
            this.UserContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.UserContextMenu_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddPoints,
            this.MenuRemovePoints});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // MenuAddPoints
            // 
            this.MenuAddPoints.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddPoints5,
            this.MenuAddPoints50,
            this.MenuAddPoints100,
            this.MenuCustomAddPoints});
            this.MenuAddPoints.Name = "MenuAddPoints";
            this.MenuAddPoints.Size = new System.Drawing.Size(117, 22);
            this.MenuAddPoints.Text = "Add";
            // 
            // MenuAddPoints5
            // 
            this.MenuAddPoints5.Name = "MenuAddPoints5";
            this.MenuAddPoints5.Size = new System.Drawing.Size(160, 22);
            this.MenuAddPoints5.Text = "5";
            this.MenuAddPoints5.Click += new System.EventHandler(this.MenuAddPoints5_Click);
            // 
            // MenuAddPoints50
            // 
            this.MenuAddPoints50.Name = "MenuAddPoints50";
            this.MenuAddPoints50.Size = new System.Drawing.Size(160, 22);
            this.MenuAddPoints50.Text = "50";
            this.MenuAddPoints50.Click += new System.EventHandler(this.MenuAddPoints50_Click);
            // 
            // MenuAddPoints100
            // 
            this.MenuAddPoints100.Name = "MenuAddPoints100";
            this.MenuAddPoints100.Size = new System.Drawing.Size(160, 22);
            this.MenuAddPoints100.Text = "100";
            this.MenuAddPoints100.Click += new System.EventHandler(this.MenuAddPoints100_Click);
            // 
            // MenuCustomAddPoints
            // 
            this.MenuCustomAddPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuCustomAddPoints.Name = "MenuCustomAddPoints";
            this.MenuCustomAddPoints.Size = new System.Drawing.Size(100, 23);
            this.MenuCustomAddPoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuCustomAddPoints_KeyDown);
            // 
            // MenuRemovePoints
            // 
            this.MenuRemovePoints.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRemovePoints5,
            this.MenuRemovePoints50,
            this.MenuRemovePoints100,
            this.MenuCustomRemovePoints});
            this.MenuRemovePoints.Name = "MenuRemovePoints";
            this.MenuRemovePoints.Size = new System.Drawing.Size(117, 22);
            this.MenuRemovePoints.Text = "Remove";
            // 
            // MenuRemovePoints5
            // 
            this.MenuRemovePoints5.Name = "MenuRemovePoints5";
            this.MenuRemovePoints5.Size = new System.Drawing.Size(160, 22);
            this.MenuRemovePoints5.Text = "5";
            this.MenuRemovePoints5.Click += new System.EventHandler(this.MenuRemovePoints5_Click);
            // 
            // MenuRemovePoints50
            // 
            this.MenuRemovePoints50.Name = "MenuRemovePoints50";
            this.MenuRemovePoints50.Size = new System.Drawing.Size(160, 22);
            this.MenuRemovePoints50.Text = "50";
            this.MenuRemovePoints50.Click += new System.EventHandler(this.MenuRemovePoints50_Click);
            // 
            // MenuRemovePoints100
            // 
            this.MenuRemovePoints100.Name = "MenuRemovePoints100";
            this.MenuRemovePoints100.Size = new System.Drawing.Size(160, 22);
            this.MenuRemovePoints100.Text = "100";
            this.MenuRemovePoints100.Click += new System.EventHandler(this.MenuRemovePoints100_Click);
            // 
            // MenuCustomRemovePoints
            // 
            this.MenuCustomRemovePoints.Name = "MenuCustomRemovePoints";
            this.MenuCustomRemovePoints.Size = new System.Drawing.Size(100, 23);
            this.MenuCustomRemovePoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuCustomRemovePoints_KeyDown);
            // 
            // RankSaveButton
            // 
            this.RankSaveButton.Location = new System.Drawing.Point(584, 114);
            this.RankSaveButton.Name = "RankSaveButton";
            this.RankSaveButton.Size = new System.Drawing.Size(131, 32);
            this.RankSaveButton.TabIndex = 7;
            this.RankSaveButton.Text = "Add";
            this.RankSaveButton.UseVisualStyleBackColor = true;
            this.RankSaveButton.Click += new System.EventHandler(this.RankSaveButton_Click);
            // 
            // HoursReqTextBox
            // 
            this.HoursReqTextBox.Location = new System.Drawing.Point(566, 88);
            this.HoursReqTextBox.Name = "HoursReqTextBox";
            this.HoursReqTextBox.Size = new System.Drawing.Size(166, 20);
            this.HoursReqTextBox.TabIndex = 6;
            // 
            // PointsReqTextBox
            // 
            this.PointsReqTextBox.Location = new System.Drawing.Point(566, 62);
            this.PointsReqTextBox.Name = "PointsReqTextBox";
            this.PointsReqTextBox.Size = new System.Drawing.Size(166, 20);
            this.PointsReqTextBox.TabIndex = 5;
            // 
            // RankListView
            // 
            this.RankListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RankName,
            this.RankPointsReq,
            this.RankHoursReq});
            this.RankListView.ContextMenuStrip = this.RankContextMenu;
            this.RankListView.FullRowSelect = true;
            this.RankListView.HideSelection = false;
            this.RankListView.Location = new System.Drawing.Point(17, 18);
            this.RankListView.MultiSelect = false;
            this.RankListView.Name = "RankListView";
            this.RankListView.ShowGroups = false;
            this.RankListView.Size = new System.Drawing.Size(529, 326);
            this.RankListView.TabIndex = 3;
            this.RankListView.UseCompatibleStateImageBehavior = false;
            this.RankListView.View = System.Windows.Forms.View.Details;
            this.RankListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RankListView_MouseClick);
            // 
            // RankName
            // 
            this.RankName.Text = "Name";
            // 
            // RankPointsReq
            // 
            this.RankPointsReq.Text = "Points Required";
            this.RankPointsReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RankPointsReq.Width = 97;
            // 
            // RankHoursReq
            // 
            this.RankHoursReq.Text = "Hours Required";
            this.RankHoursReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RankHoursReq.Width = 98;
            // 
            // RankContextMenu
            // 
            this.RankContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.RankContextMenu.Name = "RankContextMenu";
            this.RankContextMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // LiveViewersTimer
            // 
            this.LiveViewersTimer.Interval = 60000;
            this.LiveViewersTimer.Tick += new System.EventHandler(this.LiveViewersTimer_Tick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.DashboardTab);
            this.metroTabControl1.Controls.Add(this.CommandsTab);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1280, 660);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // DashboardTab
            // 
            this.DashboardTab.Controls.Add(this.DashboardPanel);
            this.DashboardTab.Location = new System.Drawing.Point(4, 38);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.Size = new System.Drawing.Size(1272, 618);
            this.DashboardTab.TabIndex = 0;
            this.DashboardTab.Text = "Dashboard";
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.metroPanel1);
            this.DashboardPanel.Controls.Add(this.ChatMessageBox);
            this.DashboardPanel.Controls.Add(this.LiveViewerSearch);
            this.DashboardPanel.Controls.Add(this.ViewerListView);
            this.DashboardPanel.Controls.Add(this.Chat);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.HorizontalScrollbarBarColor = true;
            this.DashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.DashboardPanel.HorizontalScrollbarSize = 10;
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1272, 618);
            this.DashboardPanel.TabIndex = 3;
            this.DashboardPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DashboardPanel.VerticalScrollbarBarColor = true;
            this.DashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.DashboardPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.StreamLanguage);
            this.metroPanel1.Controls.Add(this.FollowerCountIcon);
            this.metroPanel1.Controls.Add(this.ViewerCountIcon);
            this.metroPanel1.Controls.Add(this.StreamUpdate);
            this.metroPanel1.Controls.Add(this.StreamFollowers);
            this.metroPanel1.Controls.Add(this.StreamViewers);
            this.metroPanel1.Controls.Add(this.StreamBrodacasterLanguage);
            this.metroPanel1.Controls.Add(this.StreamGame);
            this.metroPanel1.Controls.Add(this.StreamTitle);
            this.metroPanel1.HorizontalScrollbarBarColor = false;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(757, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(512, 104);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // StreamLanguage
            // 
            this.StreamLanguage.FormattingEnabled = true;
            this.StreamLanguage.ItemHeight = 23;
            this.StreamLanguage.Location = new System.Drawing.Point(369, 34);
            this.StreamLanguage.Name = "StreamLanguage";
            this.StreamLanguage.Size = new System.Drawing.Size(140, 29);
            this.StreamLanguage.TabIndex = 11;
            this.StreamLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StreamLanguage.UseSelectable = true;
            // 
            // FollowerCountIcon
            // 
            this.FollowerCountIcon.BackColor = System.Drawing.Color.Transparent;
            this.FollowerCountIcon.Image = global::SnakBot.Properties.Resources.gray_heart;
            this.FollowerCountIcon.Location = new System.Drawing.Point(3, 71);
            this.FollowerCountIcon.Name = "FollowerCountIcon";
            this.FollowerCountIcon.Size = new System.Drawing.Size(25, 25);
            this.FollowerCountIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FollowerCountIcon.TabIndex = 15;
            this.FollowerCountIcon.TabStop = false;
            // 
            // ViewerCountIcon
            // 
            this.ViewerCountIcon.BackColor = System.Drawing.Color.Transparent;
            this.ViewerCountIcon.Image = global::SnakBot.Properties.Resources.red_user_icon;
            this.ViewerCountIcon.Location = new System.Drawing.Point(3, 34);
            this.ViewerCountIcon.Name = "ViewerCountIcon";
            this.ViewerCountIcon.Size = new System.Drawing.Size(24, 24);
            this.ViewerCountIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewerCountIcon.TabIndex = 11;
            this.ViewerCountIcon.TabStop = false;
            // 
            // StreamUpdate
            // 
            this.StreamUpdate.Location = new System.Drawing.Point(130, 69);
            this.StreamUpdate.Name = "StreamUpdate";
            this.StreamUpdate.Size = new System.Drawing.Size(233, 29);
            this.StreamUpdate.TabIndex = 14;
            this.StreamUpdate.Text = "Update";
            this.StreamUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StreamUpdate.UseSelectable = true;
            this.StreamUpdate.Click += new System.EventHandler(this.StreamUpdate_Click);
            // 
            // StreamFollowers
            // 
            this.StreamFollowers.AutoSize = true;
            this.StreamFollowers.Location = new System.Drawing.Point(29, 73);
            this.StreamFollowers.Name = "StreamFollowers";
            this.StreamFollowers.Size = new System.Drawing.Size(33, 19);
            this.StreamFollowers.TabIndex = 13;
            this.StreamFollowers.Text = "N/A";
            this.StreamFollowers.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StreamViewers
            // 
            this.StreamViewers.AutoSize = true;
            this.StreamViewers.Location = new System.Drawing.Point(29, 36);
            this.StreamViewers.Name = "StreamViewers";
            this.StreamViewers.Size = new System.Drawing.Size(33, 19);
            this.StreamViewers.TabIndex = 12;
            this.StreamViewers.Text = "N/A";
            this.StreamViewers.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StreamBrodacasterLanguage
            // 
            this.StreamBrodacasterLanguage.AutoSize = true;
            this.StreamBrodacasterLanguage.Location = new System.Drawing.Point(369, 69);
            this.StreamBrodacasterLanguage.Name = "StreamBrodacasterLanguage";
            this.StreamBrodacasterLanguage.Size = new System.Drawing.Size(140, 15);
            this.StreamBrodacasterLanguage.TabIndex = 11;
            this.StreamBrodacasterLanguage.Text = "Broadcaster Language";
            this.StreamBrodacasterLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StreamBrodacasterLanguage.UseSelectable = true;
            // 
            // StreamGame
            // 
            this.StreamGame.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StreamGame.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.StreamGame.CustomButton.Image = null;
            this.StreamGame.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.StreamGame.CustomButton.Name = "";
            this.StreamGame.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.StreamGame.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StreamGame.CustomButton.TabIndex = 1;
            this.StreamGame.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StreamGame.CustomButton.UseSelectable = true;
            this.StreamGame.CustomButton.Visible = false;
            this.StreamGame.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.StreamGame.Lines = new string[] {
        "N/A"};
            this.StreamGame.Location = new System.Drawing.Point(130, 34);
            this.StreamGame.MaxLength = 128;
            this.StreamGame.Name = "StreamGame";
            this.StreamGame.PasswordChar = '\0';
            this.StreamGame.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StreamGame.SelectedText = "";
            this.StreamGame.SelectionLength = 0;
            this.StreamGame.SelectionStart = 0;
            this.StreamGame.ShortcutsEnabled = true;
            this.StreamGame.Size = new System.Drawing.Size(233, 29);
            this.StreamGame.TabIndex = 9;
            this.StreamGame.Text = "N/A";
            this.StreamGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StreamGame.UseSelectable = true;
            this.StreamGame.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StreamGame.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.StreamGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StreamGame_KeyDown);
            // 
            // StreamTitle
            // 
            // 
            // 
            // 
            this.StreamTitle.CustomButton.Image = null;
            this.StreamTitle.CustomButton.Location = new System.Drawing.Point(482, 1);
            this.StreamTitle.CustomButton.Name = "";
            this.StreamTitle.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.StreamTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.StreamTitle.CustomButton.TabIndex = 1;
            this.StreamTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StreamTitle.CustomButton.UseSelectable = true;
            this.StreamTitle.CustomButton.Visible = false;
            this.StreamTitle.Lines = new string[] {
        "N/A"};
            this.StreamTitle.Location = new System.Drawing.Point(3, 3);
            this.StreamTitle.MaxLength = 128;
            this.StreamTitle.Name = "StreamTitle";
            this.StreamTitle.PasswordChar = '\0';
            this.StreamTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StreamTitle.SelectedText = "";
            this.StreamTitle.SelectionLength = 0;
            this.StreamTitle.SelectionStart = 0;
            this.StreamTitle.ShortcutsEnabled = true;
            this.StreamTitle.ShowClearButton = true;
            this.StreamTitle.Size = new System.Drawing.Size(506, 25);
            this.StreamTitle.TabIndex = 8;
            this.StreamTitle.Text = "N/A";
            this.StreamTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StreamTitle.UseSelectable = true;
            this.StreamTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StreamTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChatMessageBox
            // 
            // 
            // 
            // 
            this.ChatMessageBox.CustomButton.Image = null;
            this.ChatMessageBox.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.ChatMessageBox.CustomButton.Name = "";
            this.ChatMessageBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.ChatMessageBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChatMessageBox.CustomButton.TabIndex = 1;
            this.ChatMessageBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChatMessageBox.CustomButton.UseSelectable = true;
            this.ChatMessageBox.CustomButton.Visible = false;
            this.ChatMessageBox.Lines = new string[] {
        "Send chat message..."};
            this.ChatMessageBox.Location = new System.Drawing.Point(3, 590);
            this.ChatMessageBox.MaxLength = 128;
            this.ChatMessageBox.Name = "ChatMessageBox";
            this.ChatMessageBox.PasswordChar = '\0';
            this.ChatMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChatMessageBox.SelectedText = "";
            this.ChatMessageBox.SelectionLength = 0;
            this.ChatMessageBox.SelectionStart = 0;
            this.ChatMessageBox.ShortcutsEnabled = true;
            this.ChatMessageBox.ShowClearButton = true;
            this.ChatMessageBox.Size = new System.Drawing.Size(448, 25);
            this.ChatMessageBox.TabIndex = 3;
            this.ChatMessageBox.Text = "Send chat message...";
            this.ChatMessageBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ChatMessageBox.UseSelectable = true;
            this.ChatMessageBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChatMessageBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ChatMessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatMessageBox_KeyDown);
            // 
            // LiveViewerSearch
            // 
            this.LiveViewerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LiveViewerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LiveViewerSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.LiveViewerSearch.CustomButton.Image = null;
            this.LiveViewerSearch.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.LiveViewerSearch.CustomButton.Name = "";
            this.LiveViewerSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.LiveViewerSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LiveViewerSearch.CustomButton.TabIndex = 1;
            this.LiveViewerSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LiveViewerSearch.CustomButton.UseSelectable = true;
            this.LiveViewerSearch.CustomButton.Visible = false;
            this.LiveViewerSearch.Lines = new string[] {
        "search viewer..."};
            this.LiveViewerSearch.Location = new System.Drawing.Point(457, 3);
            this.LiveViewerSearch.MaxLength = 25;
            this.LiveViewerSearch.Name = "LiveViewerSearch";
            this.LiveViewerSearch.PasswordChar = '\0';
            this.LiveViewerSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LiveViewerSearch.SelectedText = "";
            this.LiveViewerSearch.SelectionLength = 0;
            this.LiveViewerSearch.SelectionStart = 0;
            this.LiveViewerSearch.ShortcutsEnabled = true;
            this.LiveViewerSearch.ShowClearButton = true;
            this.LiveViewerSearch.Size = new System.Drawing.Size(294, 25);
            this.LiveViewerSearch.TabIndex = 6;
            this.LiveViewerSearch.Text = "search viewer...";
            this.LiveViewerSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LiveViewerSearch.UseSelectable = true;
            this.LiveViewerSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LiveViewerSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LiveViewerSearch.Enter += new System.EventHandler(this.LiveViewerSearch_Enter);
            this.LiveViewerSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LiveViewerSearch_KeyDown);
            // 
            // ViewerListView
            // 
            this.ViewerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ViewerName,
            this.ViewerRank,
            this.ViewerPoints,
            this.ViewerHours});
            this.ViewerListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ViewerListView.FullRowSelect = true;
            listViewGroup1.Header = "Moderators";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "Moderatos";
            listViewGroup2.Header = "Viewers";
            listViewGroup2.Name = "Viewers";
            this.ViewerListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ViewerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ViewerListView.Location = new System.Drawing.Point(457, 34);
            this.ViewerListView.MultiSelect = false;
            this.ViewerListView.Name = "ViewerListView";
            this.ViewerListView.OwnerDraw = true;
            this.ViewerListView.Size = new System.Drawing.Size(294, 581);
            this.ViewerListView.TabIndex = 7;
            this.ViewerListView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ViewerListView.UseCompatibleStateImageBehavior = false;
            this.ViewerListView.UseSelectable = true;
            this.ViewerListView.View = System.Windows.Forms.View.Details;
            this.ViewerListView.VirtualMode = true;
            this.ViewerListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.ViewerListView_RetrieveVirtualItem);
            this.ViewerListView.SearchForVirtualItem += new System.Windows.Forms.SearchForVirtualItemEventHandler(this.ViewerListView_SearchForVirtualItem);
            this.ViewerListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewerListView_MouseClick);
            // 
            // ViewerName
            // 
            this.ViewerName.Text = "Username";
            this.ViewerName.Width = 90;
            // 
            // ViewerRank
            // 
            this.ViewerRank.Text = "Rank";
            this.ViewerRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ViewerRank.Width = 74;
            // 
            // ViewerPoints
            // 
            this.ViewerPoints.Text = "Points";
            this.ViewerPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ViewerPoints.Width = 68;
            // 
            // ViewerHours
            // 
            this.ViewerHours.Text = "Hours";
            this.ViewerHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ViewerHours.Width = 54;
            // 
            // Chat
            // 
            this.Chat.BackColor = System.Drawing.Color.DarkGray;
            this.Chat.Location = new System.Drawing.Point(3, 3);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(448, 581);
            this.Chat.TabIndex = 2;
            this.Chat.Text = "";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.RankNameTextBox);
            this.metroTabPage1.Controls.Add(this.RankSaveButton);
            this.metroTabPage1.Controls.Add(this.HoursReqTextBox);
            this.metroTabPage1.Controls.Add(this.PointsReqTextBox);
            this.metroTabPage1.Controls.Add(this.RankListView);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1272, 618);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // RankNameTextBox
            // 
            // 
            // 
            // 
            this.RankNameTextBox.CustomButton.Image = null;
            this.RankNameTextBox.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.RankNameTextBox.CustomButton.Name = "";
            this.RankNameTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.RankNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RankNameTextBox.CustomButton.TabIndex = 1;
            this.RankNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RankNameTextBox.CustomButton.UseSelectable = true;
            this.RankNameTextBox.CustomButton.Visible = false;
            this.RankNameTextBox.Lines = new string[0];
            this.RankNameTextBox.Location = new System.Drawing.Point(566, 18);
            this.RankNameTextBox.MaxLength = 32767;
            this.RankNameTextBox.Name = "RankNameTextBox";
            this.RankNameTextBox.PasswordChar = '\0';
            this.RankNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RankNameTextBox.SelectedText = "";
            this.RankNameTextBox.SelectionLength = 0;
            this.RankNameTextBox.SelectionStart = 0;
            this.RankNameTextBox.ShortcutsEnabled = true;
            this.RankNameTextBox.Size = new System.Drawing.Size(165, 32);
            this.RankNameTextBox.TabIndex = 8;
            this.RankNameTextBox.UseSelectable = true;
            this.RankNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RankNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DashboardRefreshTimer
            // 
            this.DashboardRefreshTimer.Enabled = true;
            this.DashboardRefreshTimer.Interval = 60000;
            this.DashboardRefreshTimer.Tick += new System.EventHandler(this.DashboardRefreshTimer_Tick);
            // 
            // CommandsTab
            // 
            this.CommandsTab.HorizontalScrollbarBarColor = true;
            this.CommandsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CommandsTab.HorizontalScrollbarSize = 10;
            this.CommandsTab.Location = new System.Drawing.Point(4, 38);
            this.CommandsTab.Name = "CommandsTab";
            this.CommandsTab.Size = new System.Drawing.Size(1272, 618);
            this.CommandsTab.TabIndex = 2;
            this.CommandsTab.Text = "Commands";
            this.CommandsTab.VerticalScrollbarBarColor = true;
            this.CommandsTab.VerticalScrollbarHighlightOnWheel = false;
            this.CommandsTab.VerticalScrollbarSize = 10;
            // 
            // SnakBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "SnakBot";
            this.Text = "SnakBot";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SnakBot_FormClosing);
            this.Load += new System.EventHandler(this.SnakBot_Load);
            this.UserContextMenu.ResumeLayout(false);
            this.RankContextMenu.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.DashboardTab.ResumeLayout(false);
            this.DashboardPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FollowerCountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewerCountIcon)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer LiveViewersTimer;
        private System.Windows.Forms.ContextMenuStrip UserContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAddPoints;
        private System.Windows.Forms.ToolStripMenuItem MenuAddPoints5;
        private System.Windows.Forms.ToolStripMenuItem MenuAddPoints50;
        private System.Windows.Forms.ToolStripMenuItem MenuAddPoints100;
        private System.Windows.Forms.ToolStripMenuItem MenuRemovePoints;
        private System.Windows.Forms.ToolStripMenuItem MenuRemovePoints5;
        private System.Windows.Forms.ToolStripMenuItem MenuRemovePoints50;
        private System.Windows.Forms.ToolStripMenuItem MenuRemovePoints100;
        private System.Windows.Forms.ToolStripTextBox MenuCustomRemovePoints;
        private System.Windows.Forms.ToolStripTextBox MenuCustomAddPoints;
        private System.Windows.Forms.ListView RankListView;
        private System.Windows.Forms.ColumnHeader RankName;
        private System.Windows.Forms.ColumnHeader RankPointsReq;
        private System.Windows.Forms.ColumnHeader RankHoursReq;
        private System.Windows.Forms.Button RankSaveButton;
        private System.Windows.Forms.TextBox HoursReqTextBox;
        private System.Windows.Forms.TextBox PointsReqTextBox;
        private System.Windows.Forms.ContextMenuStrip RankContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage DashboardTab;
        private MetroFramework.Controls.MetroPanel DashboardPanel;
        private MetroFramework.Controls.MetroListView ViewerListView;
        private System.Windows.Forms.ColumnHeader ViewerName;
        private System.Windows.Forms.ColumnHeader ViewerRank;
        private System.Windows.Forms.ColumnHeader ViewerPoints;
        private System.Windows.Forms.ColumnHeader ViewerHours;
        private System.Windows.Forms.RichTextBox Chat;
        private MetroFramework.Controls.MetroTextBox LiveViewerSearch;
        private MetroFramework.Controls.MetroTextBox ChatMessageBox;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton StreamUpdate;
        private MetroFramework.Controls.MetroLabel StreamFollowers;
        private MetroFramework.Controls.MetroLabel StreamViewers;
        private MetroFramework.Controls.MetroCheckBox StreamBrodacasterLanguage;
        private MetroFramework.Controls.MetroTextBox StreamGame;
        private MetroFramework.Controls.MetroTextBox StreamTitle;
        private System.Windows.Forms.PictureBox ViewerCountIcon;
        private System.Windows.Forms.PictureBox FollowerCountIcon;
        private System.Windows.Forms.Timer DashboardRefreshTimer;
        private MetroFramework.Controls.MetroTextBox RankNameTextBox;
        private MetroFramework.Controls.MetroComboBox StreamLanguage;
        private MetroFramework.Controls.MetroTabPage CommandsTab;
    }
}

