namespace Simple_Calculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 265);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbPlus
            // 
            this.rbPlus.AutoSize = true;
            this.rbPlus.Location = new System.Drawing.Point(12, 12);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(45, 17);
            this.rbPlus.TabIndex = 1;
            this.rbPlus.TabStop = true;
            this.rbPlus.Text = "Plus";
            this.rbPlus.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // rbMinus
            // 
            this.rbMinus.AutoSize = true;
            this.rbMinus.Location = new System.Drawing.Point(12, 51);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(53, 17);
            this.rbMinus.TabIndex = 3;
            this.rbMinus.TabStop = true;
            this.rbMinus.Text = "Minus";
            this.rbMinus.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(12, 89);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(60, 17);
            this.rbMultiply.TabIndex = 4;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Multiply";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 268);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(12, 126);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(55, 17);
            this.rbDivide.TabIndex = 7;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "Divide";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(37, 180);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(66, 13);
            this.lblFirstNumber.TabIndex = 8;
            this.lblFirstNumber.Text = "First Number";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(185, 180);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(84, 13);
            this.lblSecondNumber.TabIndex = 9;
            this.lblSecondNumber.Text = "Second Number";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(207, 252);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 340);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rbMultiply);
            this.Controls.Add(this.rbMinus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbPlus);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblResult;
    }
}

