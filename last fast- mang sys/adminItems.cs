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
    public partial class adminItems : Form
    {
        public adminItems()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double price = Convert.ToDouble(priceTxt.Text);
            
            const string ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            MenuItems Menu = new MenuItems(ConnectionString);

            if (FormH.Text == "Additem")
            {
                if (Menu.AddMenuItem(nameTxt.Text, price, catTxt.Text, DiscTxt.Text))
                {
                    MessageBox.Show("Item Added sucessfully");
                }
                else {
                    MessageBox.Show("Item not Added try again");
                }
            }else if(FormH.Text == "Update"){

                if (Menu.ModifyMenuItem(nameTxt.Text, price, catTxt.Text, DiscTxt.Text))
                {
                    MessageBox.Show("Item Update sucessfully");
                }
                else
                {
                    MessageBox.Show("Item not updated try again");
                }
            }
            else if (FormH.Text == "Update")
            {
                pricelb.Enabled = false;
                catlb.Enabled = false;
                dislb.Enabled = false;
                if (Menu.DeleteMenuItem(nameTxt.Text))
                {
                    MessageBox.Show("Item Delete sucessfully");
                }
                else {
                    MessageBox.Show("Item not deleted try again");
                }
            }
        }
    }
}
