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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.MetricUnits = new System.Windows.Forms.RadioButton();
            this.CalculateBMIbutton = new System.Windows.Forms.Button();
            this.TextBoxControl = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 45);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Weight";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 45);
            this.textBox2.TabIndex = 3;
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(39, 179);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(160, 43);
            this.Imperial.TabIndex = 1;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            // 
            // MetricUnits
            // 
            this.MetricUnits.AutoSize = true;
            this.MetricUnits.Location = new System.Drawing.Point(39, 216);
            this.MetricUnits.Name = "MetricUnits";
            this.MetricUnits.Size = new System.Drawing.Size(217, 43);
            this.MetricUnits.TabIndex = 2;
            this.MetricUnits.TabStop = true;
            this.MetricUnits.Text = "Metric Units";
            this.MetricUnits.UseVisualStyleBackColor = true;
            // 
            // CalculateBMIbutton
            // 
            this.CalculateBMIbutton.Location = new System.Drawing.Point(12, 368);
            this.CalculateBMIbutton.Name = "CalculateBMIbutton";
            this.CalculateBMIbutton.Size = new System.Drawing.Size(278, 53);
            this.CalculateBMIbutton.TabIndex = 3;
            this.CalculateBMIbutton.Text = "CalculateBMI";
            this.CalculateBMIbutton.UseVisualStyleBackColor = true;
            // 
            // TextBoxControl
            // 
            this.TextBoxControl.Enabled = false;
            this.TextBoxControl.Location = new System.Drawing.Point(49, 300);
            this.TextBoxControl.Name = "TextBoxControl";
            this.TextBoxControl.Size = new System.Drawing.Size(193, 45);
            this.TextBoxControl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.TextBoxControl);
            this.Controls.Add(this.CalculateBMIbutton);
            this.Controls.Add(this.MetricUnits);
            this.Controls.Add(this.Imperial);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.RadioButton MetricUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CalculateBMIbutton;
        private System.Windows.Forms.TextBox TextBoxControl;
    }
}

