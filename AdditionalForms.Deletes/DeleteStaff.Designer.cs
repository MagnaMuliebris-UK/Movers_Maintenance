namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    partial class DeleteStaff
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
            pnlForDelStaff = new Panel();
            pnlDelStaff = new Panel();
            lblSID = new Label();
            btnHELP = new Button();
            updnSID = new NumericUpDown();
            btnVaV = new Button();
            btnDelRecord = new Button();
            pnlForDelStaff.SuspendLayout();
            pnlDelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updnSID).BeginInit();
            SuspendLayout();
            // 
            // pnlForDelStaff
            // 
            pnlForDelStaff.BackColor = Color.FromArgb(74, 74, 84);
            pnlForDelStaff.Controls.Add(pnlDelStaff);
            pnlForDelStaff.Dock = DockStyle.Fill;
            pnlForDelStaff.Location = new Point(0, 0);
            pnlForDelStaff.Name = "pnlForDelStaff";
            pnlForDelStaff.Size = new Size(570, 550);
            pnlForDelStaff.TabIndex = 26;
            // 
            // pnlDelStaff
            // 
            pnlDelStaff.BackColor = Color.FromArgb(84, 84, 84);
            pnlDelStaff.Controls.Add(lblSID);
            pnlDelStaff.Controls.Add(btnHELP);
            pnlDelStaff.Controls.Add(updnSID);
            pnlDelStaff.Controls.Add(btnVaV);
            pnlDelStaff.Controls.Add(btnDelRecord);
            pnlDelStaff.Location = new Point(30, 30);
            pnlDelStaff.Name = "pnlDelStaff";
            pnlDelStaff.Size = new Size(510, 490);
            pnlDelStaff.TabIndex = 64;
            // 
            // lblSID
            // 
            lblSID.BackColor = Color.FromArgb(84, 84, 84);
            lblSID.Font = new Font("Segoe UI", 16F);
            lblSID.ForeColor = Color.White;
            lblSID.Location = new Point(80, 150);
            lblSID.Name = "lblSID";
            lblSID.Size = new Size(88, 36);
            lblSID.TabIndex = 33;
            lblSID.Text = "Staff ID:";
            lblSID.TextAlign = ContentAlignment.MiddleRight;
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
            // updnSID
            // 
            updnSID.Font = new Font("Segoe UI", 16F);
            updnSID.Location = new Point(175, 150);
            updnSID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnSID.Name = "updnSID";
            updnSID.Size = new Size(240, 36);
            updnSID.TabIndex = 63;
            // 
            // btnVaV
            // 
            btnVaV.Font = new Font("Segoe UI", 16F);
            btnVaV.Location = new Point(105, 280);
            btnVaV.Name = "btnVaV";
            btnVaV.Size = new Size(300, 70);
            btnVaV.TabIndex = 45;
            btnVaV.Text = "Verify Staff Member";
            btnVaV.UseVisualStyleBackColor = true;
            btnVaV.Click += btnVaV_Click;
            // 
            // btnDelRecord
            // 
            btnDelRecord.Font = new Font("Segoe UI", 16F);
            btnDelRecord.Location = new Point(105, 390);
            btnDelRecord.Name = "btnDelRecord";
            btnDelRecord.Size = new Size(300, 70);
            btnDelRecord.TabIndex = 4;
            btnDelRecord.Text = "Remove Staff";
            btnDelRecord.UseVisualStyleBackColor = true;
            btnDelRecord.Click += btnDelRecord_Click;
            // 
            // DeleteStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 550);
            Controls.Add(pnlForDelStaff);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "DeleteStaff";
            Text = "DeleteStaff";
            pnlForDelStaff.ResumeLayout(false);
            pnlDelStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updnSID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForDelStaff;
        private Button btnHELP;
        private Button btnVaV;
        private Label lblSID;
        private Button btnDelRecord;
        private NumericUpDown updnSID;
        private Panel pnlDelStaff;
    }
}