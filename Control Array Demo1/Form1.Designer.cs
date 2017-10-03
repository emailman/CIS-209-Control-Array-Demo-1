namespace Control_Array_Demo1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGradesEntered = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Student 3";
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(3, 3);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 4;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(3, 29);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 20);
            this.tbx2.TabIndex = 5;
            // 
            // tbx4
            // 
            this.tbx4.Location = new System.Drawing.Point(3, 84);
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(100, 20);
            this.tbx4.TabIndex = 7;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(3, 55);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 20);
            this.tbx3.TabIndex = 6;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(71, 133);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 23);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process Grades";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Average";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverage.Location = new System.Drawing.Point(72, 177);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(100, 23);
            this.lblAverage.TabIndex = 10;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHigh
            // 
            this.lblHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHigh.Location = new System.Drawing.Point(71, 213);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(100, 23);
            this.lblHigh.TabIndex = 12;
            this.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLow
            // 
            this.lblLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLow.Location = new System.Drawing.Point(72, 250);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(100, 23);
            this.lblLow.TabIndex = 14;
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "High";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Low";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Grades Entered";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGradesEntered
            // 
            this.lblGradesEntered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGradesEntered.Location = new System.Drawing.Point(72, 289);
            this.lblGradesEntered.Name = "lblGradesEntered";
            this.lblGradesEntered.Size = new System.Drawing.Size(100, 23);
            this.lblGradesEntered.TabIndex = 17;
            this.lblGradesEntered.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbx1);
            this.panel1.Controls.Add(this.tbx2);
            this.panel1.Controls.Add(this.tbx3);
            this.panel1.Controls.Add(this.tbx4);
            this.panel1.Location = new System.Drawing.Point(68, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 111);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblGradesEntered);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Grade List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGradesEntered;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

