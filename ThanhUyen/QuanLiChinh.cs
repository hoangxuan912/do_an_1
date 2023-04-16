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
    public partial class QuanLiChinh : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        //Constructor
        public QuanLiChinh()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                }
            }
        }
        public bool isAdmin { get; set; }


         
        //private void butXuatHang_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    panel1.Controls.Clear();
        //    XuatHang t = new XuatHang();
        //    t.TopLevel = false;
        //    t.AutoScroll = true;
        //    panel1.Controls.Add(t);
        //    t.Show();
        //}

        //private void butSP_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    panel1.Controls.Clear();
        //    SanPham t = new SanPham();
        //    t.TopLevel = false;
        //    t.AutoScroll = true;
        //    panel1.Controls.Add(t);
        //    t.Show();
        //}

        //private void butTK_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    panel1.Controls.Clear();
        //    TaiKhoan t = new TaiKhoan();
        //    t.TopLevel = false;
        //    t.AutoScroll = true;
        //    panel1.Controls.Add(t);
        //    t.Show();
        //}

        //private void butKH_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    panel1.Controls.Clear();
        //    KhachHang t = new KhachHang();
        //    t.TopLevel = false;
        //    t.AutoScroll = true;
        //    panel1.Controls.Add(t);
        //    t.Show();
        //}

        //private void butNCC_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    panel1.Controls.Clear();
        //    Nha_cung_cap t = new Nha_cung_cap();
        //    t.TopLevel = false;
        //    t.AutoScroll = true;
        //    panel1.Controls.Add(t);
        //    t.Show();
        //}

        //private void butNhapHang_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    panel1.Controls.Clear();
        //    NhapHang t = new NhapHang();
        //    t.TopLevel = false;
        //    t.AutoScroll = true;
        //    panel1.Controls.Add(t);
        //    t.Show();
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    this.Hide();
        //    formLogin loginForm = new formLogin();
        //    loginForm.Show();
        //}

        private void QuanLiChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void QuanLiChinh_Load(object sender, EventArgs e)
        {
            if(isAdmin)
            {
                butTK.Visible = true;
                btn_tke.Visible = true;
                butNhapHang.Visible = true;
            }
            else
            {
                butTK.Visible = false;
                btn_tke.Visible = false;
                butNhapHang.Visible = true;
                //button1.Location = new Point(-20, 245);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butSP_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel1.Controls.Clear();
            SanPham t = new SanPham();
            t.TopLevel = false;
            t.AutoScroll = true;
            t.Dock = DockStyle.Fill;
            panel1.Controls.Add(t);
            t.Show();
        }

        private void butNCC_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel1.Controls.Clear();
            Nha_cung_cap t = new Nha_cung_cap();
            t.TopLevel = false;
            t.AutoScroll = true;
            t.Dock = DockStyle.Fill;
            panel1.Controls.Add(t);
            t.Show();
        }

        private void butNhapHang_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel1.Controls.Clear();
            NhapHang t = new NhapHang();
            t.TopLevel = false;
            t.AutoScroll = true;
            t.Dock = DockStyle.Fill;
            panel1.Controls.Add(t);
            t.Show();
        }

        private void butXuatHang_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel1.Controls.Clear();
            XuatHang t = new XuatHang();
            t.TopLevel = false;
            t.AutoScroll = true;
            t.Dock = DockStyle.Fill;
            panel1.Controls.Add(t);
            t.Show();
        }

        private void butTK_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel1.Controls.Clear();
            TaiKhoan t = new TaiKhoan();
            t.TopLevel = false;
            t.AutoScroll = true;
            t.Dock = DockStyle.Fill;
            panel1.Controls.Add(t);
            t.Show();
        }

        private void btn_tke_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel1.Controls.Clear();
            BaokaoThongKe t = new BaokaoThongKe();
            t.TopLevel = false;
            t.AutoScroll = true;
            t.Dock = DockStyle.Fill;
            panel1.Controls.Add(t);
            t.Show();
        }

        private void butKH_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panel1.Controls.Clear();
            KhachHang t = new KhachHang();
            t.TopLevel = false;
            t.AutoScroll = true;
            t.Dock = DockStyle.Fill;
            panel1.Controls.Add(t);
            t.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            formLogin loginForm = new formLogin();
            loginForm.Show();
        }
    }
}
