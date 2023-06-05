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

             private SqlConnection GetSqlConnection()
             {
                 string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
                 return new SqlConnection(connectionString);
             }

             public DataTable GetItemsDataFromDataSource()
             {
                 string query = "SELECT * FROM MenuItemss";

                 using (SqlConnection connection = GetSqlConnection())
                 {
                     SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                     DataTable dataTable = new DataTable();
                     adapter.Fill(dataTable);

                     return dataTable;
                 }
             }

             public DataTable GetItemsOrdersDataFromDataSource()
             {
                 string query = "SELECT * FROM Orders";

                 using (SqlConnection connection = GetSqlConnection())
                 {
                     SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                     DataTable dataTable = new DataTable();
                     adapter.Fill(dataTable);

                     return dataTable;
                 }
             }

             public DataTable GetUsersDataFromDataSource()
             {
                 string query = "SELECT * FROM Users";

                 using (SqlConnection connection = GetSqlConnection())
                 {
                     SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                     DataTable dataTable = new DataTable();
                     adapter.Fill(dataTable);

                     return dataTable;
                 }
             }


        public bool AddMenuItem(string name, int price, string category, string description)
        {
            try
            {
                string query = "INSERT INTO MenuItemss (Name, Price, Category, Discription) VALUES (@name, @price, @category, @description)";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["@name"] = name;
                parameters["@price"] = price;
                parameters["@category"] = category;
                parameters["@description"] = description;

                ExecuteNonQuery(query, parameters);

                return true; // Add success
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error message if needed
                Console.WriteLine("Error occurred during menu item addition: " + ex.Message);
                return false; // Operation failure
            }
        }

        public bool ModifyMenuItem(string name, int newPrice, string newCategory, string newDescription)
        {
            try
            {
                string query = "UPDATE MenuItemss SET Price = @newPrice, Category = @newCategory, Discription = @newDescription WHERE Name = @name";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["@newPrice"] = newPrice;
                parameters["@newCategory"] = newCategory;
                parameters["@newDescription"] = newDescription;
                parameters["@name"] = name;

                ExecuteNonQuery(query, parameters);

                return true; // Update success
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error message if needed
                Console.WriteLine("Error occurred during menu item modification: " + ex.Message);
                return false; // Operation failure
            }
        }

        public bool DeleteMenuItem(string name)
        {
            try
            {
                string query = "DELETE FROM MenuItemss WHERE Name = @name";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["@name"] = name;

                ExecuteNonQuery(query, parameters);

                return true; // Deletion success
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error message if needed
                Console.WriteLine("Error occurred during menu item deletion: " + ex.Message);
                return false; // Operation failure
            }
        }

    }
}
