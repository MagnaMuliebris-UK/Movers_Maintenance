namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    partial class UpdateSession
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
            lblSID = new Label();
            updnSID = new NumericUpDown();
            btnHELP = new Button();
            btnWipe = new Button();
            txtbxSType = new TextBox();
            lblSType = new Label();
            lblSDate = new Label();
            txtbxSDate = new TextBox();
            btnUpdRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)updnSID).BeginInit();
            SuspendLayout();
            // 
            // lblSID
            // 
            lblSID.BackColor = Color.FromArgb(84, 84, 84);
            lblSID.Font = new Font("Segoe UI", 16F);
            lblSID.ForeColor = Color.White;
            lblSID.Location = new Point(104, 115);
            lblSID.Name = "lblSID";
            lblSID.Size = new Size(150, 36);
            lblSID.TabIndex = 73;
            lblSID.Text = "Session ID:";
            lblSID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnSID
            // 
            updnSID.Font = new Font("Segoe UI", 16F);
            updnSID.Location = new Point(259, 115);
            updnSID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnSID.Name = "updnSID";
            updnSID.Size = new Size(240, 36);
            updnSID.TabIndex = 74;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(475, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 72;
            btnHELP.Text = "Help";
            btnHELP.UseVisualStyleBackColor = true;
            btnHELP.Click += btnHELP_Click;
            // 
            // btnWipe
            // 
            btnWipe.Font = new Font("Segoe UI", 16F);
            btnWipe.Location = new Point(345, 465);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(200, 70);
            btnWipe.TabIndex = 71;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // txtbxSType
            // 
            txtbxSType.Font = new Font("Segoe UI", 16F);
            txtbxSType.Location = new Point(259, 225);
            txtbxSType.Name = "txtbxSType";
            txtbxSType.Size = new Size(240, 36);
            txtbxSType.TabIndex = 68;
            // 
            // lblSType
            // 
            lblSType.BackColor = Color.FromArgb(84, 84, 84);
            lblSType.Font = new Font("Segoe UI", 16F);
            lblSType.ForeColor = Color.White;
            lblSType.Location = new Point(104, 225);
            lblSType.Name = "lblSType";
            lblSType.Size = new Size(150, 36);
            lblSType.TabIndex = 67;
            lblSType.Text = "Session type:";
            lblSType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSDate
            // 
            lblSDate.BackColor = Color.FromArgb(84, 84, 84);
            lblSDate.Font = new Font("Segoe UI", 16F);
            lblSDate.ForeColor = Color.White;
            lblSDate.Location = new Point(104, 335);
            lblSDate.Name = "lblSDate";
            lblSDate.Size = new Size(150, 36);
            lblSDate.TabIndex = 69;
            lblSDate.Text = "Session date:";
            lblSDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxSDate
            // 
            txtbxSDate.Font = new Font("Segoe UI", 16F);
            txtbxSDate.Location = new Point(259, 335);
            txtbxSDate.Name = "txtbxSDate";
            txtbxSDate.Size = new Size(240, 36);
            txtbxSDate.TabIndex = 70;
            // 
            // btnUpdRecord
            // 
            btnUpdRecord.Font = new Font("Segoe UI", 16F);
            btnUpdRecord.Location = new Point(15, 465);
            btnUpdRecord.Name = "btnUpdRecord";
            btnUpdRecord.Size = new Size(200, 70);
            btnUpdRecord.TabIndex = 66;
            btnUpdRecord.Text = "Update Session";
            btnUpdRecord.UseVisualStyleBackColor = true;
            btnUpdRecord.Click += btnUpdRecord_Click;
            // 
            // UpdateSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(lblSID);
            Controls.Add(updnSID);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(txtbxSType);
            Controls.Add(lblSType);
            Controls.Add(lblSDate);
            Controls.Add(txtbxSDate);
            Controls.Add(btnUpdRecord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateSession";
            Text = "UpdateSession";
            ((System.ComponentModel.ISupportInitialize)updnSID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSID;
        private NumericUpDown updnSID;
        private Button btnHELP;
        private Button btnWipe;
        private TextBox txtbxSType;
        private Label lblSType;
        private Label lblSDate;
        private TextBox txtbxSDate;
        private Button btnUpdRecord;
    }
}