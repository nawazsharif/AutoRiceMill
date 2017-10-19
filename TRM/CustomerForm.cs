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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerAddress.Text = "";
            txtEmail.Text = "";
            txtNID.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
