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
    public partial class BaokaoThongKe : Form
    {
        private clquanli BCTK = new clquanli();
        private DataTable tbl_bctk = new DataTable();
        private SanPham dsa = new SanPham();
        public BaokaoThongKe()
        {
            InitializeComponent();
        }

        private void dateTimePickertoi_ValueChanged(object sender, EventArgs e)
        {
        }

        private void BaokaoThongKe_Load(object sender, EventArgs e)
        {
            BCTK.Conect_QLT();
            string query = "SELECT \r\n  sp.SanPham_id, \r\n  sp.SanPham_sl,\r\n  COALESCE(SUM(px.CTPhieuXuatHang_sl), 0) AS TongXuat,\r\n  COALESCE(SUM(pn.CTPhieuNhapHang_sl), 0) AS TongNhap,\r\n  SUM(sp.SanPham_sl * sp.SanPham_GiaBan) AS TongGiaTriTonKho,\r\n  COALESCE(SUM(pn.CTPhieuNhapHang_sl * sp.SanPham_GiaBan), 0) AS TongGiaTriNhap,\r\n  COALESCE(SUM(px.CTHoaDon_tongTien), 0) AS TongGiaTriXuat\r\nFROM SanPham sp\r\nLEFT JOIN CTPhieuXuatHang px ON sp.SanPham_id = px.SanPham_id\r\nLEFT JOIN CTPhieuNhapHang pn ON sp.SanPham_id = pn.SanPham_id\r\nGROUP BY sp.SanPham_id, sp.SanPham_sl, sp.SanPham_GiaBan;\r\n";
            tbl_bctk = BCTK.layDl(query);
            dsa.DoDL_VaoGV(tbl_bctk, dataGridViewBCTK);
            dataGridViewBCTK.Columns[0].HeaderText = "Mã SP";
            dataGridViewBCTK.Columns[1].HeaderText = "Số lượng tồn kho";
            dataGridViewBCTK.Columns[2].HeaderText = "Số lượng đã xuất";
            dataGridViewBCTK.Columns[3].HeaderText = "Số lượng nhập";
            dataGridViewBCTK.Columns[4].HeaderText = "Tổng giá trị tồn kho";
            dataGridViewBCTK.Columns[5].HeaderText = "Tổng giá trị đã xuất";
            dataGridViewBCTK.Columns[6].HeaderText = "Tổng giá trị nhập";
        }

        private void dateTimePickertu_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
