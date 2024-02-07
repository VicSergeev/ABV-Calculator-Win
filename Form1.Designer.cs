namespace AlcVolume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.initDensBox = new System.Windows.Forms.TextBox();
            this.finDensBox = new System.Windows.Forms.TextBox();
            this.getResultButton = new System.Windows.Forms.Button();
            this.showResultLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.faqButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "AlcVolumeCalc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "by Vic Sergeev Q4 2023";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // initDensBox
            // 
            this.initDensBox.Location = new System.Drawing.Point(578, 151);
            this.initDensBox.Name = "initDensBox";
            this.initDensBox.Size = new System.Drawing.Size(100, 20);
            this.initDensBox.TabIndex = 4;
            this.initDensBox.TextChanged += new System.EventHandler(this.initDensBox_TextChanged);
            this.initDensBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initDensBox_KeyPress);
            // 
            // finDensBox
            // 
            this.finDensBox.Location = new System.Drawing.Point(578, 182);
            this.finDensBox.Name = "finDensBox";
            this.finDensBox.Size = new System.Drawing.Size(100, 20);
            this.finDensBox.TabIndex = 5;
            this.finDensBox.TextChanged += new System.EventHandler(this.finDensBox_TextChanged);
            this.finDensBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.finDensBox_KeyPress);
            // 
            // getResultButton
            // 
            this.getResultButton.Location = new System.Drawing.Point(323, 232);
            this.getResultButton.Name = "getResultButton";
            this.getResultButton.Size = new System.Drawing.Size(100, 39);
            this.getResultButton.TabIndex = 6;
            this.getResultButton.Text = "Рассчитать об.%";
            this.getResultButton.UseVisualStyleBackColor = true;
            this.getResultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // showResultLabel
            // 
            this.showResultLabel.AutoSize = true;
            this.showResultLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.showResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showResultLabel.ForeColor = System.Drawing.Color.Blue;
            this.showResultLabel.Location = new System.Drawing.Point(323, 286);
            this.showResultLabel.Name = "showResultLabel";
            this.showResultLabel.Size = new System.Drawing.Size(137, 16);
            this.showResultLabel.TabIndex = 7;
            this.showResultLabel.Text = "Здесь будет расчет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(320, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Начальная не больше 28.9, не отрицательное число";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(320, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(348, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Конечная не больше начальной, не отрицательное число";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(578, 232);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 39);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(135, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "v.0.1.6";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 238);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(323, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "ПУСТЫХ СТРОК БЫТЬ НЕ ДОЛЖНО";
            // 
            // faqButton
            // 
            this.faqButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.faqButton.ForeColor = System.Drawing.Color.Black;
            this.faqButton.Location = new System.Drawing.Point(629, 19);
            this.faqButton.Name = "faqButton";
            this.faqButton.Size = new System.Drawing.Size(43, 39);
            this.faqButton.TabIndex = 16;
            this.faqButton.Text = "?";
            this.faqButton.UseVisualStyleBackColor = false;
            this.faqButton.Click += new System.EventHandler(this.faqButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(319, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Конечная плотность Сусла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(319, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начальная плотность Сусла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 330);
            this.Controls.Add(this.faqButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showResultLabel);
            this.Controls.Add(this.getResultButton);
            this.Controls.Add(this.finDensBox);
            this.Controls.Add(this.initDensBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AlcVolCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initDensBox;
        private System.Windows.Forms.TextBox finDensBox;
        private System.Windows.Forms.Button getResultButton;
        private System.Windows.Forms.Label showResultLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button faqButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

