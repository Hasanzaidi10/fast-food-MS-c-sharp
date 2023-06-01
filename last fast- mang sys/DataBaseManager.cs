using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace last_fast__mang_sys
{
    abstract  class  DataBaseManager
    {
        protected string connectionString;

        public DataBaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
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
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error executing database query: " + ex.Message);
                    }
                }
            }
        }
    }
}
