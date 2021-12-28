namespace QLcuahangbanmaytinh
{
    partial class frmkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkhachhang));
            this.grpquanlykhachhang = new System.Windows.Forms.GroupBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lbltenkh = new System.Windows.Forms.Label();
            this.lblmakh = new System.Windows.Forms.Label();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.clmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpquanlykhachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpquanlykhachhang
            // 
            this.grpquanlykhachhang.BackColor = System.Drawing.Color.PowderBlue;
            this.grpquanlykhachhang.Controls.Add(this.txtgioitinh);
            this.grpquanlykhachhang.Controls.Add(this.btnthoat);
            this.grpquanlykhachhang.Controls.Add(this.btnquaylai);
            this.grpquanlykhachhang.Controls.Add(this.btnxoa);
            this.grpquanlykhachhang.Controls.Add(this.btnsua);
            this.grpquanlykhachhang.Controls.Add(this.btnthem);
            this.grpquanlykhachhang.Controls.Add(this.btnlammoi);
            this.grpquanlykhachhang.Controls.Add(this.txtsdt);
            this.grpquanlykhachhang.Controls.Add(this.txtdiachi);
            this.grpquanlykhachhang.Controls.Add(this.txttenkh);
            this.grpquanlykhachhang.Controls.Add(this.txtmakh);
            this.grpquanlykhachhang.Controls.Add(this.lblsdt);
            this.grpquanlykhachhang.Controls.Add(this.lbldiachi);
            this.grpquanlykhachhang.Controls.Add(this.lblgioitinh);
            this.grpquanlykhachhang.Controls.Add(this.lbltenkh);
            this.grpquanlykhachhang.Controls.Add(this.lblmakh);
            this.grpquanlykhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpquanlykhachhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpquanlykhachhang.Location = new System.Drawing.Point(18, 18);
            this.grpquanlykhachhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpquanlykhachhang.Name = "grpquanlykhachhang";
            this.grpquanlykhachhang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpquanlykhachhang.Size = new System.Drawing.Size(1148, 389);
            this.grpquanlykhachhang.TabIndex = 2;
            this.grpquanlykhachhang.TabStop = false;
            this.grpquanlykhachhang.Text = "Quản lý khách hàng";
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.BackColor = System.Drawing.Color.White;
            this.txtgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgioitinh.Location = new System.Drawing.Point(313, 223);
            this.txtgioitinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(204, 30);
            this.txtgioitinh.TabIndex = 44;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Teal;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(958, 303);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(130, 58);
            this.btnthoat.TabIndex = 43;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Teal;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Image = ((System.Drawing.Image)(resources.GetObject("btnquaylai.Image")));
            this.btnquaylai.Location = new System.Drawing.Point(766, 303);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(160, 58);
            this.btnquaylai.TabIndex = 14;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Teal;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(590, 303);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(130, 58);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Teal;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(410, 303);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(130, 58);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Teal;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(236, 303);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(130, 58);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.Teal;
            this.btnlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnlammoi.Image")));
            this.btnlammoi.Location = new System.Drawing.Point(56, 303);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(151, 58);
            this.btnlammoi.TabIndex = 10;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.White;
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(750, 138);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(204, 30);
            this.txtsdt.TabIndex = 9;
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.White;
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(750, 62);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(204, 30);
            this.txtdiachi.TabIndex = 8;
            // 
            // txttenkh
            // 
            this.txttenkh.BackColor = System.Drawing.Color.White;
            this.txttenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.Location = new System.Drawing.Point(313, 138);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(204, 30);
            this.txttenkh.TabIndex = 6;
            // 
            // txtmakh
            // 
            this.txtmakh.BackColor = System.Drawing.Color.White;
            this.txtmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Location = new System.Drawing.Point(313, 63);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(204, 30);
            this.txtmakh.TabIndex = 5;
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblsdt.Location = new System.Drawing.Point(586, 140);
            this.lblsdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(154, 29);
            this.lblsdt.TabIndex = 4;
            this.lblsdt.Text = "Số điện thoại";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbldiachi.Location = new System.Drawing.Point(586, 63);
            this.lbldiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(91, 29);
            this.lbldiachi.TabIndex = 3;
            this.lbldiachi.Text = "Địa Chỉ";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblgioitinh.Location = new System.Drawing.Point(106, 223);
            this.lblgioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(101, 29);
            this.lblgioitinh.TabIndex = 2;
            this.lblgioitinh.Text = "Giới tính";
            // 
            // lbltenkh
            // 
            this.lbltenkh.AutoSize = true;
            this.lbltenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltenkh.Location = new System.Drawing.Point(106, 140);
            this.lbltenkh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenkh.Name = "lbltenkh";
            this.lbltenkh.Size = new System.Drawing.Size(188, 29);
            this.lbltenkh.TabIndex = 1;
            this.lbltenkh.Text = "Tên Khách hàng";
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblmakh.Location = new System.Drawing.Point(106, 63);
            this.lblmakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(178, 29);
            this.lblmakh.TabIndex = 0;
            this.lblmakh.Text = "Mã Khách hàng";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkhachhang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmakh,
            this.cltenkh,
            this.clgioitinh,
            this.cldiachi,
            this.clsdt});
            this.dgvkhachhang.Location = new System.Drawing.Point(16, 417);
            this.dgvkhachhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.RowHeadersWidth = 62;
            this.dgvkhachhang.Size = new System.Drawing.Size(1149, 231);
            this.dgvkhachhang.TabIndex = 3;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // clmakh
            // 
            this.clmakh.DataPropertyName = "MaKH";
            this.clmakh.HeaderText = "Mã KH";
            this.clmakh.MinimumWidth = 8;
            this.clmakh.Name = "clmakh";
            // 
            // cltenkh
            // 
            this.cltenkh.DataPropertyName = "TenKH";
            this.cltenkh.HeaderText = "Tên KH";
            this.cltenkh.MinimumWidth = 8;
            this.cltenkh.Name = "cltenkh";
            // 
            // clgioitinh
            // 
            this.clgioitinh.DataPropertyName = "Gioitinh";
            this.clgioitinh.HeaderText = "Giới tính";
            this.clgioitinh.MinimumWidth = 8;
            this.clgioitinh.Name = "clgioitinh";
            // 
            // cldiachi
            // 
            this.cldiachi.DataPropertyName = "Diachi";
            this.cldiachi.HeaderText = "Địa chỉ";
            this.cldiachi.MinimumWidth = 8;
            this.cldiachi.Name = "cldiachi";
            // 
            // clsdt
            // 
            this.clsdt.DataPropertyName = "sdt";
            this.clsdt.HeaderText = "Số điện thoại";
            this.clsdt.MinimumWidth = 8;
            this.clsdt.Name = "clsdt";
            // 
            // frmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 662);
            this.Controls.Add(this.dgvkhachhang);
            this.Controls.Add(this.grpquanlykhachhang);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmkhachhang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmkhachhang_Load);
            this.grpquanlykhachhang.ResumeLayout(false);
            this.grpquanlykhachhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpquanlykhachhang;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lbltenkh;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
    }
}