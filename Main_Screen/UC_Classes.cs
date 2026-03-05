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
                    var mySections = db.Sections
                        .Where(s => s.TeacherId == UserSession.CurrentTeacherId)
                        .ToList()
                        .OrderBy(s => s.StartTimeSchedule)
                        .Select(s => new
                        {
                            s.Id,
                            Section = s.SectionName,
                            Time = DateTime.Today.Add(s.StartTimeSchedule).ToString("hh:mm tt") + " - " +
                                    DateTime.Today.Add(s.EndTimeSchedule).ToString("hh:mm tt"),
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
                    Main_Screen_Form mainForm = (Main_Screen_Form)this.FindForm();
                    UC_Attendance attendanceScreen = new UC_Attendance();
                    attendanceScreen.CallerControl = this;
                    attendanceScreen.SetSection(sectionId);

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

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.RoundControl(kryptonPanel1, 50);
        }
    }
}
