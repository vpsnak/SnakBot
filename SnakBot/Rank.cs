using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakBot
{
    public class Rank
    {
        public string name { set; get; }
        public double pointsReq { set; get; }
        public int hoursReq { set; get; }
        public bool edited { set; get; } = false;
        public bool isNew { set; get; } = false;
        public Rank(string name, double pointsReq, int hoursReq)
        {
            this.name = name;
            this.pointsReq = pointsReq;
            this.hoursReq = hoursReq;
        }
        public bool isRank(string name)
        {
            if (this.name == name)
                return true;
            else
                return false;
        }
        public bool isRank(Rank rank)
        {
            if (this == rank)
                return true;
            else
                return false;
        }
    }
}
