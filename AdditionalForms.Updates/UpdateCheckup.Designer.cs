namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    partial class UpdateCheckup
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
            ckbxIsC_MOT = new CheckBox();
            updnMID = new NumericUpDown();
            updnVID = new NumericUpDown();
            lblCID = new Label();
            updnCID = new NumericUpDown();
            btnHELP = new Button();
            btnWipe = new Button();
            txtbxVCondition = new TextBox();
            lblVID = new Label();
            lblMID = new Label();
            txtbxCDate = new TextBox();
            lblVCondition = new Label();
            lblCDate = new Label();
            btnUpdRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)updnMID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnVID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnCID).BeginInit();
            SuspendLayout();
            // 
            // ckbxIsC_MOT
            // 
            ckbxIsC_MOT.CheckAlign = ContentAlignment.BottomCenter;
            ckbxIsC_MOT.Font = new Font("Segoe UI", 16F);
            ckbxIsC_MOT.ForeColor = Color.White;
            ckbxIsC_MOT.Location = new Point(0, 385);
            ckbxIsC_MOT.Name = "ckbxIsC_MOT";
            ckbxIsC_MOT.Size = new Size(570, 45);
            ckbxIsC_MOT.TabIndex = 96;
            ckbxIsC_MOT.Text = "Is this checkup to check if the van is MOT certified?";
            ckbxIsC_MOT.TextAlign = ContentAlignment.MiddleCenter;
            ckbxIsC_MOT.UseVisualStyleBackColor = true;
            // 
            // updnMID
            // 
            updnMID.Font = new Font("Segoe UI", 16F);
            updnMID.Location = new Point(264, 145);
            updnMID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnMID.Name = "updnMID";
            updnMID.Size = new Size(240, 36);
            updnMID.TabIndex = 95;
            // 
            // updnVID
            // 
            updnVID.Font = new Font("Segoe UI", 16F);
            updnVID.Location = new Point(264, 205);
            updnVID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnVID.Name = "updnVID";
            updnVID.Size = new Size(240, 36);
            updnVID.TabIndex = 94;
            // 
            // lblCID
            // 
            lblCID.BackColor = Color.FromArgb(84, 84, 84);
            lblCID.Font = new Font("Segoe UI", 16F);
            lblCID.ForeColor = Color.White;
            lblCID.Location = new Point(128, 85);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(131, 36);
            lblCID.TabIndex = 92;
            lblCID.Text = "Checkup ID:";
            lblCID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnCID
            // 
            updnCID.Font = new Font("Segoe UI", 16F);
            updnCID.Location = new Point(264, 85);
            updnCID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnCID.Name = "updnCID";
            updnCID.Size = new Size(240, 36);
            updnCID.TabIndex = 93;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(480, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 91;
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
            btnWipe.TabIndex = 90;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // txtbxVCondition
            // 
            txtbxVCondition.Font = new Font("Segoe UI", 16F);
            txtbxVCondition.Location = new Point(264, 265);
            txtbxVCondition.Name = "txtbxVCondition";
            txtbxVCondition.Size = new Size(240, 36);
            txtbxVCondition.TabIndex = 85;
            // 
            // lblVID
            // 
            lblVID.BackColor = Color.FromArgb(84, 84, 84);
            lblVID.Font = new Font("Segoe UI", 16F);
            lblVID.ForeColor = Color.White;
            lblVID.Location = new Point(170, 205);
            lblVID.Name = "lblVID";
            lblVID.Size = new Size(89, 36);
            lblVID.TabIndex = 86;
            lblVID.Text = "Van ID:";
            lblVID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMID
            // 
            lblMID.BackColor = Color.FromArgb(84, 84, 84);
            lblMID.Font = new Font("Segoe UI", 16F);
            lblMID.ForeColor = Color.White;
            lblMID.Location = new Point(109, 145);
            lblMID.Name = "lblMID";
            lblMID.Size = new Size(150, 36);
            lblMID.TabIndex = 84;
            lblMID.Text = "Mechanic ID:";
            lblMID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxCDate
            // 
            txtbxCDate.Font = new Font("Segoe UI", 16F);
            txtbxCDate.Location = new Point(264, 325);
            txtbxCDate.Name = "txtbxCDate";
            txtbxCDate.Size = new Size(240, 36);
            txtbxCDate.TabIndex = 87;
            // 
            // lblVCondition
            // 
            lblVCondition.BackColor = Color.FromArgb(84, 84, 84);
            lblVCondition.Font = new Font("Segoe UI", 16F);
            lblVCondition.ForeColor = Color.White;
            lblVCondition.Location = new Point(0, 265);
            lblVCondition.Name = "lblVCondition";
            lblVCondition.Size = new Size(259, 36);
            lblVCondition.TabIndex = 88;
            lblVCondition.Text = "Van condition:";
            lblVCondition.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCDate
            // 
            lblCDate.BackColor = Color.FromArgb(84, 84, 84);
            lblCDate.Font = new Font("Segoe UI", 16F);
            lblCDate.ForeColor = Color.White;
            lblCDate.Location = new Point(79, 325);
            lblCDate.Name = "lblCDate";
            lblCDate.Size = new Size(180, 36);
            lblCDate.TabIndex = 89;
            lblCDate.Text = "Date of checkup:";
            lblCDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUpdRecord
            // 
            btnUpdRecord.Font = new Font("Segoe UI", 16F);
            btnUpdRecord.Location = new Point(20, 465);
            btnUpdRecord.Name = "btnUpdRecord";
            btnUpdRecord.Size = new Size(200, 70);
            btnUpdRecord.TabIndex = 83;
            btnUpdRecord.Text = "Update Checkup";
            btnUpdRecord.UseVisualStyleBackColor = true;
            btnUpdRecord.Click += btnUpdRecord_Click;
            // 
            // UpdateCheckup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(ckbxIsC_MOT);
            Controls.Add(updnMID);
            Controls.Add(updnVID);
            Controls.Add(lblCID);
            Controls.Add(updnCID);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(txtbxVCondition);
            Controls.Add(lblVID);
            Controls.Add(lblMID);
            Controls.Add(txtbxCDate);
            Controls.Add(lblVCondition);
            Controls.Add(lblCDate);
            Controls.Add(btnUpdRecord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCheckup";
            Text = "UpdateCheckup";
            ((System.ComponentModel.ISupportInitialize)updnMID).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnVID).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnCID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckbxIsC_MOT;
        private NumericUpDown updnMID;
        private NumericUpDown updnVID;
        private Label lblCID;
        private NumericUpDown updnCID;
        private Button btnHELP;
        private Button btnWipe;
        private TextBox txtbxVCondition;
        private Label lblVID;
        private Label lblMID;
        private TextBox txtbxCDate;
        private Label lblVCondition;
        private Label lblCDate;
        private Button btnUpdRecord;
    }
}