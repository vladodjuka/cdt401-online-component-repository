using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ControllerUnit;

namespace AdminApplication
{
    public partial class AdminPanel : Form
    {
        public static string defaultSearchText = "Search for component...";

        ComponentDbAdmin com = new ComponentDbImpl();

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            onAddOrEditComponent();
            clearComponentListSelectionAndFields();

        }

        public void clearComponentListSelectionAndFields()
        {
            componentList.ClearSelected();
            resetComponentInfo();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            populateComponentList();
        }

        public void populateComponentList()
        {
            componentList.Items.Clear();
            List<Component> components = com.getComponents();
            foreach (Component comp in components)
            {
                componentList.Items.Add(comp);

            }
        }

        public void populateComponentListByName(string name)
        {
            componentList.Items.Clear();
            List<Component> components = com.getComponentsByName(name);
            foreach (Component comp in components)
            {
                componentList.Items.Add(comp);

            }
        }

        private void componentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetComponentInfo();
            try
            {
                Component selectedComponent = componentList.SelectedItem as Component;
                setComponentInfo(selectedComponent);
                onSelectedComponent();
            }
            catch (Exception)
            {
                onDeselectedComponent();
                return;
            }
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

        public void resetComponentInfo()
        {
            componentName.Text = "";
            componentAuthor.Text = "";
            componentDescription.Text = "";
            componentPath.Text = "";
            netRadio.Checked = false;
            javaRadio.Checked = false;
            comRadio.Checked = false;
        }

        private void inspectButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(componentPath.Text))
            {
                Component selectedComponent = componentList.SelectedItem as Component;

                Inspection inspection = new Inspection(com.reflectComponentClasses(selectedComponent), com.reflectComponentInterfaces(selectedComponent));
                inspection.Show();
            }
        }

        public void onSelectedComponent()
        {
            inspectButton.Enabled = true;
            editButton.Enabled = true;
            downloadButton.Enabled = true;
            deleteButton.Enabled = true;
            onComponentNormalState();
        }

        public void onDeselectedComponent()
        {
            inspectButton.Enabled = false;
            editButton.Enabled = false;
            downloadButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        public void onAddOrEditComponent()
        {
            componentName.Enabled = true;
            componentAuthor.Enabled = true;
            componentPath.Enabled = true;
            browseButton.Enabled = true;
            componentDescription.Enabled = true;
            cancelButton.Enabled = true;
            confirmButton.Enabled = true;
            radioPanel.Enabled = true;
        }

        public void onComponentNormalState()
        {
            componentName.Enabled = false;
            componentAuthor.Enabled = false;
            componentPath.Enabled = false;
            browseButton.Enabled = false;
            componentDescription.Enabled = false;
            cancelButton.Enabled = false;
            confirmButton.Enabled = false;
            radioPanel.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            onAddOrEditComponent();
            componentName.Focus();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                componentPath.Text = sFileName;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!isAnyMandatoryFieldEmpty())
            {
                string path = componentPath.Text.Replace("\\", "\\\\");
                int selectedIndex = componentList.SelectedIndex;
                if (selectedIndex == -1)
                {
                    if (com.insertNewComponent(componentName.Text, componentDescription.Text, componentAuthor.Text, getSelectedRadio().ToLower(), path))
                    {
                        populateComponentList();
                    }
                }
                else
                {
                    Component selectedComponent = componentList.SelectedItem as Component;
                    if (com.editComponentInfo(selectedComponent.id.ToString(), componentName.Text, componentDescription.Text, componentAuthor.Text, getSelectedRadio().ToLower(), path))
                    {
                        populateComponentList();
                        componentList.SelectedIndex = selectedIndex;
                    }
                }

                onComponentNormalState();
            }
            else
            {
                MessageBox.Show("Not all fields' values provided or invalid values. Try again!");
            }
        }

        public bool isAnyMandatoryFieldEmpty()
        {
            if (string.IsNullOrEmpty(componentName.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(componentPath.Text) || !File.Exists(componentPath.Text))
            {
                return true;
            }
            if (radioPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked) == null)
            {
                return true;
            }

            return false;
        }

        public string getSelectedRadio()
        {
            if (comRadio.Checked)
            {
                return comRadio.Text;
            }
            if (netRadio.Checked)
            {
                return netRadio.Text;
            }
            if (javaRadio.Checked)
            {
                return javaRadio.Text;
            }
            return "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete selected item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Component selectedComponent = componentList.SelectedItem as Component;
                com.deleteComponent(selectedComponent.id.ToString(), selectedComponent.name);
                populateComponentList();
                resetComponentInfo();
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Component selectedComponent = componentList.SelectedItem as Component;
            string componentNameAndExtension = getNameAndExtension(selectedComponent.path);

            if (componentNameAndExtension != null)
            {
                if (downloadFile(selectedComponent.path, componentNameAndExtension))
                {
                    MessageBox.Show("Successfully downloaded", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Failed download", "Failure", MessageBoxButtons.OK);
                }
            }
        }

        public string getNameAndExtension(string fullPath)
        {

            int idNameExtension = fullPath.LastIndexOf('\\');

            if (idNameExtension != -1)
            {
                return fullPath.Substring(idNameExtension + 1);
            }
            return null;
        }

        public bool downloadFile(string fullPath, string targetNameAndExtension)
        {
            try
            {
                var client = new WebClient();
                Uri uri = new Uri(fullPath);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string downloadFolderPath = desktopPath + @"\Download\";

                System.IO.FileInfo downloadFolder = new System.IO.FileInfo(downloadFolderPath);
                downloadFolder.Directory.Create();

                client.DownloadFile(uri, downloadFolderPath + targetNameAndExtension);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            onComponentNormalState();
            if (componentList.SelectedIndex == -1)
            {
                resetComponentInfo();
            }
            else
            {
                Component selectedComponent = componentList.SelectedItem as Component;
                setComponentInfo(selectedComponent);
            }

        }

        private void searchField_Click(object sender, EventArgs e)
        {
            if (searchField.Text.Equals(defaultSearchText))
            {
                searchField.Text = "";
            }
        }

        private void searchField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchField.Text))
            {
                searchField.Text = defaultSearchText;
            }
        }

        private void searchField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                populateComponentListByName(searchField.Text);
            }
        }

        private void resetSearch_Click(object sender, EventArgs e)
        {
            populateComponentList();
            searchField.Text = defaultSearchText;
            resetComponentInfo();
            onDeselectedComponent();
        }
    }
}
