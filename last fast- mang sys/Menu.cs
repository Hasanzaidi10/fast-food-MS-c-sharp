using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace last_fast__mang_sys
{
    class MenuItems : DataBaseManager
    {
             public MenuItems(string connectionString)
            : base(connectionString)
        {
        }

        public bool AddMenuItem(string name, double price, string category,string discription)
        {
            bool item = false;

            try
            {
                string query = "INSERT INTO MenuItems (Name, Price, Category) VALUES (@Name, @Price, @Category, @Discription)";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["@Name"] = name;
                parameters["@Price"] = price;
                parameters["@Category"] = category;
                parameters["@Discription"] = discription;

                ExecuteNonQuery(query, parameters);

                item = true;
            }
            catch { 
            }

            return item;
        }

        public bool ModifyMenuItem(string name, double newPrice, string newCategory, string newDiscription)
        {
            bool item = false;

            try
            {

                string query = "UPDATE MenuItems SET Price = @NewPrice, Category = @NewCategory, Discription = @newDiscription WHERE Name = @Name";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["@NewPrice"] = newPrice;
                parameters["@NewCategory"] = newCategory;
                parameters["@NewDiscription"] = newDiscription;
                parameters["@Name"] = name;

                ExecuteNonQuery(query, parameters);
                item = true;
            }
            catch { 
            
            }

            return item;

        }

        public bool DeleteMenuItem(string name)
        {
            bool item = false;
            try
            {
                string query = "DELETE FROM MenuItems WHERE Name = @Name";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["@Name"] = name;

                ExecuteNonQuery(query, parameters);

                item = true;
            }
            catch { 
            
            }
            return item;
        }


        public DataTable GetMenuItems(string connectionString)
        {
            string query = "SELECT [Name], [Price], [Category], [Description] FROM [MenuItems]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

    }
}
