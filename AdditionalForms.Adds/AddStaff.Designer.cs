namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    partial class AddStaff
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
            btnHELP = new Button();
            btnWipe = new Button();
            cbbxPosition = new ComboBox();
            ckbxTrainer = new CheckBox();
            txtbxForename = new TextBox();
            lblSurname = new Label();
            lblForename = new Label();
            txtbxSurname = new TextBox();
            lblPosition = new Label();
            lblHWPW = new Label();
            lblHSalary = new Label();
            btnAddRecord = new Button();
            txtbxHSalary = new TextBox();
            txtbxHWPW = new TextBox();
            SuspendLayout();
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(480, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 76;
            btnHELP.Text = "Help";
            btnHELP.UseVisualStyleBackColor = true;
            btnHELP.Click += btnHelp_Click;
            // 
            // btnWipe
            // 
            btnWipe.BackColor = Color.White;
            btnWipe.Font = new Font("Segoe UI", 16F);
            btnWipe.Location = new Point(350, 465);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(200, 70);
            btnWipe.TabIndex = 74;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = false;
            btnWipe.Click += btnWipe_Click;
            // 
            // cbbxPosition
            // 
            cbbxPosition.FlatStyle = FlatStyle.Flat;
            cbbxPosition.Font = new Font("Segoe UI", 16F);
            cbbxPosition.FormattingEnabled = true;
            cbbxPosition.Items.AddRange(new object[] { "Driver", "Mechanic", "Maintenance Manager", "CEO" });
            cbbxPosition.Location = new Point(264, 320);
            cbbxPosition.Name = "cbbxPosition";
            cbbxPosition.Size = new Size(240, 38);
            cbbxPosition.TabIndex = 75;
            // 
            // ckbxTrainer
            // 
            ckbxTrainer.CheckAlign = ContentAlignment.BottomCenter;
            ckbxTrainer.Font = new Font("Segoe UI", 16F);
            ckbxTrainer.ForeColor = Color.White;
            ckbxTrainer.Location = new Point(0, 380);
            ckbxTrainer.Name = "ckbxTrainer";
            ckbxTrainer.Size = new Size(570, 45);
            ckbxTrainer.TabIndex = 64;
            ckbxTrainer.Text = "Is this person able to train other staff?";
            ckbxTrainer.TextAlign = ContentAlignment.MiddleCenter;
            ckbxTrainer.UseVisualStyleBackColor = true;
            // 
            // txtbxForename
            // 
            txtbxForename.Font = new Font("Segoe UI", 16F);
            txtbxForename.Location = new Point(264, 80);
            txtbxForename.Name = "txtbxForename";
            txtbxForename.Size = new Size(240, 36);
            txtbxForename.TabIndex = 66;
            // 
            // lblSurname
            // 
            lblSurname.BackColor = Color.FromArgb(84, 84, 84);
            lblSurname.Font = new Font("Segoe UI", 16F);
            lblSurname.ForeColor = Color.White;
            lblSurname.Location = new Point(139, 140);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(120, 36);
            lblSurname.TabIndex = 67;
            lblSurname.Text = "Surname:";
            lblSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblForename
            // 
            lblForename.BackColor = Color.FromArgb(84, 84, 84);
            lblForename.Font = new Font("Segoe UI", 16F);
            lblForename.ForeColor = Color.White;
            lblForename.Location = new Point(139, 80);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(120, 36);
            lblForename.TabIndex = 65;
            lblForename.Text = "Forename:";
            lblForename.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxSurname
            // 
            txtbxSurname.Font = new Font("Segoe UI", 16F);
            txtbxSurname.Location = new Point(264, 140);
            txtbxSurname.Name = "txtbxSurname";
            txtbxSurname.Size = new Size(240, 36);
            txtbxSurname.TabIndex = 68;
            // 
            // lblPosition
            // 
            lblPosition.BackColor = Color.FromArgb(84, 84, 84);
            lblPosition.Font = new Font("Segoe UI", 16F);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(139, 320);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(120, 38);
            lblPosition.TabIndex = 69;
            lblPosition.Text = "Position:";
            lblPosition.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHWPW
            // 
            lblHWPW.BackColor = Color.FromArgb(84, 84, 84);
            lblHWPW.Font = new Font("Segoe UI", 16F);
            lblHWPW.ForeColor = Color.White;
            lblHWPW.Location = new Point(0, 200);
            lblHWPW.Name = "lblHWPW";
            lblHWPW.Size = new Size(259, 36);
            lblHWPW.TabIndex = 71;
            lblHWPW.Text = "Hours worked per week:";
            lblHWPW.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHSalary
            // 
            lblHSalary.BackColor = Color.FromArgb(84, 84, 84);
            lblHSalary.Font = new Font("Segoe UI", 16F);
            lblHSalary.ForeColor = Color.White;
            lblHSalary.Location = new Point(109, 260);
            lblHSalary.Name = "lblHSalary";
            lblHSalary.Size = new Size(150, 36);
            lblHSalary.TabIndex = 73;
            lblHSalary.Text = "Hourly salary:";
            lblHSalary.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddRecord
            // 
            btnAddRecord.BackColor = Color.White;
            btnAddRecord.Font = new Font("Segoe UI", 16F);
            btnAddRecord.Location = new Point(20, 465);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(200, 70);
            btnAddRecord.TabIndex = 63;
            btnAddRecord.Text = "Add Staff";
            btnAddRecord.UseVisualStyleBackColor = false;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // txtbxHSalary
            // 
            txtbxHSalary.Font = new Font("Segoe UI", 16F);
            txtbxHSalary.Location = new Point(264, 260);
            txtbxHSalary.Name = "txtbxHSalary";
            txtbxHSalary.Size = new Size(240, 36);
            txtbxHSalary.TabIndex = 72;
            // 
            // txtbxHWPW
            // 
            txtbxHWPW.Font = new Font("Segoe UI", 16F);
            txtbxHWPW.Location = new Point(264, 200);
            txtbxHWPW.Name = "txtbxHWPW";
            txtbxHWPW.Size = new Size(240, 36);
            txtbxHWPW.TabIndex = 70;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(cbbxPosition);
            Controls.Add(ckbxTrainer);
            Controls.Add(txtbxForename);
            Controls.Add(lblSurname);
            Controls.Add(lblForename);
            Controls.Add(txtbxSurname);
            Controls.Add(lblPosition);
            Controls.Add(lblHWPW);
            Controls.Add(lblHSalary);
            Controls.Add(btnAddRecord);
            Controls.Add(txtbxHSalary);
            Controls.Add(txtbxHWPW);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStaff";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHELP;
        private Button btnWipe;
        private ComboBox cbbxPosition;
        private CheckBox ckbxTrainer;
        private TextBox txtbxForename;
        private Label lblSurname;
        private Label lblForename;
        private TextBox txtbxSurname;
        private Label lblPosition;
        private Label lblHWPW;
        private Label lblHSalary;
        private Button btnAddRecord;
        private TextBox txtbxHSalary;
        private TextBox txtbxHWPW;
    }
}