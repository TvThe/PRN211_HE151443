
namespace AutomobileApp
{
    partial class frmCarDetails
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
            this.lbCarID = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.lbCarName = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.mtxtPrice = new System.Windows.Forms.MaskedTextBox();
            this.lbReleaseYear = new System.Windows.Forms.Label();
            this.mtxtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(96, 81);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(50, 20);
            this.lbCarID.TabIndex = 0;
            this.lbCarID.Text = "Car ID";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(203, 74);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(335, 27);
            this.txtCarID.TabIndex = 2;
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(96, 136);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(75, 20);
            this.lbCarName.TabIndex = 3;
            this.lbCarName.Text = "Car Name";
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(203, 129);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(335, 27);
            this.txtCarName.TabIndex = 4;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(96, 189);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(97, 20);
            this.lbManufacturer.TabIndex = 5;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Items.AddRange(new object[] {
            "Items:",
            "Audi",
            "BMW",
            "Ford",
            "Honda",
            "Hyundai",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.cboManufacturer.Location = new System.Drawing.Point(203, 181);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(335, 28);
            this.cboManufacturer.TabIndex = 6;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(96, 233);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 20);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Price";
            // 
            // mtxtPrice
            // 
            this.mtxtPrice.Location = new System.Drawing.Point(203, 226);
            this.mtxtPrice.Mask = "000000000";
            this.mtxtPrice.Name = "mtxtPrice";
            this.mtxtPrice.Size = new System.Drawing.Size(335, 27);
            this.mtxtPrice.TabIndex = 8;
            this.mtxtPrice.Text = "0";
            // 
            // lbReleaseYear
            // 
            this.lbReleaseYear.AutoSize = true;
            this.lbReleaseYear.Location = new System.Drawing.Point(96, 275);
            this.lbReleaseYear.Name = "lbReleaseYear";
            this.lbReleaseYear.Size = new System.Drawing.Size(92, 20);
            this.lbReleaseYear.TabIndex = 9;
            this.lbReleaseYear.Text = "Release Year";
            // 
            // mtxtReleaseYear
            // 
            this.mtxtReleaseYear.Location = new System.Drawing.Point(203, 268);
            this.mtxtReleaseYear.Mask = "0000";
            this.mtxtReleaseYear.Name = "mtxtReleaseYear";
            this.mtxtReleaseYear.Size = new System.Drawing.Size(335, 27);
            this.mtxtReleaseYear.TabIndex = 11;
            this.mtxtReleaseYear.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(203, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(444, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mtxtReleaseYear);
            this.Controls.Add(this.lbReleaseYear);
            this.Controls.Add(this.mtxtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lbCarID);
            this.Name = "frmCarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarDetails";
            this.Load += new System.EventHandler(this.frmCarDetails_Load);
            this.Click += new System.EventHandler(this.btnCancel_Click);
            this.Click += new System.EventHandler(this.btnSave_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.MaskedTextBox mtxtPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.MaskedTextBox mtxtReleaseYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

