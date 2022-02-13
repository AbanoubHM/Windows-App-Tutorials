using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpnDwn {
    public partial class UpnDwn : Form {

        public UpnDwn() {
            InitializeComponent();
            
            
            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e) {

            label1.ForeColor = Color.FromName(domainUpDown1.SelectedItem.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            label1.Font=new Font("Arial",(float) numericUpDown1.Value);
        }
    }
}
