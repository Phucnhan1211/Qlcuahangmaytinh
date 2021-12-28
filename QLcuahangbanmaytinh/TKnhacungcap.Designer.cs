namespace QLcuahangbanmaytinh
{
    partial class frmtkncc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtkncc));
            this.dgvtkncc = new System.Windows.Forms.DataGridView();
            this.grptimkiem = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblmancc = new System.Windows.Forms.Label();
            this.lbltenncc = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkncc)).BeginInit();
            this.grptimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtkncc
            // 
            this.dgvtkncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtkncc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvtkncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtkncc.Location = new System.Drawing.Point(18, 338);
            this.dgvtkncc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvtkncc.Name = "dgvtkncc";
            this.dgvtkncc.RowHeadersWidth = 62;
            this.dgvtkncc.Size = new System.Drawing.Size(948, 231);
            this.dgvtkncc.TabIndex = 28;
            // 
            // grptimkiem
            // 
            this.grptimkiem.BackColor = System.Drawing.Color.PowderBlue;
            this.grptimkiem.Controls.Add(this.btntimkiem);
            this.grptimkiem.Controls.Add(this.txtdiachi);
            this.grptimkiem.Controls.Add(this.txtmancc);
            this.grptimkiem.Controls.Add(this.txttenncc);
            this.grptimkiem.Controls.Add(this.lbldiachi);
            this.grptimkiem.Controls.Add(this.lblmancc);
            this.grptimkiem.Controls.Add(this.lbltenncc);
            this.grptimkiem.Controls.Add(this.btnthoat);
            this.grptimkiem.Controls.Add(this.btnquaylai);
            this.grptimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptimkiem.Location = new System.Drawing.Point(18, 18);
            this.grptimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grptimkiem.Name = "grptimkiem";
            this.grptimkiem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grptimkiem.Size = new System.Drawing.Size(948, 311);
            this.grptimkiem.TabIndex = 27;
            this.grptimkiem.TabStop = false;
            this.grptimkiem.Text = "Tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Teal;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(591, 55);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(160, 58);
            this.btntimkiem.TabIndex = 51;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.White;
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(321, 235);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 33);
            this.txtdiachi.TabIndex = 50;
            // 
            // txtmancc
            // 
            this.txtmancc.BackColor = System.Drawing.Color.White;
            this.txtmancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmancc.Location = new System.Drawing.Point(321, 61);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(200, 33);
            this.txtmancc.TabIndex = 49;
            this.txtmancc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmancc_MouseClick);
            this.txtmancc.TextChanged += new System.EventHandler(this.txtmancc_TextChanged);
            // 
            // txttenncc
            // 
            this.txttenncc.BackColor = System.Drawing.Color.White;
            this.txttenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenncc.Location = new System.Drawing.Point(321, 154);
            this.txttenncc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(200, 33);
            this.txttenncc.TabIndex = 48;
            this.txttenncc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttenncc_MouseClick);
            this.txttenncc.TextChanged += new System.EventHandler(this.txttenncc_TextChanged);
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbldiachi.Location = new System.Drawing.Point(114, 235);
            this.lbldiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(86, 29);
            this.lbldiachi.TabIndex = 47;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblmancc
            // 
            this.lblmancc.AutoSize = true;
            this.lblmancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmancc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblmancc.Location = new System.Drawing.Point(114, 65);
            this.lblmancc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmancc.Name = "lblmancc";
            this.lblmancc.Size = new System.Drawing.Size(199, 29);
            this.lblmancc.TabIndex = 46;
            this.lblmancc.Text = "Mã Nhà cung cấp";
            // 
            // lbltenncc
            // 
            this.lbltenncc.AutoSize = true;
            this.lbltenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltenncc.Location = new System.Drawing.Point(114, 154);
            this.lbltenncc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenncc.Name = "lbltenncc";
            this.lbltenncc.Size = new System.Drawing.Size(209, 29);
            this.lbltenncc.TabIndex = 45;
            this.lbltenncc.Text = "Tên Nhà cung cấp";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Teal;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(591, 231);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(160, 58);
            this.btnthoat.TabIndex = 44;
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
            this.btnquaylai.Location = new System.Drawing.Point(591, 145);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(160, 58);
            this.btnquaylai.TabIndex = 43;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquaylai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // frmtkncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1005, 589);
            this.Controls.Add(this.dgvtkncc);
            this.Controls.Add(this.grptimkiem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmtkncc";
            this.Text = "Tìm kiếm nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkncc)).EndInit();
            this.grptimkiem.ResumeLayout(false);
            this.grptimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtkncc;
        private System.Windows.Forms.GroupBox grptimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblmancc;
        private System.Windows.Forms.Label lbltenncc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnquaylai;
    }
}