using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhUyen
{
    public partial class XuatHang : Form
    {
        public XuatHang()
        {
            InitializeComponent();
        }
        private clquanli cl_XH = new clquanli();
        private DataTable tbl_XH = new DataTable();
        private SanPham sp = new SanPham();
        private void grBoxPXH_Enter(object sender, EventArgs e)
        {

        }

        private void XuatHang_Load(object sender, EventArgs e)
        {
            cl_XH.Conect_QLT();
            tbl_XH = cl_XH.layDl("select * from CTPhieuXuatHang");
            sp.DoDL_VaoGV(tbl_XH,dataGridViewxh);
            DataTable tbl_mkh = cl_XH.layDl("select KhachHang_id from KhachHang");
            DataTable tbl_msp = cl_XH.layDl("select SanPham_id from SanPham");
            sp.DoDL_VaoCB(tbl_mkh,cb_xhmkh);
            sp.DoDL_VaoCB(tbl_msp, cb_xhsp);

            dataGridViewxh.Columns[0].HeaderText = "ID Phiếu";
            dataGridViewxh.Columns[1].HeaderText = "Mã Khách hàng";
            dataGridViewxh.Columns[2].HeaderText = "Mã Sản Phẩm";
            dataGridViewxh.Columns[3].HeaderText = "Số lượng";
            dataGridViewxh.Columns[4].HeaderText = "Tổng tiền";
            dataGridViewxh.Columns[5].HeaderText = "Ngày Xuất";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtSoLuongXH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
        }

        private void cb_xhmsp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewxh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    int dong_ht = dataGridViewxh.CurrentRow.Index;
            //    if (dong_ht > dataGridViewxh.Rows.Count - 1)
            //        return;
            //    else
            //    {
            //        cb_xhmkh.Text = dataGridViewxh.Rows[dong_ht].Cells[1].Value.ToString();
            //        cb_xhsp.Text = dataGridViewxh.Rows[dong_ht].Cells[2].Value.ToString();
            //        txtSoLuongXH.Text = dataGridViewxh.Rows[dong_ht].Cells[3].Value.ToString();
            //    }
        }

        private void butThemXuatHang_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string dateString = now.ToString("yyyy/MM/dd HH:mm:ss");


            DataTable tbl_giaban = cl_XH.layDl("select SanPham_GiaBan from SanPham where SanPham_id = '" + cb_xhsp.Text + "'");
            
            int giabansp = Convert.ToInt32(tbl_giaban.Rows[0]["SanPham_GiaBan"]);
            int result = giabansp * int.Parse(txtSoLuongXH.Text);

            cl_XH = new clquanli("", "", "", "", cb_xhmkh.Text, "", "", "", "", "", "", "", cb_xhsp.Text, "", 0, 0, 0, 0, "", 0, int.Parse(txtSoLuongXH.Text), result, dateString);
            cl_XH.Conect_QLT();
            cl_XH.Insert_XuatHang();
            DataTable tbl_slxh = cl_XH.layDl("select TOP 1 CTPhieuXuatHang_sl from CTPhieuXuatHang where SanPham_id = '" + cb_xhsp.Text + "' ORDER BY CTPhieuXuatHang_Ngay DESC");
            int slxh = Convert.ToInt32(tbl_slxh.Rows[0]["CTPhieuXuatHang_sl"]);
            MessageBox.Show("Đã nhập phiếu xuất");
            DataTable tbl_slht = cl_XH.layDl("select SanPham_sl from SanPham where SanPham_id = '" + cb_xhsp.Text + "'");
            int slht = Convert.ToInt32(tbl_slht.Rows[0]["SanPham_sl"]);
            int slmoi = slht - slxh;

            //Cập nhật
            cl_XH.CapnhatDl("UPDATE SanPham SET SanPham_sl = " + slmoi + " WHERE SanPham_id = '" + cb_xhsp.Text + "'");
            XuatHang_Load(sender, e);
        }
    }
}
