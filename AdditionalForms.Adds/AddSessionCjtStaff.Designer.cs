namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    partial class AddSessionCjtStaff
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
            txtbxStID = new TextBox();
            lblSeID = new Label();
            lblStID = new Label();
            txtbxSeID = new TextBox();
            lblTID = new Label();
            btnAddRecord = new Button();
            txtbxTID = new TextBox();
            SuspendLayout();
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(470, 20);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 71;
            btnHELP.Text = "Help";
            btnHELP.UseVisualStyleBackColor = true;
            btnHELP.Click += btnHELP_Click;
            // 
            // btnWipe
            // 
            btnWipe.Font = new Font("Segoe UI", 16F);
            btnWipe.Location = new Point(340, 460);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(200, 70);
            btnWipe.TabIndex = 70;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // txtbxStID
            // 
            txtbxStID.Font = new Font("Segoe UI", 16F);
            txtbxStID.Location = new Point(220, 115);
            txtbxStID.Name = "txtbxStID";
            txtbxStID.Size = new Size(240, 36);
            txtbxStID.TabIndex = 65;
            // 
            // lblSeID
            // 
            lblSeID.BackColor = Color.FromArgb(84, 84, 84);
            lblSeID.Font = new Font("Segoe UI", 16F);
            lblSeID.ForeColor = Color.White;
            lblSeID.Location = new Point(95, 220);
            lblSeID.Name = "lblSeID";
            lblSeID.Size = new Size(120, 36);
            lblSeID.TabIndex = 66;
            lblSeID.Text = "Session ID:";
            lblSeID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStID
            // 
            lblStID.BackColor = Color.FromArgb(84, 84, 84);
            lblStID.Font = new Font("Segoe UI", 16F);
            lblStID.ForeColor = Color.White;
            lblStID.Location = new Point(95, 115);
            lblStID.Name = "lblStID";
            lblStID.Size = new Size(120, 36);
            lblStID.TabIndex = 64;
            lblStID.Text = "Staff ID:";
            lblStID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxSeID
            // 
            txtbxSeID.Font = new Font("Segoe UI", 16F);
            txtbxSeID.Location = new Point(220, 220);
            txtbxSeID.Name = "txtbxSeID";
            txtbxSeID.Size = new Size(240, 36);
            txtbxSeID.TabIndex = 67;
            // 
            // lblTID
            // 
            lblTID.BackColor = Color.FromArgb(84, 84, 84);
            lblTID.Font = new Font("Segoe UI", 16F);
            lblTID.ForeColor = Color.White;
            lblTID.Location = new Point(95, 325);
            lblTID.Name = "lblTID";
            lblTID.Size = new Size(120, 36);
            lblTID.TabIndex = 68;
            lblTID.Text = "Trainer ID:";
            lblTID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Font = new Font("Segoe UI", 16F);
            btnAddRecord.Location = new Point(20, 460);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(200, 70);
            btnAddRecord.TabIndex = 63;
            btnAddRecord.Text = "Add Staff into Session";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // txtbxTID
            // 
            txtbxTID.Font = new Font("Segoe UI", 16F);
            txtbxTID.Location = new Point(220, 325);
            txtbxTID.Name = "txtbxTID";
            txtbxTID.Size = new Size(240, 36);
            txtbxTID.TabIndex = 69;
            // 
            // AddSessionCjtStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(txtbxStID);
            Controls.Add(lblSeID);
            Controls.Add(lblStID);
            Controls.Add(txtbxSeID);
            Controls.Add(lblTID);
            Controls.Add(btnAddRecord);
            Controls.Add(txtbxTID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSessionCjtStaff";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHELP;
        private Button btnWipe;
        private TextBox txtbxStID;
        private Label lblSeID;
        private Label lblStID;
        private TextBox txtbxSeID;
        private Label lblTID;
        private Button btnAddRecord;
        private TextBox txtbxTID;
    }
}