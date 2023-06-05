using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace last_fast__mang_sys
{
    class order
    {

        public bool StoreUserOrder(string userEmail, string itemName, int quantity)
        {
            try {
                string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"; // Replace with your SQL Server connection string

                // SQL query to insert the order details into the table
                string query = "INSERT INTO Orders (ItemName, UserEmail, TotalAmount) VALUES (@ItemName, @UserEmail, @TotalAmount)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Calculate the total amount based on the item price from the Menu table and the quantity
                    decimal totalAmount = CalculateTotalAmount(itemName, quantity);

                    // Add parameters to the command to prevent SQL injection
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    command.Parameters.AddWithValue("@UserEmail", userEmail);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch {
                return false;
            }
        }

        public decimal CalculateTotalAmount(string itemName, int quantity)
        {
            string connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=Resturant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"; // Replace with your SQL Server connection string

            // SQL query to retrieve the item price from the Menu table
            string query = "SELECT Price FROM MenuItemss WHERE Name = @ItemName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameter to the command to prevent SQL injection
                command.Parameters.AddWithValue("@ItemName", itemName);

                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    decimal itemPrice = (decimal)result;
                    // Calculate the total amount
                    decimal totalAmount = itemPrice * quantity;
                    return totalAmount;
                }
                else
                {
                    // Return 0 if the item price is not found
                    return 0;
                }
            }
        }

 
    }
}
