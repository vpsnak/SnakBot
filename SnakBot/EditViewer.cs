using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakBot
{
    public partial class EditViewer : Form
    {
        public Viewer viewer;
        public EditViewer(Viewer viewer)
        {
            this.viewer = viewer;
            InitializeComponent();
        }

        private void EditViewer_Load(object sender, EventArgs e)
        {
            Viewername.Text = this.viewer.name;
            RankName.Text = this.viewer.rank.name;
            PointsName.Text = this.viewer.points.ToString();
            HoursName.Text = this.viewer.hours.ToString();
        }
    }
}
