namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    partial class UpdateItem
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
            updnCNum = new NumericUpDown();
            updnINum = new NumericUpDown();
            lblIID = new Label();
            updnIID = new NumericUpDown();
            btnHELP = new Button();
            btnWipe = new Button();
            txtbxIName = new TextBox();
            lblDesc = new Label();
            lblIName = new Label();
            txtbxDesc = new TextBox();
            lblCNum = new Label();
            lblINum = new Label();
            btnUpdRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)updnCNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnINum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnIID).BeginInit();
            SuspendLayout();
            // 
            // updnCNum
            // 
            updnCNum.Font = new Font("Segoe UI", 16F);
            updnCNum.Location = new Point(259, 285);
            updnCNum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnCNum.Name = "updnCNum";
            updnCNum.Size = new Size(240, 36);
            updnCNum.TabIndex = 5;
            // 
            // updnINum
            // 
            updnINum.Font = new Font("Segoe UI", 16F);
            updnINum.Location = new Point(259, 350);
            updnINum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnINum.Name = "updnINum";
            updnINum.Size = new Size(240, 36);
            updnINum.TabIndex = 6;
            // 
            // lblIID
            // 
            lblIID.BackColor = Color.FromArgb(84, 84, 84);
            lblIID.Font = new Font("Segoe UI", 16F);
            lblIID.ForeColor = Color.White;
            lblIID.Location = new Point(162, 90);
            lblIID.Name = "lblIID";
            lblIID.Size = new Size(92, 36);
            lblIID.TabIndex = 77;
            lblIID.Text = "Item ID:";
            lblIID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnIID
            // 
            updnIID.Font = new Font("Segoe UI", 16F);
            updnIID.Location = new Point(259, 90);
            updnIID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnIID.Name = "updnIID";
            updnIID.Size = new Size(240, 36);
            updnIID.TabIndex = 2;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(475, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 1;
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
            btnWipe.TabIndex = 75;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // txtbxIName
            // 
            txtbxIName.Font = new Font("Segoe UI", 16F);
            txtbxIName.Location = new Point(259, 155);
            txtbxIName.Name = "txtbxIName";
            txtbxIName.Size = new Size(240, 36);
            txtbxIName.TabIndex = 3;
            // 
            // lblDesc
            // 
            lblDesc.BackColor = Color.FromArgb(84, 84, 84);
            lblDesc.Font = new Font("Segoe UI", 16F);
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(124, 220);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(130, 36);
            lblDesc.TabIndex = 71;
            lblDesc.Text = "Description:";
            lblDesc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIName
            // 
            lblIName.BackColor = Color.FromArgb(84, 84, 84);
            lblIName.Font = new Font("Segoe UI", 16F);
            lblIName.ForeColor = Color.White;
            lblIName.Location = new Point(124, 155);
            lblIName.Name = "lblIName";
            lblIName.Size = new Size(130, 36);
            lblIName.TabIndex = 69;
            lblIName.Text = "Item name:";
            lblIName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxDesc
            // 
            txtbxDesc.Font = new Font("Segoe UI", 16F);
            txtbxDesc.Location = new Point(259, 220);
            txtbxDesc.Name = "txtbxDesc";
            txtbxDesc.Size = new Size(240, 36);
            txtbxDesc.TabIndex = 4;
            // 
            // lblCNum
            // 
            lblCNum.BackColor = Color.FromArgb(84, 84, 84);
            lblCNum.Font = new Font("Segoe UI", 16F);
            lblCNum.ForeColor = Color.White;
            lblCNum.Location = new Point(74, 285);
            lblCNum.Name = "lblCNum";
            lblCNum.Size = new Size(180, 36);
            lblCNum.TabIndex = 73;
            lblCNum.Text = "Current Quantity:";
            lblCNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblINum
            // 
            lblINum.BackColor = Color.FromArgb(84, 84, 84);
            lblINum.Font = new Font("Segoe UI", 16F);
            lblINum.ForeColor = Color.White;
            lblINum.Location = new Point(74, 350);
            lblINum.Name = "lblINum";
            lblINum.Size = new Size(180, 36);
            lblINum.TabIndex = 74;
            lblINum.Text = "Ideal Quantity:";
            lblINum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUpdRecord
            // 
            btnUpdRecord.Font = new Font("Segoe UI", 16F);
            btnUpdRecord.Location = new Point(15, 465);
            btnUpdRecord.Name = "btnUpdRecord";
            btnUpdRecord.Size = new Size(200, 70);
            btnUpdRecord.TabIndex = 68;
            btnUpdRecord.Text = "Update Item";
            btnUpdRecord.UseVisualStyleBackColor = true;
            btnUpdRecord.Click += btnUpdRecord_Click;
            // 
            // UpdateItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(lblIName);
            Controls.Add(updnCNum);
            Controls.Add(updnINum);
            Controls.Add(lblIID);
            Controls.Add(updnIID);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(txtbxIName);
            Controls.Add(lblDesc);
            Controls.Add(txtbxDesc);
            Controls.Add(lblCNum);
            Controls.Add(lblINum);
            Controls.Add(btnUpdRecord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateItem";
            Text = "UpdateItem";
            ((System.ComponentModel.ISupportInitialize)updnCNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnINum).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnIID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown updnCNum;
        private NumericUpDown updnINum;
        private Label lblIID;
        private NumericUpDown updnIID;
        private Button btnHELP;
        private Button btnWipe;
        private TextBox txtbxIName;
        private Label lblDesc;
        private Label lblIName;
        private TextBox txtbxDesc;
        private Label lblCNum;
        private Label lblINum;
        private Button btnUpdRecord;
    }
}