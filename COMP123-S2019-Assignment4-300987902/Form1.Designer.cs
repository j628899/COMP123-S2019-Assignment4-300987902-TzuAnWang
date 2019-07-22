namespace COMP123_S2019_Assignment4_300987902
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_imperial = new System.Windows.Forms.TableLayoutPanel();
            this.inchesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poundsBox = new System.Windows.Forms.TextBox();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.MetricUnits = new System.Windows.Forms.RadioButton();
            this.CalculateBMIbutton = new System.Windows.Forms.Button();
            this.TextBoxControl = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_MetricUnits = new System.Windows.Forms.TableLayoutPanel();
            this.MetreBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KilogramsBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_imperial.SuspendLayout();
            this.tableLayoutPanel_MetricUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_imperial
            // 
            this.tableLayoutPanel_imperial.ColumnCount = 2;
            this.tableLayoutPanel_imperial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.18705F));
            this.tableLayoutPanel_imperial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.81295F));
            this.tableLayoutPanel_imperial.Controls.Add(this.inchesBox, 1, 0);
            this.tableLayoutPanel_imperial.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_imperial.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel_imperial.Controls.Add(this.poundsBox, 1, 1);
            this.tableLayoutPanel_imperial.Location = new System.Drawing.Point(12, 51);
            this.tableLayoutPanel_imperial.Name = "tableLayoutPanel_imperial";
            this.tableLayoutPanel_imperial.RowCount = 2;
            this.tableLayoutPanel_imperial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_imperial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_imperial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_imperial.Size = new System.Drawing.Size(278, 122);
            this.tableLayoutPanel_imperial.TabIndex = 0;
            // 
            // inchesBox
            // 
            this.inchesBox.Location = new System.Drawing.Point(186, 3);
            this.inchesBox.Name = "inchesBox";
            this.inchesBox.Size = new System.Drawing.Size(89, 45);
            this.inchesBox.TabIndex = 3;
            this.inchesBox.Text = "Inch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Weight";
            // 
            // poundsBox
            // 
            this.poundsBox.Location = new System.Drawing.Point(186, 64);
            this.poundsBox.Name = "poundsBox";
            this.poundsBox.Size = new System.Drawing.Size(89, 45);
            this.poundsBox.TabIndex = 3;
            this.poundsBox.Text = "Pounds";
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(39, 193);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(160, 43);
            this.Imperial.TabIndex = 1;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            this.Imperial.CheckedChanged += new System.EventHandler(this.Imperial_CheckedChanged);
            // 
            // MetricUnits
            // 
            this.MetricUnits.AutoSize = true;
            this.MetricUnits.Location = new System.Drawing.Point(39, 242);
            this.MetricUnits.Name = "MetricUnits";
            this.MetricUnits.Size = new System.Drawing.Size(217, 43);
            this.MetricUnits.TabIndex = 2;
            this.MetricUnits.Text = "Metric Units";
            this.MetricUnits.UseVisualStyleBackColor = true;
            this.MetricUnits.CheckedChanged += new System.EventHandler(this.MetricUnits_CheckedChanged);
            // 
            // CalculateBMIbutton
            // 
            this.CalculateBMIbutton.Location = new System.Drawing.Point(12, 368);
            this.CalculateBMIbutton.Name = "CalculateBMIbutton";
            this.CalculateBMIbutton.Size = new System.Drawing.Size(278, 53);
            this.CalculateBMIbutton.TabIndex = 3;
            this.CalculateBMIbutton.Text = "CalculateBMI";
            this.CalculateBMIbutton.UseVisualStyleBackColor = true;
            this.CalculateBMIbutton.Click += new System.EventHandler(this.CalculateBMIbutton_Click);
            // 
            // TextBoxControl
            // 
            this.TextBoxControl.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxControl.Enabled = false;
            this.TextBoxControl.Location = new System.Drawing.Point(49, 300);
            this.TextBoxControl.Name = "TextBoxControl";
            this.TextBoxControl.Size = new System.Drawing.Size(193, 45);
            this.TextBoxControl.TabIndex = 4;
            // 
            // tableLayoutPanel_MetricUnits
            // 
            this.tableLayoutPanel_MetricUnits.ColumnCount = 2;
            this.tableLayoutPanel_MetricUnits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.18705F));
            this.tableLayoutPanel_MetricUnits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.81295F));
            this.tableLayoutPanel_MetricUnits.Controls.Add(this.MetreBox, 1, 0);
            this.tableLayoutPanel_MetricUnits.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel_MetricUnits.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel_MetricUnits.Controls.Add(this.KilogramsBox, 1, 1);
            this.tableLayoutPanel_MetricUnits.Location = new System.Drawing.Point(9, 51);
            this.tableLayoutPanel_MetricUnits.Name = "tableLayoutPanel_MetricUnits";
            this.tableLayoutPanel_MetricUnits.RowCount = 2;
            this.tableLayoutPanel_MetricUnits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MetricUnits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MetricUnits.Size = new System.Drawing.Size(278, 122);
            this.tableLayoutPanel_MetricUnits.TabIndex = 5;
            // 
            // MetreBox
            // 
            this.MetreBox.Location = new System.Drawing.Point(186, 3);
            this.MetreBox.Name = "MetreBox";
            this.MetreBox.Size = new System.Drawing.Size(89, 45);
            this.MetreBox.TabIndex = 3;
            this.MetreBox.Text = "metres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "My Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "My Weight";
            // 
            // KilogramsBox
            // 
            this.KilogramsBox.Location = new System.Drawing.Point(186, 64);
            this.KilogramsBox.Name = "KilogramsBox";
            this.KilogramsBox.Size = new System.Drawing.Size(89, 45);
            this.KilogramsBox.TabIndex = 3;
            this.KilogramsBox.Text = "kilograms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.tableLayoutPanel_MetricUnits);
            this.Controls.Add(this.TextBoxControl);
            this.Controls.Add(this.CalculateBMIbutton);
            this.Controls.Add(this.MetricUnits);
            this.Controls.Add(this.Imperial);
            this.Controls.Add(this.tableLayoutPanel_imperial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel_imperial.ResumeLayout(false);
            this.tableLayoutPanel_imperial.PerformLayout();
            this.tableLayoutPanel_MetricUnits.ResumeLayout(false);
            this.tableLayoutPanel_MetricUnits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_imperial;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.RadioButton MetricUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inchesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poundsBox;
        private System.Windows.Forms.Button CalculateBMIbutton;
        private System.Windows.Forms.TextBox TextBoxControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MetricUnits;
        private System.Windows.Forms.TextBox MetreBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KilogramsBox;
    }
}

