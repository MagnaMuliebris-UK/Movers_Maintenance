namespace Movers_Maintenance_Subsystem.AdditionalForms.Adds
{
    partial class AddVan
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
            cbxIsFitToDrive = new CheckBox();
            txtbxVMake = new TextBox();
            lblDriverID = new Label();
            lblVMake = new Label();
            txtbxDriverID = new TextBox();
            lblMOTExpDate = new Label();
            btnAddRecord = new Button();
            txtbxMOTExpDate = new TextBox();
            SuspendLayout();
            // 
            // btnHELP
            // 
            btnHELP.Font = new Font("Segoe UI", 14F);
            btnHELP.Location = new Point(480, 15);
            btnHELP.Name = "btnHELP";
            btnHELP.Size = new Size(80, 40);
            btnHELP.TabIndex = 72;
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
            btnWipe.TabIndex = 71;
            btnWipe.Text = "Wipe Page";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // cbxIsFitToDrive
            // 
            cbxIsFitToDrive.CheckAlign = ContentAlignment.BottomCenter;
            cbxIsFitToDrive.Font = new Font("Segoe UI", 16F);
            cbxIsFitToDrive.ForeColor = Color.White;
            cbxIsFitToDrive.Location = new Point(0, 365);
            cbxIsFitToDrive.Name = "cbxIsFitToDrive";
            cbxIsFitToDrive.Size = new Size(570, 45);
            cbxIsFitToDrive.TabIndex = 64;
            cbxIsFitToDrive.Text = "Is this van in the condition to be driven?";
            cbxIsFitToDrive.TextAlign = ContentAlignment.MiddleCenter;
            cbxIsFitToDrive.UseVisualStyleBackColor = true;
            // 
            // txtbxVMake
            // 
            txtbxVMake.Font = new Font("Segoe UI", 16F);
            txtbxVMake.Location = new Point(260, 95);
            txtbxVMake.Name = "txtbxVMake";
            txtbxVMake.Size = new Size(240, 36);
            txtbxVMake.TabIndex = 66;
            // 
            // lblDriverID
            // 
            lblDriverID.BackColor = Color.FromArgb(84, 84, 84);
            lblDriverID.Font = new Font("Segoe UI", 16F);
            lblDriverID.ForeColor = Color.White;
            lblDriverID.Location = new Point(135, 185);
            lblDriverID.Name = "lblDriverID";
            lblDriverID.Size = new Size(120, 36);
            lblDriverID.TabIndex = 67;
            lblDriverID.Text = "Driver ID:";
            lblDriverID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVMake
            // 
            lblVMake.BackColor = Color.FromArgb(84, 84, 84);
            lblVMake.Font = new Font("Segoe UI", 16F);
            lblVMake.ForeColor = Color.White;
            lblVMake.Location = new Point(135, 95);
            lblVMake.Name = "lblVMake";
            lblVMake.Size = new Size(120, 36);
            lblVMake.TabIndex = 65;
            lblVMake.Text = "Van make:";
            lblVMake.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxDriverID
            // 
            txtbxDriverID.Font = new Font("Segoe UI", 16F);
            txtbxDriverID.Location = new Point(260, 185);
            txtbxDriverID.Name = "txtbxDriverID";
            txtbxDriverID.Size = new Size(240, 36);
            txtbxDriverID.TabIndex = 68;
            // 
            // lblMOTExpDate
            // 
            lblMOTExpDate.BackColor = Color.FromArgb(84, 84, 84);
            lblMOTExpDate.Font = new Font("Segoe UI", 16F);
            lblMOTExpDate.ForeColor = Color.White;
            lblMOTExpDate.Location = new Point(30, 275);
            lblMOTExpDate.Name = "lblMOTExpDate";
            lblMOTExpDate.Size = new Size(225, 36);
            lblMOTExpDate.TabIndex = 69;
            lblMOTExpDate.Text = "MOT expiration date:";
            lblMOTExpDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Font = new Font("Segoe UI", 16F);
            btnAddRecord.Location = new Point(20, 465);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(200, 70);
            btnAddRecord.TabIndex = 63;
            btnAddRecord.Text = "Add Van";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // txtbxMOTExpDate
            // 
            txtbxMOTExpDate.Font = new Font("Segoe UI", 16F);
            txtbxMOTExpDate.Location = new Point(260, 275);
            txtbxMOTExpDate.Name = "txtbxMOTExpDate";
            txtbxMOTExpDate.PlaceholderText = "dd-mm-yyyy";
            txtbxMOTExpDate.Size = new Size(240, 36);
            txtbxMOTExpDate.TabIndex = 70;
            // 
            // AddVan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 84, 84);
            ClientSize = new Size(570, 550);
            Controls.Add(btnHELP);
            Controls.Add(btnWipe);
            Controls.Add(cbxIsFitToDrive);
            Controls.Add(txtbxVMake);
            Controls.Add(lblDriverID);
            Controls.Add(lblVMake);
            Controls.Add(txtbxDriverID);
            Controls.Add(lblMOTExpDate);
            Controls.Add(btnAddRecord);
            Controls.Add(txtbxMOTExpDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddVan";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHELP;
        private Button btnWipe;
        private CheckBox cbxIsFitToDrive;
        private TextBox txtbxVMake;
        private Label lblDriverID;
        private Label lblVMake;
        private TextBox txtbxDriverID;
        private Label lblMOTExpDate;
        private Button btnAddRecord;
        private TextBox txtbxMOTExpDate;
    }
}