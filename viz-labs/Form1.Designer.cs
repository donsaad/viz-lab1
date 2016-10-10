namespace viz_labs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValToColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioDiscrete = new System.Windows.Forms.RadioButton();
            this.radioContinuous = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.RBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.outLabel = new System.Windows.Forms.Label();
            this.btnColorToVal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 204);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(372, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discrete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Continuous";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 29);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Value to Convert";
            // 
            // btnValToColor
            // 
            this.btnValToColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnValToColor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValToColor.Location = new System.Drawing.Point(12, 309);
            this.btnValToColor.Name = "btnValToColor";
            this.btnValToColor.Size = new System.Drawing.Size(210, 128);
            this.btnValToColor.TabIndex = 3;
            this.btnValToColor.Text = "Convert Value To Color";
            this.btnValToColor.UseVisualStyleBackColor = false;
            this.btnValToColor.Click += new System.EventHandler(this.btnValToColor_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(19, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 79);
            this.panel2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(9, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 29);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(209, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 29);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter sMin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter sMax";
            // 
            // radioDiscrete
            // 
            this.radioDiscrete.AutoSize = true;
            this.radioDiscrete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDiscrete.Location = new System.Drawing.Point(6, 36);
            this.radioDiscrete.Name = "radioDiscrete";
            this.radioDiscrete.Size = new System.Drawing.Size(81, 22);
            this.radioDiscrete.TabIndex = 9;
            this.radioDiscrete.TabStop = true;
            this.radioDiscrete.Text = "Discrete";
            this.radioDiscrete.UseVisualStyleBackColor = true;
            // 
            // radioContinuous
            // 
            this.radioContinuous.AutoSize = true;
            this.radioContinuous.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioContinuous.Location = new System.Drawing.Point(101, 36);
            this.radioContinuous.Name = "radioContinuous";
            this.radioContinuous.Size = new System.Drawing.Size(100, 22);
            this.radioContinuous.TabIndex = 10;
            this.radioContinuous.TabStop = true;
            this.radioContinuous.Text = "Continuous";
            this.radioContinuous.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioContinuous);
            this.groupBox1.Controls.Add(this.radioDiscrete);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Function";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.GBox);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.BBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RBox);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(228, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 165);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "R";
            // 
            // GBox
            // 
            this.GBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox.Location = new System.Drawing.Point(251, 118);
            this.GBox.Name = "GBox";
            this.GBox.Size = new System.Drawing.Size(37, 29);
            this.GBox.TabIndex = 16;
            // 
            // BBox
            // 
            this.BBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBox.Location = new System.Drawing.Point(294, 118);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(37, 29);
            this.BBox.TabIndex = 15;
            // 
            // RBox
            // 
            this.RBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBox.Location = new System.Drawing.Point(207, 118);
            this.RBox.Name = "RBox";
            this.RBox.Size = new System.Drawing.Size(37, 29);
            this.RBox.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox3.Location = new System.Drawing.Point(227, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 169);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Color";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.outLabel);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox4.Location = new System.Drawing.Point(437, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 169);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output Value";
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.outLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.Location = new System.Drawing.Point(79, 73);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(0, 29);
            this.outLabel.TabIndex = 19;
            // 
            // btnColorToVal
            // 
            this.btnColorToVal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColorToVal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorToVal.Location = new System.Drawing.Point(11, 443);
            this.btnColorToVal.Name = "btnColorToVal";
            this.btnColorToVal.Size = new System.Drawing.Size(210, 128);
            this.btnColorToVal.TabIndex = 16;
            this.btnColorToVal.Text = "Convert Color To Value";
            this.btnColorToVal.UseVisualStyleBackColor = false;
            this.btnColorToVal.Click += new System.EventHandler(this.btnColorToVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 574);
            this.Controls.Add(this.btnColorToVal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnValToColor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Color Mapping";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValToColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioDiscrete;
        private System.Windows.Forms.RadioButton radioContinuous;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GBox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox RBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Button btnColorToVal;
    }
}

