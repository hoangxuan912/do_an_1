namespace ThanhUyen
{
    partial class Nha_cung_cap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grBoxCapNhatNCC = new System.Windows.Forms.GroupBox();
            this.dataGridViewncc = new System.Windows.Forms.DataGridView();
            this.butSua = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lbSodt = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            this.lbTenCongTyNCC = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.grBoxCapNhatNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewncc)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxCapNhatNCC
            // 
            this.grBoxCapNhatNCC.BackColor = System.Drawing.Color.Transparent;
            this.grBoxCapNhatNCC.Controls.Add(this.dataGridViewncc);
            this.grBoxCapNhatNCC.Controls.Add(this.butSua);
            this.grBoxCapNhatNCC.Controls.Add(this.butAdd);
            this.grBoxCapNhatNCC.Controls.Add(this.txtDiaChi);
            this.grBoxCapNhatNCC.Controls.Add(this.txtSodt);
            this.grBoxCapNhatNCC.Controls.Add(this.txtTenCT);
            this.grBoxCapNhatNCC.Controls.Add(this.txtMaNCC);
            this.grBoxCapNhatNCC.Controls.Add(this.lbSodt);
            this.grBoxCapNhatNCC.Controls.Add(this.lbDC);
            this.grBoxCapNhatNCC.Controls.Add(this.lbTenCongTyNCC);
            this.grBoxCapNhatNCC.Controls.Add(this.lb);
            this.grBoxCapNhatNCC.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCapNhatNCC.ForeColor = System.Drawing.Color.White;
            this.grBoxCapNhatNCC.Location = new System.Drawing.Point(14, 1);
            this.grBoxCapNhatNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxCapNhatNCC.Name = "grBoxCapNhatNCC";
            this.grBoxCapNhatNCC.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxCapNhatNCC.Size = new System.Drawing.Size(1052, 734);
            this.grBoxCapNhatNCC.TabIndex = 4;
            this.grBoxCapNhatNCC.TabStop = false;
            this.grBoxCapNhatNCC.Text = "Nhà Cung Cấp ";
            this.grBoxCapNhatNCC.Enter += new System.EventHandler(this.grBoxCapNhatNCC_Enter);
            // 
            // dataGridViewncc
            // 
            this.dataGridViewncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewncc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewncc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewncc.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewncc.Location = new System.Drawing.Point(0, 284);
            this.dataGridViewncc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewncc.Name = "dataGridViewncc";
            this.dataGridViewncc.RowHeadersWidth = 51;
            this.dataGridViewncc.RowTemplate.Height = 24;
            this.dataGridViewncc.Size = new System.Drawing.Size(1023, 424);
            this.dataGridViewncc.TabIndex = 17;
            this.dataGridViewncc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewncc_CellContentClick_1);
            // 
            // butSua
            // 
            this.butSua.AutoSize = true;
            this.butSua.BackColor = System.Drawing.Color.Gray;
            this.butSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butSua.ForeColor = System.Drawing.Color.White;
            this.butSua.Location = new System.Drawing.Point(775, 162);
            this.butSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(207, 62);
            this.butSua.TabIndex = 13;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = false;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butAdd
            // 
            this.butAdd.AutoSize = true;
            this.butAdd.BackColor = System.Drawing.Color.Gray;
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Location = new System.Drawing.Point(775, 60);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(207, 64);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "Thêm";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(145, 216);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(539, 34);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtSodt
            // 
            this.txtSodt.Location = new System.Drawing.Point(428, 60);
            this.txtSodt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(256, 34);
            this.txtSodt.TabIndex = 9;
            this.txtSodt.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtTenCT
            // 
            this.txtTenCT.ForeColor = System.Drawing.Color.Black;
            this.txtTenCT.Location = new System.Drawing.Point(148, 137);
            this.txtTenCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(536, 34);
            this.txtTenCT.TabIndex = 8;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.ForeColor = System.Drawing.Color.Black;
            this.txtMaNCC.Location = new System.Drawing.Point(148, 60);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(196, 34);
            this.txtMaNCC.TabIndex = 7;
            // 
            // lbSodt
            // 
            this.lbSodt.AutoSize = true;
            this.lbSodt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSodt.ForeColor = System.Drawing.Color.White;
            this.lbSodt.Location = new System.Drawing.Point(365, 63);
            this.lbSodt.Name = "lbSodt";
            this.lbSodt.Size = new System.Drawing.Size(57, 26);
            this.lbSodt.TabIndex = 5;
            this.lbSodt.Text = "SDT";
            this.lbSodt.Click += new System.EventHandler(this.lbSodt_Click);
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDC.ForeColor = System.Drawing.Color.White;
            this.lbDC.Location = new System.Drawing.Point(7, 219);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(91, 26);
            this.lbDC.TabIndex = 4;
            this.lbDC.Text = "Địa Chỉ";
            this.lbDC.Click += new System.EventHandler(this.lbDC_Click);
            // 
            // lbTenCongTyNCC
            // 
            this.lbTenCongTyNCC.AutoSize = true;
            this.lbTenCongTyNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenCongTyNCC.ForeColor = System.Drawing.Color.White;
            this.lbTenCongTyNCC.Location = new System.Drawing.Point(7, 140);
            this.lbTenCongTyNCC.Name = "lbTenCongTyNCC";
            this.lbTenCongTyNCC.Size = new System.Drawing.Size(142, 26);
            this.lbTenCongTyNCC.TabIndex = 3;
            this.lbTenCongTyNCC.Text = "Tên Công Ty";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(7, 61);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(104, 26);
            this.lb.TabIndex = 2;
            this.lb.Text = "Mã NCC";
            // 
            // Nha_cung_cap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 750);
            this.Controls.Add(this.grBoxCapNhatNCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Nha_cung_cap";
            this.Text = "Nhà_Cung_Cấp";
            this.Load += new System.EventHandler(this.Nha_cung_cap_Load);
            this.grBoxCapNhatNCC.ResumeLayout(false);
            this.grBoxCapNhatNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewncc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grBoxCapNhatNCC;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lbSodt;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label lbTenCongTyNCC;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.DataGridView dataGridViewncc;
    }
}