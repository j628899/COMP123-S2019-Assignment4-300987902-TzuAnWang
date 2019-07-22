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
            double meter;
            double kg;
            double bmi;
            double inches;
            double pounds;
           
            
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
    }
}
