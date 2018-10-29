namespace AdminApplication
{
    partial class Inspection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.classesField = new System.Windows.Forms.Label();
            this.interfacesField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(235, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interfaces";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 294);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(341, 42);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // classesField
            // 
            this.classesField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classesField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.classesField.Location = new System.Drawing.Point(12, 66);
            this.classesField.Name = "classesField";
            this.classesField.Size = new System.Drawing.Size(147, 214);
            this.classesField.TabIndex = 5;
            // 
            // interfacesField
            // 
            this.interfacesField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.interfacesField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.interfacesField.Location = new System.Drawing.Point(207, 66);
            this.interfacesField.Name = "interfacesField";
            this.interfacesField.Size = new System.Drawing.Size(146, 214);
            this.interfacesField.TabIndex = 6;
            // 
            // Inspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 348);
            this.Controls.Add(this.interfacesField);
            this.Controls.Add(this.classesField);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inspection";
            this.Text = "Inspection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label classesField;
        private System.Windows.Forms.Label interfacesField;
    }
}