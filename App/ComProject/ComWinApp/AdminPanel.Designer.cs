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
            this.label1 = new System.Windows.Forms.Label();
            this.componentName = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.componentAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.componentPath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.componentDescription = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // componentList
            // 
            this.componentList.FormattingEnabled = true;
            this.componentList.Location = new System.Drawing.Point(21, 25);
            this.componentList.Name = "componentList";
            this.componentList.Size = new System.Drawing.Size(199, 277);
            this.componentList.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(61, 318);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 33);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Component";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(343, 277);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Component Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Component Name";
            // 
            // componentName
            // 
            this.componentName.Location = new System.Drawing.Point(119, 40);
            this.componentName.Name = "componentName";
            this.componentName.Size = new System.Drawing.Size(203, 20);
            this.componentName.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(265, 318);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 33);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Component";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(489, 318);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(119, 33);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update Component";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Component Author";
            // 
            // componentAuthor
            // 
            this.componentAuthor.Location = new System.Drawing.Point(119, 84);
            this.componentAuthor.Name = "componentAuthor";
            this.componentAuthor.Size = new System.Drawing.Size(203, 20);
            this.componentAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Component Path";
            // 
            // componentPath
            // 
            this.componentPath.Location = new System.Drawing.Point(119, 129);
            this.componentPath.Name = "componentPath";
            this.componentPath.Size = new System.Drawing.Size(157, 20);
            this.componentPath.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Viper Squadron Solid", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(282, 129);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(40, 20);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "...";
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browseButton.UseVisualStyleBackColor = true;
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
            // componentDescription
            // 
            this.componentDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.componentDescription.Location = new System.Drawing.Point(19, 200);
            this.componentDescription.Multiline = true;
            this.componentDescription.Name = "componentDescription";
            this.componentDescription.Size = new System.Drawing.Size(303, 65);
            this.componentDescription.TabIndex = 8;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 372);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.componentList);
            this.Name = "AdminPanel";
            this.ShowIcon = false;
            this.Text = "Admin Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox componentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox componentName;
        private System.Windows.Forms.Button updateButton;
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
    }
}