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
    public partial class MainForm : Form
    {
        public double meter { get; set; }
        public double kg { get; set; }
        public double bmi { get; set; }
        public double inches { get; set; }
        public double pounds { get; set; }

        public MainForm()
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
            if (MetreBox != null)
            {
                MetreBox.BackColor = Color.LightSalmon;
                
            }
            
            
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
            if (KilogramsBox != null)
            {
                KilogramsBox.BackColor = Color.LightSalmon;

            }
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
            if (inchesBox != null)
            {
                inchesBox.BackColor = Color.LightSalmon;

            }
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
            if (poundsBox != null)
            {
                poundsBox.BackColor = Color.LightSalmon;

            }
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

            MetreBox.BackColor = Color.White;
            KilogramsBox.BackColor = Color.White;
            inchesBox.BackColor = Color.White;
            poundsBox.BackColor = Color.White;
            TextBoxControl.BackColor = Color.WhiteSmoke;
            TextBoxControl.Text = null;

            CalculateBMIbutton.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);
        }
    }
}
