namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    partial class UpdateStaff
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
            UpDnHWPW = new NumericUpDown();
            updnHSalary = new NumericUpDown();
            lblSID = new Label();
            updnSID = new NumericUpDown();
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
            btnUpdRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)UpDnHWPW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnHSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnSID).BeginInit();
            SuspendLayout();
            // 
            // UpDnHWPW
            // 
            UpDnHWPW.Font = new Font("Segoe UI", 16F);
            UpDnHWPW.Location = new Point(264, 230);
            UpDnHWPW.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            UpDnHWPW.Name = "UpDnHWPW";
            UpDnHWPW.Size = new Size(240, 36);
            UpDnHWPW.TabIndex = 83;
            // 
            // updnHSalary
            // 
            updnHSalary.DecimalPlaces = 2;
            updnHSalary.Font = new Font("Segoe UI", 16F);
            updnHSalary.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            updnHSalary.Location = new Point(264, 285);
            updnHSalary.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnHSalary.Minimum = new decimal(new int[] { 860, 0, 0, 131072 });
            updnHSalary.Name = "updnHSalary";
            updnHSalary.Size = new Size(240, 36);
            updnHSalary.TabIndex = 82;
            updnHSalary.Value = new decimal(new int[] { 860, 0, 0, 131072 });
            // 
            // lblSID
            // 
            lblSID.BackColor = Color.FromArgb(84, 84, 84);
            lblSID.Font = new Font("Segoe UI", 16F);
            lblSID.ForeColor = Color.White;
            lblSID.Location = new Point(171, 66);
            lblSID.Name = "lblSID";
            lblSID.Size = new Size(88, 36);
            lblSID.TabIndex = 80;
            lblSID.Text = "Staff ID:";
            lblSID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnSID
            // 
            updnSID.Font = new Font("Segoe UI", 16F);
            updnSID.Location = new Point(264, 66);
            updnSID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnSID.Name = "updnSID";
            updnSID.Size = new Size(240, 36);
            updnSID.TabIndex = 81;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(480, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 79;
            btnHELP.Text = "Help";
            btnHELP.UseVisualStyleBackColor = true;
            btnHELP.Click += btnHELP_Click;
            // 
            // btnWipe
            // 
            btnWipe.Font = new Font("Segoe UI", 16F);
            btnWipe.Location = new Point(350, 465);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(200, 70);
            btnWipe.TabIndex = 77;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // cbbxPosition
            // 
            cbbxPosition.FlatStyle = FlatStyle.Flat;
            cbbxPosition.Font = new Font("Segoe UI", 16F);
            cbbxPosition.FormattingEnabled = true;
            cbbxPosition.Items.AddRange(new object[] { "Driver", "Mechanic", "Maintenance Manager", "CEO" });
            cbbxPosition.Location = new Point(264, 340);
            cbbxPosition.Name = "cbbxPosition";
            cbbxPosition.Size = new Size(240, 38);
            cbbxPosition.TabIndex = 78;
            // 
            // ckbxTrainer
            // 
            ckbxTrainer.CheckAlign = ContentAlignment.BottomCenter;
            ckbxTrainer.Font = new Font("Segoe UI", 16F);
            ckbxTrainer.ForeColor = Color.White;
            ckbxTrainer.Location = new Point(0, 395);
            ckbxTrainer.Name = "ckbxTrainer";
            ckbxTrainer.Size = new Size(570, 45);
            ckbxTrainer.TabIndex = 69;
            ckbxTrainer.Text = "Is this person able to train other staff?";
            ckbxTrainer.TextAlign = ContentAlignment.MiddleCenter;
            ckbxTrainer.UseVisualStyleBackColor = true;
            // 
            // txtbxForename
            // 
            txtbxForename.Font = new Font("Segoe UI", 16F);
            txtbxForename.Location = new Point(264, 120);
            txtbxForename.Name = "txtbxForename";
            txtbxForename.Size = new Size(240, 36);
            txtbxForename.TabIndex = 71;
            // 
            // lblSurname
            // 
            lblSurname.BackColor = Color.FromArgb(84, 84, 84);
            lblSurname.Font = new Font("Segoe UI", 16F);
            lblSurname.ForeColor = Color.White;
            lblSurname.Location = new Point(139, 175);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(120, 36);
            lblSurname.TabIndex = 72;
            lblSurname.Text = "Surname:";
            lblSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblForename
            // 
            lblForename.BackColor = Color.FromArgb(84, 84, 84);
            lblForename.Font = new Font("Segoe UI", 16F);
            lblForename.ForeColor = Color.White;
            lblForename.Location = new Point(139, 120);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(120, 36);
            lblForename.TabIndex = 70;
            lblForename.Text = "Forename:";
            lblForename.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxSurname
            // 
            txtbxSurname.Font = new Font("Segoe UI", 16F);
            txtbxSurname.Location = new Point(264, 175);
            txtbxSurname.Name = "txtbxSurname";
            txtbxSurname.Size = new Size(240, 36);
            txtbxSurname.TabIndex = 73;
            // 
            // lblPosition
            // 
            lblPosition.BackColor = Color.FromArgb(84, 84, 84);
            lblPosition.Font = new Font("Segoe UI", 16F);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(139, 340);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(120, 38);
            lblPosition.TabIndex = 74;
            lblPosition.Text = "Position:";
            lblPosition.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHWPW
            // 
            lblHWPW.BackColor = Color.FromArgb(84, 84, 84);
            lblHWPW.Font = new Font("Segoe UI", 16F);
            lblHWPW.ForeColor = Color.White;
            lblHWPW.Location = new Point(0, 230);
            lblHWPW.Name = "lblHWPW";
            lblHWPW.Size = new Size(259, 36);
            lblHWPW.TabIndex = 75;
            lblHWPW.Text = "Hours worked per week:";
            lblHWPW.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHSalary
            // 
            lblHSalary.BackColor = Color.FromArgb(84, 84, 84);
            lblHSalary.Font = new Font("Segoe UI", 16F);
            lblHSalary.ForeColor = Color.White;
            lblHSalary.Location = new Point(109, 285);
            lblHSalary.Name = "lblHSalary";
            lblHSalary.Size = new Size(150, 36);
            lblHSalary.TabIndex = 76;
            lblHSalary.Text = "Hourly salary:";
            lblHSalary.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUpdRecord
            // 
            btnUpdRecord.Font = new Font("Segoe UI", 16F);
            btnUpdRecord.Location = new Point(20, 465);
            btnUpdRecord.Name = "btnUpdRecord";
            btnUpdRecord.Size = new Size(200, 70);
            btnUpdRecord.TabIndex = 68;
            btnUpdRecord.Text = "Update Staff";
            btnUpdRecord.UseVisualStyleBackColor = true;
            btnUpdRecord.Click += this.btnUpdRecord_Click;
            // 
            // UpdateStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(UpDnHWPW);
            Controls.Add(updnHSalary);
            Controls.Add(lblSID);
            Controls.Add(updnSID);
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
            Controls.Add(btnUpdRecord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStaff";
            Text = "UpdateStaff";
            ((System.ComponentModel.ISupportInitialize)UpDnHWPW).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnHSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnSID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown UpDnHWPW;
        private NumericUpDown updnHSalary;
        private Label lblSID;
        private NumericUpDown updnSID;
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
        private Button btnUpdRecord;
    }
}