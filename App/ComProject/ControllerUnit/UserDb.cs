using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControllerUnit
{
    public class UserDb
    {
    
        public static readonly string connectionString = "server=localhost;user id=root;database=compproject;password=vlado";
        public static readonly string checkIfUserExist = "SELECT COUNT(*) FROM USER WHERE USERNAME = '{0}' AND PASSWORD = '{1}'";

        MySqlConnection con = new MySqlConnection(connectionString);


        public bool doesUserExist(string username, string password)
        {
            try
            {
                con.Open();
                string sqlCommandString = string.Format(checkIfUserExist, username, password);
                MySqlCommand command = new MySqlCommand(sqlCommandString, con);
                int existingUsers = Int32.Parse(command.ExecuteScalar().ToString());
                if(existingUsers > 0)
                {
                    return true;
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
            return false;
        }

    }
}
