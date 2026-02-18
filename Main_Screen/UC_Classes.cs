using AE.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Syncfusion.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class UC_Classes : UserControl
    {
        public UC_Classes()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Now we load the data, because the screen size is finally correct.
            LoadSections();
        }
        public void LoadSections()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // 1. GET DATA: Filter strictly by the Logged In Teacher
                    var mySections = db.Sections
                        .Where(s => s.TeacherId == UserSession.CurrentTeacherId)
                        .Select(s => new
                        {
                            s.Id,
                            Section = s.SectionName,     // Rename 'Name' to 'Section' for the header
                            Time = s.TimeSchedule,
                            s.Subject,
                            teacherId = s.TeacherId
                        })
                        .ToList();

                    sfDataGrid1.DataSource = mySections;
                    sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                AddSectionForm form = new AddSectionForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSections();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sfDataGrid1_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
        {
            if (e.Column.MappingName == "teacherId")
            {
                var rowContainer = e.Record as Syncfusion.WinForms.DataGrid.DataRow;
                if (rowContainer != null)
                    {
                        dynamic rowData = rowContainer.RowData;
                        int sectionId = rowData.Id;
                        string sectionName = rowData.Section;
                        Main_Screen_Form mainForm = (Main_Screen_Form)this.FindForm();
                        UC_Attendance attendanceScreen = new UC_Attendance();
                        attendanceScreen.CurrentSectionId = sectionId;
                        mainForm.loadForm(attendanceScreen);
                    }
            }
        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
