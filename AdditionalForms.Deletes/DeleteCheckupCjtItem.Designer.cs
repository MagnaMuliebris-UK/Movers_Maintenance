namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    partial class DeleteCheckupCjtItem
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
            pnlForDeliC = new Panel();
            pnlDelIiC = new Panel();
            lblCID = new Label();
            updnCID = new NumericUpDown();
            lblIID = new Label();
            btnHELP = new Button();
            updnIID = new NumericUpDown();
            btnVaV = new Button();
            btnDelRecord = new Button();
            pnlForDeliC.SuspendLayout();
            pnlDelIiC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updnCID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnIID).BeginInit();
            SuspendLayout();
            // 
            // pnlForDeliC
            // 
            pnlForDeliC.BackColor = Color.FromArgb(74, 74, 84);
            pnlForDeliC.Controls.Add(pnlDelIiC);
            pnlForDeliC.Dock = DockStyle.Fill;
            pnlForDeliC.Location = new Point(0, 0);
            pnlForDeliC.Name = "pnlForDeliC";
            pnlForDeliC.Size = new Size(570, 550);
            pnlForDeliC.TabIndex = 29;
            // 
            // pnlDelIiC
            // 
            pnlDelIiC.BackColor = Color.FromArgb(84, 84, 84);
            pnlDelIiC.Controls.Add(lblCID);
            pnlDelIiC.Controls.Add(updnCID);
            pnlDelIiC.Controls.Add(lblIID);
            pnlDelIiC.Controls.Add(btnHELP);
            pnlDelIiC.Controls.Add(updnIID);
            pnlDelIiC.Controls.Add(btnVaV);
            pnlDelIiC.Controls.Add(btnDelRecord);
            pnlDelIiC.Location = new Point(30, 30);
            pnlDelIiC.Name = "pnlDelIiC";
            pnlDelIiC.Size = new Size(510, 490);
            pnlDelIiC.TabIndex = 64;
            // 
            // lblCID
            // 
            lblCID.BackColor = Color.FromArgb(84, 84, 84);
            lblCID.Font = new Font("Segoe UI", 16F);
            lblCID.ForeColor = Color.White;
            lblCID.Location = new Point(60, 193);
            lblCID.Name = "lblCID";
            lblCID.Size = new Size(130, 36);
            lblCID.TabIndex = 64;
            lblCID.Text = "Checkup ID:";
            lblCID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnCID
            // 
            updnCID.Font = new Font("Segoe UI", 16F);
            updnCID.Location = new Point(197, 193);
            updnCID.Name = "updnCID";
            updnCID.Size = new Size(240, 36);
            updnCID.TabIndex = 65;
            // 
            // lblIID
            // 
            lblIID.BackColor = Color.FromArgb(84, 84, 84);
            lblIID.Font = new Font("Segoe UI", 16F);
            lblIID.ForeColor = Color.White;
            lblIID.Location = new Point(60, 121);
            lblIID.Name = "lblIID";
            lblIID.Size = new Size(130, 36);
            lblIID.TabIndex = 33;
            lblIID.Text = "Item ID:";
            lblIID.TextAlign = ContentAlignment.MiddleRight;
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
            // updnIID
            // 
            updnIID.Font = new Font("Segoe UI", 16F);
            updnIID.Location = new Point(197, 121);
            updnIID.Name = "updnIID";
            updnIID.Size = new Size(240, 36);
            updnIID.TabIndex = 63;
            // 
            // btnVaV
            // 
            btnVaV.Font = new Font("Segoe UI", 16F);
            btnVaV.Location = new Point(105, 289);
            btnVaV.Name = "btnVaV";
            btnVaV.Size = new Size(300, 70);
            btnVaV.TabIndex = 45;
            btnVaV.Text = "Verify Item in Checkup";
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
            btnDelRecord.Text = "Remove Item from Checkup";
            btnDelRecord.UseVisualStyleBackColor = true;
            btnDelRecord.Click += btnDelRecord_Click;
            // 
            // DeleteCheckupCjtItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 550);
            Controls.Add(pnlForDeliC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteCheckupCjtItem";
            Text = "DeleteCheckupCjtItem";
            pnlForDeliC.ResumeLayout(false);
            pnlDelIiC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updnCID).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnIID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForDeliC;
        private Panel pnlDelIiC;
        private Label lblCID;
        private NumericUpDown updnCID;
        private Label lblIID;
        private Button btnHELP;
        private NumericUpDown updnIID;
        private Button btnVaV;
        private Button btnDelRecord;
    }
}