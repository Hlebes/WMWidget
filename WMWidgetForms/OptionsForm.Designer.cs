namespace WMWidgetForms
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.navPanel = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.fundSelectLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.timeFormatLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateFormatLabel = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.languageSelectLabel = new System.Windows.Forms.Label();
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.navPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.navPanel.Controls.Add(this.minButton);
            this.navPanel.Controls.Add(this.titleLabel);
            this.navPanel.Controls.Add(this.iconPictureBox);
            this.navPanel.Controls.Add(this.backButton);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(384, 28);
            this.navPanel.TabIndex = 4;
            this.navPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseDown);
            this.navPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseMove);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(168)))));
            this.minButton.Location = new System.Drawing.Point(354, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(27, 27);
            this.minButton.TabIndex = 5;
            this.minButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Core Sans N", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(34, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 17);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseMove);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(168)))));
            this.backButton.Location = new System.Drawing.Point(321, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(27, 27);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // fundSelectLabel
            // 
            this.fundSelectLabel.AutoSize = true;
            this.fundSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fundSelectLabel.Location = new System.Drawing.Point(15, 44);
            this.fundSelectLabel.Name = "fundSelectLabel";
            this.fundSelectLabel.Size = new System.Drawing.Size(126, 20);
            this.fundSelectLabel.TabIndex = 5;
            this.fundSelectLabel.Text = "Выбор валюты:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 2);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 2);
            this.panel2.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(183, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // timeFormatLabel
            // 
            this.timeFormatLabel.AutoSize = true;
            this.timeFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeFormatLabel.Location = new System.Drawing.Point(15, 9);
            this.timeFormatLabel.Name = "timeFormatLabel";
            this.timeFormatLabel.Size = new System.Drawing.Size(144, 20);
            this.timeFormatLabel.TabIndex = 8;
            this.timeFormatLabel.Text = "Формат времени:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(183, 113);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(189, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // dateFormatLabel
            // 
            this.dateFormatLabel.AutoSize = true;
            this.dateFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateFormatLabel.Location = new System.Drawing.Point(15, 113);
            this.dateFormatLabel.Name = "dateFormatLabel";
            this.dateFormatLabel.Size = new System.Drawing.Size(119, 20);
            this.dateFormatLabel.TabIndex = 11;
            this.dateFormatLabel.Text = "Формат даты:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(183, 8);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(189, 21);
            this.comboBox4.TabIndex = 15;
            // 
            // languageSelectLabel
            // 
            this.languageSelectLabel.AutoSize = true;
            this.languageSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageSelectLabel.Location = new System.Drawing.Point(15, 9);
            this.languageSelectLabel.Name = "languageSelectLabel";
            this.languageSelectLabel.Size = new System.Drawing.Size(123, 20);
            this.languageSelectLabel.TabIndex = 14;
            this.languageSelectLabel.Text = "Язык виджета:";
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startupCheckBox.Location = new System.Drawing.Point(16, 183);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(319, 24);
            this.startupCheckBox.TabIndex = 20;
            this.startupCheckBox.Text = "Старт WMWidget при запуске системы";
            this.startupCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Цветовая схема:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Выбрать цвет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Выбранный цвет:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "По умолчанию";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.panel6.Location = new System.Drawing.Point(180, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 46);
            this.panel6.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Цветовая тема:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(180, 110);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 24);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Светлая";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(289, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 24);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "Тёмная";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(37, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 30);
            this.button3.TabIndex = 29;
            this.button3.Text = "Сохранить настройки";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(37, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(311, 30);
            this.button4.TabIndex = 30;
            this.button4.Text = "Сбросить настройки по умолчанию";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.timeFormatLabel);
            this.panel8.Controls.Add(this.comboBox2);
            this.panel8.Location = new System.Drawing.Point(0, 70);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(384, 37);
            this.panel8.TabIndex = 31;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.languageSelectLabel);
            this.panel9.Controls.Add(this.comboBox4);
            this.panel9.Location = new System.Drawing.Point(0, 140);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(384, 37);
            this.panel9.TabIndex = 32;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(384, 2);
            this.panel10.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(0, 35);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(384, 2);
            this.panel11.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 146);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 2);
            this.panel4.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(0, 144);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(384, 2);
            this.panel12.TabIndex = 10;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(168)))));
            this.iconPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.InitialImage")));
            this.iconPictureBox.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(28, 28);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 3;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseDown);
            this.iconPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseMove);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(384, 439);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.startupCheckBox);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateFormatLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fundSelectLabel);
            this.Controls.Add(this.navPanel);
            this.Name = "OptionsForm";
            this.Text = "Настройки WMWidget";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Label fundSelectLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label timeFormatLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label dateFormatLabel;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label languageSelectLabel;
        private System.Windows.Forms.CheckBox startupCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel12;
    }
}