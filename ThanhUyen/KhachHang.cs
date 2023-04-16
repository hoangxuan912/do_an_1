using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhUyen
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private clquanli clQL = new clquanli();
        private SanPham khachhang = new SanPham();
        private DataTable tbl_kh = new DataTable();
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            try
            {

                clQL.Conect_QLT();
                tbl_kh = clQL.layDl("select * from KhachHang");
                khachhang.DoDL_VaoGV(tbl_kh,dataGridView1);
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Tên Khách Hàng";
                dataGridView1.Columns[2].HeaderText = "Địa Chỉ";
                dataGridView1.Columns[3].HeaderText = "Số điện thoại";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grBoxCapNhatKH_Enter(object sender, EventArgs e)
        {

        }

        

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong_ht = dataGridView1.CurrentRow.Index;
            if (dong_ht > dataGridView1.Rows.Count - 1)
                return;
            else
            {
                txtTenKH.Text = dataGridView1.Rows[dong_ht].Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[dong_ht].Cells[2].Value.ToString();
                txtSodtKH.Text = dataGridView1.Rows[dong_ht].Cells[3].Value.ToString();
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            tbl_kh = clQL.layDl("select * from KhachHang Where KhachHang_ten = '" + txtTenKH.Text + "'");
            if (tbl_kh.Rows.Count == 1)
            {
                MessageBox.Show("Khách Hàng: " + txtTenKH.Text + " đã tồn tại.");
                txtTenKH.Focus();

            }
            else
            {
                clQL = new clquanli("", "", "", "", "", txtTenKH.Text, txtDiaChi.Text, txtSodtKH.Text, "", "", "", "", "", "", 0, 0, 0, 0, "", 0, 0, 0, "");
                clQL.Conect_QLT();
                clQL.Insert_KhachHang();
                MessageBox.Show("Đã Thêm");
                KhachHang_Load(sender, e);
            }
        }
        private void butXoa_Click(object sender, EventArgs e)
        {
            //int dong_ht = dataGridView1.CurrentRow.Index;
            //string test = dataGridView1.Rows[dong_ht].Cells[0].Value.ToString();
            //clQL = new clquanli("", "", "", "", test, txtTenKH.Text, txtDiaChi.Text, txtSodtKH.Text, "", "", "", "", "", "", 0, 0, 0, 0, "", 0, 0, 0, "");
            //clQL.Conect_QLT();
            //clQL.Delete_KhachHang();
            //MessageBox.Show("Đã Xóa");
            //KhachHang_Load(sender, e);
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            int dong_ht = dataGridView1.CurrentRow.Index;
            string test = dataGridView1.Rows[dong_ht].Cells[0].Value.ToString();
            clQL = new clquanli("", "", "", "", test, txtTenKH.Text, txtDiaChi.Text, txtSodtKH.Text, "", "", "", "", "", "", 0, 0, 0, 0, "", 0, 0, 0, "");
            clQL.Conect_QLT();
            clQL.Update_KhachHang();
            MessageBox.Show("Đã Sửa");
            KhachHang_Load(sender, e);
        }

        private void lbSodtKH_Click(object sender, EventArgs e)
        {

        }

        private void txtSodtKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            tbl_kh = clQL.layDl("SELECT * FROM KhachHang WHERE KhachHang_ten LIKE N'%" + txtTenKH.Text + "%' OR KhachHang_diachi LIKE N'%" + txtDiaChi.Text + "%' OR KhachHang_sdt LIKE N'%" + txtSodtKH.Text + "%'");
            khachhang.DoDL_VaoGV(tbl_kh, dataGridView1);
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clQL.Conect_QLT();
            tbl_kh = clQL.layDl("select * from KhachHang");
            khachhang.DoDL_VaoGV(tbl_kh, dataGridView1);
        }
    }
}
