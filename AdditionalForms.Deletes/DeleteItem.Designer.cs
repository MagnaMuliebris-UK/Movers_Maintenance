namespace Movers_Maintenance_Subsystem.AdditionalForms.Deletes
{
    partial class DeleteItem
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
            panel1 = new Panel();
            lblIID = new Label();
            btnHELP = new Button();
            updnIID = new NumericUpDown();
            btnVaV = new Button();
            btnDelRecord = new Button();
            pnlForDelStaff.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updnIID).BeginInit();
            SuspendLayout();
            // 
            // pnlForDelStaff
            // 
            pnlForDelStaff.BackColor = Color.FromArgb(74, 74, 84);
            pnlForDelStaff.Controls.Add(panel1);
            pnlForDelStaff.Dock = DockStyle.Fill;
            pnlForDelStaff.Location = new Point(0, 0);
            pnlForDelStaff.Name = "pnlForDelStaff";
            pnlForDelStaff.Size = new Size(570, 550);
            pnlForDelStaff.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 84, 84);
            panel1.Controls.Add(lblIID);
            panel1.Controls.Add(btnHELP);
            panel1.Controls.Add(updnIID);
            panel1.Controls.Add(btnVaV);
            panel1.Controls.Add(btnDelRecord);
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 490);
            panel1.TabIndex = 64;
            // 
            // lblIID
            // 
            lblIID.BackColor = Color.FromArgb(84, 84, 84);
            lblIID.Font = new Font("Segoe UI", 16F);
            lblIID.ForeColor = Color.White;
            lblIID.Location = new Point(84, 150);
            lblIID.Name = "lblIID";
            lblIID.Size = new Size(97, 36);
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
            updnIID.Location = new Point(188, 150);
            updnIID.Name = "updnIID";
            updnIID.Size = new Size(240, 36);
            updnIID.TabIndex = 63;
            // 
            // btnVaV
            // 
            btnVaV.Font = new Font("Segoe UI", 16F);
            btnVaV.Location = new Point(105, 280);
            btnVaV.Name = "btnVaV";
            btnVaV.Size = new Size(300, 70);
            btnVaV.TabIndex = 45;
            btnVaV.Text = "Verify Item";
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
            btnDelRecord.Text = "Remove Item";
            btnDelRecord.UseVisualStyleBackColor = true;
            btnDelRecord.Click += btnDelRecord_Click;
            // 
            // DeleteItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 550);
            Controls.Add(pnlForDelStaff);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteItem";
            Text = "DeleteItem";
            pnlForDelStaff.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)updnIID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForDelStaff;
        private Panel panel1;
        private Label lblIID;
        private Button btnHELP;
        private NumericUpDown updnIID;
        private Button btnVaV;
        private Button btnDelRecord;
    }
}