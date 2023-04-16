namespace ThanhUyen
{
    partial class XuatHang
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
            this.grBoxPXH = new System.Windows.Forms.GroupBox();
            this.dataGridViewxh = new System.Windows.Forms.DataGridView();
            this.cb_xhsp = new System.Windows.Forms.ComboBox();
            this.cb_xhmkh = new System.Windows.Forms.ComboBox();
            this.butThemXuatHang = new System.Windows.Forms.Button();
            this.txtSoLuongXH = new System.Windows.Forms.TextBox();
            this.SLXH = new System.Windows.Forms.Label();
            this.lbSPXH = new System.Windows.Forms.Label();
            this.lbMaPhieuXH = new System.Windows.Forms.Label();
            this.grBoxPXH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewxh)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxPXH
            // 
            this.grBoxPXH.BackColor = System.Drawing.Color.Transparent;
            this.grBoxPXH.Controls.Add(this.dataGridViewxh);
            this.grBoxPXH.Controls.Add(this.cb_xhsp);
            this.grBoxPXH.Controls.Add(this.cb_xhmkh);
            this.grBoxPXH.Controls.Add(this.butThemXuatHang);
            this.grBoxPXH.Controls.Add(this.txtSoLuongXH);
            this.grBoxPXH.Controls.Add(this.SLXH);
            this.grBoxPXH.Controls.Add(this.lbSPXH);
            this.grBoxPXH.Controls.Add(this.lbMaPhieuXH);
            this.grBoxPXH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxPXH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxPXH.ForeColor = System.Drawing.SystemColors.Control;
            this.grBoxPXH.Location = new System.Drawing.Point(0, 0);
            this.grBoxPXH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxPXH.Name = "grBoxPXH";
            this.grBoxPXH.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grBoxPXH.Size = new System.Drawing.Size(1354, 750);
            this.grBoxPXH.TabIndex = 2;
            this.grBoxPXH.TabStop = false;
            this.grBoxPXH.Text = "Phiếu Xuất Hàng";
            this.grBoxPXH.Enter += new System.EventHandler(this.grBoxPXH_Enter);
            // 
            // dataGridViewxh
            // 
            this.dataGridViewxh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewxh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewxh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewxh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewxh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewxh.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewxh.Location = new System.Drawing.Point(12, 124);
            this.dataGridViewxh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewxh.Name = "dataGridViewxh";
            this.dataGridViewxh.RowHeadersWidth = 62;
            this.dataGridViewxh.RowTemplate.Height = 28;
            this.dataGridViewxh.Size = new System.Drawing.Size(1139, 589);
            this.dataGridViewxh.TabIndex = 13;
            this.dataGridViewxh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewxh_CellContentClick);
            // 
            // cb_xhsp
            // 
            this.cb_xhsp.FormattingEnabled = true;
            this.cb_xhsp.Location = new System.Drawing.Point(467, 51);
            this.cb_xhsp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_xhsp.Name = "cb_xhsp";
            this.cb_xhsp.Size = new System.Drawing.Size(198, 31);
            this.cb_xhsp.TabIndex = 12;
            this.cb_xhsp.SelectedIndexChanged += new System.EventHandler(this.cb_xhmsp_SelectedIndexChanged);
            // 
            // cb_xhmkh
            // 
            this.cb_xhmkh.ForeColor = System.Drawing.Color.Black;
            this.cb_xhmkh.FormattingEnabled = true;
            this.cb_xhmkh.Location = new System.Drawing.Point(182, 51);
            this.cb_xhmkh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_xhmkh.Name = "cb_xhmkh";
            this.cb_xhmkh.Size = new System.Drawing.Size(125, 31);
            this.cb_xhmkh.TabIndex = 11;
            this.cb_xhmkh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // butThemXuatHang
            // 
            this.butThemXuatHang.BackColor = System.Drawing.Color.Gray;
            this.butThemXuatHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butThemXuatHang.ForeColor = System.Drawing.Color.White;
            this.butThemXuatHang.Location = new System.Drawing.Point(969, 32);
            this.butThemXuatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butThemXuatHang.Name = "butThemXuatHang";
            this.butThemXuatHang.Size = new System.Drawing.Size(167, 68);
            this.butThemXuatHang.TabIndex = 8;
            this.butThemXuatHang.Text = "Thêm";
            this.butThemXuatHang.UseVisualStyleBackColor = false;
            this.butThemXuatHang.Click += new System.EventHandler(this.butThemXuatHang_Click);
            // 
            // txtSoLuongXH
            // 
            this.txtSoLuongXH.Location = new System.Drawing.Point(830, 51);
            this.txtSoLuongXH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongXH.Multiline = true;
            this.txtSoLuongXH.Name = "txtSoLuongXH";
            this.txtSoLuongXH.Size = new System.Drawing.Size(99, 31);
            this.txtSoLuongXH.TabIndex = 6;
            this.txtSoLuongXH.TextChanged += new System.EventHandler(this.txtSoLuongXH_TextChanged);
            // 
            // SLXH
            // 
            this.SLXH.AutoSize = true;
            this.SLXH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLXH.ForeColor = System.Drawing.Color.White;
            this.SLXH.Location = new System.Drawing.Point(713, 51);
            this.SLXH.Name = "SLXH";
            this.SLXH.Size = new System.Drawing.Size(111, 26);
            this.SLXH.TabIndex = 2;
            this.SLXH.Text = "Số Lượng";
            // 
            // lbSPXH
            // 
            this.lbSPXH.AutoSize = true;
            this.lbSPXH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSPXH.ForeColor = System.Drawing.Color.White;
            this.lbSPXH.Location = new System.Drawing.Point(346, 51);
            this.lbSPXH.Name = "lbSPXH";
            this.lbSPXH.Size = new System.Drawing.Size(115, 26);
            this.lbSPXH.TabIndex = 1;
            this.lbSPXH.Text = "Sản Phẩm";
            // 
            // lbMaPhieuXH
            // 
            this.lbMaPhieuXH.AutoSize = true;
            this.lbMaPhieuXH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhieuXH.ForeColor = System.Drawing.Color.White;
            this.lbMaPhieuXH.Location = new System.Drawing.Point(34, 51);
            this.lbMaPhieuXH.Name = "lbMaPhieuXH";
            this.lbMaPhieuXH.Size = new System.Drawing.Size(142, 26);
            this.lbMaPhieuXH.TabIndex = 0;
            this.lbMaPhieuXH.Text = "Khách Hàng";
            // 
            // XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 750);
            this.Controls.Add(this.grBoxPXH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XuatHang";
            this.Text = "XuatHang";
            this.Load += new System.EventHandler(this.XuatHang_Load);
            this.grBoxPXH.ResumeLayout(false);
            this.grBoxPXH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewxh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grBoxPXH;
        private System.Windows.Forms.Button butThemXuatHang;
        private System.Windows.Forms.TextBox txtSoLuongXH;
        private System.Windows.Forms.Label SLXH;
        private System.Windows.Forms.Label lbSPXH;
        private System.Windows.Forms.Label lbMaPhieuXH;
        private System.Windows.Forms.ComboBox cb_xhsp;
        private System.Windows.Forms.ComboBox cb_xhmkh;
        private System.Windows.Forms.DataGridView dataGridViewxh;
    }
}