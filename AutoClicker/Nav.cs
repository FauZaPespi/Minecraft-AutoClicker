using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Nav : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x2000000;
                return handleparam;
            }
        }
        public Point defaultX = new Point(3);

        public Nav()
        {
            InitializeComponent();
            AnimeAllNavIndex.Start();
        }

        private void AnimeAllNavIndex_Tick(object sender, EventArgs e)
        {
            if (sPanel1.Location.X == defaultX.X)
            {
                AnimeAllNavIndex.Stop();
            }
            else
            {
                MoveLeftNav(sPanel1);
                MoveLeftNav(sPanel2);
                MoveLeftNav(sPanel3);
                MoveLeftNav(sPanel4);
            }
        }
        public void MoveLeftNav(Panel panel)
        {
            panel.Location = new Point(panel.Location.X+1, panel.Location.Y);
        }
    }
}
