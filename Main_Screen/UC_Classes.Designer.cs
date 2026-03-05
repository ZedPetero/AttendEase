namespace AE.Application
{
    partial class UC_Classes
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn1 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            panel1 = new Panel();
            btnAddClass = new Syncfusion.WinForms.Controls.SfButton();
            label2 = new Label();
            label1 = new Label();
            sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sfDataGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAddClass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sfDataGrid1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 640);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnAddClass
            // 
            btnAddClass.BackColor = Color.FromArgb(39, 165, 153);
            btnAddClass.Font = new Font("Segoe UI Semibold", 9F);
            btnAddClass.ForeColor = Color.White;
            btnAddClass.Location = new Point(457, 103);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(96, 28);
            btnAddClass.Style.BackColor = Color.FromArgb(39, 165, 153);
            btnAddClass.Style.ForeColor = Color.White;
            btnAddClass.TabIndex = 3;
            btnAddClass.Text = "Add Class+";
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.FromArgb(29, 37, 48);
            label2.Location = new Point(43, 101);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 1;
            label2.Text = "Classes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(29, 37, 48);
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(242, 45);
            label1.TabIndex = 0;
            label1.Text = "Hello, Teacher!";
            // 
            // sfDataGrid1
            // 
            sfDataGrid1.AccessibleName = "Table";
            sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            gridTextColumn1.HeaderText = "Name";
            gridTextColumn1.MappingName = "Section";
            gridTextColumn2.HeaderText = "Subject";
            gridTextColumn2.MappingName = "Subject";
            gridTextColumn3.HeaderText = "Time";
            gridTextColumn3.MappingName = "Time";
            gridButtonColumn1.AllowDefaultButtonText = true;
            gridButtonColumn1.ButtonSize = new Size(0, 0);
            gridButtonColumn1.DefaultButtonText = "Check";
            gridButtonColumn1.HeaderText = "Attendance";
            gridButtonColumn1.ImageSize = new Size(0, 0);
            gridButtonColumn1.MappingName = "teacherId";
            sfDataGrid1.Columns.Add(gridTextColumn1);
            sfDataGrid1.Columns.Add(gridTextColumn2);
            sfDataGrid1.Columns.Add(gridTextColumn3);
            sfDataGrid1.Columns.Add(gridButtonColumn1);
            sfDataGrid1.ForeColor = Color.FromArgb(29, 37, 48);
            sfDataGrid1.Location = new Point(36, 155);
            sfDataGrid1.Name = "sfDataGrid1";
            sfDataGrid1.RowHeight = 50;
            sfDataGrid1.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.None;
            sfDataGrid1.Size = new Size(517, 453);
            sfDataGrid1.Style.BorderColor = Color.FromArgb(100, 100, 100);
            sfDataGrid1.Style.DragPreviewRowStyle.Font = new Font("Segoe UI", 9F);
            sfDataGrid1.Style.DragPreviewRowStyle.RowCountIndicatorTextColor = Color.FromArgb(255, 255, 255);
            sfDataGrid1.TabIndex = 2;
            sfDataGrid1.Text = "sfDataGrid1";
            sfDataGrid1.CellButtonClick += sfDataGrid1_CellButtonClick;
            sfDataGrid1.Click += sfDataGrid1_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Location = new Point(786, 197);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(210, 226);
            kryptonPanel1.TabIndex = 1;
            kryptonPanel1.Paint += kryptonPanel1_Paint;
            // 
            // UC_Classes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            Controls.Add(kryptonPanel1);
            Controls.Add(panel1);
            Name = "UC_Classes";
            Size = new Size(1150, 640);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sfDataGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private Syncfusion.WinForms.Controls.SfButton btnAddClass;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}
