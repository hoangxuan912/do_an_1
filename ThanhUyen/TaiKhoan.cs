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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private SanPham tk = new SanPham();
        private clquanli clQL = new clquanli();
        private DataTable tbl_tk = new DataTable();
        private QuanLiChinh qlc = new QuanLiChinh();
        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSodt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenCT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTenCongTyNCC_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSodt_Click(object sender, EventArgs e)
        {

        }

        private void grBoxCapNhatNCC_Enter(object sender, EventArgs e)
        {

        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            //clQL = new clquanli("", "", "", "", "", "", "", "", "", txtTenTK.Text, txt_mk.Text, comboBoxtruycap.Text, "", "", 0, 0, 0, 0, "", 0, 0, 0, "");
            //clQL.Conect_QLT();
            //clQL.Delete_TaiKhoan();
            //MessageBox.Show("Đã xóa");
            //TaiKhoan_Load(sender, e);
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                clQL.Conect_QLT();
                tbl_tk = clQL.layDl("select * from TaiKhoan");
                tk.DoDL_VaoGV(tbl_tk,dataGridViewTK);
                DataTable tbl_quyentruycap = clQL.layDl("select TaiKhoan_QuyenTruyCap from TaiKhoan");
                tk.DoDL_VaoCB(tbl_quyentruycap, comboBoxtruycap);
                dataGridViewTK.Columns[0].HeaderText = "ID";
                dataGridViewTK.Columns[1].HeaderText = "Tài khoản";
                dataGridViewTK.Columns[2].HeaderText = "Mật Khẩu";
                dataGridViewTK.Columns[3].HeaderText = "Quyền truy cập";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong_ht = dataGridViewTK.CurrentRow.Index;
            if (dong_ht > dataGridViewTK.Rows.Count - 1)
                return;
            else
            {
                comboBoxtruycap.Text = dataGridViewTK.Rows[dong_ht].Cells[3].Value.ToString();
                txtTenTK.Text = dataGridViewTK.Rows[dong_ht].Cells[1].Value.ToString();
                txt_mk.Text = dataGridViewTK.Rows[dong_ht].Cells[2].Value.ToString();
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            clQL = new clquanli("", "", "", "", "", "", "", "", "", txtTenTK.Text, txt_mk.Text, comboBoxtruycap.Text, "", "", 0, 0, 0, 0, "", 0, 0, 0, "");
            clQL.Conect_QLT();
            clQL.Insert_TaiKhoan();
            MessageBox.Show("Đã Thêm");
            TaiKhoan_Load(sender, e);
        }
    }
}
