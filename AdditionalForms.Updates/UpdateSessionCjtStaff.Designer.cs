namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    partial class UpdateSessionCjtStaff
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
            updnSeID = new NumericUpDown();
            updnTID = new NumericUpDown();
            lblStID = new Label();
            updnStID = new NumericUpDown();
            btnHELP = new Button();
            btnWipe = new Button();
            lblTID = new Label();
            lblSeID = new Label();
            btnUpdRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)updnSeID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnTID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnStID).BeginInit();
            SuspendLayout();
            // 
            // updnSeID
            // 
            updnSeID.Font = new Font("Segoe UI", 16F);
            updnSeID.Location = new Point(238, 220);
            updnSeID.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            updnSeID.Name = "updnSeID";
            updnSeID.Size = new Size(240, 36);
            updnSeID.TabIndex = 85;
            // 
            // updnTID
            // 
            updnTID.Font = new Font("Segoe UI", 16F);
            updnTID.Location = new Point(238, 325);
            updnTID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnTID.Name = "updnTID";
            updnTID.Size = new Size(240, 36);
            updnTID.TabIndex = 84;
            // 
            // lblStID
            // 
            lblStID.BackColor = Color.FromArgb(84, 84, 84);
            lblStID.Font = new Font("Segoe UI", 16F);
            lblStID.ForeColor = Color.White;
            lblStID.Location = new Point(145, 115);
            lblStID.Name = "lblStID";
            lblStID.Size = new Size(88, 36);
            lblStID.TabIndex = 82;
            lblStID.Text = "Staff ID:";
            lblStID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnStID
            // 
            updnStID.Font = new Font("Segoe UI", 16F);
            updnStID.Location = new Point(238, 115);
            updnStID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnStID.Name = "updnStID";
            updnStID.Size = new Size(240, 36);
            updnStID.TabIndex = 83;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(475, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 81;
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
            btnWipe.TabIndex = 80;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // lblTID
            // 
            lblTID.BackColor = Color.FromArgb(84, 84, 84);
            lblTID.Font = new Font("Segoe UI", 16F);
            lblTID.ForeColor = Color.White;
            lblTID.Location = new Point(113, 325);
            lblTID.Name = "lblTID";
            lblTID.Size = new Size(120, 36);
            lblTID.TabIndex = 79;
            lblTID.Text = "Trainer ID:";
            lblTID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSeID
            // 
            lblSeID.BackColor = Color.FromArgb(84, 84, 84);
            lblSeID.Font = new Font("Segoe UI", 16F);
            lblSeID.ForeColor = Color.White;
            lblSeID.Location = new Point(113, 220);
            lblSeID.Name = "lblSeID";
            lblSeID.Size = new Size(120, 36);
            lblSeID.TabIndex = 78;
            lblSeID.Text = "Session ID:";
            lblSeID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUpdRecord
            // 
            btnUpdRecord.Font = new Font("Segoe UI", 16F);
            btnUpdRecord.Location = new Point(15, 465);
            btnUpdRecord.Name = "btnUpdRecord";
            btnUpdRecord.Size = new Size(200, 70);
            btnUpdRecord.TabIndex = 77;
            btnUpdRecord.Text = "Update Staff in Session";
            btnUpdRecord.UseVisualStyleBackColor = true;
            btnUpdRecord.Click += btnUpdRecord_Click;
            // 
            // UpdateSessionCjtStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(updnSeID);
            Controls.Add(updnTID);
            Controls.Add(lblStID);
            Controls.Add(updnStID);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(lblTID);
            Controls.Add(lblSeID);
            Controls.Add(btnUpdRecord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateSessionCjtStaff";
            Text = "UpdateSessionCjtStaff";
            ((System.ComponentModel.ISupportInitialize)updnSeID).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnTID).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnStID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown updnSeID;
        private NumericUpDown updnTID;
        private Label lblStID;
        private NumericUpDown updnStID;
        private Button btnHELP;
        private Button btnWipe;
        private Label lblTID;
        private Label lblSeID;
        private Button btnUpdRecord;
    }
}