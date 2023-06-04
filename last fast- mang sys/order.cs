using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace last_fast__mang_sys
{
    class order : DataBaseManager
    {

         public order(string connectionString)
            : base(connectionString)
        {
        }

        public void PlaceOrder(string itemName, string userEmail, decimal totalAmount)
        {
            string query = "INSERT INTO Orders (ItemName, UserEmail, TotalAmount) VALUES (@ItemName, @UserEmail, @TotalAmount)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@ItemName"] = itemName;
            parameters["@UserEmail"] = userEmail;
            parameters["@TotalAmount"] = totalAmount;

            ExecuteNonQuery(query, parameters);

            Console.WriteLine("Order placed by: " + userEmail);
        }

        public decimal GetTotalBill(string userEmail)
        {
            string query = "SELECT SUM(TotalAmount) FROM Orders WHERE UserEmail = @UserEmail";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@UserEmail"] = userEmail;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            return Convert.ToDecimal(result);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error executing database query: " + ex.Message);
                    }
                }
            }

            return 0;
        }

    }
}
