using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop {
    public partial class Drag : Form {
        Graphics g;
        Rectangle rect = new Rectangle(50,50,50,50);
        public Drag() {
            InitializeComponent();
        }
        override protected void OnPaint(PaintEventArgs e) {
            g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.Red), rect);
            base.OnPaint(e);
        }
        protected override void OnMouseDown(MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                rect = new Rectangle(e.X - 25, e.Y - 25, 50, 50);
                Invalidate();
            }
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                rect = new Rectangle(e.X - 25, e.Y - 25, 50, 50);
                Invalidate();
            }
        }

    }
}
