namespace Kalkulator
{
    partial class Calculator
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
            this.components = new System.ComponentModel.Container();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDivision = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bMultiplication = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bSubtraction = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.bResult = new System.Windows.Forms.Button();
            this.bAddition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 12);
            this.tbResult.Name = "tbResult";
            this.tbResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbResult.Size = new System.Drawing.Size(166, 20);
            this.tbResult.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 38);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(37, 34);
            this.b7.TabIndex = 2;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(55, 38);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(37, 34);
            this.b8.TabIndex = 3;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(98, 38);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(37, 34);
            this.b9.TabIndex = 4;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bDivision
            // 
            this.bDivision.Location = new System.Drawing.Point(141, 38);
            this.bDivision.Name = "bDivision";
            this.bDivision.Size = new System.Drawing.Size(37, 34);
            this.bDivision.TabIndex = 5;
            this.bDivision.Text = "/";
            this.bDivision.UseVisualStyleBackColor = true;
            this.bDivision.Click += new System.EventHandler(this.bDivision_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 78);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(37, 34);
            this.b4.TabIndex = 6;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(55, 78);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(37, 34);
            this.b5.TabIndex = 7;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(98, 78);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(37, 34);
            this.b6.TabIndex = 8;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bMultiplication
            // 
            this.bMultiplication.Location = new System.Drawing.Point(141, 78);
            this.bMultiplication.Name = "bMultiplication";
            this.bMultiplication.Size = new System.Drawing.Size(37, 34);
            this.bMultiplication.TabIndex = 9;
            this.bMultiplication.Text = "*";
            this.bMultiplication.UseVisualStyleBackColor = true;
            this.bMultiplication.Click += new System.EventHandler(this.bMultiplication_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 118);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(37, 34);
            this.b1.TabIndex = 10;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(55, 118);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(37, 34);
            this.b2.TabIndex = 11;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(98, 118);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(37, 34);
            this.b3.TabIndex = 12;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bSubtraction
            // 
            this.bSubtraction.Location = new System.Drawing.Point(141, 118);
            this.bSubtraction.Name = "bSubtraction";
            this.bSubtraction.Size = new System.Drawing.Size(37, 34);
            this.bSubtraction.TabIndex = 13;
            this.bSubtraction.Text = "-";
            this.bSubtraction.UseVisualStyleBackColor = true;
            this.bSubtraction.Click += new System.EventHandler(this.bSubtraction_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 158);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(37, 34);
            this.b0.TabIndex = 14;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(55, 158);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(37, 34);
            this.bClean.TabIndex = 15;
            this.bClean.Text = "C";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // bResult
            // 
            this.bResult.Location = new System.Drawing.Point(98, 158);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(37, 34);
            this.bResult.TabIndex = 16;
            this.bResult.Text = "=";
            this.bResult.UseVisualStyleBackColor = true;
            this.bResult.Click += new System.EventHandler(this.bResult_Click);
            // 
            // bAddition
            // 
            this.bAddition.Location = new System.Drawing.Point(141, 158);
            this.bAddition.Name = "bAddition";
            this.bAddition.Size = new System.Drawing.Size(37, 34);
            this.bAddition.TabIndex = 17;
            this.bAddition.Text = "+";
            this.bAddition.UseVisualStyleBackColor = true;
            this.bAddition.Click += new System.EventHandler(this.bAddition_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 202);
            this.Controls.Add(this.bAddition);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bSubtraction);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bMultiplication);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bDivision);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.tbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bDivision;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bMultiplication;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bSubtraction;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.Button bAddition;
    }
}

