using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakBot
{
    class PointSystem
    {
        public string name { get; } = "Points";
        public bool pointsReq { get; } = true;
        public bool hoursReq { get; } = true;
        public short gain { get; } = 5;
        public short rollMin = 50;
        short pointsGain { get; }
        public PointSystem()
        {
        }
        public void addPoints(Viewer viewer, double amount)
        {
            viewer.points += amount;
        }
        public void removePoints(Viewer viewer, double amount)
        {
            if (viewer.points <= amount)
                viewer.points = 0;
            else
                viewer.points -= amount;
        }
        public bool commandPoints(Viewer viewer, double amount)
        {
            if (viewer.points >= amount)
                return false;
            return true;

        }
        public void gainPoints(Dictionary<string, Viewer> LiveViewers)
        {
            foreach (KeyValuePair<string, Viewer> viewer in LiveViewers)
                addPoints(viewer.Value, this.gain);
        }
        public void gamblePoints(Viewer viewer, double amount)
        {
            Random num = new Random();
            int result = num.Next(100);
            if (result + 1 > rollMin)
                addPoints(viewer, amount);
            else
                removePoints(viewer, amount);
        }
        public void refreshRank(Viewer viewer, List<Rank> rankList)
        {
            List<Rank> filteredRankList = rankList.Where(rankSelection => rankSelection.hoursReq <= viewer.hours && rankSelection.pointsReq <= viewer.points).ToList();
            Rank finalRank = null;
            bool pointsOK = false;
            bool hoursOK = false;
            foreach (Rank rank in filteredRankList)
            {
                if (finalRank == null)
                {
                    finalRank = rank;
                    continue;
                }
                if (viewer.points >= rank.pointsReq)
                    pointsOK = true;
                if (viewer.hours >= rank.hoursReq)
                    hoursOK = true;
                if (hoursOK == true && pointsOK == true)
                    finalRank = rank;
            }
            viewer.rank = finalRank;
        }
    }
}
