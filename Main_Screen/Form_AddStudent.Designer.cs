namespace AE.Application
{
    partial class Form_AddStudent
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
            label1 = new Label();
            btnSave = new Button();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            label2 = new Label();
            textLastName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 70);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(147, 185);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(147, 62);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(159, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(147, 103);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(159, 23);
            txtMiddleName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 153);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name:";
            label2.Click += label2_Click;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(147, 144);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(159, 23);
            textLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 110);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Middle Name:";
            // 
            // Form_AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 240);
            Controls.Add(label3);
            Controls.Add(textLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Name = "Form_AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private Label label2;
        private TextBox textLastName;
        private Label label3;
    }
}