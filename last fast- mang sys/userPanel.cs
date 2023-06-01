using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last_fast__mang_sys
{
    public partial class userPanel : Form
    {
        public userPanel()
        {
            InitializeComponent();

        }

        private void navAdmin_Click(object sender, EventArgs e)
        {
            navBut.Text = "ORDER HISTORY";
        }

        private void navUser_Click(object sender, EventArgs e)
        {
            navBut.Text = "ORDER ITEM";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            userOrderMenu obj = new userOrderMenu();
            obj.Show();
        }
    }
}
