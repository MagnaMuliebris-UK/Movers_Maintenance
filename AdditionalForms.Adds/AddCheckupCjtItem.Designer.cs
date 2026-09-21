namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    partial class AddCheckupCjtItem
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
            txtbxCID = new TextBox();
            lblIID = new Label();
            lblCID = new Label();
            txtbxIID = new TextBox();
            lblNumUsed = new Label();
            btnAddRecord = new Button();
            txtbxNumUsed = new TextBox();
            SuspendLayout();
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(475, 15);
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
            btnWipe.Location = new Point(345, 465);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(200, 70);
            btnWipe.TabIndex = 70;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // txtbxCID
            // 
            txtbxCID.Font = new Font("Segoe UI", 16F);
            txtbxCID.Location = new Point(240, 210);
            txtbxCID.Name = "txtbxCID";
            txtbxCID.Size = new Size(240, 36);
            txtbxCID.TabIndex = 65;
            // 
            // lblIID
            // 
            lblIID.BackColor = Color.FromArgb(84, 84, 84);
            lblIID.Font = new Font("Segoe UI", 16F);
            lblIID.ForeColor = Color.White;
            lblIID.Location = new Point(115, 100);
            lblIID.Name = "lblIID";
            lblIID.Size = new Size(120, 36);
            lblIID.TabIndex = 66;
            lblIID.Text = "Item ID:";
            lblIID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCID
            // 
            lblCID.BackColor = Color.FromArgb(84, 84, 84);
            lblCID.Font = new Font("Segoe UI", 16F);
            lblCID.ForeColor = Color.White;
            lblCID.Location = new Point(103, 210);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(132, 36);
            lblCID.TabIndex = 64;
            lblCID.Text = "Checkup ID:";
            lblCID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxIID
            // 
            txtbxIID.Font = new Font("Segoe UI", 16F);
            txtbxIID.Location = new Point(240, 100);
            txtbxIID.Name = "txtbxIID";
            txtbxIID.Size = new Size(240, 36);
            txtbxIID.TabIndex = 67;
            // 
            // lblNumUsed
            // 
            lblNumUsed.BackColor = Color.FromArgb(84, 84, 84);
            lblNumUsed.Font = new Font("Segoe UI", 16F);
            lblNumUsed.ForeColor = Color.White;
            lblNumUsed.Location = new Point(80, 320);
            lblNumUsed.Name = "lblNumUsed";
            lblNumUsed.Size = new Size(155, 36);
            lblNumUsed.TabIndex = 68;
            lblNumUsed.Text = "Quantity used:";
            lblNumUsed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Font = new Font("Segoe UI", 16F);
            btnAddRecord.Location = new Point(15, 465);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(200, 70);
            btnAddRecord.TabIndex = 63;
            btnAddRecord.Text = "Add Items into Checkup";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // txtbxNumUsed
            // 
            txtbxNumUsed.Font = new Font("Segoe UI", 16F);
            txtbxNumUsed.Location = new Point(240, 320);
            txtbxNumUsed.Name = "txtbxNumUsed";
            txtbxNumUsed.Size = new Size(240, 36);
            txtbxNumUsed.TabIndex = 69;
            // 
            // AddCheckupCjtItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(txtbxCID);
            Controls.Add(lblIID);
            Controls.Add(lblCID);
            Controls.Add(txtbxIID);
            Controls.Add(lblNumUsed);
            Controls.Add(btnAddRecord);
            Controls.Add(txtbxNumUsed);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCheckupCjtItem";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHELP;
        private Button btnWipe;
        private TextBox txtbxCID;
        private Label lblIID;
        private Label lblCID;
        private TextBox txtbxIID;
        private Label lblNumUsed;
        private Button btnAddRecord;
        private TextBox txtbxNumUsed;
    }
}