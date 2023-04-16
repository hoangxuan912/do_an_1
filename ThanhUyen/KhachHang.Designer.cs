namespace ThanhUyen
{
    partial class KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grBoxCapNhatKH = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butXoa = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSodtKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lbSodtKH = new System.Windows.Forms.Label();
            this.lbDCKH = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.grBoxCapNhatKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxCapNhatKH
            // 
            this.grBoxCapNhatKH.AutoSize = true;
            this.grBoxCapNhatKH.BackColor = System.Drawing.Color.Transparent;
            this.grBoxCapNhatKH.Controls.Add(this.dataGridView1);
            this.grBoxCapNhatKH.Controls.Add(this.butXoa);
            this.grBoxCapNhatKH.Controls.Add(this.butSua);
            this.grBoxCapNhatKH.Controls.Add(this.butAdd);
            this.grBoxCapNhatKH.Controls.Add(this.txtDiaChi);
            this.grBoxCapNhatKH.Controls.Add(this.txtSodtKH);
            this.grBoxCapNhatKH.Controls.Add(this.txtTenKH);
            this.grBoxCapNhatKH.Controls.Add(this.lbSodtKH);
            this.grBoxCapNhatKH.Controls.Add(this.lbDCKH);
            this.grBoxCapNhatKH.Controls.Add(this.lbTenKH);
            this.grBoxCapNhatKH.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCapNhatKH.ForeColor = System.Drawing.Color.White;
            this.grBoxCapNhatKH.Location = new System.Drawing.Point(6, 12);
            this.grBoxCapNhatKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxCapNhatKH.Name = "grBoxCapNhatKH";
            this.grBoxCapNhatKH.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxCapNhatKH.Size = new System.Drawing.Size(1033, 722);
            this.grBoxCapNhatKH.TabIndex = 17;
            this.grBoxCapNhatKH.TabStop = false;
            this.grBoxCapNhatKH.Text = "Khách Hàng";
            this.grBoxCapNhatKH.Enter += new System.EventHandler(this.grBoxCapNhatKH_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 282);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 402);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // butXoa
            // 
            this.butXoa.AutoSize = true;
            this.butXoa.BackColor = System.Drawing.Color.Gray;
            this.butXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butXoa.ForeColor = System.Drawing.Color.White;
            this.butXoa.Location = new System.Drawing.Point(748, 212);
            this.butXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(212, 52);
            this.butXoa.TabIndex = 14;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butSua
            // 
            this.butSua.AutoSize = true;
            this.butSua.BackColor = System.Drawing.Color.Gray;
            this.butSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butSua.ForeColor = System.Drawing.Color.White;
            this.butSua.Location = new System.Drawing.Point(748, 125);
            this.butSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(212, 52);
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
            this.butAdd.Location = new System.Drawing.Point(748, 36);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(212, 52);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "Thêm";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChi.Location = new System.Drawing.Point(188, 109);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(346, 34);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtSodtKH
            // 
            this.txtSodtKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSodtKH.Location = new System.Drawing.Point(188, 191);
            this.txtSodtKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSodtKH.Name = "txtSodtKH";
            this.txtSodtKH.Size = new System.Drawing.Size(346, 34);
            this.txtSodtKH.TabIndex = 9;
            this.txtSodtKH.TextChanged += new System.EventHandler(this.txtSodtKH_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenKH.Location = new System.Drawing.Point(188, 38);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(346, 34);
            this.txtTenKH.TabIndex = 8;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // lbSodtKH
            // 
            this.lbSodtKH.AutoSize = true;
            this.lbSodtKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSodtKH.ForeColor = System.Drawing.Color.White;
            this.lbSodtKH.Location = new System.Drawing.Point(7, 191);
            this.lbSodtKH.Name = "lbSodtKH";
            this.lbSodtKH.Size = new System.Drawing.Size(101, 26);
            this.lbSodtKH.TabIndex = 5;
            this.lbSodtKH.Text = "SDT KH";
            this.lbSodtKH.Click += new System.EventHandler(this.lbSodtKH_Click);
            // 
            // lbDCKH
            // 
            this.lbDCKH.AutoSize = true;
            this.lbDCKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDCKH.ForeColor = System.Drawing.Color.White;
            this.lbDCKH.Location = new System.Drawing.Point(7, 112);
            this.lbDCKH.Name = "lbDCKH";
            this.lbDCKH.Size = new System.Drawing.Size(135, 26);
            this.lbDCKH.TabIndex = 4;
            this.lbDCKH.Text = "Địa Chỉ KH";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenKH.ForeColor = System.Drawing.Color.White;
            this.lbTenKH.Location = new System.Drawing.Point(7, 45);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(187, 26);
            this.lbTenKH.TabIndex = 3;
            this.lbTenKH.Text = "Tên Khách Hàng";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 750);
            this.ControlBox = false;
            this.Controls.Add(this.grBoxCapNhatKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.grBoxCapNhatKH.ResumeLayout(false);
            this.grBoxCapNhatKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grBoxCapNhatKH;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSodtKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lbSodtKH;
        private System.Windows.Forms.Label lbDCKH;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}