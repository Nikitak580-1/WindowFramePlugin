namespace WindowFramePlugin.View
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
            this.BilderPanel = new System.Windows.Forms.Panel();
            this.NameOfParameters = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.DetailPictureBox = new System.Windows.Forms.PictureBox();
            this.ParameterLimitations = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParameterValues = new System.Windows.Forms.Panel();
            this.HeightOFThreeLeafTextBox = new System.Windows.Forms.TextBox();
            this.HeightOFOneLeafTextBox = new System.Windows.Forms.TextBox();
            this.WidthOFTheFlapsTextBox = new System.Windows.Forms.TextBox();
            this.FrameWidthTextBox = new System.Windows.Forms.TextBox();
            this.FrameHeightTextBox = new System.Windows.Forms.TextBox();
            this.FramelengthTextBox = new System.Windows.Forms.TextBox();
            this.BilderPanel.SuspendLayout();
            this.NameOfParameters.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailPictureBox)).BeginInit();
            this.ParameterLimitations.SuspendLayout();
            this.ParameterValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // BilderPanel
            // 
            this.BilderPanel.Controls.Add(this.NameOfParameters);
            this.BilderPanel.Controls.Add(this.ButtonPanel);
            this.BilderPanel.Controls.Add(this.ImagePanel);
            this.BilderPanel.Controls.Add(this.ParameterLimitations);
            this.BilderPanel.Controls.Add(this.ParameterValues);
            this.BilderPanel.Location = new System.Drawing.Point(2, 2);
            this.BilderPanel.Name = "BilderPanel";
            this.BilderPanel.Size = new System.Drawing.Size(622, 275);
            this.BilderPanel.TabIndex = 0;
            // 
            // NameOfParameters
            // 
            this.NameOfParameters.Controls.Add(this.label8);
            this.NameOfParameters.Controls.Add(this.label10);
            this.NameOfParameters.Controls.Add(this.label11);
            this.NameOfParameters.Controls.Add(this.label12);
            this.NameOfParameters.Controls.Add(this.label13);
            this.NameOfParameters.Controls.Add(this.label14);
            this.NameOfParameters.Location = new System.Drawing.Point(3, 0);
            this.NameOfParameters.Name = "NameOfParameters";
            this.NameOfParameters.Size = new System.Drawing.Size(185, 197);
            this.NameOfParameters.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Общая высота 3 створки окна g3 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Общая высота 1 створки окна g1 ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Общая ширина створок окна tm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Общая ширина рамы окна th";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Высота рамы окна h2 ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Длина рамы окна  w1 ";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.BuildButton);
            this.ButtonPanel.Location = new System.Drawing.Point(3, 196);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(616, 79);
            this.ButtonPanel.TabIndex = 4;
            // 
            // BuildButton
            // 
            this.BuildButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BuildButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildButton.Location = new System.Drawing.Point(455, 23);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(151, 45);
            this.BuildButton.TabIndex = 0;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButtonClick);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.DetailPictureBox);
            this.ImagePanel.Location = new System.Drawing.Point(384, 3);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(256, 194);
            this.ImagePanel.TabIndex = 3;
            // 
            // DetailPictureBox
            // 
            this.DetailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DetailPictureBox.Image")));
            this.DetailPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DetailPictureBox.InitialImage")));
            this.DetailPictureBox.Location = new System.Drawing.Point(3, 3);
            this.DetailPictureBox.Name = "DetailPictureBox";
            this.DetailPictureBox.Size = new System.Drawing.Size(232, 188);
            this.DetailPictureBox.TabIndex = 0;
            this.DetailPictureBox.TabStop = false;
            // 
            // ParameterLimitations
            // 
            this.ParameterLimitations.Controls.Add(this.label7);
            this.ParameterLimitations.Controls.Add(this.label1);
            this.ParameterLimitations.Controls.Add(this.label2);
            this.ParameterLimitations.Controls.Add(this.label5);
            this.ParameterLimitations.Controls.Add(this.label3);
            this.ParameterLimitations.Controls.Add(this.label4);
            this.ParameterLimitations.Location = new System.Drawing.Point(300, 3);
            this.ParameterLimitations.Name = "ParameterLimitations";
            this.ParameterLimitations.Size = new System.Drawing.Size(86, 194);
            this.ParameterLimitations.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "10мм — 30мм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "50мм — 300мм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "50мм — 700мм";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "45мм — 700мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "30мм — 50мм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "30мм — 50мм";
            // 
            // ParameterValues
            // 
            this.ParameterValues.Controls.Add(this.HeightOFThreeLeafTextBox);
            this.ParameterValues.Controls.Add(this.HeightOFOneLeafTextBox);
            this.ParameterValues.Controls.Add(this.WidthOFTheFlapsTextBox);
            this.ParameterValues.Controls.Add(this.FrameWidthTextBox);
            this.ParameterValues.Controls.Add(this.FrameHeightTextBox);
            this.ParameterValues.Controls.Add(this.FramelengthTextBox);
            this.ParameterValues.Location = new System.Drawing.Point(191, 3);
            this.ParameterValues.Name = "ParameterValues";
            this.ParameterValues.Size = new System.Drawing.Size(109, 194);
            this.ParameterValues.TabIndex = 1;
            // 
            // HeightOFThreeLeafTextBox
            // 
            this.HeightOFThreeLeafTextBox.Location = new System.Drawing.Point(3, 131);
            this.HeightOFThreeLeafTextBox.Name = "HeightOFThreeLeafTextBox";
            this.HeightOFThreeLeafTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightOFThreeLeafTextBox.TabIndex = 6;
            this.HeightOFThreeLeafTextBox.Leave += new System.EventHandler(this.HeightOFThreeLeafTextBox_Leave);
            // 
            // HeightOFOneLeafTextBox
            // 
            this.HeightOFOneLeafTextBox.Location = new System.Drawing.Point(3, 105);
            this.HeightOFOneLeafTextBox.Name = "HeightOFOneLeafTextBox";
            this.HeightOFOneLeafTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightOFOneLeafTextBox.TabIndex = 4;
            this.HeightOFOneLeafTextBox.Leave += new System.EventHandler(this.HeightOFOneLeafTextBox_Leave);
            // 
            // WidthOFTheFlapsTextBox
            // 
            this.WidthOFTheFlapsTextBox.Location = new System.Drawing.Point(3, 79);
            this.WidthOFTheFlapsTextBox.Name = "WidthOFTheFlapsTextBox";
            this.WidthOFTheFlapsTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthOFTheFlapsTextBox.TabIndex = 3;
            this.WidthOFTheFlapsTextBox.Leave += new System.EventHandler(this.WidthOFTheFlapsTextBox_Leave);
            // 
            // FrameWidthTextBox
            // 
            this.FrameWidthTextBox.Location = new System.Drawing.Point(3, 53);
            this.FrameWidthTextBox.Name = "FrameWidthTextBox";
            this.FrameWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.FrameWidthTextBox.TabIndex = 2;
            this.FrameWidthTextBox.Leave += new System.EventHandler(this.FrameWidthTextBox_Leave);
            // 
            // FrameHeightTextBox
            // 
            this.FrameHeightTextBox.Location = new System.Drawing.Point(3, 27);
            this.FrameHeightTextBox.Name = "FrameHeightTextBox";
            this.FrameHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.FrameHeightTextBox.TabIndex = 1;
            this.FrameHeightTextBox.Leave += new System.EventHandler(this.FrameHeightTextBox_Leave);
            // 
            // FramelengthTextBox
            // 
            this.FramelengthTextBox.Location = new System.Drawing.Point(3, 1);
            this.FramelengthTextBox.Name = "FramelengthTextBox";
            this.FramelengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.FramelengthTextBox.TabIndex = 0;
            this.FramelengthTextBox.Leave += new System.EventHandler(this.FramelengthTextBox_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 278);
            this.Controls.Add(this.BilderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WindowFrameCreate";
            this.BilderPanel.ResumeLayout(false);
            this.NameOfParameters.ResumeLayout(false);
            this.NameOfParameters.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailPictureBox)).EndInit();
            this.ParameterLimitations.ResumeLayout(false);
            this.ParameterLimitations.PerformLayout();
            this.ParameterValues.ResumeLayout(false);
            this.ParameterValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BilderPanel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox DetailPictureBox;
        private System.Windows.Forms.Panel ParameterLimitations;
        private System.Windows.Forms.Panel ParameterValues;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Panel NameOfParameters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HeightOFThreeLeafTextBox;
        private System.Windows.Forms.TextBox HeightOFOneLeafTextBox;
        private System.Windows.Forms.TextBox WidthOFTheFlapsTextBox;
        private System.Windows.Forms.TextBox FrameWidthTextBox;
        private System.Windows.Forms.TextBox FrameHeightTextBox;
        private System.Windows.Forms.TextBox FramelengthTextBox;
    }
}

