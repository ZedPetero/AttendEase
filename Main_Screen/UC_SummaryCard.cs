using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class UC_SummaryCard : UserControl
    {
        public UC_SummaryCard()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Integer
        {
            get
            {
                if (int.TryParse(lblInteger.Text, out var v)) return v;
                return 0;
            }
            set => lblInteger.Text = value.ToString();
        }

        // Setting empty string will hide the percentage label (per your requirement for total).
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Percentage
        {
            get => lblPercentage.Text;
            set
            {
                lblPercentage.Text = value ?? string.Empty;
                lblPercentage.Visible = !string.IsNullOrEmpty(lblPercentage.Text);
            }
        }
    }
}
