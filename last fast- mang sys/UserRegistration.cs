using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace last_fast__mang_sys
{
    class UserRegistration : DataBaseManager
    {
        public UserRegistration(string connectionString)
            : base(connectionString)
        {
        }

        public bool RegisterUser(string fullName, string email, string password,string role)
        {
            try
            {
                string query = "INSERT INTO Users (FullName, Email, Password, role) VALUES (@FullName, @Email, @Password, @role)";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["@FullName"] = fullName;
                parameters["@Email"] = email;
                parameters["@Password"] = password;
                parameters["@role"] = role;

                ExecuteNonQuery(query, parameters);

                return true; // Registration success
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error message if needed
                Console.WriteLine("Error occurred during user registration: " + ex.Message);
                return false; // Registration failure
            }
        }
    }
}
