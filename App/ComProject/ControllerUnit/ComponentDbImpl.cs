using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using NETComponentInspector;
using COMComponentInspector;
using JAVAComponentInspector;

namespace ControllerUnit
{
    public class ComponentDbImpl : ComponentDb
    {
        public static readonly string connectionString = "server=localhost;user id=root;database=compproject;password=vlado";
        public static readonly string retrieveComponents = "SELECT * from component";
        public static readonly string addNewComponent = "INSERT INTO component (name, description, author, type, path) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
        public static readonly string deleteComponentWithIdAndTitle = "DELETE FROM component where id = {0} and name='{1}'";
        public static readonly string editComponent = "UPDATE component set name = '{1}', description = '{2}', author = '{3}', type = '{4}', path = '{5}' where id = {0}";
        public static readonly string retrieveComponentByName = "SELECT * from component where name like'%{0}%'";
        MySqlConnection con = new MySqlConnection(connectionString);


        public List<Component> getComponents()
        {
            List<Component> components = new List<Component>();
            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(retrieveComponents, con);
                components = getComponentsByCommand(command);

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

        public List<Component> getComponentsByName(string name)
        {
            List<Component> components = new List<Component>();
            try
            {
                con.Open();

                string retrieveComponentByNameString = string.Format(retrieveComponentByName, name);
                MySqlCommand command = new MySqlCommand(retrieveComponentByNameString, con);
                components = getComponentsByCommand(command);

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

        private List<Component> getComponentsByCommand(MySqlCommand command)
        {
            List<Component> components = new List<Component>();
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
            return components;
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

        public List<string> reflectComponentClasses(Component component)
        {
            List<string> classes;
            switch (component.type)
            {
                case "net":
                    NETReflection netReflection = new NETReflectionImpl();
                    classes = netReflection.getClasses(component.path); break;
                case "java":
                    JAVAReflection javaReflection = new JAVAReflectionImpl();
                    classes = javaReflection.getClasses(component.path); break;
                case "com":
                    COMReflection comReflection = new COMReflectionImpl();
                    classes = comReflection.getClasses(component.path); break;
                default: classes = null; break;
            }

            return classes;
        }

        public List<string> reflectComponentInterfaces(Component component)
        {
            List<string> interfaces;
            switch (component.type)
            {
                case "net":
                    NETReflection netReflection = new NETReflectionImpl();
                    interfaces = netReflection.getInterfaces(component.path); break;
                case "java":
                    JAVAReflection javaReflection = new JAVAReflectionImpl();
                    interfaces = javaReflection.getInterfaces(component.path); break;
                case "com":
                    COMReflection comReflection = new COMReflectionImpl();
                    interfaces = comReflection.getInterfaces(component.path); break;
                default: interfaces = null; break;
            }

            return interfaces;
        }
    }
}