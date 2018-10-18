using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NETComponentInspector;
using ControllerUnit;

namespace ComWinApp
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void componentPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NETReflection netReflection = new NETReflectionImpl();
            netReflection.getClasses("C:\\Users\\Vlado\\Desktop\\FruitShop.API.dll");
            netReflection.getInterfaces("C:\\Users\\Vlado\\Desktop\\FruitShop.API.dll");

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ComponentDb com = new ComponentDb();
            List<Component> components = com.getComponents();
            foreach (Component comp in components)
            {
                componentList.Items.Add(comp);

            }

        }

        private void componentList_SelectedIndexChanged(object sender, EventArgs e)
        {

            Component selectedComponent = componentList.SelectedItem as Component;
            componentName.Text = selectedComponent.name;
            componentAuthor.Text = selectedComponent.author;
            componentDescription.Text = selectedComponent.description;
            componentPath.Text = selectedComponent.path;
            setComponentInfo(selectedComponent);
        }

        public void setComponentInfo(Component component)
        {
            componentName.Text = component.name;
            componentAuthor.Text = component.author;
            componentDescription.Text = component.description;
            componentPath.Text = component.path;
            switch (component.type)
            {
                case "net": netRadio.Checked = true; break;
                case "java": javaRadio.Checked = true; break;
                case "com": comRadio.Checked = true; break;
                default: break;
            }
        }

        private void inspectButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(componentPath.Text))
            {
                NETReflection netReflection = new NETReflectionImpl();
                Inspection inspection = new Inspection(netReflection.getClasses(componentPath.Text), netReflection.getInterfaces(componentPath.Text));
                inspection.Show();
            }
        }
    }
}
