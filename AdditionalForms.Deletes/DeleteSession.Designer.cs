namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    partial class DeleteSession
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
            pnlForDelSession = new Panel();
            pnlDelSession = new Panel();
            lblSID = new Label();
            btnHELP = new Button();
            updnSID = new NumericUpDown();
            btnVaV = new Button();
            btnDelRecord = new Button();
            pnlForDelSession.SuspendLayout();
            pnlDelSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updnSID).BeginInit();
            SuspendLayout();
            // 
            // pnlForDelSession
            // 
            pnlForDelSession.BackColor = Color.FromArgb(74, 74, 84);
            pnlForDelSession.Controls.Add(pnlDelSession);
            pnlForDelSession.Dock = DockStyle.Fill;
            pnlForDelSession.Location = new Point(0, 0);
            pnlForDelSession.Name = "pnlForDelSession";
            pnlForDelSession.Size = new Size(570, 550);
            pnlForDelSession.TabIndex = 28;
            // 
            // pnlDelSession
            // 
            pnlDelSession.BackColor = Color.FromArgb(84, 84, 84);
            pnlDelSession.Controls.Add(lblSID);
            pnlDelSession.Controls.Add(btnHELP);
            pnlDelSession.Controls.Add(updnSID);
            pnlDelSession.Controls.Add(btnVaV);
            pnlDelSession.Controls.Add(btnDelRecord);
            pnlDelSession.Location = new Point(30, 30);
            pnlDelSession.Name = "pnlDelSession";
            pnlDelSession.Size = new Size(510, 490);
            pnlDelSession.TabIndex = 64;
            // 
            // lblSID
            // 
            lblSID.BackColor = Color.FromArgb(84, 84, 84);
            lblSID.Font = new Font("Segoe UI", 16F);
            lblSID.ForeColor = Color.White;
            lblSID.Location = new Point(60, 150);
            lblSID.Name = "lblSID";
            lblSID.Size = new Size(130, 36);
            lblSID.TabIndex = 33;
            lblSID.Text = "Session ID:";
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
            updnSID.Location = new Point(197, 150);
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
            btnVaV.Text = "Verify Session";
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
            btnDelRecord.Text = "Remove Session";
            btnDelRecord.UseVisualStyleBackColor = true;
            btnDelRecord.Click += btnDelRecord_Click;
            // 
            // DeleteSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 550);
            Controls.Add(pnlForDelSession);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteSession";
            Text = "DeleteSession";
            pnlForDelSession.ResumeLayout(false);
            pnlDelSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updnSID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForDelSession;
        private Panel pnlDelSession;
        private Label lblSID;
        private Button btnHELP;
        private NumericUpDown updnSID;
        private Button btnVaV;
        private Button btnDelRecord;
    }
}