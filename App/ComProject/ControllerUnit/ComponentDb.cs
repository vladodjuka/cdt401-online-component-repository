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
        public static readonly string addNewComponent = "INSERT INTO component (name, description, author, type, path) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
        public static readonly string deleteComponentWithIdAndTitle = "DELETE FROM component where id = {0} and name='{1}'";
        public static readonly string editComponent = "UPDATE component set name = '{1}', description = '{2}', author = '{3}', type = '{4}', path = '{5}' where id = {0}";
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
                        comp.id = (int)dataReader["id"];
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

        public bool insertNewComponent(string name, string description, string author, string type, string path)
        {
            try
            {
                con.Open();
                string addComponentString = string.Format(addNewComponent, name, description, author, type, path);
                MySqlCommand command = new MySqlCommand(addComponentString, con);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }

            catch (Exception)
            {
                con.Close();
                return false;
            }
        }

        public bool deleteComponent(string id, string name)
        {
            try
            {
                con.Open();
                string deleteComponentString = string.Format(deleteComponentWithIdAndTitle, id, name);
                MySqlCommand command = new MySqlCommand(deleteComponentString, con);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }

            catch (Exception)
            {
                con.Close();
                return false;
            }
        }

        public bool editComponentInfo(string id, string newName, string newDescription, string newAuthor, string newType, string newPath)
        {
            try
            {
                con.Open();
                string editComponentString = string.Format(editComponent, id, newName, newDescription, newAuthor, newType, newPath);
                MySqlCommand command = new MySqlCommand(editComponentString, con);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }

            catch (Exception)
            {
                con.Close();
                return false;
            }
        }
    }
}