namespace Calculator_fractions
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SumBtn = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.SubtrBtn = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.MultiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 31);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 31);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 31);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 31);
            this.textBox4.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(324, 71);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(143, 47);
            this.textBox6.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // SumBtn
            // 
            this.SumBtn.Location = new System.Drawing.Point(35, 229);
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Size = new System.Drawing.Size(112, 58);
            this.SumBtn.TabIndex = 7;
            this.SumBtn.Text = "+";
            this.SumBtn.UseVisualStyleBackColor = true;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(324, 306);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(112, 58);
            this.Result.TabIndex = 8;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // SubtrBtn
            // 
            this.SubtrBtn.Location = new System.Drawing.Point(35, 306);
            this.SubtrBtn.Name = "SubtrBtn";
            this.SubtrBtn.Size = new System.Drawing.Size(112, 58);
            this.SubtrBtn.TabIndex = 9;
            this.SubtrBtn.Text = "-";
            this.SubtrBtn.UseVisualStyleBackColor = true;
            this.SubtrBtn.Click += new System.EventHandler(this.SubtrBtn_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(175, 306);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(112, 58);
            this.Division.TabIndex = 10;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // MultiBtn
            // 
            this.MultiBtn.Location = new System.Drawing.Point(175, 229);
            this.MultiBtn.Name = "MultiBtn";
            this.MultiBtn.Size = new System.Drawing.Size(112, 58);
            this.MultiBtn.TabIndex = 11;
            this.MultiBtn.Text = "*";
            this.MultiBtn.UseVisualStyleBackColor = true;
            this.MultiBtn.Click += new System.EventHandler(this.MultiBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MultiBtn);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.SubtrBtn);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button SubtrBtn;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button MultiBtn;
    }
}

