namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    partial class DeleteVan
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
            pnlForDelVan = new Panel();
            pnlDelVan = new Panel();
            lblVID = new Label();
            btnHELP = new Button();
            updnVID = new NumericUpDown();
            btnVaV = new Button();
            btnDelRecord = new Button();
            pnlForDelVan.SuspendLayout();
            pnlDelVan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updnVID).BeginInit();
            SuspendLayout();
            // 
            // pnlForDelVan
            // 
            pnlForDelVan.BackColor = Color.FromArgb(74, 74, 84);
            pnlForDelVan.Controls.Add(pnlDelVan);
            pnlForDelVan.Dock = DockStyle.Fill;
            pnlForDelVan.Location = new Point(0, 0);
            pnlForDelVan.Name = "pnlForDelVan";
            pnlForDelVan.Size = new Size(570, 550);
            pnlForDelVan.TabIndex = 27;
            // 
            // pnlDelVan
            // 
            pnlDelVan.BackColor = Color.FromArgb(84, 84, 84);
            pnlDelVan.Controls.Add(lblVID);
            pnlDelVan.Controls.Add(btnHELP);
            pnlDelVan.Controls.Add(updnVID);
            pnlDelVan.Controls.Add(btnVaV);
            pnlDelVan.Controls.Add(btnDelRecord);
            pnlDelVan.Location = new Point(30, 30);
            pnlDelVan.Name = "pnlDelVan";
            pnlDelVan.Size = new Size(510, 490);
            pnlDelVan.TabIndex = 64;
            // 
            // lblVID
            // 
            lblVID.BackColor = Color.FromArgb(84, 84, 84);
            lblVID.Font = new Font("Segoe UI", 16F);
            lblVID.ForeColor = Color.White;
            lblVID.Location = new Point(80, 150);
            lblVID.Name = "lblVID";
            lblVID.Size = new Size(88, 36);
            lblVID.TabIndex = 33;
            lblVID.Text = "Van ID:";
            lblVID.TextAlign = ContentAlignment.MiddleRight;
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
            // updnVID
            // 
            updnVID.Font = new Font("Segoe UI", 16F);
            updnVID.Location = new Point(175, 150);
            updnVID.Name = "updnVID";
            updnVID.Size = new Size(240, 36);
            updnVID.TabIndex = 63;
            // 
            // btnVaV
            // 
            btnVaV.Font = new Font("Segoe UI", 16F);
            btnVaV.Location = new Point(105, 280);
            btnVaV.Name = "btnVaV";
            btnVaV.Size = new Size(300, 70);
            btnVaV.TabIndex = 45;
            btnVaV.Text = "Verify Van";
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
            btnDelRecord.Text = "Remove Van";
            btnDelRecord.UseVisualStyleBackColor = true;
            btnDelRecord.Click += btnDelRecord_Click;
            // 
            // DeleteVan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 550);
            Controls.Add(pnlForDelVan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteVan";
            Text = "DeleteVan";
            pnlForDelVan.ResumeLayout(false);
            pnlDelVan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updnVID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForDelVan;
        private Panel pnlDelVan;
        private Label lblVID;
        private Button btnHELP;
        private NumericUpDown updnVID;
        private Button btnVaV;
        private Button btnDelRecord;
    }
}