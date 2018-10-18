﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComWinApp
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
            foreach (string item in classes)
            {
                classesField.Text += "- " + item + "\n";
            }
            foreach (string item in interfaces)
            {
                interfacesField.Text += "- " + item + "\n";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}