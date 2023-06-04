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

        private void BindDataToGrid()
        {
            MenuItems obj = new MenuItems("Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

            DataTable dataTable = obj.GetDataFromDataSource();

            // Clear existing columns and data
            userItems.Columns.Clear();
            userItems.Rows.Clear();

            // Add columns to the DataGridView
            foreach (DataColumn column in dataTable.Columns)
            {
                userItems.Columns.Add(column.ColumnName, column.ColumnName);
            }

            // Add data rows to the DataGridView
            foreach (DataRow row in dataTable.Rows)
            {
                userItems.Rows.Add(row.ItemArray);
            }
        }


        private void userPanel_Load(object sender, EventArgs e)
        {
            BindDataToGrid();
        }


    }
}
