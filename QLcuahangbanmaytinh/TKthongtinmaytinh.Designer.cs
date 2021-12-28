namespace QLcuahangbanmaytinh
{
    partial class frmtkthongtinmaytinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtkthongtinmaytinh));
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttktheoten = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btntktheoten = new System.Windows.Forms.Button();
            this.btntktheoma = new System.Windows.Forms.Button();
            this.txttktheoma = new System.Windows.Forms.TextBox();
            this.dgvtkthongtinmaytinh = new System.Windows.Forms.DataGridView();
            this.grptimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkthongtinmaytinh)).BeginInit();
            this.SuspendLayout();
            // 
            // grptimkiem
            // 
            this.grptimkiem.BackColor = System.Drawing.Color.LightBlue;
            this.grptimkiem.Controls.Add(this.btnthoat);
            this.grptimkiem.Controls.Add(this.txttktheoten);
            this.grptimkiem.Controls.Add(this.btnquaylai);
            this.grptimkiem.Controls.Add(this.btntktheoten);
            this.grptimkiem.Controls.Add(this.btntktheoma);
            this.grptimkiem.Controls.Add(this.txttktheoma);
            this.grptimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grptimkiem.Location = new System.Drawing.Point(18, 18);
            this.grptimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grptimkiem.Size = new System.Drawing.Size(948, 263);
            this.grptimkiem.TabIndex = 21;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Teal;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(758, 167);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(141, 58);
            this.btnthoat.TabIndex = 44;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttktheoten
            // 
            this.txttktheoten.BackColor = System.Drawing.Color.White;
            this.txttktheoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttktheoten.Location = new System.Drawing.Point(144, 91);
            this.txttktheoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttktheoten.Name = "txttktheoten";
            this.txttktheoten.Size = new System.Drawing.Size(144, 30);
            this.txttktheoten.TabIndex = 17;
            this.txttktheoten.Text = "Nhập vào tên";
            this.txttktheoten.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoten_MouseClick);
            this.txttktheoten.TextChanged += new System.EventHandler(this.txttktheoten_TextChanged);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.Color.Teal;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Image = ((System.Drawing.Image)(resources.GetObject("btnquaylai.Image")));
            this.btnquaylai.Location = new System.Drawing.Point(565, 166);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(149, 58);
            this.btnquaylai.TabIndex = 43;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btntktheoten
            // 
            this.btntktheoten.BackColor = System.Drawing.Color.Teal;
            this.btntktheoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntktheoten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntktheoten.Image = ((System.Drawing.Image)(resources.GetObject("btntktheoten.Image")));
            this.btntktheoten.Location = new System.Drawing.Point(356, 71);
            this.btntktheoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntktheoten.Name = "btntktheoten";
            this.btntktheoten.Size = new System.Drawing.Size(177, 58);
            this.btntktheoten.TabIndex = 10;
            this.btntktheoten.Text = "TK theo tên";
            this.btntktheoten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntktheoten.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntktheoten.UseVisualStyleBackColor = false;
            this.btntktheoten.Click += new System.EventHandler(this.btntktheoten_Click);
            // 
            // btntktheoma
            // 
            this.btntktheoma.BackColor = System.Drawing.Color.Teal;
            this.btntktheoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntktheoma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntktheoma.Image = ((System.Drawing.Image)(resources.GetObject("btntktheoma.Image")));
            this.btntktheoma.Location = new System.Drawing.Point(356, 165);
            this.btntktheoma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntktheoma.Name = "btntktheoma";
            this.btntktheoma.Size = new System.Drawing.Size(177, 58);
            this.btntktheoma.TabIndex = 16;
            this.btntktheoma.Text = "TK theo mã";
            this.btntktheoma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntktheoma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntktheoma.UseVisualStyleBackColor = false;
            this.btntktheoma.Click += new System.EventHandler(this.btntktheoma_Click);
            // 
            // txttktheoma
            // 
            this.txttktheoma.BackColor = System.Drawing.Color.White;
            this.txttktheoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttktheoma.Location = new System.Drawing.Point(144, 166);
            this.txttktheoma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttktheoma.Name = "txttktheoma";
            this.txttktheoma.Size = new System.Drawing.Size(144, 30);
            this.txttktheoma.TabIndex = 18;
            this.txttktheoma.Text = "Nhập vào mã";
            this.txttktheoma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoma_MouseClick);
            this.txttktheoma.TextChanged += new System.EventHandler(this.txttktheoma_TextChanged);
            // 
            // dgvtkthongtinmaytinh
            // 
            this.dgvtkthongtinmaytinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtkthongtinmaytinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvtkthongtinmaytinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtkthongtinmaytinh.Location = new System.Drawing.Point(16, 291);
            this.dgvtkthongtinmaytinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvtkthongtinmaytinh.Name = "dgvtkthongtinmaytinh";
            this.dgvtkthongtinmaytinh.RowHeadersWidth = 62;
            this.dgvtkthongtinmaytinh.Size = new System.Drawing.Size(956, 231);
            this.dgvtkthongtinmaytinh.TabIndex = 22;
            // 
            // frmtkthongtinmaytinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(990, 543);
            this.Controls.Add(this.dgvtkthongtinmaytinh);
            this.Controls.Add(this.grptimkiem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmtkthongtinmaytinh";
            this.Text = "Tìm kiếm thông tin máy tính";
            this.Load += new System.EventHandler(this.frmtkthongtinmaytinh_Load);
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkthongtinmaytinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.TextBox txttktheoten;
        private System.Windows.Forms.Button btntktheoma;
        private System.Windows.Forms.TextBox txttktheoma;
        private System.Windows.Forms.DataGridView dgvtkthongtinmaytinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnquaylai;
        protected internal System.Windows.Forms.Button btntktheoten;
    }
}