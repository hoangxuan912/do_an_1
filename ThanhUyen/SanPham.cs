using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ThanhUyen
{
    public partial class SanPham : Form
    {
        private clquanli cl_SanPham= new clquanli();
        private DataTable tbl_SP = new DataTable();

        public SanPham()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void DoDL_VaoGV(DataTable tbl_all, DataGridView dataG_all)
        {
            dataG_all.DataSource = tbl_all;   
        }
        public void DoDL_VaoCB(DataTable tbl_all, ComboBox cb_all)
        {
            cb_all.Items.Clear();
            foreach (DataRow row in tbl_all.Rows)
            {
                cb_all.Items.Add(row[0].ToString());
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            try
            {
                cl_SanPham.Conect_QLT();
                tbl_SP = cl_SanPham.layDl("select * from SanPham");
                DataTable tbl_mncc = cl_SanPham.layDl("SELECT * FROM NhaCungCap");
                DoDL_VaoGV(tbl_SP, dataGridView2);
                DoDL_VaoCB(tbl_mncc, cb_mncc);

                //Đổi header
                dataGridView2.Columns[0].HeaderText = "Mã sản phẩm";
                dataGridView2.Columns[1].HeaderText = "Sản phẩm";
                dataGridView2.Columns[2].HeaderText = "Số lượng";
                dataGridView2.Columns[3].HeaderText = "Giá bán";
                dataGridView2.Columns[4].HeaderText = "Thương hiệu";

            }
            catch (Exception)
            {

                
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tbl_SP = cl_SanPham.layDl("SELECT * FROM SanPham WHERE SanPham_id LIKE N'%" + txtTimKiem.Text + "%' OR SanPham_ten LIKE N'%" + txtTimKiem.Text + "%' OR NhaCungCap_id LIKE N'%" + txtTimKiem.Text + "%'");
            DoDL_VaoGV(tbl_SP, dataGridView2);
        }

        private void txtTimKiem_Enter(object sender, EventArgs e) { 
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
        }

        private void label1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Leave(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong_ht = dataGridView2.CurrentRow.Index;
            if (dong_ht > dataGridView2.Rows.Count - 1)
                return;
            else
            {
                txtMaSP.Text = dataGridView2.Rows[dong_ht].Cells[0].Value.ToString();
                txtTenSP.Text = dataGridView2.Rows[dong_ht].Cells[1].Value.ToString();
                txtSoLuong.Text = dataGridView2.Rows[dong_ht].Cells[2].Value.ToString();
                txtGiaBan.Text = dataGridView2.Rows[dong_ht].Cells[3].Value.ToString();
                cb_mncc.Text = dataGridView2.Rows[dong_ht].Cells[4].Value.ToString();
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            int giaBan = int.Parse(txtGiaBan.Text);
            int soluong = int.Parse(txtSoLuong.Text);


            tbl_SP = cl_SanPham.layDl("select * from SanPham Where SanPham_id = '" + txtMaSP.Text + "'");
            if (tbl_SP.Rows.Count == 1)
            {
                MessageBox.Show("Sản Phẩm mã " + txtMaSP.Text + " đã tồn tại.");
                txtMaSP.Focus();

            }
            else
            {

                cl_SanPham = new clquanli(cb_mncc.Text,"","","","","","","","","","","",txtMaSP.Text,txtTenSP.Text, soluong, giaBan, 0,0,"",0,0,0,"");
                cl_SanPham.Conect_QLT();
                cl_SanPham.Insert_SanPham();
                MessageBox.Show("Đã Thêm");
                SanPham_Load(sender, e);
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            int giaBan = int.Parse(txtGiaBan.Text);
            int soluong = int.Parse(txtSoLuong.Text);

            cl_SanPham = new clquanli(cb_mncc.Text, "", "", "", "", "", "", "", "", "", "", "", txtMaSP.Text, txtTenSP.Text, soluong, giaBan, 0, 0, "", 0, 0, 0, "");
            cl_SanPham.Conect_QLT();
            cl_SanPham.Update_SanPham();
            MessageBox.Show("Đã Sửa");
            SanPham_Load(sender, e);
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            //int giaBan = int.Parse(txtGiaBan.Text);
            //int soluong = int.Parse(txtSoLuong.Text);

            //cl_SanPham = new clquanli(cb_mncc.Text, "", "", "", "", "", "", "", "", "", "", "", txtMaSP.Text, txtTenSP.Text, soluong, giaBan, 0, 0, "", 0, 0, 0, "");
            //cl_SanPham.Conect_QLT();
            
            //var result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Xóa",
            //                     MessageBoxButtons.YesNo,
            //                     MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    cl_SanPham.Delete_SanPham();
            //}
            //SanPham_Load(sender, e);
        }

        private void labeltimk_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_SanPham.Conect_QLT();
            tbl_SP = cl_SanPham.layDl("select * from SanPham");
            DoDL_VaoGV(tbl_SP, dataGridView2);
        }

        private void grBoxCapNhatSP_Enter(object sender, EventArgs e)
        {

        }
    }
}
