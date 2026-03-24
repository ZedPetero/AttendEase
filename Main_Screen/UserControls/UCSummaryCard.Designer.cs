namespace Brevi.Application
{
    partial class UCSummaryCard
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
            lblTitle.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(14, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblInteger
            // 
            lblInteger.AutoSize = true;
            lblInteger.Font = new Font("Inter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInteger.Location = new Point(18, 60);
            lblInteger.Name = "lblInteger";
            lblInteger.Size = new Size(46, 50);
            lblInteger.TabIndex = 1;
            lblInteger.Text = "0";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPercentage.Location = new Point(72, 74);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(64, 30);
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
            Size = new Size(227, 134);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInteger;
        private Label lblPercentage;
    }
}
