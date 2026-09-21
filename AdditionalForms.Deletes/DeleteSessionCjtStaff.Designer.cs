namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    partial class DeleteSessionCjtStaff
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
            pnlForDelSiS = new Panel();
            pnlDelSiS = new Panel();
            lblSeID = new Label();
            updnSeID = new NumericUpDown();
            lblStID = new Label();
            btnHELP = new Button();
            updnStID = new NumericUpDown();
            btnVaV = new Button();
            btnDelRecord = new Button();
            pnlForDelSiS.SuspendLayout();
            pnlDelSiS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updnSeID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnStID).BeginInit();
            SuspendLayout();
            // 
            // pnlForDelSiS
            // 
            pnlForDelSiS.BackColor = Color.FromArgb(74, 74, 84);
            pnlForDelSiS.Controls.Add(pnlDelSiS);
            pnlForDelSiS.Dock = DockStyle.Fill;
            pnlForDelSiS.Location = new Point(0, 0);
            pnlForDelSiS.Name = "pnlForDelSiS";
            pnlForDelSiS.Size = new Size(570, 550);
            pnlForDelSiS.TabIndex = 28;
            // 
            // pnlDelSiS
            // 
            pnlDelSiS.BackColor = Color.FromArgb(84, 84, 84);
            pnlDelSiS.Controls.Add(lblSeID);
            pnlDelSiS.Controls.Add(updnSeID);
            pnlDelSiS.Controls.Add(lblStID);
            pnlDelSiS.Controls.Add(btnHELP);
            pnlDelSiS.Controls.Add(updnStID);
            pnlDelSiS.Controls.Add(btnVaV);
            pnlDelSiS.Controls.Add(btnDelRecord);
            pnlDelSiS.Location = new Point(30, 30);
            pnlDelSiS.Name = "pnlDelSiS";
            pnlDelSiS.Size = new Size(510, 490);
            pnlDelSiS.TabIndex = 64;
            // 
            // lblSeID
            // 
            lblSeID.BackColor = Color.FromArgb(84, 84, 84);
            lblSeID.Font = new Font("Segoe UI", 16F);
            lblSeID.ForeColor = Color.White;
            lblSeID.Location = new Point(60, 193);
            lblSeID.Name = "lblSeID";
            lblSeID.Size = new Size(130, 36);
            lblSeID.TabIndex = 64;
            lblSeID.Text = "Session ID:";
            lblSeID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnSeID
            // 
            updnSeID.Font = new Font("Segoe UI", 16F);
            updnSeID.Location = new Point(197, 193);
            updnSeID.Name = "updnSeID";
            updnSeID.Size = new Size(240, 36);
            updnSeID.TabIndex = 65;
            // 
            // lblStID
            // 
            lblStID.BackColor = Color.FromArgb(84, 84, 84);
            lblStID.Font = new Font("Segoe UI", 16F);
            lblStID.ForeColor = Color.White;
            lblStID.Location = new Point(60, 121);
            lblStID.Name = "lblStID";
            lblStID.Size = new Size(130, 36);
            lblStID.TabIndex = 33;
            lblStID.Text = "Staff ID:";
            lblStID.TextAlign = ContentAlignment.MiddleRight;
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
            // updnStID
            // 
            updnStID.Font = new Font("Segoe UI", 16F);
            updnStID.Location = new Point(197, 121);
            updnStID.Name = "updnStID";
            updnStID.Size = new Size(240, 36);
            updnStID.TabIndex = 63;
            // 
            // btnVaV
            // 
            btnVaV.Font = new Font("Segoe UI", 16F);
            btnVaV.Location = new Point(105, 289);
            btnVaV.Name = "btnVaV";
            btnVaV.Size = new Size(300, 70);
            btnVaV.TabIndex = 45;
            btnVaV.Text = "Verify Staff in Session";
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
            btnDelRecord.Text = "Remove Staff from Session";
            btnDelRecord.UseVisualStyleBackColor = true;
            btnDelRecord.Click += btnDelRecord_Click;
            // 
            // DeleteSessionCjtStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 550);
            Controls.Add(pnlForDelSiS);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteSessionCjtStaff";
            Text = "DeleteSessionCjtStaff";
            pnlForDelSiS.ResumeLayout(false);
            pnlDelSiS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updnSeID).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnStID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForDelSiS;
        private Panel pnlDelSiS;
        private Label lblSeID;
        private NumericUpDown updnSeID;
        private Label lblStID;
        private Button btnHELP;
        private NumericUpDown updnStID;
        private Button btnVaV;
        private Button btnDelRecord;
    }
}