
namespace MyWinApp
{
    partial class frmEmployeeDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEmployeeDetails = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.lbDegree = new System.Windows.Forms.Label();
            this.cboDegree = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmployeeDetails
            // 
            this.lbEmployeeDetails.AutoSize = true;
            this.lbEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEmployeeDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmployeeDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEmployeeDetails.Location = new System.Drawing.Point(252, 31);
            this.lbEmployeeDetails.Name = "lbEmployeeDetails";
            this.lbEmployeeDetails.Size = new System.Drawing.Size(245, 40);
            this.lbEmployeeDetails.TabIndex = 0;
            this.lbEmployeeDetails.Text = "Employee Details";
            
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmployeeID.Location = new System.Drawing.Point(71, 108);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(113, 25);
            this.lbEmployeeID.TabIndex = 1;
            this.lbEmployeeID.Text = "Employee ID";
            
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.AccessibleName = "";
            this.txtEmployeeID.Location = new System.Drawing.Point(252, 106);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(339, 27);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(71, 158);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(119, 20);
            this.lbEmployeeName.TabIndex = 3;
            this.lbEmployeeName.Text = "Employee Name";
            
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(252, 158);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(339, 27);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(71, 212);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(50, 20);
            this.lbPhone.TabIndex = 5;
            this.lbPhone.Text = "Phone";
            
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(71, 263);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(57, 20);
            this.lbGender.TabIndex = 7;
            this.lbGender.Text = "Gender";
            
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(252, 205);
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(339, 27);
            this.mtxtPhone.TabIndex = 8;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdFemale);
            this.gbGender.Controls.Add(this.rdMale);
            this.gbGender.Location = new System.Drawing.Point(252, 238);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(339, 53);
            this.gbGender.TabIndex = 9;
            this.gbGender.TabStop = false;
            
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(15, 21);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(63, 24);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(203, 21);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(78, 24);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // lbDegree
            // 
            this.lbDegree.AutoSize = true;
            this.lbDegree.Location = new System.Drawing.Point(71, 316);
            this.lbDegree.Name = "lbDegree";
            this.lbDegree.Size = new System.Drawing.Size(58, 20);
            this.lbDegree.TabIndex = 10;
            this.lbDegree.Text = "Degree";
            // 
            // cboDegree
            // 
            this.cboDegree.FormattingEnabled = true;
            this.cboDegree.Items.AddRange(new object[] {
            "Ph.D",
            "Master",
            "Engineer",
            "Bachelor",
            "Technician"});
            this.cboDegree.Location = new System.Drawing.Point(252, 308);
            this.cboDegree.Name = "cboDegree";
            this.cboDegree.Size = new System.Drawing.Size(339, 28);
            this.cboDegree.TabIndex = 11;
            this.cboDegree.Text = "---Select Degree---";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(252, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(497, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboDegree);
            this.Controls.Add(this.lbDegree);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lbEmployeeID);
            this.Controls.Add(this.lbEmployeeDetails);
            this.Name = "frmEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDetails";

            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmployeeDetails;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label lbDegree;
        private System.Windows.Forms.ComboBox cboDegree;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

