namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    partial class AddSession
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
            pnlForAddSession = new Panel();
            pnlMainSession = new Panel();
            lblSType = new Label();
            btnHELP = new Button();
            btnAddRecord = new Button();
            txtbxSDate = new TextBox();
            btnWipe = new Button();
            lblSDate = new Label();
            txtbxSType = new TextBox();
            pnlForAddSession.SuspendLayout();
            pnlMainSession.SuspendLayout();
            SuspendLayout();
            // 
            // pnlForAddSession
            // 
            pnlForAddSession.BackColor = Color.FromArgb(74, 74, 84);
            pnlForAddSession.Controls.Add(pnlMainSession);
            pnlForAddSession.Dock = DockStyle.Fill;
            pnlForAddSession.Location = new Point(0, 0);
            pnlForAddSession.Name = "pnlForAddSession";
            pnlForAddSession.Size = new Size(570, 550);
            pnlForAddSession.TabIndex = 26;
            // 
            // pnlMainSession
            // 
            pnlMainSession.BackColor = Color.FromArgb(84, 84, 84);
            pnlMainSession.Controls.Add(lblSType);
            pnlMainSession.Controls.Add(btnHELP);
            pnlMainSession.Controls.Add(btnAddRecord);
            pnlMainSession.Controls.Add(txtbxSDate);
            pnlMainSession.Controls.Add(btnWipe);
            pnlMainSession.Controls.Add(lblSDate);
            pnlMainSession.Controls.Add(txtbxSType);
            pnlMainSession.Location = new Point(30, 20);
            pnlMainSession.Name = "pnlMainSession";
            pnlMainSession.Size = new Size(510, 510);
            pnlMainSession.TabIndex = 65;
            // 
            // lblSType
            // 
            lblSType.BackColor = Color.FromArgb(84, 84, 84);
            lblSType.Font = new Font("Segoe UI", 16F);
            lblSType.ForeColor = Color.White;
            lblSType.Location = new Point(60, 140);
            lblSType.Name = "lblSType";
            lblSType.Size = new Size(145, 36);
            lblSType.TabIndex = 33;
            lblSType.Text = "Session Type:";
            lblSType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 16F);
            btnHELP.Location = new Point(390, 20);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(100, 50);
            btnHELP.TabIndex = 62;
            btnHELP.Text = "Help";
            btnHELP.UseVisualStyleBackColor = true;
            btnHELP.Click += btnHELP_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Font = new Font("Segoe UI", 16F);
            btnAddRecord.Location = new Point(20, 420);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(200, 70);
            btnAddRecord.TabIndex = 4;
            btnAddRecord.Text = "Add Session";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // txtbxSDate
            // 
            txtbxSDate.Font = new Font("Segoe UI", 16F);
            txtbxSDate.Location = new Point(210, 240);
            txtbxSDate.Name = "txtbxSDate";
            txtbxSDate.PlaceholderText = "dd-mm-yyyy";
            txtbxSDate.Size = new Size(240, 36);
            txtbxSDate.TabIndex = 36;
            // 
            // btnWipe
            // 
            btnWipe.Font = new Font("Segoe UI", 16F);
            btnWipe.Location = new Point(290, 420);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(200, 70);
            btnWipe.TabIndex = 45;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // lblSDate
            // 
            lblSDate.BackColor = Color.FromArgb(84, 84, 84);
            lblSDate.Font = new Font("Segoe UI", 16F);
            lblSDate.ForeColor = Color.White;
            lblSDate.Location = new Point(60, 240);
            lblSDate.Name = "lblSDate";
            lblSDate.Size = new Size(145, 36);
            lblSDate.TabIndex = 35;
            lblSDate.Text = "Session Date:";
            lblSDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxSType
            // 
            txtbxSType.Font = new Font("Segoe UI", 16F);
            txtbxSType.Location = new Point(210, 140);
            txtbxSType.Name = "txtbxSType";
            txtbxSType.Size = new Size(240, 36);
            txtbxSType.TabIndex = 34;
            // 
            // AddSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 550);
            Controls.Add(pnlForAddSession);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSession";
            Text = "Form1";
            pnlForAddSession.ResumeLayout(false);
            pnlMainSession.ResumeLayout(false);
            pnlMainSession.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForAddSession;
        private Button btnHELP;
        private Button btnWipe;
        private TextBox txtbxSType;
        private Label lblSDate;
        private Label lblSType;
        private TextBox txtbxSDate;
        private Button btnAddRecord;
        private Panel pnlMainSession;
    }
}