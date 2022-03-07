namespace WinFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmain = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.bnt4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblmain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 62);
            this.panel1.TabIndex = 0;
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblmain.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmain.Location = new System.Drawing.Point(0, 0);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(36, 60);
            this.lblmain.TabIndex = 0;
            this.lblmain.Text = "|";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btndivide);
            this.panel2.Controls.Add(this.btnmultiply);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btnplus);
            this.panel2.Controls.Add(this.btnminus);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.bnt4);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 309);
            this.panel2.TabIndex = 1;
            // 
            // btndivide
            // 
            this.btndivide.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndivide.Location = new System.Drawing.Point(327, 241);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(98, 57);
            this.btndivide.TabIndex = 13;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmultiply.Location = new System.Drawing.Point(327, 167);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(98, 57);
            this.btnmultiply.TabIndex = 12;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(12, 241);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(306, 57);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnplus.Location = new System.Drawing.Point(327, 7);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(98, 57);
            this.btnplus.TabIndex = 10;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnminus.Location = new System.Drawing.Point(327, 86);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(98, 57);
            this.btnminus.TabIndex = 9;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(12, 167);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(98, 57);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(116, 167);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(98, 57);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(220, 167);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(98, 57);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // bnt4
            // 
            this.bnt4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnt4.Location = new System.Drawing.Point(12, 86);
            this.bnt4.Name = "bnt4";
            this.bnt4.Size = new System.Drawing.Size(98, 57);
            this.bnt4.TabIndex = 5;
            this.bnt4.Text = "4";
            this.bnt4.UseVisualStyleBackColor = true;
            this.bnt4.Click += new System.EventHandler(this.bnt4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(116, 86);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(98, 57);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(220, 86);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(98, 57);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(220, 6);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(98, 57);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(116, 6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(98, 57);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 58);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnequal);
            this.panel3.Controls.Add(this.btnclear);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 82);
            this.panel3.TabIndex = 2;
            // 
            // btnequal
            // 
            this.btnequal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnequal.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnequal.Location = new System.Drawing.Point(214, 0);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(214, 82);
            this.btnequal.TabIndex = 16;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclear.Location = new System.Drawing.Point(0, 0);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(214, 82);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "C.E";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblmain;
        private Panel panel2;
        private Button btn1;
        private Panel panel3;
        private Button btn0;
        private Button btnplus;
        private Button btnminus;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button bnt4;
        private Button btn5;
        private Button btn6;
        private Button btn3;
        private Button btn2;
        private Button btndivide;
        private Button btnmultiply;
        private Button btnclear;
        private Button btnequal;
    }
}