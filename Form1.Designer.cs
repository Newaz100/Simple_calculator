﻿namespace Lab1_windows_forms__app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiplication = new Button();
            btnDivision = new Button();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(144, 100);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(125, 27);
            txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(363, 100);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(125, 27);
            txtNumber2.TabIndex = 1;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(105, 190);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 29);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(221, 190);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 29);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Location = new Point(339, 190);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(94, 29);
            btnMultiplication.TabIndex = 4;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(450, 190);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(94, 29);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplication);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiplication;
        private Button btnDivision;
    }
}