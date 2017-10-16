using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRM
{
    public partial class ARMHome : Form
    {
        public ARMHome()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Close();

        }

        private void chengePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARMPOS atmpos = new ARMPOS();
            atmpos.Show();
        }
    }
}
