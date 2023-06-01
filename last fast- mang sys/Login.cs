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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void navBut_Click(object sender, EventArgs e)
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
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void logSub_Click(object sender, EventArgs e)
        {
            const string ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            UserAuthentication Auth = new UserAuthentication(ConnectionString);


         if (Auth.ValidateLogin(emailTxt.Text, passwordTxt.Text) == "" )
         {
            if (navBut.Text == "ADMIN" && Auth.AuthenticateUser(emailTxt.Text, passwordTxt.Text) )
            {
             
                    if (Auth.GetUserRoleFromDatabase(ConnectionString, emailTxt.Text) == "admin")
                    {
                        MessageBox.Show("you are Authenticated");
                    }
                    else
                    {
                        MessageBox.Show("Admin Not Found");
                    }
                
            }
            else if (navBut.Text == "USER" && Auth.AuthenticateUser(emailTxt.Text, passwordTxt.Text))
            {
                if (Auth.GetUserRoleFromDatabase(ConnectionString,emailTxt.Text) == "user")
                {
                    userPanel obj = new userPanel();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Not Found");
                }
            }
         }
         else
         {
             MessageBox.Show(Auth.ValidateLogin(emailTxt.Text, passwordTxt.Text));
         }
            
        }
    }
}
