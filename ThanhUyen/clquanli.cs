using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhUyen
{
    internal class clquanli:ConnectData
    {
        //Nhà Cung cấp
        public string NCC_Ten, NCC_TenCTY, NCC_DiaChi,NCC_Sdt;
        public string ncc_ten { get { return NCC_Ten; } set { NCC_Ten = value; } }
        public string ncc_cty { get { return NCC_Ten; } set { NCC_Ten = value; } }
        public string ncc_diachi { get { return NCC_Ten; } set { NCC_Ten = value; } }
        public string ncc_sdt { get { return NCC_Ten; } set { NCC_Ten = value; } }


        //Khách Hàng
        public string KH_Ma,KH_Ten,KH_DiaChi,KH_Sdt;
        public string kh_ma { get { return KH_Ma; } set { KH_Ma = value; } }
        public string kh_ten { get { return KH_Ten; } set { KH_Ten = value; } }
        public string kh_diachi { get { return KH_DiaChi; } set { KH_DiaChi = value; } }
        public string kh_sdt { get { return KH_Sdt; } set { KH_Sdt = value; } }


        //Tài khoản
        public string TK_Ma, TK_Tk, TK_Mk, TK_QuyenTruyCap;
        public string tk_ma { get { return TK_Ma; } set { TK_Ma = value; } }
        public string tk_tk { get { return TK_Tk; } set { TK_Tk = value; } }
        public string tk_mk { get { return TK_Mk; } set { TK_Mk = value; } }
        public string tk_quyentruycap { get { return TK_QuyenTruyCap; } set { TK_QuyenTruyCap = value; } }

        //Sản Phẩm
        public string SP_Ma, SP_Ten;
        public int SP_SoLuong;
        public int SP_GiaBan;
        public string sp_ma { get { return SP_Ma; } set { SP_Ma = value; } }
        public string sp_ten { get { return SP_Ten; } set { SP_Ten = value; } }
        public int sp_soluong { get { return SP_SoLuong; } set { SP_SoLuong = value; } }
        public int sp_giaban { get { return SP_GiaBan; } set { SP_GiaBan = value; } }


        //Nhập Hàng
        public int NH_Ma, NH_SoLuong;
        public string NH_Ngay;
        public int nh_ma { get { return NH_Ma; } set { NH_Ma = value; } }
        public int nh_soluong { get { return NH_SoLuong; } set { NH_SoLuong = value; } }
        public string nh_ngay { get { return NH_Ngay; } set { NH_Ngay = value; } }



        //Xuất Hàng
        public int XH_Ma, XH_SoLuong;
        public int XH_TongTien;
        public string XH_Ngay;
        public int xh_ma { get { return XH_Ma; } set { XH_Ma = value; } }
        public int xh_soluong { get { return XH_SoLuong; } set { XH_SoLuong = value; } }
        public int xh_tongtien { get { return XH_TongTien; } set { XH_TongTien = value; } }
        public string xh_ngay { get { return XH_Ngay; } set { XH_Ngay = value; } }

        //Khởi tạo Constructor
        public clquanli(
            string nCC_Ten, string nCC_TenCTY, string nCC_DiaChi, string nCC_Sdt, 
            string kH_Ma, string kH_Ten, string kH_DiaChi, string kH_Sdt, 
            string tK_Ma, string tK_Tk, string tK_Mk, string tK_QuyenTruyCap, 
            string sP_Ma, string sP_Ten, int sP_SoLuong, int sP_GiaBan, 
            int nH_Ma, int nH_SoLuong, string nH_Ngay, 
            int xH_Ma, int xH_SoLuong, int xH_TongTien, string xH_Ngay)
        {
            NCC_Ten = nCC_Ten;
            NCC_TenCTY = nCC_TenCTY;
            NCC_DiaChi = nCC_DiaChi;
            NCC_Sdt = nCC_Sdt;
            KH_Ma = kH_Ma;
            KH_Ten = kH_Ten;
            KH_DiaChi = kH_DiaChi;
            KH_Sdt = kH_Sdt;
            TK_Ma = tK_Ma;
            TK_Tk = tK_Tk;
            TK_Mk = tK_Mk;
            TK_QuyenTruyCap = tK_QuyenTruyCap;
            SP_Ma = sP_Ma;
            SP_Ten = sP_Ten;
            SP_SoLuong = sP_SoLuong;
            SP_GiaBan = sP_GiaBan;
            NH_Ma = nH_Ma;
            NH_SoLuong = nH_SoLuong;
            NH_Ngay = nH_Ngay;
            XH_Ma = xH_Ma;
            XH_SoLuong = xH_SoLuong;
            XH_TongTien = xH_TongTien;
            XH_Ngay = xH_Ngay;
        }

        public clquanli()
        {
            NCC_Ten = NCC_TenCTY = NCC_DiaChi = NCC_Sdt =
            KH_Ma = KH_Ten = KH_DiaChi = KH_Sdt =
            TK_Ma = TK_Tk = TK_Mk = TK_QuyenTruyCap =
            SP_Ma = SP_Ten = "";
        }



        //Thêm Dữ Liệu
        public void Insert_NhaCungCap()
        {
            string CauLenhThem = "insert into NhaCungCap values(N'" + NCC_Ten + "',N'" + NCC_TenCTY + "',N'" + NCC_DiaChi + "',N'" + NCC_Sdt + "')";
            sqlCon = new SqlCommand(CauLenhThem, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Insert_KhachHang()
        {
            string CauLenhThem = "insert into KhachHang values('" + KH_Ten + "',N'" + KH_DiaChi + "',N'" + KH_Sdt + "')";
            sqlCon = new SqlCommand(CauLenhThem, Conn);
            sqlCon.ExecuteNonQuery();
        } 
        public void Insert_TaiKhoan()
        {
            string CauLenhThem = "insert into TaiKhoan values(N'" + TK_Tk + "',N'" + TK_Mk + "',N'" + TK_QuyenTruyCap + "')";
            sqlCon = new SqlCommand(CauLenhThem, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Insert_SanPham()
        {
            string CauLenhThem = "insert into SanPham values(N'" + SP_Ma + "',N'" + SP_Ten + "',N'" + SP_SoLuong + "',N'" + SP_GiaBan + "',N'" + NCC_Ten + "')";
            sqlCon = new SqlCommand(CauLenhThem, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Insert_NhapHang()
        {
            string CauLenhThem = "insert into CTPhieuNhapHang values(N'" + SP_Ma + "',N'" + NH_SoLuong + "',N'" + NH_Ngay + "')";
            sqlCon = new SqlCommand(CauLenhThem, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Insert_XuatHang()
        {
            string CauLenhThem = "insert into CTPhieuXuatHang values(N'" + KH_Ma + "',N'" + SP_Ma + "',N'" + XH_SoLuong + "',N'" + XH_TongTien + "',N'" + XH_Ngay + "')";
            sqlCon = new SqlCommand(CauLenhThem, Conn);
            sqlCon.ExecuteNonQuery();
        }



        //Cập Nhật
        public void Update_NhaCungCap()
        {
            string CauLenhSua = "update NhaCungCap set NhaCungCap_ten=N'" + NCC_TenCTY + "',NhaCungCap_diachi=N'" + NCC_DiaChi + "',NhaCungCap_sdt=N'" + NCC_Sdt + "' where NhaCungCap_id='" + NCC_Ten + "' ";
            sqlCon = new SqlCommand(CauLenhSua, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Update_KhachHang()
        {
            string CauLenhSua = "update KhachHang set KhachHang_ten=N'" + KH_Ten + "',KhachHang_diachi=N'" + KH_DiaChi + "',KhachHang_sdt=N'" + KH_Sdt + "' where KhachHang_id='" + KH_Ma + "'";
            sqlCon = new SqlCommand(CauLenhSua, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Update_SanPham()
        {
            string CauLenhSua = "update SanPham set SanPham_ten=N'" + SP_Ten + "',SanPham_sl=N'" + SP_SoLuong + "',SanPham_GiaBan=N'" + SP_GiaBan + "',NhaCungCap_id=N'" + NCC_Ten + "' where SanPham_id='" + SP_Ma + "'";
            sqlCon = new SqlCommand(CauLenhSua, Conn);
            sqlCon.ExecuteNonQuery();
        }
        

        //Xóa
        public void Delete_NhaCungCap()
        {
            string CauLenhXoa = "delete from NhaCungCap where NhaCungCap_id='" + NCC_Ten + "'";
            sqlCon = new SqlCommand(CauLenhXoa, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Delete_KhachHang()
        {
            string CauLenhXoa = "delete from KhachHang where KhachHang_id='" + KH_Ma + "'";
            sqlCon = new SqlCommand(CauLenhXoa, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Delete_TaiKhoan()
        {
            string CauLenhXoa = "delete from TaiKhoan where TaiKhoan_TK='" + TK_Tk + "'";
            sqlCon = new SqlCommand(CauLenhXoa, Conn);
            sqlCon.ExecuteNonQuery();
        }
        public void Delete_SanPham()
        {
            string CauLenhXoa = "delete from SanPham where SanPham_id='" + SP_Ma + "'";
            sqlCon = new SqlCommand(CauLenhXoa, Conn);
            sqlCon.ExecuteNonQuery();
        }
        

    }
}
