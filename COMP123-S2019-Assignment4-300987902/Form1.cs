using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4_300987902
{
    public partial class Form1 : Form
    {
        public double meter { get; set; }
        public double kg { get; set; }
        public double bmi { get; set; }
        public double inches { get; set; }
        public double pounds { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void MetricUnits_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel_MetricUnits.Visible = true;
            tableLayoutPanel_imperial.Visible = false;
        }

        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel_imperial.Visible = true;
            tableLayoutPanel_MetricUnits.Visible = false;
        }

        private void CalculateBMIbutton_Click(object sender, EventArgs e)
        {
            
           
            
            if (tableLayoutPanel_MetricUnits.Visible == true) 
            {
                meter = double.Parse(MetreBox.Text);
                kg = double.Parse(KilogramsBox.Text);
                bmi = (kg / (meter * meter));
                TextBoxControl.Text = bmi.ToString();
                TextBoxControl.BackColor = Color.LightBlue;

            }
            else
            {
                inches = double.Parse(inchesBox.Text);
                pounds = double.Parse(poundsBox.Text);
                bmi = ((pounds*703) / (inches * inches));
                TextBoxControl.Text = bmi.ToString();
                TextBoxControl.BackColor = Color.LightGreen;
            }

        }

        private void MetreBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(MetreBox.Text);
                CalculateBMIbutton.Enabled = true;
            }
            catch
            {
                CalculateBMIbutton.Enabled = false;
            }
        }

        private void KilogramsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(KilogramsBox.Text);
                CalculateBMIbutton.Enabled = true;
            }
            catch
            {
                CalculateBMIbutton.Enabled = false;
            }
        }

        private void inchesBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(inchesBox.Text);
                CalculateBMIbutton.Enabled = true;
            }
            catch
            {
                CalculateBMIbutton.Enabled = false;
            }
        }

        private void poundsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(poundsBox.Text);
                CalculateBMIbutton.Enabled = true;
            }
            catch
            {
                CalculateBMIbutton.Enabled = false;
            }
        }

        private void ResetButtom_Click(object sender, EventArgs e)
        {
            MetreBox.Text = "metre";
            KilogramsBox.Text = "kilograms";
            inchesBox.Text = "inch";
            poundsBox.Text = "pound";

            CalculateBMIbutton.Enabled = false;
        }
    }
}
