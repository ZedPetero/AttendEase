using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCSummaryCard : UserControl
    {
        public UCSummaryCard()
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TitleColor
        {
            get => lblTitle.ForeColor.ToString();
            set
            {
                try
                {
                    string[] rgbValues = value.Split(',');

                    if (rgbValues.Length == 3)
                    {
                        int r = Convert.ToInt32(rgbValues[0].Trim());
                        int g = Convert.ToInt32(rgbValues[1].Trim());
                        int b = Convert.ToInt32(rgbValues[2].Trim());

                        lblTitle.ForeColor = Color.FromArgb(r, g, b);
                    }
                }
                catch
                {

                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string IntegerColor
        {
            get => lblInteger.ForeColor.ToString();
            set
            {
                try
                {
                    string[] rgbValues = value.Split(',');

                    if (rgbValues.Length == 3)
                    {
                        int r = Convert.ToInt32(rgbValues[0].Trim());
                        int g = Convert.ToInt32(rgbValues[1].Trim());
                        int b = Convert.ToInt32(rgbValues[2].Trim());

                        lblInteger.ForeColor = Color.FromArgb(r, g, b);
                    }
                }
                catch
                {
                }
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PercentageColor
        {
            get => lblPercentage.ForeColor.ToString();
            set
            {
                try
                {
                    string[] rgbValues = value.Split(',');

                    if (rgbValues.Length == 3)
                    {
                        int r = Convert.ToInt32(rgbValues[0].Trim());
                        int g = Convert.ToInt32(rgbValues[1].Trim());
                        int b = Convert.ToInt32(rgbValues[2].Trim());

                        lblPercentage.ForeColor = Color.FromArgb(r, g, b);
                    }
                }
                catch
                {
                }
            }
        }
    }
}
