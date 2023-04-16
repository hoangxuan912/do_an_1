namespace ThanhUyen
{
    partial class TaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grBoxCapNhatNCC = new System.Windows.Forms.GroupBox();
            this.dataGridViewTK = new System.Windows.Forms.DataGridView();
            this.comboBoxtruycap = new System.Windows.Forms.ComboBox();
            this.butXoa = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.lbSodt = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            this.lbTenCongTyNCC = new System.Windows.Forms.Label();
            this.lbNCC = new System.Windows.Forms.Label();
            this.grBoxCapNhatNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxCapNhatNCC
            // 
            this.grBoxCapNhatNCC.BackColor = System.Drawing.Color.Transparent;
            this.grBoxCapNhatNCC.Controls.Add(this.dataGridViewTK);
            this.grBoxCapNhatNCC.Controls.Add(this.comboBoxtruycap);
            this.grBoxCapNhatNCC.Controls.Add(this.butXoa);
            this.grBoxCapNhatNCC.Controls.Add(this.butAdd);
            this.grBoxCapNhatNCC.Controls.Add(this.txt_mk);
            this.grBoxCapNhatNCC.Controls.Add(this.txtTenTK);
            this.grBoxCapNhatNCC.Controls.Add(this.lbSodt);
            this.grBoxCapNhatNCC.Controls.Add(this.lbDC);
            this.grBoxCapNhatNCC.Controls.Add(this.lbTenCongTyNCC);
            this.grBoxCapNhatNCC.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCapNhatNCC.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.grBoxCapNhatNCC.Location = new System.Drawing.Point(14, 89);
            this.grBoxCapNhatNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxCapNhatNCC.Name = "grBoxCapNhatNCC";
            this.grBoxCapNhatNCC.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxCapNhatNCC.Size = new System.Drawing.Size(1023, 510);
            this.grBoxCapNhatNCC.TabIndex = 5;
            this.grBoxCapNhatNCC.TabStop = false;
            this.grBoxCapNhatNCC.Enter += new System.EventHandler(this.grBoxCapNhatNCC_Enter);
            // 
            // dataGridViewTK
            // 
            this.dataGridViewTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTK.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTK.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTK.Location = new System.Drawing.Point(16, 208);
            this.dataGridViewTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTK.Name = "dataGridViewTK";
            this.dataGridViewTK.RowHeadersWidth = 62;
            this.dataGridViewTK.RowTemplate.Height = 28;
            this.dataGridViewTK.Size = new System.Drawing.Size(1001, 261);
            this.dataGridViewTK.TabIndex = 17;
            this.dataGridViewTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTK_CellContentClick);
            // 
            // comboBoxtruycap
            // 
            this.comboBoxtruycap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtruycap.FormattingEnabled = true;
            this.comboBoxtruycap.Location = new System.Drawing.Point(156, 22);
            this.comboBoxtruycap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxtruycap.Name = "comboBoxtruycap";
            this.comboBoxtruycap.Size = new System.Drawing.Size(489, 35);
            this.comboBoxtruycap.TabIndex = 16;
            // 
            // butXoa
            // 
            this.butXoa.AutoSize = true;
            this.butXoa.BackColor = System.Drawing.Color.Gray;
            this.butXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoa.ForeColor = System.Drawing.Color.White;
            this.butXoa.Location = new System.Drawing.Point(774, 109);
            this.butXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(220, 49);
            this.butXoa.TabIndex = 14;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butAdd
            // 
            this.butAdd.AutoSize = true;
            this.butAdd.BackColor = System.Drawing.Color.Gray;
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Location = new System.Drawing.Point(774, 47);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(220, 49);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "Thêm";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(156, 150);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(489, 34);
            this.txt_mk.TabIndex = 11;
            this.txt_mk.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(156, 92);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(489, 34);
            this.txtTenTK.TabIndex = 8;
            this.txtTenTK.TextChanged += new System.EventHandler(this.txtTenCT_TextChanged);
            // 
            // lbSodt
            // 
            this.lbSodt.AutoSize = true;
            this.lbSodt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSodt.ForeColor = System.Drawing.Color.White;
            this.lbSodt.Location = new System.Drawing.Point(17, 28);
            this.lbSodt.Name = "lbSodt";
            this.lbSodt.Size = new System.Drawing.Size(109, 26);
            this.lbSodt.TabIndex = 5;
            this.lbSodt.Text = "Truy Cập";
            this.lbSodt.Click += new System.EventHandler(this.lbSodt_Click);
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDC.ForeColor = System.Drawing.Color.White;
            this.lbDC.Location = new System.Drawing.Point(17, 152);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(118, 26);
            this.lbDC.TabIndex = 4;
            this.lbDC.Text = "Mật Khẩu";
            // 
            // lbTenCongTyNCC
            // 
            this.lbTenCongTyNCC.AutoSize = true;
            this.lbTenCongTyNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenCongTyNCC.ForeColor = System.Drawing.Color.White;
            this.lbTenCongTyNCC.Location = new System.Drawing.Point(17, 95);
            this.lbTenCongTyNCC.Name = "lbTenCongTyNCC";
            this.lbTenCongTyNCC.Size = new System.Drawing.Size(121, 26);
            this.lbTenCongTyNCC.TabIndex = 3;
            this.lbTenCongTyNCC.Text = "Tài Khoản";
            this.lbTenCongTyNCC.Click += new System.EventHandler(this.lbTenCongTyNCC_Click);
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.BackColor = System.Drawing.Color.Transparent;
            this.lbNCC.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNCC.ForeColor = System.Drawing.Color.White;
            this.lbNCC.Location = new System.Drawing.Point(3, 20);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(270, 64);
            this.lbNCC.TabIndex = 6;
            this.lbNCC.Text = "Tài Khoản";
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 750);
            this.Controls.Add(this.lbNCC);
            this.Controls.Add(this.grBoxCapNhatNCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.grBoxCapNhatNCC.ResumeLayout(false);
            this.grBoxCapNhatNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grBoxCapNhatNCC;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label lbSodt;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label lbTenCongTyNCC;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.ComboBox comboBoxtruycap;
        private System.Windows.Forms.DataGridView dataGridViewTK;
    }
}