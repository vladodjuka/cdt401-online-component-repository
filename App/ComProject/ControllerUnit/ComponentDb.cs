using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControllerUnit
{
    public class ComponentDb
    {
        public static readonly string connectionString = "server=localhost;user id=root;database=compproject;password=vlado";
        public static readonly string retrieveComponents = "SELECT * from component";
        MySqlConnection con = new MySqlConnection(connectionString);


        public List<Component> getComponents()
        {
            List<Component> components = new List<Component>();
            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(retrieveComponents, con);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    var count = dataReader.FieldCount;
                    while (dataReader.Read())
                    {
                        Component comp = new Component();
                        comp.id = (int) dataReader["id"];
                        comp.name = dataReader["name"].ToString();
                        comp.author = dataReader["author"].ToString();
                        comp.description = dataReader["description"].ToString();
                        comp.path = dataReader["path"].ToString();
                        comp.type = dataReader["type"].ToString();
                        components.Add(comp);
                    }

                    dataReader.Close();
                }
                con.Close();
                return components;
            }
            catch (Exception e)
            {
                string message = e.StackTrace;
                con.Close();
                return components;
            }
        }
    }
}
