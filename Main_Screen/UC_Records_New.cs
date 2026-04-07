using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Brevi.Application
{
    public partial class UC_Records_New : UserControl
    {
        public UC_Records_New()
        {
            InitializeComponent();

            // FIX #1: Round the controls here in the constructor, NOT in the Paint event!
            UIHelper.RoundControl(CurrentClassespanel, 20);
            UIHelper.RoundControl(ArchivedClassespanel, 20);
        }

        private void UC_Records_New_Load(object sender, EventArgs e)
        {
            try
            {
                currentclassesflowpanel.Controls.Clear();
                archivedClassFlowpanel.Controls.Clear();

                using var db = new Brevi.Infrastructure.Data.AppDbContext();

                var sections = db.Sections
                    .OrderBy(s => s.SectionName)
                    .ToList();

                foreach (var sec in sections)
                {
                    var item = new UC_RecordsClass();
                    item.SetSection(sec.Id);

                    item.AutoSize = false;
                    // Initial width setup
                    item.Width = currentclassesflowpanel.ClientSize.Width - 25;

                    if (sec.IsArchived)
                    {
                        item.SetArchivedState(true);
                        archivedClassFlowpanel.Controls.Add(item);
                    }
                    else
                    {
                        item.SetArchivedState(false);
                        currentclassesflowpanel.Controls.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                // Better to output the error to debug rather than silently swallowing it
                System.Diagnostics.Debug.WriteLine("Error loading sections: " + ex.Message);
            }
        }

        public void MoveToArchived(UC_RecordsClass item)
        {
            if (item == null) return;
            currentclassesflowpanel.Controls.Remove(item);
            item.AutoSize = false;
            item.Width = archivedClassFlowpanel.ClientSize.Width - 25;
            archivedClassFlowpanel.Controls.Add(item);
            item.SetArchivedState(true);
        }

        public void MoveToCurrent(UC_RecordsClass item)
        {
            if (item == null) return;
            archivedClassFlowpanel.Controls.Remove(item);
            item.AutoSize = false;
            item.Width = currentclassesflowpanel.ClientSize.Width - 25;
            currentclassesflowpanel.Controls.Add(item);
            item.SetArchivedState(false);
        }

        // FIX #2: Add Resize events to keep your cards responsive when the window changes size!
        private void currentclassesflowpanel_Resize(object sender, EventArgs e)
        {
            foreach (Control item in currentclassesflowpanel.Controls)
            {
                if (item is UC_RecordsClass)
                {
                    item.Width = currentclassesflowpanel.ClientSize.Width - 25;
                }
            }
        }

        private void archivedClassFlowpanel_Resize(object sender, EventArgs e)
        {
            foreach (Control item in archivedClassFlowpanel.Controls)
            {
                if (item is UC_RecordsClass)
                {
                    item.Width = archivedClassFlowpanel.ClientSize.Width - 25;
                }
            }
        }
        private void currentclassesflowpanel_SizeChanged(object sender, EventArgs e)
        {
            // Dynamically push the "Archived Classes" header down below the current classes list
            ArchivedClassespanel.Top = currentclassesflowpanel.Bottom + 20; // 20 is just a visual margin

            // Dynamically push the archived list down below its header
            archivedClassFlowpanel.Top = ArchivedClassespanel.Bottom + 10;
        }
    }
}