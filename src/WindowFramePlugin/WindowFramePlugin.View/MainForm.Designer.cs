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
            this.l3Label = new System.Windows.Forms.Label();
            this.G2Label = new System.Windows.Forms.Label();
            this.TmLabel = new System.Windows.Forms.Label();
            this.ThLabel = new System.Windows.Forms.Label();
            this.H2Label = new System.Windows.Forms.Label();
            this.W1Label = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.DetailPictureBox = new System.Windows.Forms.PictureBox();
            this.ParameterLimitations = new System.Windows.Forms.Panel();
            this.LimitationL3Label = new System.Windows.Forms.Label();
            this.LimitationW1Label = new System.Windows.Forms.Label();
            this.LimitationH2Label = new System.Windows.Forms.Label();
            this.LimitationG2Label = new System.Windows.Forms.Label();
            this.LimitationThLabel = new System.Windows.Forms.Label();
            this.LimitationTmLabel = new System.Windows.Forms.Label();
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
            this.BilderPanel.Size = new System.Drawing.Size(736, 387);
            this.BilderPanel.TabIndex = 0;
            // 
            // NameOfParameters
            // 
            this.NameOfParameters.Controls.Add(this.l3Label);
            this.NameOfParameters.Controls.Add(this.G2Label);
            this.NameOfParameters.Controls.Add(this.TmLabel);
            this.NameOfParameters.Controls.Add(this.ThLabel);
            this.NameOfParameters.Controls.Add(this.H2Label);
            this.NameOfParameters.Controls.Add(this.W1Label);
            this.NameOfParameters.Location = new System.Drawing.Point(3, 0);
            this.NameOfParameters.Name = "NameOfParameters";
            this.NameOfParameters.Size = new System.Drawing.Size(203, 283);
            this.NameOfParameters.TabIndex = 5;
            // 
            // l3Label
            // 
            this.l3Label.AutoSize = true;
            this.l3Label.Location = new System.Drawing.Point(3, 134);
            this.l3Label.Name = "l3Label";
            this.l3Label.Size = new System.Drawing.Size(191, 13);
            this.l3Label.TabIndex = 6;
            this.l3Label.Text = "Длина перегородки внутри рамы L3";
            // 
            // G2Label
            // 
            this.G2Label.AutoSize = true;
            this.G2Label.Location = new System.Drawing.Point(3, 108);
            this.G2Label.Name = "G2Label";
            this.G2Label.Size = new System.Drawing.Size(172, 13);
            this.G2Label.TabIndex = 4;
            this.G2Label.Text = "Высота створки g2 внутри рамы";
            // 
            // TmLabel
            // 
            this.TmLabel.AutoSize = true;
            this.TmLabel.Location = new System.Drawing.Point(3, 82);
            this.TmLabel.Name = "TmLabel";
            this.TmLabel.Size = new System.Drawing.Size(181, 13);
            this.TmLabel.TabIndex = 3;
            this.TmLabel.Text = "Ширина створок и перегородки tm";
            // 
            // ThLabel
            // 
            this.ThLabel.AutoSize = true;
            this.ThLabel.Location = new System.Drawing.Point(3, 56);
            this.ThLabel.Name = "ThLabel";
            this.ThLabel.Size = new System.Drawing.Size(116, 13);
            this.ThLabel.TabIndex = 2;
            this.ThLabel.Text = "Ширина рамы окна th";
            // 
            // H2Label
            // 
            this.H2Label.AutoSize = true;
            this.H2Label.Location = new System.Drawing.Point(3, 30);
            this.H2Label.Name = "H2Label";
            this.H2Label.Size = new System.Drawing.Size(121, 13);
            this.H2Label.TabIndex = 1;
            this.H2Label.Text = "Высота рамы окна h2 ";
            // 
            // W1Label
            // 
            this.W1Label.AutoSize = true;
            this.W1Label.Location = new System.Drawing.Point(3, 4);
            this.W1Label.Name = "W1Label";
            this.W1Label.Size = new System.Drawing.Size(121, 13);
            this.W1Label.TabIndex = 0;
            this.W1Label.Text = "Длина рамы окна  w1 ";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.BuildButton);
            this.ButtonPanel.Location = new System.Drawing.Point(3, 286);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(730, 98);
            this.ButtonPanel.TabIndex = 4;
            // 
            // BuildButton
            // 
            this.BuildButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BuildButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildButton.Location = new System.Drawing.Point(573, 45);
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
            this.ImagePanel.Location = new System.Drawing.Point(487, 3);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(246, 268);
            this.ImagePanel.TabIndex = 3;
            // 
            // DetailPictureBox
            // 
            this.DetailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DetailPictureBox.Image")));
            this.DetailPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("DetailPictureBox.InitialImage")));
            this.DetailPictureBox.Location = new System.Drawing.Point(3, -3);
            this.DetailPictureBox.Name = "DetailPictureBox";
            this.DetailPictureBox.Size = new System.Drawing.Size(240, 265);
            this.DetailPictureBox.TabIndex = 0;
            this.DetailPictureBox.TabStop = false;
            // 
            // ParameterLimitations
            // 
            this.ParameterLimitations.Controls.Add(this.LimitationL3Label);
            this.ParameterLimitations.Controls.Add(this.LimitationW1Label);
            this.ParameterLimitations.Controls.Add(this.LimitationH2Label);
            this.ParameterLimitations.Controls.Add(this.LimitationG2Label);
            this.ParameterLimitations.Controls.Add(this.LimitationThLabel);
            this.ParameterLimitations.Controls.Add(this.LimitationTmLabel);
            this.ParameterLimitations.Location = new System.Drawing.Point(378, 3);
            this.ParameterLimitations.Name = "ParameterLimitations";
            this.ParameterLimitations.Size = new System.Drawing.Size(106, 280);
            this.ParameterLimitations.TabIndex = 2;
            // 
            // LimitationL3Label
            // 
            this.LimitationL3Label.AutoSize = true;
            this.LimitationL3Label.Location = new System.Drawing.Point(5, 134);
            this.LimitationL3Label.Name = "LimitationL3Label";
            this.LimitationL3Label.Size = new System.Drawing.Size(81, 13);
            this.LimitationL3Label.TabIndex = 6;
            this.LimitationL3Label.Text = "50мм — 300мм";
            // 
            // LimitationW1Label
            // 
            this.LimitationW1Label.AutoSize = true;
            this.LimitationW1Label.Location = new System.Drawing.Point(5, 4);
            this.LimitationW1Label.Name = "LimitationW1Label";
            this.LimitationW1Label.Size = new System.Drawing.Size(81, 13);
            this.LimitationW1Label.TabIndex = 0;
            this.LimitationW1Label.Text = "50мм — 300мм";
            // 
            // LimitationH2Label
            // 
            this.LimitationH2Label.AutoSize = true;
            this.LimitationH2Label.Location = new System.Drawing.Point(3, 30);
            this.LimitationH2Label.Name = "LimitationH2Label";
            this.LimitationH2Label.Size = new System.Drawing.Size(81, 13);
            this.LimitationH2Label.TabIndex = 1;
            this.LimitationH2Label.Text = "50мм — 700мм";
            // 
            // LimitationG2Label
            // 
            this.LimitationG2Label.AutoSize = true;
            this.LimitationG2Label.Location = new System.Drawing.Point(5, 108);
            this.LimitationG2Label.Name = "LimitationG2Label";
            this.LimitationG2Label.Size = new System.Drawing.Size(81, 13);
            this.LimitationG2Label.TabIndex = 4;
            this.LimitationG2Label.Text = "45мм — 700мм";
            // 
            // LimitationThLabel
            // 
            this.LimitationThLabel.AutoSize = true;
            this.LimitationThLabel.Location = new System.Drawing.Point(5, 56);
            this.LimitationThLabel.Name = "LimitationThLabel";
            this.LimitationThLabel.Size = new System.Drawing.Size(75, 13);
            this.LimitationThLabel.TabIndex = 2;
            this.LimitationThLabel.Text = "30мм — 50мм";
            // 
            // LimitationTmLabel
            // 
            this.LimitationTmLabel.AutoSize = true;
            this.LimitationTmLabel.Location = new System.Drawing.Point(5, 82);
            this.LimitationTmLabel.Name = "LimitationTmLabel";
            this.LimitationTmLabel.Size = new System.Drawing.Size(75, 13);
            this.LimitationTmLabel.TabIndex = 3;
            this.LimitationTmLabel.Text = "30мм — 50мм";
            // 
            // ParameterValues
            // 
            this.ParameterValues.Controls.Add(this.HeightOFThreeLeafTextBox);
            this.ParameterValues.Controls.Add(this.HeightOFOneLeafTextBox);
            this.ParameterValues.Controls.Add(this.WidthOFTheFlapsTextBox);
            this.ParameterValues.Controls.Add(this.FrameWidthTextBox);
            this.ParameterValues.Controls.Add(this.FrameHeightTextBox);
            this.ParameterValues.Controls.Add(this.FramelengthTextBox);
            this.ParameterValues.Location = new System.Drawing.Point(212, 3);
            this.ParameterValues.Name = "ParameterValues";
            this.ParameterValues.Size = new System.Drawing.Size(160, 280);
            this.ParameterValues.TabIndex = 1;
            // 
            // HeightOFThreeLeafTextBox
            // 
            this.HeightOFThreeLeafTextBox.Location = new System.Drawing.Point(3, 131);
            this.HeightOFThreeLeafTextBox.Name = "HeightOFThreeLeafTextBox";
            this.HeightOFThreeLeafTextBox.Size = new System.Drawing.Size(131, 20);
            this.HeightOFThreeLeafTextBox.TabIndex = 6;
            this.HeightOFThreeLeafTextBox.Leave += new System.EventHandler(this.HeightOFThreeLeafTextBox_Leave);
            // 
            // HeightOFOneLeafTextBox
            // 
            this.HeightOFOneLeafTextBox.Location = new System.Drawing.Point(3, 105);
            this.HeightOFOneLeafTextBox.Name = "HeightOFOneLeafTextBox";
            this.HeightOFOneLeafTextBox.Size = new System.Drawing.Size(131, 20);
            this.HeightOFOneLeafTextBox.TabIndex = 4;
            this.HeightOFOneLeafTextBox.Leave += new System.EventHandler(this.HeightOFOneLeafTextBox_Leave);
            // 
            // WidthOFTheFlapsTextBox
            // 
            this.WidthOFTheFlapsTextBox.Location = new System.Drawing.Point(3, 79);
            this.WidthOFTheFlapsTextBox.Name = "WidthOFTheFlapsTextBox";
            this.WidthOFTheFlapsTextBox.Size = new System.Drawing.Size(131, 20);
            this.WidthOFTheFlapsTextBox.TabIndex = 3;
            this.WidthOFTheFlapsTextBox.Leave += new System.EventHandler(this.WidthOFTheFlapsTextBox_Leave);
            // 
            // FrameWidthTextBox
            // 
            this.FrameWidthTextBox.Location = new System.Drawing.Point(3, 53);
            this.FrameWidthTextBox.Name = "FrameWidthTextBox";
            this.FrameWidthTextBox.Size = new System.Drawing.Size(131, 20);
            this.FrameWidthTextBox.TabIndex = 2;
            this.FrameWidthTextBox.Leave += new System.EventHandler(this.FrameWidthTextBox_Leave);
            // 
            // FrameHeightTextBox
            // 
            this.FrameHeightTextBox.Location = new System.Drawing.Point(3, 27);
            this.FrameHeightTextBox.Name = "FrameHeightTextBox";
            this.FrameHeightTextBox.Size = new System.Drawing.Size(131, 20);
            this.FrameHeightTextBox.TabIndex = 1;
            this.FrameHeightTextBox.Leave += new System.EventHandler(this.FrameHeightTextBox_Leave);
            // 
            // FramelengthTextBox
            // 
            this.FramelengthTextBox.Location = new System.Drawing.Point(3, 1);
            this.FramelengthTextBox.Name = "FramelengthTextBox";
            this.FramelengthTextBox.Size = new System.Drawing.Size(131, 20);
            this.FramelengthTextBox.TabIndex = 0;
            this.FramelengthTextBox.Leave += new System.EventHandler(this.FramelengthTextBox_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 390);
            this.Controls.Add(this.BilderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Window Frame Create";
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
        private System.Windows.Forms.Label l3Label;
        private System.Windows.Forms.Label G2Label;
        private System.Windows.Forms.Label TmLabel;
        private System.Windows.Forms.Label ThLabel;
        private System.Windows.Forms.Label H2Label;
        private System.Windows.Forms.Label W1Label;
        private System.Windows.Forms.Label LimitationL3Label;
        private System.Windows.Forms.Label LimitationG2Label;
        private System.Windows.Forms.Label LimitationTmLabel;
        private System.Windows.Forms.Label LimitationThLabel;
        private System.Windows.Forms.Label LimitationH2Label;
        private System.Windows.Forms.Label LimitationW1Label;
        private System.Windows.Forms.TextBox HeightOFThreeLeafTextBox;
        private System.Windows.Forms.TextBox HeightOFOneLeafTextBox;
        private System.Windows.Forms.TextBox WidthOFTheFlapsTextBox;
        private System.Windows.Forms.TextBox FrameWidthTextBox;
        private System.Windows.Forms.TextBox FrameHeightTextBox;
        private System.Windows.Forms.TextBox FramelengthTextBox;
    }
}

