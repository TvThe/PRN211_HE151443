
using System;

namespace AutomobileApp
{
    partial class frmCarManagement
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
            this.lbCarID = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbReleaseYear = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(51, 41);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(50, 20);
            this.lbCarID.TabIndex = 0;
            this.lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(51, 86);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(75, 20);
            this.lbCarName.TabIndex = 1;
            this.lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(51, 130);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(97, 20);
            this.lbManufacturer.TabIndex = 2;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(444, 41);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 20);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            this.lbReleaseYear.AutoSize = true;
            this.lbReleaseYear.Location = new System.Drawing.Point(444, 86);
            this.lbReleaseYear.Name = "lbReleaseYear";
            this.lbReleaseYear.Size = new System.Drawing.Size(92, 20);
            this.lbReleaseYear.TabIndex = 4;
            this.lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(168, 34);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(258, 27);
            this.txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(168, 79);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(258, 27);
            this.txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(168, 123);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(258, 27);
            this.txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(548, 34);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(252, 27);
            this.txtPrice.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(548, 79);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(252, 27);
            this.txtReleaseYear.TabIndex = 9;
            // 
            // dgvCarList
            // 
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Location = new System.Drawing.Point(12, 216);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.ReadOnly = true;
            this.dgvCarList.RowHeadersWidth = 51;
            this.dgvCarList.RowTemplate.Height = 29;
            this.dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarList.Size = new System.Drawing.Size(776, 188);
            this.dgvCarList.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(332, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(168, 170);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(410, 170);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(694, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmCarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 451);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvCarList);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lbReleaseYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.lbCarID);
            this.Name = "frmCarManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Management";
            this.Load += new System.EventHandler(this.frmCarManagement_Load);
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
    }
}