using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace last_fast__mang_sys
{
    class UserAuthentication : DataBaseManager
    {
        public UserAuthentication(string connectionString)
            : base(connectionString)
        {
        }

        public string GetUserRoleFromDatabase(string connectionString, string email)
        {
            string userRole = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT [role] FROM [Users] WHERE [Email] = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userRole = reader.GetString(0);
                        }
                    }
                }
            }

            return userRole;
        }

        public string ValidateLogin(string email, string password)
        {
            // Perform validation checks
            if (string.IsNullOrWhiteSpace(email))
            {
                return "Email is required.";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return "Password is required.";
            }

            // Additional validation logic can be added here

            // If no validation errors occurred, return an empty string
            return string.Empty;
        }

        public bool AuthenticateUser(string email, string password)
        {
             bool isAuth = false ;

            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@Email"] = email;
            parameters["@Password"] = password;

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
                        int count = (int)command.ExecuteScalar();
                          // If count is greater than 0, the user is authenticated
                        if (count > 0 )
	                    {   
		                   isAuth = true;         
	                    }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error executing database query: " + ex.Message);
                    }
                }
            }

            return isAuth;
        }
    }
}
