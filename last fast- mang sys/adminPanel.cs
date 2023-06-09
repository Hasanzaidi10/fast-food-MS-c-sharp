﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace last_fast__mang_sys
{
    public partial class adminPanel : Form
    {

        public adminPanel()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        adminItems obj1 = new adminItems() ;
        adminItems obj2 = new adminItems() ;
        adminItems obj3 = new adminItems() ;

        private void orderBtn_Click(object sender, EventArgs e)
        {
            obj1 = new adminItems();
            obj1.FormH.Text = "Add item";
            obj1.Show();

            if (obj2.Visible || obj3.Visible)
            {
                obj1.Hide();

                if (obj1.Visible)
                {
                    addBtn.Enabled = false;
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj2 = new adminItems();
            obj2.FormH.Text = "Delete item";
            obj2.Show();
            if (obj1.Visible && obj3.Visible)
            {
                obj2.Hide();
                if (obj2.Visible)
                {
                    deletebtn.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj3 = new adminItems();
            obj3.FormH.Text = "Update item";
            obj3.Show();
            if (obj1.Visible && obj2.Visible)
            {
                obj3.Hide();
                if (obj3.Visible)
                {
                    editbtn.Enabled = false;
                }
            }
        }

        private void navUser_Click(object sender, EventArgs e)
        {
            navBut.Text = "Items";
            items.Refresh();
        }


        private void adminPanel_Load(object sender, EventArgs e)
        {

            items.Visible = true;
            orders.Visible = true;
            users.Visible = true;

            MenuItems obj = new MenuItems("Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

            if (navBut.Text == "Items")
            {
                DataTable itemsData = obj.GetItemsDataFromDataSource();
                items.DataSource = itemsData;
                items.BringToFront();
                orders.SendToBack();
                users.SendToBack();
            }
            else if (navBut.Text == "orders")
            {
                DataTable ordersData = obj.GetItemsOrdersDataFromDataSource();
                orders.DataSource = ordersData;
                orders.BringToFront();
                items.SendToBack();
                users.SendToBack();
                orders.SendToBack();
                addBtn.Visible = false;
                deletebtn.Visible = false;
                editbtn.Visible = false;
            }
            if (navBut.Text == "Users")
            {
                DataTable usersData = obj.GetUsersDataFromDataSource();
                users.DataSource = usersData;
                users.BringToFront();
                items.SendToBack();
                orders.SendToBack();
                addBtn.Visible = false;
                deletebtn.Visible = false;
                editbtn.Visible = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            navBut.Text = "Users";
            users.Refresh();
        }

        private void navAdmin_Click(object sender, EventArgs e)
        {
            navBut.Text = "orders";
            orders.Refresh();
        }

        private void orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
