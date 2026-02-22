using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AE.Domain.Models;
using AE.Infrastructure.Data;

namespace AE.Application
{
    public partial class UC_Records : UserControl
    {
        public UC_Records()
        {
            InitializeComponent();
            LoadLists();
        }
        private void LoadLists()
        {
            currentclasseslistbox.Items.Clear();
            archivedclasseslistbox.Items.Clear();

            try
            {
                using var db = new AppDbContext();
                var current = db.Sections.Where(s => !s.IsArchived).OrderBy(s => s.SectionName).ToList();
                var archived = db.Sections.Where(s => s.IsArchived).OrderBy(s => s.SectionName).ToList();

                currentclasseslistbox.DisplayMember = "SectionName";
                archivedclasseslistbox.DisplayMember = "SectionName";

                foreach (var s in current)
                    currentclasseslistbox.Items.Add(s);

                foreach (var s in archived)
                    archivedclasseslistbox.Items.Add(s);
            }
            catch
            {
                // ignore DB errors at design time
            }
        }

        private void archivebutton_Click(object? sender, EventArgs e)
        {
            if (currentclasseslistbox.SelectedItem is Section s)
            {
                try
                {
                    using var db = new AppDbContext();
                    var sec = db.Sections.Find(s.Id);
                    if (sec != null)
                    {
                        sec.IsArchived = true;
                        db.Sections.Update(sec);
                        db.SaveChanges();
                    }

                    LoadLists();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to archive section: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a class to archive.", "Archive", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void restorebutton_Click(object? sender, EventArgs e)
        {
            if (archivedclasseslistbox.SelectedItem is Section s)
            {
                try
                {
                    using var db = new AppDbContext();
                    var sec = db.Sections.Find(s.Id);
                    if (sec != null)
                    {
                        sec.IsArchived = false;
                        db.Sections.Update(sec);
                        db.SaveChanges();
                    }

                    LoadLists();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to restore section: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a class to restore.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void currentclasses_TextChanged(object sender, EventArgs e)
        {

        }

        private void currentclasspanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
