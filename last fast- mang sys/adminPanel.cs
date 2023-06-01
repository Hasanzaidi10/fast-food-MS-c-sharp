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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
            
            const string ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            MenuItems obj = new MenuItems(ConnectionString);
            
            DataTable menuItem = obj.GetMenuItems(ConnectionString);

            obj.DeleteMenuItem(ConnectionString);
            itemsMenu.DataSource = menuItem;

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
