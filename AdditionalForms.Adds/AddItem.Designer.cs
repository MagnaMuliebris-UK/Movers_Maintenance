namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    partial class AddItem
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
            txtbxIName = new TextBox();
            lblDesc = new Label();
            lblIName = new Label();
            txtbxDesc = new TextBox();
            lblCNum = new Label();
            lblINum = new Label();
            btnAddRecord = new Button();
            txtbxINum = new TextBox();
            txtbxCNum = new TextBox();
            SuspendLayout();
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(475, 10);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 73;
            btnHELP.Text = "Help";
            btnHELP.UseVisualStyleBackColor = true;
            btnHELP.Click += btnHELP_Click;
            // 
            // btnWipe
            // 
            btnWipe.Font = new Font("Segoe UI", 16F);
            btnWipe.Location = new Point(345, 470);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(200, 70);
            btnWipe.TabIndex = 72;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // txtbxIName
            // 
            txtbxIName.Font = new Font("Segoe UI", 16F);
            txtbxIName.Location = new Point(259, 85);
            txtbxIName.Name = "txtbxIName";
            txtbxIName.Size = new Size(240, 36);
            txtbxIName.TabIndex = 65;
            // 
            // lblDesc
            // 
            lblDesc.BackColor = Color.FromArgb(84, 84, 84);
            lblDesc.Font = new Font("Segoe UI", 16F);
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(125, 180);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(129, 36);
            lblDesc.TabIndex = 66;
            lblDesc.Text = "Description:";
            lblDesc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIName
            // 
            lblIName.BackColor = Color.FromArgb(84, 84, 84);
            lblIName.Font = new Font("Segoe UI", 16F);
            lblIName.ForeColor = Color.White;
            lblIName.Location = new Point(125, 85);
            lblIName.Name = "lblIName";
            lblIName.Size = new Size(129, 36);
            lblIName.TabIndex = 64;
            lblIName.Text = "Item name:";
            lblIName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxDesc
            // 
            txtbxDesc.Font = new Font("Segoe UI", 16F);
            txtbxDesc.Location = new Point(259, 180);
            txtbxDesc.Name = "txtbxDesc";
            txtbxDesc.Size = new Size(240, 36);
            txtbxDesc.TabIndex = 67;
            // 
            // lblCNum
            // 
            lblCNum.BackColor = Color.FromArgb(84, 84, 84);
            lblCNum.Font = new Font("Segoe UI", 16F);
            lblCNum.ForeColor = Color.White;
            lblCNum.Location = new Point(76, 275);
            lblCNum.Name = "lblCNum";
            lblCNum.Size = new Size(178, 36);
            lblCNum.TabIndex = 68;
            lblCNum.Text = "Current quantity:";
            lblCNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblINum
            // 
            lblINum.BackColor = Color.FromArgb(84, 84, 84);
            lblINum.Font = new Font("Segoe UI", 16F);
            lblINum.ForeColor = Color.White;
            lblINum.Location = new Point(76, 370);
            lblINum.Name = "lblINum";
            lblINum.Size = new Size(178, 36);
            lblINum.TabIndex = 70;
            lblINum.Text = "Ideal quantity:";
            lblINum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Font = new Font("Segoe UI", 16F);
            btnAddRecord.Location = new Point(15, 470);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(200, 70);
            btnAddRecord.TabIndex = 63;
            btnAddRecord.Text = "Add Item";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // txtbxINum
            // 
            txtbxINum.Font = new Font("Segoe UI", 16F);
            txtbxINum.Location = new Point(259, 370);
            txtbxINum.Name = "txtbxINum";
            txtbxINum.Size = new Size(240, 36);
            txtbxINum.TabIndex = 71;
            // 
            // txtbxCNum
            // 
            txtbxCNum.Font = new Font("Segoe UI", 16F);
            txtbxCNum.Location = new Point(259, 275);
            txtbxCNum.Name = "txtbxCNum";
            txtbxCNum.Size = new Size(240, 36);
            txtbxCNum.TabIndex = 69;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(txtbxIName);
            Controls.Add(lblDesc);
            Controls.Add(lblIName);
            Controls.Add(txtbxDesc);
            Controls.Add(lblCNum);
            Controls.Add(lblINum);
            Controls.Add(btnAddRecord);
            Controls.Add(txtbxINum);
            Controls.Add(txtbxCNum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddItem";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHELP;
        private Button btnWipe;
        private TextBox txtbxIName;
        private Label lblDesc;
        private Label lblIName;
        private TextBox txtbxDesc;
        private Label lblCNum;
        private Label lblINum;
        private Button btnAddRecord;
        private TextBox txtbxINum;
        private TextBox txtbxCNum;
    }
}