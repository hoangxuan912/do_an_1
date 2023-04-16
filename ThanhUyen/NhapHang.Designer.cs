namespace ThanhUyen
{
    partial class NhapHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_msp = new System.Windows.Forms.ComboBox();
            this.butThemNhapHang = new System.Windows.Forms.Button();
            this.txtSoLuongNH = new System.Windows.Forms.TextBox();
            this.SLNH = new System.Windows.Forms.Label();
            this.SPNH = new System.Windows.Forms.Label();
            this.dataGridViewnhaphang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cb_msp);
            this.groupBox1.Controls.Add(this.butThemNhapHang);
            this.groupBox1.Controls.Add(this.txtSoLuongNH);
            this.groupBox1.Controls.Add(this.SLNH);
            this.groupBox1.Controls.Add(this.SPNH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1023, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập Hàng";
            // 
            // cb_msp
            // 
            this.cb_msp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_msp.FormattingEnabled = true;
            this.cb_msp.Location = new System.Drawing.Point(197, 56);
            this.cb_msp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_msp.Name = "cb_msp";
            this.cb_msp.Size = new System.Drawing.Size(126, 30);
            this.cb_msp.TabIndex = 9;
            this.cb_msp.SelectedIndexChanged += new System.EventHandler(this.cb_msp_SelectedIndexChanged);
            // 
            // butThemNhapHang
            // 
            this.butThemNhapHang.BackColor = System.Drawing.Color.Gray;
            this.butThemNhapHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butThemNhapHang.ForeColor = System.Drawing.Color.White;
            this.butThemNhapHang.Location = new System.Drawing.Point(636, 68);
            this.butThemNhapHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butThemNhapHang.Name = "butThemNhapHang";
            this.butThemNhapHang.Size = new System.Drawing.Size(171, 60);
            this.butThemNhapHang.TabIndex = 8;
            this.butThemNhapHang.Text = "Thêm";
            this.butThemNhapHang.UseVisualStyleBackColor = false;
            this.butThemNhapHang.Click += new System.EventHandler(this.butThemNhapHang_Click);
            // 
            // txtSoLuongNH
            // 
            this.txtSoLuongNH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoLuongNH.Location = new System.Drawing.Point(197, 116);
            this.txtSoLuongNH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongNH.Name = "txtSoLuongNH";
            this.txtSoLuongNH.Size = new System.Drawing.Size(57, 30);
            this.txtSoLuongNH.TabIndex = 6;
            // 
            // SLNH
            // 
            this.SLNH.AutoSize = true;
            this.SLNH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SLNH.ForeColor = System.Drawing.SystemColors.Control;
            this.SLNH.Location = new System.Drawing.Point(15, 114);
            this.SLNH.Name = "SLNH";
            this.SLNH.Size = new System.Drawing.Size(133, 32);
            this.SLNH.TabIndex = 2;
            this.SLNH.Text = "Số Lượng";
            this.SLNH.Click += new System.EventHandler(this.label3_Click);
            // 
            // SPNH
            // 
            this.SPNH.AutoSize = true;
            this.SPNH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SPNH.ForeColor = System.Drawing.SystemColors.Control;
            this.SPNH.Location = new System.Drawing.Point(15, 59);
            this.SPNH.Name = "SPNH";
            this.SPNH.Size = new System.Drawing.Size(184, 32);
            this.SPNH.TabIndex = 1;
            this.SPNH.Text = "Mã Sản Phẩm";
            // 
            // dataGridViewnhaphang
            // 
            this.dataGridViewnhaphang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewnhaphang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewnhaphang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewnhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewnhaphang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewnhaphang.Location = new System.Drawing.Point(14, 202);
            this.dataGridViewnhaphang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewnhaphang.Name = "dataGridViewnhaphang";
            this.dataGridViewnhaphang.RowHeadersWidth = 62;
            this.dataGridViewnhaphang.RowTemplate.Height = 28;
            this.dataGridViewnhaphang.Size = new System.Drawing.Size(1023, 418);
            this.dataGridViewnhaphang.TabIndex = 10;
            this.dataGridViewnhaphang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewnhaphang_CellContentClick);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 634);
            this.Controls.Add(this.dataGridViewnhaphang);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhaphang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SLNH;
        private System.Windows.Forms.Label SPNH;
        private System.Windows.Forms.Button butThemNhapHang;
        private System.Windows.Forms.TextBox txtSoLuongNH;
        private System.Windows.Forms.DataGridView dataGridViewnhaphang;
        private System.Windows.Forms.ComboBox cb_msp;
    }
}