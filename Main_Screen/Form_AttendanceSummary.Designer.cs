namespace AE.Application
{
    partial class Form_AttendanceSummary
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
            gridSummary = new Krypton.Toolkit.KryptonDataGridView();
            RollNo = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Days = new DataGridViewTextBoxColumn();
            Present = new DataGridViewTextBoxColumn();
            Late = new DataGridViewTextBoxColumn();
            Absent = new DataGridViewTextBoxColumn();
            Excused = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            RawScore = new DataGridViewTextBoxColumn();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            btnDownloadCSV = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)gridSummary).BeginInit();
            SuspendLayout();
            // 
            // gridSummary
            // 
            gridSummary.AllowUserToResizeRows = false;
            gridSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSummary.BorderStyle = BorderStyle.None;
            gridSummary.ColumnHeadersHeight = 45;
            gridSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridSummary.Columns.AddRange(new DataGridViewColumn[] { RollNo, Name, Days, Present, Late, Absent, Excused, Score, RawScore });
            gridSummary.Location = new Point(31, 115);
            gridSummary.Name = "gridSummary";
            gridSummary.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            gridSummary.RowHeadersVisible = false;
            gridSummary.RowTemplate.Height = 45;
            gridSummary.Size = new Size(736, 311);
            gridSummary.StateCommon.Background.Color1 = Color.White;
            gridSummary.StateCommon.Background.Color2 = Color.White;
            gridSummary.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            gridSummary.StateCommon.DataCell.Back.Color1 = Color.White;
            gridSummary.StateCommon.DataCell.Content.Color1 = Color.FromArgb(55, 65, 81);
            gridSummary.StateCommon.DataCell.Content.Font = new Font("Inter", 8.25F);
            gridSummary.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(249, 250, 251);
            gridSummary.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(249, 250, 251);
            gridSummary.StateCommon.HeaderColumn.Border.Color1 = Color.FromArgb(229, 231, 235);
            gridSummary.StateCommon.HeaderColumn.Border.Color2 = Color.FromArgb(229, 231, 235);
            gridSummary.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom;
            gridSummary.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gridSummary.TabIndex = 0;
            gridSummary.CellFormatting += gridSummary_CellFormatting;
            // 
            // RollNo
            // 
            RollNo.HeaderText = "Roll No";
            RollNo.Name = "RollNo";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Days
            // 
            Days.HeaderText = "Days";
            Days.Name = "Days";
            // 
            // Present
            // 
            Present.HeaderText = "Present";
            Present.Name = "Present";
            // 
            // Late
            // 
            Late.HeaderText = "Late";
            Late.Name = "Late";
            // 
            // Absent
            // 
            Absent.HeaderText = "Absent";
            Absent.Name = "Absent";
            // 
            // Excused
            // 
            Excused.HeaderText = "Excused";
            Excused.Name = "Excused";
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.Name = "Score";
            // 
            // RawScore
            // 
            RawScore.HeaderText = "Raw Score";
            RawScore.Name = "RawScore";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(31, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            kryptonLabel1.Size = new Size(312, 39);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Attendance Summary";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(31, 75);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            kryptonLabel2.Size = new Size(580, 28);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 2;
            kryptonLabel2.Values.Text = "Score calculation: Present = 100%, Late = 50%, Absent = 0%";
            // 
            // btnDownloadCSV
            // 
            btnDownloadCSV.Location = new Point(645, 29);
            btnDownloadCSV.Name = "btnDownloadCSV";
            btnDownloadCSV.Size = new Size(122, 34);
            btnDownloadCSV.StateCommon.Back.Color1 = Color.Teal;
            btnDownloadCSV.StateCommon.Back.Color2 = Color.Teal;
            btnDownloadCSV.StateCommon.Border.Color1 = Color.Teal;
            btnDownloadCSV.StateCommon.Border.Rounding = 5F;
            btnDownloadCSV.StateCommon.Content.LongText.Color1 = Color.White;
            btnDownloadCSV.StateCommon.Content.LongText.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownloadCSV.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDownloadCSV.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownloadCSV.TabIndex = 3;
            btnDownloadCSV.Values.DropDownArrowColor = Color.Empty;
            btnDownloadCSV.Values.ExtraText = "Download CSV";
            btnDownloadCSV.Values.Text = "";
            btnDownloadCSV.Click += btnDownloadCSV_Click;
            // 
            // Form_AttendanceSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kryptonLabel1);
            Controls.Add(btnDownloadCSV);
            Controls.Add(kryptonLabel2);
            Controls.Add(gridSummary);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2013White;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Back.Color1 = Color.White;
            StateCommon.Back.Color2 = Color.White;
            StateCommon.Border.Color1 = Color.White;
            Load += Form_AttendanceSummary_Load;
            ((System.ComponentModel.ISupportInitialize)gridSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView gridSummary;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnDownloadCSV;
        private DataGridViewTextBoxColumn RollNo;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Days;
        private DataGridViewTextBoxColumn Present;
        private DataGridViewTextBoxColumn Late;
        private DataGridViewTextBoxColumn Absent;
        private DataGridViewTextBoxColumn Excused;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn RawScore;
    }
}