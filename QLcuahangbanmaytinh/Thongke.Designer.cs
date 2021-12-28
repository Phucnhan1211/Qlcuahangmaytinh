namespace QLcuahangbanmaytinh
{
    partial class frmthongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthongke));
            this.grpthongke = new System.Windows.Forms.GroupBox();
            this.mtbThangnam = new System.Windows.Forms.MaskedTextBox();
            this.lblthangnam = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.rdbHDB = new System.Windows.Forms.RadioButton();
            this.rdbHDN = new System.Windows.Forms.RadioButton();
            this.dgvTimkiem = new System.Windows.Forms.DataGridView();
            this.grpthongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // grpthongke
            // 
            this.grpthongke.BackColor = System.Drawing.Color.PowderBlue;
            this.grpthongke.Controls.Add(this.mtbThangnam);
            this.grpthongke.Controls.Add(this.lblthangnam);
            this.grpthongke.Controls.Add(this.btnthoat);
            this.grpthongke.Controls.Add(this.btnThongke);
            this.grpthongke.Controls.Add(this.btnquaylai);
            this.grpthongke.Controls.Add(this.rdbHDB);
            this.grpthongke.Controls.Add(this.rdbHDN);
            this.grpthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpthongke.Location = new System.Drawing.Point(18, 18);
            this.grpthongke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongke.Name = "grpthongke";
            this.grpthongke.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpthongke.Size = new System.Drawing.Size(1066, 309);
            this.grpthongke.TabIndex = 44;
            this.grpthongke.TabStop = false;
            this.grpthongke.Text = "Thống kê";
            // 
            // mtbThangnam
            // 
            this.mtbThangnam.BackColor = System.Drawing.Color.White;
            this.mtbThangnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbThangnam.Location = new System.Drawing.Point(398, 69);
            this.mtbThangnam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbThangnam.Mask = "00/00/0000";
            this.mtbThangnam.Name = "mtbThangnam";
            this.mtbThangnam.Size = new System.Drawing.Size(148, 30);
            this.mtbThangnam.TabIndex = 43;
            this.mtbThangnam.ValidatingType = typeof(System.DateTime);
            // 
            // lblthangnam
            // 
            this.lblthangnam.AutoSize = true;
            this.lblthangnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthangnam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblthangnam.Location = new System.Drawing.Point(252, 74);
            this.lblthangnam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthangnam.Name = "lblthangnam";
            this.lblthangnam.Size = new System.Drawing.Size(134, 29);
            this.lblthangnam.TabIndex = 25;
            this.lblthangnam.Text = "Tháng năm";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Teal;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(699, 226);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(141, 58);
            this.btnthoat.TabIndex = 42;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.Teal;
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.Location = new System.Drawing.Point(207, 226);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(169, 58);
            this.btnThongke.TabIndex = 18;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Teal;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Image = ((System.Drawing.Image)(resources.GetObject("btnquaylai.Image")));
            this.btnquaylai.Location = new System.Drawing.Point(466, 226);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(151, 58);
            this.btnquaylai.TabIndex = 23;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // rdbHDB
            // 
            this.rdbHDB.AutoSize = true;
            this.rdbHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdbHDB.Location = new System.Drawing.Point(652, 122);
            this.rdbHDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbHDB.Name = "rdbHDB";
            this.rdbHDB.Size = new System.Drawing.Size(175, 33);
            this.rdbHDB.TabIndex = 28;
            this.rdbHDB.TabStop = true;
            this.rdbHDB.Text = "Hóa đơn bán";
            this.rdbHDB.UseVisualStyleBackColor = true;
            // 
            // rdbHDN
            // 
            this.rdbHDN.AutoSize = true;
            this.rdbHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdbHDN.Location = new System.Drawing.Point(652, 68);
            this.rdbHDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbHDN.Name = "rdbHDN";
            this.rdbHDN.Size = new System.Drawing.Size(188, 33);
            this.rdbHDN.TabIndex = 28;
            this.rdbHDN.TabStop = true;
            this.rdbHDN.Text = "Hóa đơn nhập";
            this.rdbHDN.UseVisualStyleBackColor = true;
            // 
            // dgvTimkiem
            // 
            this.dgvTimkiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimkiem.Location = new System.Drawing.Point(18, 337);
            this.dgvTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTimkiem.Name = "dgvTimkiem";
            this.dgvTimkiem.RowHeadersWidth = 62;
            this.dgvTimkiem.Size = new System.Drawing.Size(1066, 283);
            this.dgvTimkiem.TabIndex = 45;
            // 
            // frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1112, 638);
            this.Controls.Add(this.dgvTimkiem);
            this.Controls.Add(this.grpthongke);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmthongke";
            this.Text = "Thống kê";
            this.grpthongke.ResumeLayout(false);
            this.grpthongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpthongke;
        private System.Windows.Forms.Label lblthangnam;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.RadioButton rdbHDB;
        private System.Windows.Forms.RadioButton rdbHDN;
        private System.Windows.Forms.DataGridView dgvTimkiem;
        private System.Windows.Forms.MaskedTextBox mtbThangnam;
    }
}