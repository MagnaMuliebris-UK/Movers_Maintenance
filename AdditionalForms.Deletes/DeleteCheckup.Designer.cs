namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    partial class DeleteCheckup
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
            pnlForDelCheckup = new Panel();
            pnlDelCheckup = new Panel();
            lblCID = new Label();
            btnHELP = new Button();
            updnCID = new NumericUpDown();
            btnVaV = new Button();
            btnDelRecord = new Button();
            pnlForDelCheckup.SuspendLayout();
            pnlDelCheckup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updnCID).BeginInit();
            SuspendLayout();
            // 
            // pnlForDelCheckup
            // 
            pnlForDelCheckup.BackColor = Color.FromArgb(74, 74, 84);
            pnlForDelCheckup.Controls.Add(pnlDelCheckup);
            pnlForDelCheckup.Dock = DockStyle.Fill;
            pnlForDelCheckup.Location = new Point(0, 0);
            pnlForDelCheckup.Name = "pnlForDelCheckup";
            pnlForDelCheckup.Size = new Size(570, 550);
            pnlForDelCheckup.TabIndex = 27;
            // 
            // pnlDelCheckup
            // 
            pnlDelCheckup.BackColor = Color.FromArgb(84, 84, 84);
            pnlDelCheckup.Controls.Add(lblCID);
            pnlDelCheckup.Controls.Add(btnHELP);
            pnlDelCheckup.Controls.Add(updnCID);
            pnlDelCheckup.Controls.Add(btnVaV);
            pnlDelCheckup.Controls.Add(btnDelRecord);
            pnlDelCheckup.Location = new Point(30, 30);
            pnlDelCheckup.Name = "pnlDelCheckup";
            pnlDelCheckup.Size = new Size(510, 490);
            pnlDelCheckup.TabIndex = 64;
            // 
            // lblCID
            // 
            lblCID.BackColor = Color.FromArgb(84, 84, 84);
            lblCID.Font = new Font("Segoe UI", 16F);
            lblCID.ForeColor = Color.White;
            lblCID.Location = new Point(60, 150);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(130, 36);
            lblCID.TabIndex = 33;
            lblCID.Text = "Checkup ID:";
            lblCID.TextAlign = ContentAlignment.MiddleRight;
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
            // updnCID
            // 
            updnCID.Font = new Font("Segoe UI", 16F);
            updnCID.Location = new Point(197, 150);
            updnCID.Name = "updnCID";
            updnCID.Size = new Size(240, 36);
            updnCID.TabIndex = 63;
            // 
            // btnVaV
            // 
            btnVaV.Font = new Font("Segoe UI", 16F);
            btnVaV.Location = new Point(105, 280);
            btnVaV.Name = "btnVaV";
            btnVaV.Size = new Size(300, 70);
            btnVaV.TabIndex = 45;
            btnVaV.Text = "Verify Checkup";
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
            btnDelRecord.Text = "Remove Checkup";
            btnDelRecord.UseVisualStyleBackColor = true;
            btnDelRecord.Click += btnDelRecord_Click;
            // 
            // DeleteCheckup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 550);
            Controls.Add(pnlForDelCheckup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteCheckup";
            Text = "DeleteCheckup";
            pnlForDelCheckup.ResumeLayout(false);
            pnlDelCheckup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updnCID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForDelCheckup;
        private Panel pnlDelCheckup;
        private Label lblCID;
        private Button btnHELP;
        private NumericUpDown updnCID;
        private Button btnVaV;
        private Button btnDelRecord;
    }
}