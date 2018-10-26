using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ControllerUnit;

namespace ComProject
{
    public partial class Dashboard : System.Web.UI.Page
    {
        ComponentDb com = new ComponentDbImpl();
        List<Component> loadedComponents;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Component> components = com.getComponents();
            loadedComponents = components;
            if (!IsPostBack)
            {   
                if (radioContainer.Items.Count > 0)
                {
                    radioContainer.Items.Clear();
                }
                foreach (Component component in components)
                {
                    ListItem rb = new ListItem();
                    rb.Text = component.name;
                    rb.Value = component.id.ToString();
                    radioContainer.Items.Add(rb);
                }
            }
        }

        protected void radioContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idSelected = Int32.Parse(radioContainer.SelectedItem.Value);
            Component comp = findSelectedComponent(idSelected);

            if(comp!= null)
            {
                componentName.InnerText = comp.name;
                componentAuthor.InnerText = comp.author;
                componentType.InnerText = comp.type;
                componentDescription.InnerText = comp.description;
                componentHeaderTitle.InnerText = comp.name;


                componentDownloadLink.HRef = "file:///" + comp.path;

                List<string> classes = com.reflectComponentClasses(comp);
                List<string> interfaces = com.reflectComponentInterfaces(comp);

                if(classes != null)
                {
                    classesReflection.InnerHtml = "";
                    foreach (string item in classes)
                    {
                        classesReflection.InnerHtml += "- " + item + "<br />";
                    }
                }

                if(interfaces != null)
                {
                    interfacesReflection.InnerHtml = "";
                    foreach (string item in interfaces)
                    {
                        interfacesReflection.InnerHtml += "- " + item + "<br />";
                    }

                }

            }


        }

        public Component findSelectedComponent(int selectedId)
        {
            foreach (Component comp in loadedComponents)
            {
                if(comp.id == selectedId)
                {
                    return comp;
                }
            }
            return null;
        }
    }
}