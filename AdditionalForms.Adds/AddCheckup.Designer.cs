namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    partial class AddCheckup
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
            ckbxMOTCertified = new CheckBox();
            txtbxMechanicID = new TextBox();
            lblVanID = new Label();
            lblMechanicID = new Label();
            txtbxVanID = new TextBox();
            lblVanCondition = new Label();
            lblCDate = new Label();
            btnAddRecord = new Button();
            txtbxCDate = new TextBox();
            txtbxVanCondition = new TextBox();
            SuspendLayout();
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(480, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 74;
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
            btnWipe.TabIndex = 73;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // ckbxMOTCertified
            // 
            ckbxMOTCertified.CheckAlign = ContentAlignment.BottomCenter;
            ckbxMOTCertified.Font = new Font("Segoe UI", 16F);
            ckbxMOTCertified.ForeColor = Color.White;
            ckbxMOTCertified.Location = new Point(0, 385);
            ckbxMOTCertified.Name = "ckbxMOTCertified";
            ckbxMOTCertified.Size = new Size(570, 45);
            ckbxMOTCertified.TabIndex = 64;
            ckbxMOTCertified.Text = "Is this checkup to check if the van is MOT certified?";
            ckbxMOTCertified.TextAlign = ContentAlignment.MiddleCenter;
            ckbxMOTCertified.UseVisualStyleBackColor = true;
            // 
            // txtbxMechanicID
            // 
            txtbxMechanicID.Font = new Font("Segoe UI", 16F);
            txtbxMechanicID.Location = new Point(260, 75);
            txtbxMechanicID.Name = "txtbxMechanicID";
            txtbxMechanicID.Size = new Size(240, 36);
            txtbxMechanicID.TabIndex = 66;
            // 
            // lblVanID
            // 
            lblVanID.BackColor = Color.FromArgb(84, 84, 84);
            lblVanID.Font = new Font("Segoe UI", 16F);
            lblVanID.ForeColor = Color.White;
            lblVanID.Location = new Point(175, 155);
            lblVanID.Name = "lblVanID";
            lblVanID.Size = new Size(80, 36);
            lblVanID.TabIndex = 67;
            lblVanID.Text = "Van ID:";
            lblVanID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMechanicID
            // 
            lblMechanicID.BackColor = Color.FromArgb(84, 84, 84);
            lblMechanicID.Font = new Font("Segoe UI", 16F);
            lblMechanicID.ForeColor = Color.White;
            lblMechanicID.Location = new Point(115, 75);
            lblMechanicID.Name = "lblMechanicID";
            lblMechanicID.Size = new Size(140, 36);
            lblMechanicID.TabIndex = 65;
            lblMechanicID.Text = "Mechanic ID:";
            lblMechanicID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxVanID
            // 
            txtbxVanID.Font = new Font("Segoe UI", 16F);
            txtbxVanID.Location = new Point(260, 155);
            txtbxVanID.Name = "txtbxVanID";
            txtbxVanID.Size = new Size(240, 36);
            txtbxVanID.TabIndex = 68;
            // 
            // lblVanCondition
            // 
            lblVanCondition.BackColor = Color.FromArgb(84, 84, 84);
            lblVanCondition.Font = new Font("Segoe UI", 16F);
            lblVanCondition.ForeColor = Color.White;
            lblVanCondition.Location = new Point(90, 235);
            lblVanCondition.Name = "lblVanCondition";
            lblVanCondition.Size = new Size(165, 36);
            lblVanCondition.TabIndex = 69;
            lblVanCondition.Text = "Van condition:";
            lblVanCondition.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCDate
            // 
            lblCDate.BackColor = Color.FromArgb(84, 84, 84);
            lblCDate.Font = new Font("Segoe UI", 16F);
            lblCDate.ForeColor = Color.White;
            lblCDate.Location = new Point(74, 315);
            lblCDate.Name = "lblCDate";
            lblCDate.Size = new Size(180, 36);
            lblCDate.TabIndex = 71;
            lblCDate.Text = "Date of Checkup:";
            lblCDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Font = new Font("Segoe UI", 16F);
            btnAddRecord.Location = new Point(20, 465);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(200, 70);
            btnAddRecord.TabIndex = 63;
            btnAddRecord.Text = "Add Checkup";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // txtbxCDate
            // 
            txtbxCDate.Font = new Font("Segoe UI", 16F);
            txtbxCDate.Location = new Point(260, 315);
            txtbxCDate.Name = "txtbxCDate";
            txtbxCDate.PlaceholderText = "dd-mm-yyyy";
            txtbxCDate.Size = new Size(240, 36);
            txtbxCDate.TabIndex = 72;
            // 
            // txtbxVanCondition
            // 
            txtbxVanCondition.Font = new Font("Segoe UI", 16F);
            txtbxVanCondition.Location = new Point(260, 235);
            txtbxVanCondition.Name = "txtbxVanCondition";
            txtbxVanCondition.Size = new Size(240, 36);
            txtbxVanCondition.TabIndex = 70;
            // 
            // AddCheckup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(ckbxMOTCertified);
            Controls.Add(txtbxMechanicID);
            Controls.Add(lblVanID);
            Controls.Add(lblMechanicID);
            Controls.Add(txtbxVanID);
            Controls.Add(lblVanCondition);
            Controls.Add(lblCDate);
            Controls.Add(btnAddRecord);
            Controls.Add(txtbxCDate);
            Controls.Add(txtbxVanCondition);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCheckup";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHELP;
        private Button btnWipe;
        private CheckBox ckbxMOTCertified;
        private TextBox txtbxMechanicID;
        private Label lblVanID;
        private Label lblMechanicID;
        private TextBox txtbxVanID;
        private Label lblVanCondition;
        private Label lblCDate;
        private Button btnAddRecord;
        private TextBox txtbxCDate;
        private TextBox txtbxVanCondition;
    }
}