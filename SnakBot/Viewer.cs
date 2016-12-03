
namespace SnakBot
{
    public class Viewer
    {
        public string name { set; get; }
        public Rank rank { set; get; }
        public double points { set; get; }
        public int hours { set; get; }
        public bool isOP { set; get; }
        public Viewer(string name, Rank rank, double points, int hours, bool isOP = false)
        {
            this.name = name;
            this.rank = rank;
            this.points = points;
            this.hours = hours;
            this.isOP = isOP;
        }
    }
}
