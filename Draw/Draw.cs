using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw {
    public partial class Draw : Form {
        bool moving = false;
        int x = -1;
        int y = -1;
        Graphics g;
        public Draw() {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (moving && x != -1 && y != -1) {
                g.DrawLine(new Pen(Color.Red), new Point(x, y), e.Location);
            }
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            moving = false;
            x = -1;
            y = -1;
        }
    }
}
