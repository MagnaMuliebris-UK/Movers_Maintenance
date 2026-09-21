namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    partial class UpdateCheckupCjtItem
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
            lblIID = new Label();
            lblCID = new Label();
            lblNumUsed = new Label();
            updnIID = new NumericUpDown();
            updnNumUsed = new NumericUpDown();
            updnCID = new NumericUpDown();
            btnHELP = new Button();
            btnWipe = new Button();
            btnUpdRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)updnIID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnNumUsed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnCID).BeginInit();
            SuspendLayout();
            // 
            // lblIID
            // 
            lblIID.BackColor = Color.FromArgb(84, 84, 84);
            lblIID.Font = new Font("Segoe UI", 16F);
            lblIID.ForeColor = Color.White;
            lblIID.Location = new Point(114, 120);
            lblIID.Name = "lblIID";
            lblIID.Size = new Size(120, 36);
            lblIID.TabIndex = 80;
            lblIID.Text = "Item ID:";
            lblIID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCID
            // 
            lblCID.BackColor = Color.FromArgb(84, 84, 84);
            lblCID.Font = new Font("Segoe UI", 16F);
            lblCID.ForeColor = Color.White;
            lblCID.Location = new Point(103, 225);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(132, 36);
            lblCID.TabIndex = 79;
            lblCID.Text = "Checkup ID:";
            lblCID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumUsed
            // 
            lblNumUsed.BackColor = Color.FromArgb(84, 84, 84);
            lblNumUsed.Font = new Font("Segoe UI", 16F);
            lblNumUsed.ForeColor = Color.White;
            lblNumUsed.Location = new Point(80, 330);
            lblNumUsed.Name = "lblNumUsed";
            lblNumUsed.Size = new Size(155, 36);
            lblNumUsed.TabIndex = 81;
            lblNumUsed.Text = "Quantity used:";
            lblNumUsed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnIID
            // 
            updnIID.Font = new Font("Segoe UI", 16F);
            updnIID.Location = new Point(240, 120);
            updnIID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnIID.Name = "updnIID";
            updnIID.Size = new Size(240, 36);
            updnIID.TabIndex = 78;
            // 
            // updnNumUsed
            // 
            updnNumUsed.Font = new Font("Segoe UI", 16F);
            updnNumUsed.Location = new Point(240, 330);
            updnNumUsed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnNumUsed.Name = "updnNumUsed";
            updnNumUsed.Size = new Size(240, 36);
            updnNumUsed.TabIndex = 77;
            // 
            // updnCID
            // 
            updnCID.Font = new Font("Segoe UI", 16F);
            updnCID.Location = new Point(240, 225);
            updnCID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnCID.Name = "updnCID";
            updnCID.Size = new Size(240, 36);
            updnCID.TabIndex = 76;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(475, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 75;
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
            btnWipe.TabIndex = 74;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // btnUpdRecord
            // 
            btnUpdRecord.Font = new Font("Segoe UI", 16F);
            btnUpdRecord.Location = new Point(15, 465);
            btnUpdRecord.Name = "btnUpdRecord";
            btnUpdRecord.Size = new Size(200, 70);
            btnUpdRecord.TabIndex = 73;
            btnUpdRecord.Text = "Update Item In Checkup";
            btnUpdRecord.UseVisualStyleBackColor = true;
            btnUpdRecord.Click += btnUpdRecord_Click;
            // 
            // UpdateCheckupCjtItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(lblIID);
            Controls.Add(lblCID);
            Controls.Add(lblNumUsed);
            Controls.Add(updnIID);
            Controls.Add(updnNumUsed);
            Controls.Add(updnCID);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(btnUpdRecord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCheckupCjtItem";
            Text = "UpdateCheckupCjtItem";
            ((System.ComponentModel.ISupportInitialize)updnIID).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnNumUsed).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnCID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblIID;
        private Label lblCID;
        private Label lblNumUsed;
        private NumericUpDown updnIID;
        private NumericUpDown updnNumUsed;
        private NumericUpDown updnCID;
        private Button btnHELP;
        private Button btnWipe;
        private Button btnUpdRecord;
    }
}