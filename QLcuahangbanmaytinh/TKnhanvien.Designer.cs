namespace QLcuahangbanmaytinh
{
    partial class frmtknhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtknhanvien));
            this.dgvtknhanvien = new System.Windows.Forms.DataGridView();
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lbltennv = new System.Windows.Forms.Label();
            this.txttkdiachi = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtmanv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtknhanvien)).BeginInit();
            this.grptimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtknhanvien
            // 
            this.dgvtknhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtknhanvien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvtknhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtknhanvien.Location = new System.Drawing.Point(18, 362);
            this.dgvtknhanvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvtknhanvien.Name = "dgvtknhanvien";
            this.dgvtknhanvien.RowHeadersWidth = 62;
            this.dgvtknhanvien.Size = new System.Drawing.Size(956, 231);
            this.dgvtknhanvien.TabIndex = 24;
            // 
            // grptimkiem
            // 
            this.grptimkiem.BackColor = System.Drawing.Color.PowderBlue;
            this.grptimkiem.Controls.Add(this.lbldiachi);
            this.grptimkiem.Controls.Add(this.lblmanv);
            this.grptimkiem.Controls.Add(this.lbltennv);
            this.grptimkiem.Controls.Add(this.txttkdiachi);
            this.grptimkiem.Controls.Add(this.btnthoat);
            this.grptimkiem.Controls.Add(this.txttennv);
            this.grptimkiem.Controls.Add(this.btnquaylai);
            this.grptimkiem.Controls.Add(this.btntimkiem);
            this.grptimkiem.Controls.Add(this.txtmanv);
            this.grptimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptimkiem.Location = new System.Drawing.Point(18, 18);
            this.grptimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grptimkiem.Size = new System.Drawing.Size(948, 334);
            this.grptimkiem.TabIndex = 23;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbldiachi.Location = new System.Drawing.Point(148, 251);
            this.lbldiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(86, 29);
            this.lbldiachi.TabIndex = 50;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblmanv.Location = new System.Drawing.Point(148, 158);
            this.lblmanv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(159, 29);
            this.lblmanv.TabIndex = 49;
            this.lblmanv.Text = "Mã Nhân viên";
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltennv.Location = new System.Drawing.Point(148, 69);
            this.lbltennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(169, 29);
            this.lbltennv.TabIndex = 48;
            this.lbltennv.Text = "Tên Nhân viên";
            // 
            // txttkdiachi
            // 
            this.txttkdiachi.BackColor = System.Drawing.Color.White;
            this.txttkdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttkdiachi.Location = new System.Drawing.Point(346, 247);
            this.txttkdiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttkdiachi.Name = "txttkdiachi";
            this.txttkdiachi.Size = new System.Drawing.Size(144, 33);
            this.txttkdiachi.TabIndex = 46;
            this.txttkdiachi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdiachi_MouseClick);
            this.txttkdiachi.TextChanged += new System.EventHandler(this.txtdiachi_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Teal;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(579, 240);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(159, 58);
            this.btnthoat.TabIndex = 44;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttennv
            // 
            this.txttennv.BackColor = System.Drawing.Color.White;
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(346, 65);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(144, 33);
            this.txttennv.TabIndex = 17;
            this.txttennv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoten_MouseClick);
            this.txttennv.TextChanged += new System.EventHandler(this.txttktheoten_TextChanged);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Teal;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Image = ((System.Drawing.Image)(resources.GetObject("btnquaylai.Image")));
            this.btnquaylai.Location = new System.Drawing.Point(579, 148);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(159, 58);
            this.btnquaylai.TabIndex = 43;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Teal;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(579, 60);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(160, 58);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtmanv
            // 
            this.txtmanv.BackColor = System.Drawing.Color.White;
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(346, 158);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(144, 33);
            this.txtmanv.TabIndex = 18;
            this.txtmanv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoma_MouseClick);
            this.txtmanv.TextChanged += new System.EventHandler(this.txttktheoma_TextChanged);
            // 
            // frmtknhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 583);
            this.Controls.Add(this.dgvtknhanvien);
            this.Controls.Add(this.grptimkiem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmtknhanvien";
            this.Text = "Tìm kiếm Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtknhanvien)).EndInit();
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtknhanvien;
        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttkdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lbltennv;
    }
}