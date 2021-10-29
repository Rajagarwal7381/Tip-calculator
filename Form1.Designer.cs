namespace Tip_Calculator
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
            this.txtbill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txttip = new System.Windows.Forms.TextBox();
            this.txtppl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltip = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // txtbill
            // 
            this.txtbill.Location = new System.Drawing.Point(12, 82);
            this.txtbill.Name = "txtbill";
            this.txtbill.Size = new System.Drawing.Size(213, 20);
            this.txtbill.TabIndex = 1;
            this.txtbill.Text = "0.00";
            this.txtbill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip %";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of people";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 20);
            this.button4.TabIndex = 8;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(41, 140);
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(146, 20);
            this.txttip.TabIndex = 17;
            this.txttip.Text = "10%";
            this.txttip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttip.TextChanged += new System.EventHandler(this.txttip_TextChanged);
            // 
            // txtppl
            // 
            this.txtppl.Location = new System.Drawing.Point(41, 226);
            this.txtppl.Name = "txtppl";
            this.txtppl.Size = new System.Drawing.Size(146, 20);
            this.txtppl.TabIndex = 18;
            this.txtppl.Text = "1";
            this.txtppl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtppl.TextChanged += new System.EventHandler(this.txtppl_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(274, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Per person";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(274, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Per person";
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltip.Location = new System.Drawing.Point(505, 84);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(30, 24);
            this.lbltip.TabIndex = 14;
            this.lbltip.Text = "$0";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(505, 193);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(30, 24);
            this.lbltotal.TabIndex = 16;
            this.lbltotal.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 308);
            this.Controls.Add(this.txtppl);
            this.Controls.Add(this.txttip);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbltip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbill);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.TextBox txtppl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.Label lbltotal;

    }
}

