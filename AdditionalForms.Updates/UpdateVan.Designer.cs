namespace Movers_Maintenance_Subsystem.AdditionalForms.Updates
{
    partial class UpdateVan
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
            ckbxIsDrivable = new CheckBox();
            updnDriverID = new NumericUpDown();
            lblVID = new Label();
            updnVID = new NumericUpDown();
            btnHELP = new Button();
            btnWipe = new Button();
            txtbxVMake = new TextBox();
            lblDriverID = new Label();
            lblVMake = new Label();
            txtbxMOTExpDate = new TextBox();
            lblMOTExpDate = new Label();
            btnUpdRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)updnDriverID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updnVID).BeginInit();
            SuspendLayout();
            // 
            // ckbxIsDrivable
            // 
            ckbxIsDrivable.CheckAlign = ContentAlignment.BottomCenter;
            ckbxIsDrivable.Font = new Font("Segoe UI", 16F);
            ckbxIsDrivable.ForeColor = Color.White;
            ckbxIsDrivable.Location = new Point(0, 370);
            ckbxIsDrivable.Name = "ckbxIsDrivable";
            ckbxIsDrivable.Size = new Size(570, 45);
            ckbxIsDrivable.TabIndex = 80;
            ckbxIsDrivable.Text = "Is this van in the condition to be driven?";
            ckbxIsDrivable.TextAlign = ContentAlignment.MiddleCenter;
            ckbxIsDrivable.UseVisualStyleBackColor = true;
            // 
            // updnDriverID
            // 
            updnDriverID.Font = new Font("Segoe UI", 16F);
            updnDriverID.Location = new Point(265, 230);
            updnDriverID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnDriverID.Name = "updnDriverID";
            updnDriverID.Size = new Size(240, 36);
            updnDriverID.TabIndex = 79;
            // 
            // lblVID
            // 
            lblVID.BackColor = Color.FromArgb(84, 84, 84);
            lblVID.Font = new Font("Segoe UI", 16F);
            lblVID.ForeColor = Color.White;
            lblVID.Location = new Point(171, 90);
            lblVID.Name = "lblVID";
            lblVID.Size = new Size(88, 36);
            lblVID.TabIndex = 77;
            lblVID.Text = "Van ID:";
            lblVID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // updnVID
            // 
            updnVID.Font = new Font("Segoe UI", 16F);
            updnVID.Location = new Point(264, 90);
            updnVID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            updnVID.Name = "updnVID";
            updnVID.Size = new Size(240, 36);
            updnVID.TabIndex = 78;
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(480, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 76;
            btnHELP.Text = "Help";
            btnHELP.UseVisualStyleBackColor = true;
            btnHELP.Click += btnHELP_Click;
            // 
            // btnWipe
            // 
            btnWipe.Font = new Font("Segoe UI", 16F);
            btnWipe.Location = new Point(350, 465);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(200, 70);
            btnWipe.TabIndex = 75;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // txtbxVMake
            // 
            txtbxVMake.Font = new Font("Segoe UI", 16F);
            txtbxVMake.Location = new Point(264, 160);
            txtbxVMake.Name = "txtbxVMake";
            txtbxVMake.Size = new Size(240, 36);
            txtbxVMake.TabIndex = 71;
            // 
            // lblDriverID
            // 
            lblDriverID.BackColor = Color.FromArgb(84, 84, 84);
            lblDriverID.Font = new Font("Segoe UI", 16F);
            lblDriverID.ForeColor = Color.White;
            lblDriverID.Location = new Point(139, 230);
            lblDriverID.Name = "lblDriverID";
            lblDriverID.Size = new Size(120, 36);
            lblDriverID.TabIndex = 72;
            lblDriverID.Text = "Driver ID:";
            lblDriverID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVMake
            // 
            lblVMake.BackColor = Color.FromArgb(84, 84, 84);
            lblVMake.Font = new Font("Segoe UI", 16F);
            lblVMake.ForeColor = Color.White;
            lblVMake.Location = new Point(139, 160);
            lblVMake.Name = "lblVMake";
            lblVMake.Size = new Size(120, 36);
            lblVMake.TabIndex = 70;
            lblVMake.Text = "Van make:";
            lblVMake.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxMOTExpDate
            // 
            txtbxMOTExpDate.Font = new Font("Segoe UI", 16F);
            txtbxMOTExpDate.Location = new Point(265, 300);
            txtbxMOTExpDate.Name = "txtbxMOTExpDate";
            txtbxMOTExpDate.PlaceholderText = "dd/mm/yyyy";
            txtbxMOTExpDate.Size = new Size(240, 36);
            txtbxMOTExpDate.TabIndex = 73;
            // 
            // lblMOTExpDate
            // 
            lblMOTExpDate.BackColor = Color.FromArgb(84, 84, 84);
            lblMOTExpDate.Font = new Font("Segoe UI", 16F);
            lblMOTExpDate.ForeColor = Color.White;
            lblMOTExpDate.Location = new Point(0, 300);
            lblMOTExpDate.Name = "lblMOTExpDate";
            lblMOTExpDate.Size = new Size(259, 36);
            lblMOTExpDate.TabIndex = 74;
            lblMOTExpDate.Text = "MOT expiration date:";
            lblMOTExpDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUpdRecord
            // 
            btnUpdRecord.Font = new Font("Segoe UI", 16F);
            btnUpdRecord.Location = new Point(20, 465);
            btnUpdRecord.Name = "btnUpdRecord";
            btnUpdRecord.Size = new Size(200, 70);
            btnUpdRecord.TabIndex = 69;
            btnUpdRecord.Text = "Update Van";
            btnUpdRecord.UseVisualStyleBackColor = true;
            btnUpdRecord.Click += btnUpdRecord_Click;
            // 
            // UpdateVan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(ckbxIsDrivable);
            Controls.Add(updnDriverID);
            Controls.Add(lblVID);
            Controls.Add(updnVID);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(txtbxVMake);
            Controls.Add(lblDriverID);
            Controls.Add(lblVMake);
            Controls.Add(txtbxMOTExpDate);
            Controls.Add(lblMOTExpDate);
            Controls.Add(btnUpdRecord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateVan";
            Text = "UpdateVan";
            ((System.ComponentModel.ISupportInitialize)updnDriverID).EndInit();
            ((System.ComponentModel.ISupportInitialize)updnVID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckbxIsDrivable;
        private NumericUpDown updnDriverID;
        private Label lblVID;
        private NumericUpDown updnVID;
        private Button btnHELP;
        private Button btnWipe;
        private TextBox txtbxVMake;
        private Label lblDriverID;
        private Label lblVMake;
        private TextBox txtbxMOTExpDate;
        private Label lblMOTExpDate;
        private Button btnUpdRecord;
    }
}