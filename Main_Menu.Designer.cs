namespace Movers_Maintenance_Subsystem
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            BaseScrollMenuPanel = new Panel();
            btnLeave = new Button();
            btnSettings = new Button();
            btnReportMenu = new Button();
            pnlForDataManipulation = new Panel();
            btnUpdateMenu = new Button();
            btnViewMenu = new Button();
            btnRemoveMenu = new Button();
            btnAddMenu = new Button();
            btnDataMenu = new Button();
            pnlForLogo = new Panel();
            pctbxLogo = new PictureBox();
            pnlContainer = new Panel();
            BaseScrollMenuPanel.SuspendLayout();
            pnlForDataManipulation.SuspendLayout();
            pnlForLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbxLogo).BeginInit();
            SuspendLayout();
            // 
            // BaseScrollMenuPanel
            // 
            BaseScrollMenuPanel.AutoScroll = true;
            BaseScrollMenuPanel.BackColor = Color.FromArgb(64, 64, 64);
            BaseScrollMenuPanel.Controls.Add(btnLeave);
            BaseScrollMenuPanel.Controls.Add(btnSettings);
            BaseScrollMenuPanel.Controls.Add(btnReportMenu);
            BaseScrollMenuPanel.Controls.Add(pnlForDataManipulation);
            BaseScrollMenuPanel.Controls.Add(pnlForLogo);
            BaseScrollMenuPanel.Dock = DockStyle.Left;
            BaseScrollMenuPanel.Location = new Point(0, 0);
            BaseScrollMenuPanel.Name = "BaseScrollMenuPanel";
            BaseScrollMenuPanel.Size = new Size(170, 550);
            BaseScrollMenuPanel.TabIndex = 0;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.FromArgb(192, 0, 0);
            btnLeave.Dock = DockStyle.Bottom;
            btnLeave.FlatAppearance.BorderColor = Color.FromArgb(212, 20, 20);
            btnLeave.FlatStyle = FlatStyle.Flat;
            btnLeave.Font = new Font("Segoe UI", 14F);
            btnLeave.ForeColor = Color.White;
            btnLeave.Location = new Point(0, 505);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(170, 45);
            btnLeave.TabIndex = 8;
            btnLeave.Text = "Exit Application";
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Gainsboro;
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 14F);
            btnSettings.Location = new Point(0, 440);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(170, 45);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReportMenu
            // 
            btnReportMenu.BackColor = Color.Gainsboro;
            btnReportMenu.Dock = DockStyle.Top;
            btnReportMenu.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            btnReportMenu.FlatStyle = FlatStyle.Flat;
            btnReportMenu.Font = new Font("Segoe UI", 14F);
            btnReportMenu.Location = new Point(0, 395);
            btnReportMenu.Name = "btnReportMenu";
            btnReportMenu.Size = new Size(170, 45);
            btnReportMenu.TabIndex = 6;
            btnReportMenu.Text = "Report Menu";
            btnReportMenu.UseVisualStyleBackColor = false;
            btnReportMenu.Click += btnReportMenu_Click;
            // 
            // pnlForDataManipulation
            // 
            pnlForDataManipulation.BackColor = Color.FromArgb(64, 64, 64);
            pnlForDataManipulation.Controls.Add(btnUpdateMenu);
            pnlForDataManipulation.Controls.Add(btnViewMenu);
            pnlForDataManipulation.Controls.Add(btnRemoveMenu);
            pnlForDataManipulation.Controls.Add(btnAddMenu);
            pnlForDataManipulation.Controls.Add(btnDataMenu);
            pnlForDataManipulation.Dock = DockStyle.Top;
            pnlForDataManipulation.Location = new Point(0, 170);
            pnlForDataManipulation.Name = "pnlForDataManipulation";
            pnlForDataManipulation.Size = new Size(170, 225);
            pnlForDataManipulation.TabIndex = 1;
            // 
            // btnUpdateMenu
            // 
            btnUpdateMenu.BackColor = Color.Silver;
            btnUpdateMenu.Dock = DockStyle.Top;
            btnUpdateMenu.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 212);
            btnUpdateMenu.FlatStyle = FlatStyle.Flat;
            btnUpdateMenu.Font = new Font("Segoe UI", 14F);
            btnUpdateMenu.Location = new Point(0, 180);
            btnUpdateMenu.Name = "btnUpdateMenu";
            btnUpdateMenu.Size = new Size(170, 45);
            btnUpdateMenu.TabIndex = 5;
            btnUpdateMenu.Text = "Update a Record";
            btnUpdateMenu.UseVisualStyleBackColor = false;
            btnUpdateMenu.Click += btnUpdateDataMenu_Click;
            // 
            // btnViewMenu
            // 
            btnViewMenu.BackColor = Color.Silver;
            btnViewMenu.Dock = DockStyle.Top;
            btnViewMenu.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 212);
            btnViewMenu.FlatStyle = FlatStyle.Flat;
            btnViewMenu.Font = new Font("Segoe UI", 14F);
            btnViewMenu.Location = new Point(0, 135);
            btnViewMenu.Name = "btnViewMenu";
            btnViewMenu.Size = new Size(170, 45);
            btnViewMenu.TabIndex = 4;
            btnViewMenu.Text = "View Records";
            btnViewMenu.UseVisualStyleBackColor = false;
            btnViewMenu.Click += btnViewDataMenu_Click;
            // 
            // btnRemoveMenu
            // 
            btnRemoveMenu.BackColor = Color.Silver;
            btnRemoveMenu.Dock = DockStyle.Top;
            btnRemoveMenu.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 212);
            btnRemoveMenu.FlatStyle = FlatStyle.Flat;
            btnRemoveMenu.Font = new Font("Segoe UI", 14F);
            btnRemoveMenu.Location = new Point(0, 90);
            btnRemoveMenu.Name = "btnRemoveMenu";
            btnRemoveMenu.Size = new Size(170, 45);
            btnRemoveMenu.TabIndex = 3;
            btnRemoveMenu.Text = "Remove a Record";
            btnRemoveMenu.UseVisualStyleBackColor = false;
            btnRemoveMenu.Click += btnRemoveDataMenu_Click;
            // 
            // btnAddMenu
            // 
            btnAddMenu.BackColor = Color.Silver;
            btnAddMenu.Dock = DockStyle.Top;
            btnAddMenu.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 212);
            btnAddMenu.FlatStyle = FlatStyle.Flat;
            btnAddMenu.Font = new Font("Segoe UI", 14F);
            btnAddMenu.Location = new Point(0, 45);
            btnAddMenu.Name = "btnAddMenu";
            btnAddMenu.Size = new Size(170, 45);
            btnAddMenu.TabIndex = 2;
            btnAddMenu.Text = "Add a Record";
            btnAddMenu.UseVisualStyleBackColor = false;
            btnAddMenu.Click += btnAddDataMenu_Click;
            // 
            // btnDataMenu
            // 
            btnDataMenu.BackColor = Color.Gainsboro;
            btnDataMenu.Dock = DockStyle.Top;
            btnDataMenu.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            btnDataMenu.FlatStyle = FlatStyle.Flat;
            btnDataMenu.Font = new Font("Segoe UI", 14F);
            btnDataMenu.Location = new Point(0, 0);
            btnDataMenu.Name = "btnDataMenu";
            btnDataMenu.Size = new Size(170, 45);
            btnDataMenu.TabIndex = 1;
            btnDataMenu.Text = "Data Menu";
            btnDataMenu.UseVisualStyleBackColor = false;
            btnDataMenu.Click += btnManipulateData_Click;
            // 
            // pnlForLogo
            // 
            pnlForLogo.BackColor = Color.White;
            pnlForLogo.Controls.Add(pctbxLogo);
            pnlForLogo.Dock = DockStyle.Top;
            pnlForLogo.Location = new Point(0, 0);
            pnlForLogo.Name = "pnlForLogo";
            pnlForLogo.Size = new Size(170, 170);
            pnlForLogo.TabIndex = 0;
            // 
            // pctbxLogo
            // 
            pctbxLogo.BackgroundImageLayout = ImageLayout.None;
            pctbxLogo.Image = (Image)resources.GetObject("pctbxLogo.Image");
            pctbxLogo.Location = new Point(0, 0);
            pctbxLogo.Name = "pctbxLogo";
            pctbxLogo.Size = new Size(170, 170);
            pctbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbxLogo.TabIndex = 0;
            pctbxLogo.TabStop = false;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(74, 74, 74);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(170, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(710, 550);
            pnlContainer.TabIndex = 0;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(880, 550);
            ControlBox = false;
            Controls.Add(pnlContainer);
            Controls.Add(BaseScrollMenuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            BaseScrollMenuPanel.ResumeLayout(false);
            pnlForDataManipulation.ResumeLayout(false);
            pnlForLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BaseScrollMenuPanel;
        private Panel pnlForLogo;
        private Panel pnlForDataManipulation;
        private Button btnDataMenu;
        private Button btnUpdateMenu;
        private Button btnViewMenu;
        private Button btnRemoveMenu;
        private Button btnAddMenu;
        private Button btnLeave;
        private Button btnReportMenu;
        private Panel pnlContainer;
        private Button btnSettings;
        private PictureBox pctbxLogo;
    }
}