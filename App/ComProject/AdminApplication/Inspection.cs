using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdminApplication
{
    public partial class Inspection : Form
    {
        private List<String> classes;
        private List<String> interfaces;
        public Inspection(List<String> classes, List<String> interfaces)
        {
            InitializeComponent();
            this.classes = classes;
            this.interfaces = interfaces;
            renderData();
        }

        public void renderData()
        {
            if (classes != null)
            {
                foreach (string item in classes)
                {
                    classesField.Text += "- " + item + "\n";
                }
            }
            if (interfaces != null)
            {

                foreach (string item in interfaces)
                {
                    interfacesField.Text += "- " + item + "\n";
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}