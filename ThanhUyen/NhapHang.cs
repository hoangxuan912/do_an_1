using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhUyen
{
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        private clquanli clQL = new clquanli();
        private SanPham SanPham= new SanPham();
        private DataTable tbl_NH = new DataTable();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            clQL.Conect_QLT();
            tbl_NH = clQL.layDl("select * from CTPhieuNhapHang");
            SanPham.DoDL_VaoGV(tbl_NH, dataGridViewnhaphang);
            DataTable tbl_msp = new DataTable();
            tbl_msp = clQL.layDl("select * from SanPham");
            SanPham.DoDL_VaoCB(tbl_msp, cb_msp);

            dataGridViewnhaphang.Columns[0].HeaderText = "ID Phiếu";
            dataGridViewnhaphang.Columns[1].HeaderText = "Mã Sản Phẩm";
            dataGridViewnhaphang.Columns[2].HeaderText = "Số lượng";
            dataGridViewnhaphang.Columns[3].HeaderText = "Ngày Nhập";
        }

        private void txtNgayNH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSanPhamNH_TextChanged(object sender, EventArgs e)
        {

        }

        private void butThemNhapHang_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string dateString = now.ToString("yyyy/MM/dd HH:mm:ss");

            clQL = new clquanli("", "", "", "", "", "", "", "", "", "", "", "", cb_msp.Text, "", 0, 0, 0, int.Parse(txtSoLuongNH.Text), dateString, 0, 0, 0, "");
            clQL.Conect_QLT();
            clQL.Insert_NhapHang();
            MessageBox.Show("Đã Thêm");

            //cập nhập số lượng tồn kho
            DataTable tbl_slht = clQL.layDl("select TOP 1 CTPhieuNhapHang_sl from CTPhieuNhapHang where SanPham_id = '"+cb_msp.Text+ "' ORDER BY CTPhieuNhapHang_Ngay DESC");


            DataTable tbl_spsl = clQL.layDl("select SanPham_sl from SanPham where SanPham_id = '"+ cb_msp.Text+"'");
            int slht = Convert.ToInt32(tbl_slht.Rows[0]["CTPhieuNhapHang_sl"]);
            int slsp = Convert.ToInt32(tbl_spsl.Rows[0]["SanPham_sl"]);
            int slmoi = slht + slsp;
            clQL.CapnhatDl("UPDATE SanPham SET SanPham_sl = " + slmoi + " WHERE SanPham_id = '" + cb_msp.Text + "'");
            MessageBox.Show("Đã thêm" + slht + "sản phẩm với MaSP: " + cb_msp.Text);
            NhapHang_Load(sender, e);
        }

        private void dataGridViewnhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong_ht = dataGridViewnhaphang.CurrentRow.Index;
            if (dong_ht > dataGridViewnhaphang.Rows.Count - 1)
                return;
            else
            {
                cb_msp.Text = dataGridViewnhaphang.Rows[dong_ht].Cells[1].Value.ToString();
                txtSoLuongNH.Text = dataGridViewnhaphang.Rows[dong_ht].Cells[2].Value.ToString();
            }
        }

        private void cb_msp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
