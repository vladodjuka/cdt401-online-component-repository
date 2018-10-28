using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ControllerUnit;
using System.IO;

namespace ComProject
{
    public partial class Dashboard : System.Web.UI.Page
    {
        ComponentDbUser com = new ComponentDbImpl();
        List<Component> loadedComponents;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.search.Attributes.Add("onkeypress", "button_click(this,'" + this.confirmSearch.ClientID + "')");
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

            if (comp != null)
            {
                ViewState["selectedComponentId"] = comp.id;
                componentDownloadLink.Enabled = true;
                componentDownloadLink.AlternateText = comp.path;

                componentName.InnerText = comp.name;
                componentAuthor.InnerText = comp.author;
                componentType.InnerText = comp.type;
                componentDescription.InnerText = comp.description;
                componentHeaderTitle.InnerText = comp.name;

                List<string> classes = com.reflectComponentClasses(comp);
                List<string> interfaces = com.reflectComponentInterfaces(comp);

                if (classes != null)
                {
                    classesReflection.InnerHtml = "";
                    foreach (string item in classes)
                    {
                        classesReflection.InnerHtml += "- " + item + "<br />";
                    }
                }

                if (interfaces != null)
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
                if (comp.id == selectedId)
                {
                    return comp;
                }
            }
            return null;
        }

        protected void componentDownloadLink_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(componentDownloadLink.AlternateText);

                if (fileInfo.Exists)
                {
                    Response.ClearContent();
                    Response.Clear();
                    Response.ContentType = "text/plain";
                    Response.AddHeader("Content-Disposition",
                                       "attachment; filename=" + fileInfo.Name + ";");
                    Response.TransmitFile(fileInfo.FullName);
                    Response.Flush();
                    Response.End();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        protected void confirmSearch_Click(object sender, EventArgs e)
        {
            List<Component> components = com.getComponentsByName(search.Text);
            loadedComponents = components;
            if (radioContainer.Items.Count > 0)
            {
                radioContainer.Items.Clear();
            }
            foreach (Component component in components)
            {
                ListItem rb = new ListItem();
                rb.Text = component.name;
                rb.Value = component.id.ToString();
                //radioContainer.Selected
                radioContainer.Items.Add(rb);

                if (ViewState["selectedComponentId"] != null && (int) ViewState["selectedComponentId"] == component.id)
                {
                    radioContainer.SelectedValue = rb.Value;
                }

            }
        }
    }
}