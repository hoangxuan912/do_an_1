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
    public partial class Nha_cung_cap : Form
    {
        public Nha_cung_cap()
        {
            InitializeComponent();
        }
        private clquanli clQL = new clquanli();
        private SanPham ncc = new SanPham();
        private DataTable tbl_ncc = new DataTable();
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nha_cung_cap_Load(object sender, EventArgs e)
        {
            clQL.Conect_QLT();
            tbl_ncc = clQL.layDl("select * from NhaCungCap");
            ncc.DoDL_VaoGV(tbl_ncc, dataGridViewncc);
            dataGridViewncc.Columns[0].HeaderText = "Nhà Cung Cấp";
            dataGridViewncc.Columns[1].HeaderText = "Tên Công Ty";
            dataGridViewncc.Columns[2].HeaderText = "Địa Chỉ";
            dataGridViewncc.Columns[3].HeaderText = "Số điện thoại";


        }

        private void dataGridViewncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grBoxCapNhatNCC_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewncc_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong_ht = dataGridViewncc.CurrentRow.Index;
            if (dong_ht > dataGridViewncc.Rows.Count - 1)
                return;
            else
            {
                txtMaNCC.Text = dataGridViewncc.Rows[dong_ht].Cells[0].Value.ToString();
                txtTenCT.Text = dataGridViewncc.Rows[dong_ht].Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridViewncc.Rows[dong_ht].Cells[2].Value.ToString();
                txtSodt.Text = dataGridViewncc.Rows[dong_ht].Cells[3].Value.ToString();
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            tbl_ncc = clQL.layDl("select * from NhaCungCap Where NhaCungCap_id = '" + txtMaNCC.Text + "'");
            if (tbl_ncc.Rows.Count == 1)
            {
                MessageBox.Show("Nhà cung cấp mã " + txtMaNCC.Text + " đã tồn tại.");
                txtMaNCC.Focus();

            }
            else
            {
                clQL = new clquanli(txtMaNCC.Text, txtTenCT.Text, txtDiaChi.Text, txtSodt.Text, "", "", "", "", "", "", "", "", "", "", 0, 0, 0, 0, "", 0, 0, 0, "");
                clQL.Conect_QLT();
                clQL.Insert_NhaCungCap();
                MessageBox.Show("Đã Thêm");
                Nha_cung_cap_Load(sender, e);
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            clQL = new clquanli(txtMaNCC.Text, txtTenCT.Text, txtDiaChi.Text, txtSodt.Text, "", "", "", "", "", "", "", "", "", "", 0, 0, 0, 0, "", 0, 0, 0, "");
            clQL.Conect_QLT();
            clQL.Update_NhaCungCap();
            MessageBox.Show("Đã sửa");
            Nha_cung_cap_Load(sender, e);

        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            //clQL = new clquanli(txtMaNCC.Text, txtTenCT.Text, txtDiaChi.Text, txtSodt.Text, "", "", "", "", "", "", "", "", "", "", 0, 0, 0, 0, "", 0, 0, 0, "");
            //clQL.Conect_QLT();
            //clQL.Delete_NhaCungCap(); 
            //MessageBox.Show("Đã xóa");
            //Nha_cung_cap_Load(sender, e);
        }

        private void lbSodt_Click(object sender, EventArgs e)
        {

        }

        private void lbDC_Click(object sender, EventArgs e)
        {

        }
    }
}
