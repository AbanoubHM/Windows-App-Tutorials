using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draw;
using DragDrop;

namespace MDI {
    public partial class MDI : Form {
        public MDI() {
            InitializeComponent();
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e) {
            Draw.Draw d1= new Draw.Draw();
            d1.MdiParent = this;
            d1.Show();
        }

        private void dragToolStripMenuItem_Click(object sender, EventArgs e) {
            Drag d2=new Drag();
            d2.MdiParent = this;
            d2.Show();
        }
    }
}
