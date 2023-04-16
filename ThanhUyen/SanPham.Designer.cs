namespace ThanhUyen
{
    partial class SanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grBoxCapNhatSP = new System.Windows.Forms.GroupBox();
            this.cb_mncc = new System.Windows.Forms.ComboBox();
            this.labeltimk = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.butSua = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grBoxCapNhatSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxCapNhatSP
            // 
            this.grBoxCapNhatSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grBoxCapNhatSP.Controls.Add(this.cb_mncc);
            this.grBoxCapNhatSP.Controls.Add(this.labeltimk);
            this.grBoxCapNhatSP.Controls.Add(this.dataGridView2);
            this.grBoxCapNhatSP.Controls.Add(this.butSua);
            this.grBoxCapNhatSP.Controls.Add(this.butAdd);
            this.grBoxCapNhatSP.Controls.Add(this.txtGiaBan);
            this.grBoxCapNhatSP.Controls.Add(this.txtSoLuong);
            this.grBoxCapNhatSP.Controls.Add(this.txtTenSP);
            this.grBoxCapNhatSP.Controls.Add(this.txtMaSP);
            this.grBoxCapNhatSP.Controls.Add(this.lbGiaBan);
            this.grBoxCapNhatSP.Controls.Add(this.lbSoLuong);
            this.grBoxCapNhatSP.Controls.Add(this.lbMaNCC);
            this.grBoxCapNhatSP.Controls.Add(this.lbTenSP);
            this.grBoxCapNhatSP.Controls.Add(this.lbMaSP);
            this.grBoxCapNhatSP.Controls.Add(this.txtTimKiem);
            this.grBoxCapNhatSP.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCapNhatSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grBoxCapNhatSP.Location = new System.Drawing.Point(2, 11);
            this.grBoxCapNhatSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxCapNhatSP.Name = "grBoxCapNhatSP";
            this.grBoxCapNhatSP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxCapNhatSP.Size = new System.Drawing.Size(1023, 724);
            this.grBoxCapNhatSP.TabIndex = 1;
            this.grBoxCapNhatSP.TabStop = false;
            this.grBoxCapNhatSP.Text = "Sản Phẩm";
            this.grBoxCapNhatSP.Enter += new System.EventHandler(this.grBoxCapNhatSP_Enter);
            // 
            // cb_mncc
            // 
            this.cb_mncc.ForeColor = System.Drawing.Color.Black;
            this.cb_mncc.FormattingEnabled = true;
            this.cb_mncc.Location = new System.Drawing.Point(205, 221);
            this.cb_mncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_mncc.Name = "cb_mncc";
            this.cb_mncc.Size = new System.Drawing.Size(195, 35);
            this.cb_mncc.TabIndex = 19;
            this.cb_mncc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labeltimk
            // 
            this.labeltimk.AutoSize = true;
            this.labeltimk.BackColor = System.Drawing.Color.Transparent;
            this.labeltimk.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labeltimk.ForeColor = System.Drawing.Color.White;
            this.labeltimk.Location = new System.Drawing.Point(420, 225);
            this.labeltimk.Name = "labeltimk";
            this.labeltimk.Size = new System.Drawing.Size(103, 25);
            this.labeltimk.TabIndex = 18;
            this.labeltimk.Text = "Tìm kiếm";
            this.labeltimk.Click += new System.EventHandler(this.labeltimk_Click);
            this.labeltimk.Enter += new System.EventHandler(this.label1_Enter);
            this.labeltimk.Leave += new System.EventHandler(this.label1_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(11, 306);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1017, 469);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // butSua
            // 
            this.butSua.AutoSize = true;
            this.butSua.BackColor = System.Drawing.Color.Gray;
            this.butSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butSua.ForeColor = System.Drawing.Color.White;
            this.butSua.Location = new System.Drawing.Point(810, 178);
            this.butSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(180, 50);
            this.butSua.TabIndex = 13;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = false;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butAdd
            // 
            this.butAdd.AutoSize = true;
            this.butAdd.BackColor = System.Drawing.Color.Gray;
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Location = new System.Drawing.Point(810, 103);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(180, 50);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "Thêm";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(544, 136);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(182, 34);
            this.txtGiaBan.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(544, 58);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(112, 34);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtTenSP
            // 
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.Location = new System.Drawing.Point(205, 131);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(195, 34);
            this.txtTenSP.TabIndex = 8;
            // 
            // txtMaSP
            // 
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.Location = new System.Drawing.Point(205, 58);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(200, 34);
            this.txtMaSP.TabIndex = 7;
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaBan.ForeColor = System.Drawing.Color.White;
            this.lbGiaBan.Location = new System.Drawing.Point(420, 140);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(96, 26);
            this.lbGiaBan.TabIndex = 6;
            this.lbGiaBan.Text = "Giá Bán";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoLuong.ForeColor = System.Drawing.Color.White;
            this.lbSoLuong.Location = new System.Drawing.Point(420, 61);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(111, 26);
            this.lbSoLuong.TabIndex = 5;
            this.lbSoLuong.Text = "Số Lượng";
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNCC.ForeColor = System.Drawing.Color.White;
            this.lbMaNCC.Location = new System.Drawing.Point(7, 225);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(204, 26);
            this.lbMaNCC.TabIndex = 4;
            this.lbMaNCC.Text = "Mã Nhà Cung Cấp";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenSP.ForeColor = System.Drawing.Color.White;
            this.lbTenSP.Location = new System.Drawing.Point(27, 136);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(160, 26);
            this.lbTenSP.TabIndex = 3;
            this.lbTenSP.Text = "Tên Sản Phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaSP.ForeColor = System.Drawing.Color.White;
            this.lbMaSP.Location = new System.Drawing.Point(27, 61);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(156, 26);
            this.lbMaSP.TabIndex = 2;
            this.lbMaSP.Text = "Mã Sản Phẩm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.Location = new System.Drawing.Point(544, 221);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(182, 37);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 750);
            this.Controls.Add(this.grBoxCapNhatSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.grBoxCapNhatSP.ResumeLayout(false);
            this.grBoxCapNhatSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grBoxCapNhatSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labeltimk;
        private System.Windows.Forms.ComboBox cb_mncc;
    }
}