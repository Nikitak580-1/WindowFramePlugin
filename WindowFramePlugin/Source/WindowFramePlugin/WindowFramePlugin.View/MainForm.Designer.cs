namespace WindowFramePlugin
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TmTextBox = new System.Windows.Forms.TextBox();
            this.W1TextBox = new System.Windows.Forms.TextBox();
            this.G2TextBox = new System.Windows.Forms.TextBox();
            this.H2TextBox = new System.Windows.Forms.TextBox();
            this.ThTextBox = new System.Windows.Forms.TextBox();
            this.L3TextBox = new System.Windows.Forms.TextBox();
            this.W1Label = new System.Windows.Forms.Label();
            this.H2Label = new System.Windows.Forms.Label();
            this.ThLabel = new System.Windows.Forms.Label();
            this.TmLabel = new System.Windows.Forms.Label();
            this.G2Label = new System.Windows.Forms.Label();
            this.L3Label = new System.Windows.Forms.Label();
            this.RangeL3Label = new System.Windows.Forms.Label();
            this.RangeG2Label = new System.Windows.Forms.Label();
            this.RangeThLabel = new System.Windows.Forms.Label();
            this.RangeH2Label = new System.Windows.Forms.Label();
            this.RangeW1Label = new System.Windows.Forms.Label();
            this.RangeTmLabel = new System.Windows.Forms.Label();
            this.BuildButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AllParametersLabel = new System.Windows.Forms.Label();
            this.WindowParametersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TmTextBox
            // 
            this.TmTextBox.Location = new System.Drawing.Point(209, 131);
            this.TmTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.TmTextBox.Name = "TmTextBox";
            this.TmTextBox.Size = new System.Drawing.Size(100, 20);
            this.TmTextBox.TabIndex = 0;
            this.TmTextBox.TextChanged += new System.EventHandler(this.SetParameters);
            this.TmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLimiter);
            // 
            // W1TextBox
            // 
            this.W1TextBox.Location = new System.Drawing.Point(209, 32);
            this.W1TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.W1TextBox.Name = "W1TextBox";
            this.W1TextBox.Size = new System.Drawing.Size(100, 20);
            this.W1TextBox.TabIndex = 1;
            this.W1TextBox.TextChanged += new System.EventHandler(this.SetParameters);
            this.W1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLimiter);
            // 
            // G2TextBox
            // 
            this.G2TextBox.Location = new System.Drawing.Point(209, 164);
            this.G2TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.G2TextBox.Name = "G2TextBox";
            this.G2TextBox.Size = new System.Drawing.Size(100, 20);
            this.G2TextBox.TabIndex = 3;
            this.G2TextBox.TextChanged += new System.EventHandler(this.SetParameters);
            this.G2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLimiter);
            // 
            // H2TextBox
            // 
            this.H2TextBox.Location = new System.Drawing.Point(209, 65);
            this.H2TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.H2TextBox.Name = "H2TextBox";
            this.H2TextBox.Size = new System.Drawing.Size(100, 20);
            this.H2TextBox.TabIndex = 4;
            this.H2TextBox.TextChanged += new System.EventHandler(this.SetParameters);
            this.H2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLimiter);
            // 
            // ThTextBox
            // 
            this.ThTextBox.Location = new System.Drawing.Point(209, 98);
            this.ThTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ThTextBox.Name = "ThTextBox";
            this.ThTextBox.Size = new System.Drawing.Size(100, 20);
            this.ThTextBox.TabIndex = 5;
            this.ThTextBox.TextChanged += new System.EventHandler(this.SetParameters);
            this.ThTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLimiter);
            // 
            // L3TextBox
            // 
            this.L3TextBox.Location = new System.Drawing.Point(209, 197);
            this.L3TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.L3TextBox.Name = "L3TextBox";
            this.L3TextBox.Size = new System.Drawing.Size(100, 20);
            this.L3TextBox.TabIndex = 6;
            this.L3TextBox.TextChanged += new System.EventHandler(this.SetParameters);
            this.L3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLimiter);
            // 
            // W1Label
            // 
            this.W1Label.AutoSize = true;
            this.W1Label.Location = new System.Drawing.Point(12, 35);
            this.W1Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.W1Label.Name = "W1Label";
            this.W1Label.Size = new System.Drawing.Size(115, 13);
            this.W1Label.TabIndex = 7;
            this.W1Label.Text = "Длина рамы окна w1";
            // 
            // H2Label
            // 
            this.H2Label.AutoSize = true;
            this.H2Label.Location = new System.Drawing.Point(12, 68);
            this.H2Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.H2Label.Name = "H2Label";
            this.H2Label.Size = new System.Drawing.Size(118, 13);
            this.H2Label.TabIndex = 8;
            this.H2Label.Text = "Высота рамы окна h2";
            // 
            // ThLabel
            // 
            this.ThLabel.AutoSize = true;
            this.ThLabel.Location = new System.Drawing.Point(12, 101);
            this.ThLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.ThLabel.Name = "ThLabel";
            this.ThLabel.Size = new System.Drawing.Size(153, 13);
            this.ThLabel.TabIndex = 9;
            this.ThLabel.Text = "Общая ширина рамы окна th";
            // 
            // TmLabel
            // 
            this.TmLabel.AutoSize = true;
            this.TmLabel.Location = new System.Drawing.Point(12, 134);
            this.TmLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.TmLabel.Name = "TmLabel";
            this.TmLabel.Size = new System.Drawing.Size(168, 13);
            this.TmLabel.TabIndex = 10;
            this.TmLabel.Text = "Общая ширина створок окна tm";
            // 
            // G2Label
            // 
            this.G2Label.AutoSize = true;
            this.G2Label.Location = new System.Drawing.Point(12, 167);
            this.G2Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.G2Label.Name = "G2Label";
            this.G2Label.Size = new System.Drawing.Size(177, 13);
            this.G2Label.TabIndex = 11;
            this.G2Label.Text = "Общая высота 2 створки окна g2";
            // 
            // L3Label
            // 
            this.L3Label.AutoSize = true;
            this.L3Label.Location = new System.Drawing.Point(12, 200);
            this.L3Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.L3Label.Name = "L3Label";
            this.L3Label.Size = new System.Drawing.Size(191, 13);
            this.L3Label.TabIndex = 12;
            this.L3Label.Text = "Длина перегородки внутри рамы L3";
            // 
            // RangeL3Label
            // 
            this.RangeL3Label.AutoSize = true;
            this.RangeL3Label.Location = new System.Drawing.Point(320, 200);
            this.RangeL3Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.RangeL3Label.Name = "RangeL3Label";
            this.RangeL3Label.Size = new System.Drawing.Size(62, 13);
            this.RangeL3Label.TabIndex = 18;
            this.RangeL3Label.Text = "50 - 300мм";
            // 
            // RangeG2Label
            // 
            this.RangeG2Label.AutoSize = true;
            this.RangeG2Label.Location = new System.Drawing.Point(320, 167);
            this.RangeG2Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.RangeG2Label.Name = "RangeG2Label";
            this.RangeG2Label.Size = new System.Drawing.Size(62, 13);
            this.RangeG2Label.TabIndex = 17;
            this.RangeG2Label.Text = "45 - 700мм";
            // 
            // RangeThLabel
            // 
            this.RangeThLabel.AutoSize = true;
            this.RangeThLabel.Location = new System.Drawing.Point(320, 101);
            this.RangeThLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.RangeThLabel.Name = "RangeThLabel";
            this.RangeThLabel.Size = new System.Drawing.Size(50, 13);
            this.RangeThLabel.TabIndex = 15;
            this.RangeThLabel.Text = "5 - 10мм";
            // 
            // RangeH2Label
            // 
            this.RangeH2Label.AutoSize = true;
            this.RangeH2Label.Location = new System.Drawing.Point(320, 68);
            this.RangeH2Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.RangeH2Label.Name = "RangeH2Label";
            this.RangeH2Label.Size = new System.Drawing.Size(56, 13);
            this.RangeH2Label.TabIndex = 14;
            this.RangeH2Label.Text = "50 - 80мм";
            // 
            // RangeW1Label
            // 
            this.RangeW1Label.AutoSize = true;
            this.RangeW1Label.Location = new System.Drawing.Point(320, 35);
            this.RangeW1Label.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.RangeW1Label.Name = "RangeW1Label";
            this.RangeW1Label.Size = new System.Drawing.Size(56, 13);
            this.RangeW1Label.TabIndex = 13;
            this.RangeW1Label.Text = "50 - 80мм";
            // 
            // RangeTmLabel
            // 
            this.RangeTmLabel.AutoSize = true;
            this.RangeTmLabel.Location = new System.Drawing.Point(320, 134);
            this.RangeTmLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.RangeTmLabel.Name = "RangeTmLabel";
            this.RangeTmLabel.Size = new System.Drawing.Size(44, 13);
            this.RangeTmLabel.TabIndex = 19;
            this.RangeTmLabel.Text = "4 - 6мм";
            // 
            // BuildButton
            // 
            this.BuildButton.BackColor = System.Drawing.Color.White;
            this.BuildButton.Location = new System.Drawing.Point(12, 263);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(100, 40);
            this.BuildButton.TabIndex = 20;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = false;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImage = global::WindowFramePlugin.Properties.Resources.схема;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox.Location = new System.Drawing.Point(416, 25);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(333, 283);
            this.PictureBox.TabIndex = 21;
            this.PictureBox.TabStop = false;
            // 
            // AllParametersLabel
            // 
            this.AllParametersLabel.AutoSize = true;
            this.AllParametersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllParametersLabel.Location = new System.Drawing.Point(3, 9);
            this.AllParametersLabel.Name = "AllParametersLabel";
            this.AllParametersLabel.Size = new System.Drawing.Size(177, 13);
            this.AllParametersLabel.TabIndex = 22;
            this.AllParametersLabel.Text = "Параметры для построения:";
            // 
            // WindowParametersLabel
            // 
            this.WindowParametersLabel.AutoSize = true;
            this.WindowParametersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowParametersLabel.Location = new System.Drawing.Point(400, 9);
            this.WindowParametersLabel.Name = "WindowParametersLabel";
            this.WindowParametersLabel.Size = new System.Drawing.Size(146, 13);
            this.WindowParametersLabel.TabIndex = 23;
            this.WindowParametersLabel.Text = "Схема для построения:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 315);
            this.Controls.Add(this.WindowParametersLabel);
            this.Controls.Add(this.AllParametersLabel);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.RangeTmLabel);
            this.Controls.Add(this.RangeL3Label);
            this.Controls.Add(this.RangeG2Label);
            this.Controls.Add(this.RangeThLabel);
            this.Controls.Add(this.RangeH2Label);
            this.Controls.Add(this.RangeW1Label);
            this.Controls.Add(this.L3Label);
            this.Controls.Add(this.G2Label);
            this.Controls.Add(this.TmLabel);
            this.Controls.Add(this.ThLabel);
            this.Controls.Add(this.H2Label);
            this.Controls.Add(this.W1Label);
            this.Controls.Add(this.L3TextBox);
            this.Controls.Add(this.ThTextBox);
            this.Controls.Add(this.H2TextBox);
            this.Controls.Add(this.G2TextBox);
            this.Controls.Add(this.W1TextBox);
            this.Controls.Add(this.TmTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(779, 354);
            this.MinimumSize = new System.Drawing.Size(779, 354);
            this.Name = "MainForm";
            this.Text = "Create Window";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TmTextBox;
        private System.Windows.Forms.TextBox W1TextBox;
        private System.Windows.Forms.TextBox G2TextBox;
        private System.Windows.Forms.TextBox H2TextBox;
        private System.Windows.Forms.TextBox ThTextBox;
        private System.Windows.Forms.TextBox L3TextBox;
        private System.Windows.Forms.Label W1Label;
        private System.Windows.Forms.Label H2Label;
        private System.Windows.Forms.Label ThLabel;
        private System.Windows.Forms.Label TmLabel;
        private System.Windows.Forms.Label G2Label;
        private System.Windows.Forms.Label L3Label;
        private System.Windows.Forms.Label RangeL3Label;
        private System.Windows.Forms.Label RangeG2Label;
        private System.Windows.Forms.Label RangeThLabel;
        private System.Windows.Forms.Label RangeH2Label;
        private System.Windows.Forms.Label RangeW1Label;
        private System.Windows.Forms.Label RangeTmLabel;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label AllParametersLabel;
        private System.Windows.Forms.Label WindowParametersLabel;
    }
}

