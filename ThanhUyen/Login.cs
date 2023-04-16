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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private int dem = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private ConnectData con= new ConnectData();

        
        public void button3_Click(object sender, EventArgs e)
        {
        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_login;
            txtTK.Focus();
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi sự kiện Click của nút đăng nhập
                button3_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            con.Conect_QLT();
            DataTable tbl_DN = new DataTable();
            tbl_DN = con.layDl("select * from TaiKhoan where TaiKhoan_Tk='" + txtTK.Text + "' and TaiKhoan_MK='" + textBox1mk.Text + "'");
            DataTable getRole = new DataTable();
            getRole = con.layDl("select TaiKhoan_QuyenTruyCap from TaiKhoan where TaiKhoan_Tk='" + txtTK.Text + "' and TaiKhoan_MK='" + textBox1mk.Text + "'");
            if (tbl_DN.Rows.Count > 0)
            {
                if (getRole.Rows.Count > 0 && getRole.Rows[0]["TaiKhoan_QuyenTruyCap"].ToString() == "admin")
                {
                    QuanLiChinh qlc = new QuanLiChinh();
                    qlc.isAdmin = true;
                    qlc.Show();
                    this.Hide();
                }
                else
                {
                    QuanLiChinh qlc = new QuanLiChinh();
                    qlc.isAdmin = false;
                    qlc.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập sai", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dem++;
                if(dem == 5)
                {
                    btn_login.Enabled = false;
                    btn_login.BackColor = SystemColors.ControlDark;
                    await Task.Delay(60000);

                }
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 