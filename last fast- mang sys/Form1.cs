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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void navUser_Click(object sender, EventArgs e)
        {
            navBut.Text = "USER";
        }

        private void navAdmin_Click(object sender, EventArgs e)
        {
            navBut.Text = "ADMIN";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == confirmPass.Text)
            {
                match.Visible = true;
                match.Text = "Matched";
                match.ForeColor = Color.Blue;
                RegSubmit.Enabled = true;
            }
            else {
                match.Visible = true;
                match.Text = "Un-Matched";
                match.ForeColor = Color.Red;
                RegSubmit.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            const string ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            UserRegistration reg = new UserRegistration(ConnectionString);


            if (navBut.Text == "ADMIN")
            {
                if (reg.RegisterUser(fullnameTxt.Text, EmailTxt.Text, PasswordTxt.Text, "admin"))
                {
                    Login obj = new Login();
                    obj.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("user Already Exist");
                }
            }
            else if (navBut.Text == "USER")
            {
                if (reg.RegisterUser(fullnameTxt.Text, EmailTxt.Text, PasswordTxt.Text,"user"))
                {
                    Login obj = new Login();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("user Already Exist");
                }
            }

        }
    }
}
