namespace Painting
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
            this.CreatCirclBtn = new System.Windows.Forms.Button();
            this.ParametersBtn = new System.Windows.Forms.Button();
            this.CreatRecBtn = new System.Windows.Forms.Button();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HeigthBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.CirPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.RecPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.MoveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CirPanel.SuspendLayout();
            this.RecPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatCirclBtn
            // 
            this.CreatCirclBtn.Location = new System.Drawing.Point(24, 643);
            this.CreatCirclBtn.Name = "CreatCirclBtn";
            this.CreatCirclBtn.Size = new System.Drawing.Size(196, 73);
            this.CreatCirclBtn.TabIndex = 1;
            this.CreatCirclBtn.Text = "Создать круг";
            this.CreatCirclBtn.UseVisualStyleBackColor = true;
            this.CreatCirclBtn.Click += new System.EventHandler(this.CreatCirclBtn_Click);
            // 
            // ParametersBtn
            // 
            this.ParametersBtn.Location = new System.Drawing.Point(462, 643);
            this.ParametersBtn.Name = "ParametersBtn";
            this.ParametersBtn.Size = new System.Drawing.Size(196, 73);
            this.ParametersBtn.TabIndex = 4;
            this.ParametersBtn.Text = "Задать параметры";
            this.ParametersBtn.UseVisualStyleBackColor = true;
            this.ParametersBtn.Click += new System.EventHandler(this.ParametersBtn_Click);
            // 
            // CreatRecBtn
            // 
            this.CreatRecBtn.Location = new System.Drawing.Point(240, 643);
            this.CreatRecBtn.Name = "CreatRecBtn";
            this.CreatRecBtn.Size = new System.Drawing.Size(196, 73);
            this.CreatRecBtn.TabIndex = 5;
            this.CreatRecBtn.Text = "Создать прямоуголник";
            this.CreatRecBtn.UseVisualStyleBackColor = true;
            this.CreatRecBtn.Click += new System.EventHandler(this.CreatRecBtn_Click);
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(119, 51);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(100, 31);
            this.SizeBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Радиус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Высота";
            // 
            // HeigthBox
            // 
            this.HeigthBox.Location = new System.Drawing.Point(119, 54);
            this.HeigthBox.Name = "HeigthBox";
            this.HeigthBox.Size = new System.Drawing.Size(100, 31);
            this.HeigthBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ширина";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(119, 105);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 31);
            this.WidthBox.TabIndex = 18;
            // 
            // CirPanel
            // 
            this.CirPanel.Controls.Add(this.label8);
            this.CirPanel.Controls.Add(this.SizeBox);
            this.CirPanel.Controls.Add(this.label1);
            this.CirPanel.Location = new System.Drawing.Point(677, 610);
            this.CirPanel.Name = "CirPanel";
            this.CirPanel.Size = new System.Drawing.Size(236, 239);
            this.CirPanel.TabIndex = 20;
            this.CirPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Круг";
            // 
            // RecPanel
            // 
            this.RecPanel.Controls.Add(this.label9);
            this.RecPanel.Controls.Add(this.HeigthBox);
            this.RecPanel.Controls.Add(this.label7);
            this.RecPanel.Controls.Add(this.label6);
            this.RecPanel.Controls.Add(this.WidthBox);
            this.RecPanel.Location = new System.Drawing.Point(966, 610);
            this.RecPanel.Name = "RecPanel";
            this.RecPanel.Size = new System.Drawing.Size(236, 239);
            this.RecPanel.TabIndex = 12;
            this.RecPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Прямоугольник";
            // 
            // MoveBtn
            // 
            this.MoveBtn.Location = new System.Drawing.Point(24, 734);
            this.MoveBtn.Name = "MoveBtn";
            this.MoveBtn.Size = new System.Drawing.Size(196, 73);
            this.MoveBtn.TabIndex = 22;
            this.MoveBtn.Text = "Перемещение";
            this.MoveBtn.UseVisualStyleBackColor = true;
            this.MoveBtn.Click += new System.EventHandler(this.MoveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 592);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 734);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 73);
            this.button1.TabIndex = 24;
            this.button1.Text = "Vagoon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 852);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoveBtn);
            this.Controls.Add(this.RecPanel);
            this.Controls.Add(this.CirPanel);
            this.Controls.Add(this.CreatRecBtn);
            this.Controls.Add(this.ParametersBtn);
            this.Controls.Add(this.CreatCirclBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CirPanel.ResumeLayout(false);
            this.CirPanel.PerformLayout();
            this.RecPanel.ResumeLayout(false);
            this.RecPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreatCirclBtn;
        private System.Windows.Forms.Button ParametersBtn;
        private System.Windows.Forms.Button CreatRecBtn;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HeigthBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Panel CirPanel;
        private System.Windows.Forms.Panel RecPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button MoveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

