namespace EmployeeInformationApp
{
    partial class MainMenuUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.find_EditButton = new System.Windows.Forms.Button();
            this.addDesignationButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.find_EditButton);
            this.groupBox1.Controls.Add(this.addDesignationButton);
            this.groupBox1.Controls.Add(this.addEmployeeButton);
            this.groupBox1.Location = new System.Drawing.Point(29, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // find_EditButton
            // 
            this.find_EditButton.Location = new System.Drawing.Point(300, 63);
            this.find_EditButton.Name = "find_EditButton";
            this.find_EditButton.Size = new System.Drawing.Size(100, 37);
            this.find_EditButton.TabIndex = 2;
            this.find_EditButton.Text = "Find and Edit";
            this.find_EditButton.UseVisualStyleBackColor = true;
            this.find_EditButton.Click += new System.EventHandler(this.find_EditButton_Click);
            // 
            // addDesignationButton
            // 
            this.addDesignationButton.Location = new System.Drawing.Point(167, 63);
            this.addDesignationButton.Name = "addDesignationButton";
            this.addDesignationButton.Size = new System.Drawing.Size(91, 37);
            this.addDesignationButton.TabIndex = 1;
            this.addDesignationButton.Text = "Add Designation";
            this.addDesignationButton.UseVisualStyleBackColor = true;
            this.addDesignationButton.Click += new System.EventHandler(this.addDesignationButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(36, 63);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(102, 37);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // MainMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenuUI";
            this.Text = "Main Menu (Employee Information)";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button find_EditButton;
        private System.Windows.Forms.Button addDesignationButton;
        private System.Windows.Forms.Button addEmployeeButton;
    }
}

