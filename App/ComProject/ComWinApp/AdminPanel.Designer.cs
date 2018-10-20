namespace ComWinApp
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.componentList = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPanel = new System.Windows.Forms.Panel();
            this.javaRadio = new System.Windows.Forms.RadioButton();
            this.netRadio = new System.Windows.Forms.RadioButton();
            this.comRadio = new System.Windows.Forms.RadioButton();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.componentDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.componentPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.componentAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.componentName = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.inspectButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.radioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // componentList
            // 
            this.componentList.FormattingEnabled = true;
            this.componentList.Location = new System.Drawing.Point(21, 64);
            this.componentList.Name = "componentList";
            this.componentList.Size = new System.Drawing.Size(225, 277);
            this.componentList.TabIndex = 0;
            this.componentList.SelectedIndexChanged += new System.EventHandler(this.componentList_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(21, 352);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 33);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Component";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPanel);
            this.groupBox1.Controls.Add(this.confirmButton);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.componentDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.componentPath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.componentAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.componentName);
            this.groupBox1.Location = new System.Drawing.Point(265, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // radioPanel
            // 
            this.radioPanel.Controls.Add(this.javaRadio);
            this.radioPanel.Controls.Add(this.netRadio);
            this.radioPanel.Controls.Add(this.comRadio);
            this.radioPanel.Enabled = false;
            this.radioPanel.Location = new System.Drawing.Point(119, 133);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(216, 42);
            this.radioPanel.TabIndex = 14;
            // 
            // javaRadio
            // 
            this.javaRadio.AutoSize = true;
            this.javaRadio.Location = new System.Drawing.Point(15, 12);
            this.javaRadio.Name = "javaRadio";
            this.javaRadio.Size = new System.Drawing.Size(51, 17);
            this.javaRadio.TabIndex = 10;
            this.javaRadio.TabStop = true;
            this.javaRadio.Text = "JAVA";
            this.javaRadio.UseVisualStyleBackColor = true;
            // 
            // netRadio
            // 
            this.netRadio.AutoSize = true;
            this.netRadio.Location = new System.Drawing.Point(87, 12);
            this.netRadio.Name = "netRadio";
            this.netRadio.Size = new System.Drawing.Size(47, 17);
            this.netRadio.TabIndex = 11;
            this.netRadio.TabStop = true;
            this.netRadio.Text = "NET";
            this.netRadio.UseVisualStyleBackColor = true;
            // 
            // comRadio
            // 
            this.comRadio.AutoSize = true;
            this.comRadio.Location = new System.Drawing.Point(149, 12);
            this.comRadio.Name = "comRadio";
            this.comRadio.Size = new System.Drawing.Size(49, 17);
            this.comRadio.TabIndex = 12;
            this.comRadio.TabStop = true;
            this.comRadio.Text = "COM";
            this.comRadio.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(226, 278);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(133, 23);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(19, 278);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Component Type *";
            // 
            // componentDescription
            // 
            this.componentDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.componentDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.componentDescription.Enabled = false;
            this.componentDescription.Location = new System.Drawing.Point(19, 198);
            this.componentDescription.Multiline = true;
            this.componentDescription.Name = "componentDescription";
            this.componentDescription.Size = new System.Drawing.Size(340, 65);
            this.componentDescription.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Component Description";
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Font = new System.Drawing.Font("Viper Squadron Solid", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(319, 104);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(40, 20);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "...";
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // componentPath
            // 
            this.componentPath.BackColor = System.Drawing.SystemColors.HighlightText;
            this.componentPath.Enabled = false;
            this.componentPath.Location = new System.Drawing.Point(119, 104);
            this.componentPath.Name = "componentPath";
            this.componentPath.Size = new System.Drawing.Size(190, 20);
            this.componentPath.TabIndex = 5;
            this.componentPath.TextChanged += new System.EventHandler(this.componentPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Component Path *";
            // 
            // componentAuthor
            // 
            this.componentAuthor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.componentAuthor.Enabled = false;
            this.componentAuthor.Location = new System.Drawing.Point(119, 72);
            this.componentAuthor.Name = "componentAuthor";
            this.componentAuthor.Size = new System.Drawing.Size(240, 20);
            this.componentAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Component Author *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Component Name *";
            // 
            // componentName
            // 
            this.componentName.AllowDrop = true;
            this.componentName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.componentName.Enabled = false;
            this.componentName.Location = new System.Drawing.Point(119, 40);
            this.componentName.Name = "componentName";
            this.componentName.Size = new System.Drawing.Size(240, 20);
            this.componentName.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(131, 352);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 33);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Component";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(265, 352);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(119, 33);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit Component";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Search for component...";
            // 
            // downloadButton
            // 
            this.downloadButton.Enabled = false;
            this.downloadButton.Location = new System.Drawing.Point(533, 352);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(119, 33);
            this.downloadButton.TabIndex = 14;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // inspectButton
            // 
            this.inspectButton.Enabled = false;
            this.inspectButton.Location = new System.Drawing.Point(399, 352);
            this.inspectButton.Name = "inspectButton";
            this.inspectButton.Size = new System.Drawing.Size(119, 33);
            this.inspectButton.TabIndex = 15;
            this.inspectButton.Text = "Inspect";
            this.inspectButton.UseVisualStyleBackColor = true;
            this.inspectButton.Click += new System.EventHandler(this.inspectButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 403);
            this.Controls.Add(this.inspectButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.componentList);
            this.Name = "AdminPanel";
            this.ShowIcon = false;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox componentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox componentName;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox componentAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox componentPath;
        private System.Windows.Forms.TextBox componentDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton comRadio;
        private System.Windows.Forms.RadioButton netRadio;
        private System.Windows.Forms.RadioButton javaRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button inspectButton;
        private System.Windows.Forms.Panel radioPanel;
    }
}