namespace AE.Application
{
    partial class UC_SummaryCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblInteger = new Label();
            lblPercentage = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(18, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(56, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblInteger
            // 
            lblInteger.AutoSize = true;
            lblInteger.Font = new Font("Inter", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInteger.Location = new Point(18, 74);
            lblInteger.Name = "lblInteger";
            lblInteger.Size = new Size(48, 53);
            lblInteger.TabIndex = 1;
            lblInteger.Text = "0";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Inter", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPercentage.Location = new Point(72, 88);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(74, 35);
            lblPercentage.TabIndex = 2;
            lblPercentage.Text = "0.0%";
            // 
            // UC_SummaryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPercentage);
            Controls.Add(lblInteger);
            Controls.Add(lblTitle);
            Name = "UC_SummaryCard";
            Size = new Size(227, 149);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInteger;
        private Label lblPercentage;
    }
}
