namespace WMWidgetForms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.navPanel = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.moreButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(139)))), ((int)(((byte)(254)))));
            this.navPanel.Controls.Add(this.refreshButton);
            this.navPanel.Controls.Add(this.label2);
            this.navPanel.Controls.Add(this.label1);
            this.navPanel.Controls.Add(this.minButton);
            this.navPanel.Controls.Add(this.titleLabel);
            this.navPanel.Controls.Add(this.iconPictureBox);
            this.navPanel.Controls.Add(this.moreButton);
            this.navPanel.Controls.Add(this.settingsButton);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(384, 28);
            this.navPanel.TabIndex = 3;
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
            this.minButton.TabIndex = 4;
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
            // moreButton
            // 
            this.moreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(168)))));
            this.moreButton.Location = new System.Drawing.Point(288, 0);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(27, 27);
            this.moreButton.TabIndex = 3;
            this.moreButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(168)))));
            this.settingsButton.Location = new System.Drawing.Point(321, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(27, 27);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 183);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Последнее обновление:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseMove);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(208)))), ((int)(((byte)(168)))));
            this.refreshButton.Image = global::WMWidgetForms.Properties.Resources.refreshArrow;
            this.refreshButton.Location = new System.Drawing.Point(255, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(28, 28);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.UseVisualStyleBackColor = false;
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
            // trayIcon
            // 
            this.trayIcon.Text = "WMWidget";
            this.trayIcon.Visible = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navPanel);
            this.Name = "Main";
            this.Text = "WMWidget";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}

