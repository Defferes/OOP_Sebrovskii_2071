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
            this.WagonCreatBtn = new System.Windows.Forms.Button();
            this.WagonPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeWagonBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TrainPanel = new System.Windows.Forms.Panel();
            this.LengthTrainBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SizeTrainBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CargoSumBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CirPanel.SuspendLayout();
            this.RecPanel.SuspendLayout();
            this.WagonPanel.SuspendLayout();
            this.TrainPanel.SuspendLayout();
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
            this.CirPanel.Size = new System.Drawing.Size(236, 116);
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
            this.RecPanel.Size = new System.Drawing.Size(236, 149);
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
            // WagonCreatBtn
            // 
            this.WagonCreatBtn.Location = new System.Drawing.Point(240, 734);
            this.WagonCreatBtn.Name = "WagonCreatBtn";
            this.WagonCreatBtn.Size = new System.Drawing.Size(196, 73);
            this.WagonCreatBtn.TabIndex = 24;
            this.WagonCreatBtn.Text = "Вагон";
            this.WagonCreatBtn.UseVisualStyleBackColor = true;
            this.WagonCreatBtn.Click += new System.EventHandler(this.WagonCreatBtn_Click);
            // 
            // WagonPanel
            // 
            this.WagonPanel.Controls.Add(this.label2);
            this.WagonPanel.Controls.Add(this.SizeWagonBox);
            this.WagonPanel.Controls.Add(this.label3);
            this.WagonPanel.Location = new System.Drawing.Point(677, 732);
            this.WagonPanel.Name = "WagonPanel";
            this.WagonPanel.Size = new System.Drawing.Size(236, 138);
            this.WagonPanel.TabIndex = 22;
            this.WagonPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Вагон";
            // 
            // SizeWagonBox
            // 
            this.SizeWagonBox.Location = new System.Drawing.Point(119, 35);
            this.SizeWagonBox.Name = "SizeWagonBox";
            this.SizeWagonBox.Size = new System.Drawing.Size(100, 31);
            this.SizeWagonBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Размеры";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 734);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 73);
            this.button1.TabIndex = 26;
            this.button1.Text = "Поезд";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainPanel
            // 
            this.TrainPanel.Controls.Add(this.LengthTrainBox);
            this.TrainPanel.Controls.Add(this.label4);
            this.TrainPanel.Controls.Add(this.label10);
            this.TrainPanel.Controls.Add(this.SizeTrainBox);
            this.TrainPanel.Controls.Add(this.label11);
            this.TrainPanel.Location = new System.Drawing.Point(966, 770);
            this.TrainPanel.Name = "TrainPanel";
            this.TrainPanel.Size = new System.Drawing.Size(236, 138);
            this.TrainPanel.TabIndex = 24;
            this.TrainPanel.Visible = false;
            // 
            // LengthTrainBox
            // 
            this.LengthTrainBox.Location = new System.Drawing.Point(119, 82);
            this.LengthTrainBox.Name = "LengthTrainBox";
            this.LengthTrainBox.Size = new System.Drawing.Size(100, 31);
            this.LengthTrainBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Длинна";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Поезд";
            // 
            // SizeTrainBox
            // 
            this.SizeTrainBox.Location = new System.Drawing.Point(119, 35);
            this.SizeTrainBox.Name = "SizeTrainBox";
            this.SizeTrainBox.Size = new System.Drawing.Size(100, 31);
            this.SizeTrainBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Размеры";
            // 
            // CargoSumBox
            // 
            this.CargoSumBox.Location = new System.Drawing.Point(537, 839);
            this.CargoSumBox.Name = "CargoSumBox";
            this.CargoSumBox.Size = new System.Drawing.Size(100, 31);
            this.CargoSumBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 842);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Вес поезда";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 919);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CargoSumBox);
            this.Controls.Add(this.TrainPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WagonPanel);
            this.Controls.Add(this.WagonCreatBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoveBtn);
            this.Controls.Add(this.RecPanel);
            this.Controls.Add(this.CirPanel);
            this.Controls.Add(this.CreatRecBtn);
            this.Controls.Add(this.CreatCirclBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CirPanel.ResumeLayout(false);
            this.CirPanel.PerformLayout();
            this.RecPanel.ResumeLayout(false);
            this.RecPanel.PerformLayout();
            this.WagonPanel.ResumeLayout(false);
            this.WagonPanel.PerformLayout();
            this.TrainPanel.ResumeLayout(false);
            this.TrainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreatCirclBtn;
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
        private System.Windows.Forms.Button WagonCreatBtn;
        private System.Windows.Forms.Panel WagonPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SizeWagonBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel TrainPanel;
        private System.Windows.Forms.TextBox LengthTrainBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SizeTrainBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CargoSumBox;
        private System.Windows.Forms.Label label5;
    }
}

