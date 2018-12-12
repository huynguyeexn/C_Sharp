using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsForms
{
    class KETNOICSDL
    {
        public SqlConnection ketnoi = new SqlConnection("Data Source=DESKTOP-D4U9M24\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");
        public void connect()
        {
            ketnoi.Open();
        }
        public void closeconnect()
        {
            ketnoi.Close();
        }
        public DataTable taobang(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,ketnoi);
            da.Fill(tb);
            return (tb);
        }

        #region PHÒNG BAN
        
            public void thempb(string maphongban, string tenphongban,string dchi, string sodt)
            {
                string sql = "Insert into PHONGBAN(MAPB,TENPB,DIACHI,SDT)"+"values('"+maphongban+"',N'"+tenphongban+"',N'"+dchi+"',N'"+sodt+"')";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void suapb(string chon, string maphongban, string tenphongban, string dchi, string sodt)
            {
                string sql = "UPDATE PHONGBAN SET MAPB='" + maphongban + "', TENPB=N'" + tenphongban + "',DIACHI=N'" + dchi + "',SDT='" + sodt + "' WHERE MAPB='" + chon+"'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void xoapb(string maphongban)
            {
                string sql = "DELETE FROM PHONGBAN WHERE MAPB='" + maphongban + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
        
        
        #endregion

        #region CHỨC VỤ

            public void themcv(string macv, string tencv)
            {
                string sql = "Insert into CHUCVU(MACV,TENCV)" + "values('" + macv + "',N'" + tencv + "')";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void suacv(string chon, string macv, string tencv)
            {
                string sql = "UPDATE CHUCVU SET MACV='" + macv + "', TENCV='" + tencv + "' WHERE MACV='" + chon + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void xoacv(string macv)
            {
                string sql = "DELETE FROM CHUCVU WHERE MACV=N'" + macv + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
        
        #endregion

        #region TRÌNH ĐỘ HỌC VẤN
        
            public void themtdhv(string matdhv, string tentdhv, string chuyennganh)
            {
                string sql = "Insert into TRINHDOHOCVAN(MATDHV,TENTDHV,CHUYENNGANH)" + "values('" + matdhv + "',N'" + tentdhv + "',N'" + chuyennganh + "')";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void suatdhv(string chon, string matdhv, string tentdhv, string chuyennganh)
            {
                string sql = "UPDATE TRINHDOHOCVAN SET matdhv='" + matdhv + "', tentdhv='" + tentdhv + "',chuyennganh='" + chuyennganh + "' WHERE matdhv='" + chon + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void xoatdhv(string matdhv)
            {
                string sql = "DELETE FROM TRINHDOHOCVAN WHERE MATDHV='" + matdhv + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            

        #endregion

        #region Luong

            public void themluong(string BACLUONG, string LUONGCB, string HSLUONG, string HSPC)
            {
                string sql = "Insert into LUONG(BACLUONG,LUONGCB,HSLUONG,HSPC)" + "values('" + BACLUONG + "',N'" + LUONGCB + "',N'" + HSLUONG + "',N'" + HSPC + "')";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void sualuong(string chon, string BACLUONG, string LUONGCB, string HSLUONG, string HSPC)
            {
                string sql = "UPDATE LUONG SET BACLUONG='" + BACLUONG + "', LUONGCB='" + LUONGCB + "',HSLUONG='" + HSLUONG + "',HSPC='" + HSPC + "' WHERE BACLUONG='" + chon + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void xoaluong(string BACLUONG)
            {
                string sql = "DELETE FROM LUONG WHERE BACLUONG='" + BACLUONG + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }

        #endregion

        #region CHẤM CÔNG

            public void themcc(string manv, string sonc)
            {
                string sql = "Insert into CHAMCONG(MANV,SONGAYCONG)" + "values('" + manv + "',N'" + sonc + "')";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void suacc(string chon, string manv, string sonc)
            {
                string sql = "UPDATE CHAMCONG SET MANV='" + manv + "', SONGAYCONG='" + sonc + "' WHERE MANV='" + chon + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void xoacc(string manv)
            {
                string sql = "DELETE FROM CHAMCONG WHERE MANV='" + manv + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }

        #endregion

        #region NHÂN VIÊN
        public void themnv(string manv, string hoten, string ngaysinh, string quequan, string gioitinh, string dantoc, string sdt, string mapb, string macv, string matdhv, string bacluong)
        {
            string sql = "Insert into NHANVIEN(MANV,HOTENNV,NGAYSINH,QUEQUAN,GIOITINH,DANTOC,SODT,MAPB,MACV,MATDHV,BACLUONG)" + 
                "values('" + manv + "',N'" + hoten + "',N'" + ngaysinh + "',N'" + quequan + "',N'"+gioitinh+"',N'"+dantoc+"',N'"+sdt+"',N'"+mapb+"',N'"+macv+"',N'"+matdhv+"',N'"+bacluong+"')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery(); 
        }
        public void suanv(string chon, string manv, string hoten, string ngaysinh, string quequan, string gioitinh, string dantoc, string sdt, string mapb, string macv, string matdhv, string bacluong)
        {
            string sql = "UPDATE NHANVIEN SET MANV=N'" + manv + "', HOTENNV=N'" + hoten + "',NGAYSINH='" + ngaysinh + "',QUEQUAN=N'" + quequan + "',GIOITINH=N'" + gioitinh + "',DANTOC=N'" + dantoc + "',SODT='" + sdt + "',MAPB=N'" + mapb + "',MACV=N'" + macv + "',MATDHV=N'" + matdhv + "',BACLUONG=N'" + bacluong + "' WHERE MANV=N'" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoanv(string manv)
        {
            string sql = "DELETE FROM NHANVIEN WHERE MANV='" + manv + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        #endregion

        #region ĐĂNG KÝ
        public void themdk(string tendangnhap, string matkhau)
        {
            string sql = "Insert into DANGNHAP(Username,password)" + "values('" + tendangnhap + "',N'" + matkhau + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion

        #region HOPDONGLAODONG

        public void themhd(string MAHD, string MANV, string LOAIHD, string TUNGAY, string DENNGAY)
        {
            string sql = "Insert into HOPDONGLAODONG(MAHD,MANV,LOAIHD,TUNGAY,DENNGAY)" + "values(N'" + MAHD + "',N'" + MANV + "',N'" + LOAIHD + "',N'" + TUNGAY + "',N'" + DENNGAY + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void suahd(string chon, string MAHD, string MANV, string LOAIHD, string TUNGAY, string DENNGAY)
        {
            string sql = "UPDATE HOPDONGLAODONG SET MAHD=N'" + MAHD + "', MANV=N'" + MANV + "',LOAIHD=N'" + LOAIHD + "',TUNGAY='" + TUNGAY + "',DENNGAY='" + DENNGAY + "' WHERE MAHD='" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoahd(string MAHD)
        {
            string sql = "DELETE FROM HOPDONGLAODONG WHERE MAHD=N'" + MAHD + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        #endregion

        #region KHEN THƯỞNG KỸ LUẬT

            public void themktkl(string SOQD, string NGAYQD, string MANV, string TENQD, string LOAIQD, string HINHTHUC, string SOTIEN)
            {
                string sql = "Insert into KHENTHUONGKYLUAT(SOQD,NGAYQD,MANV,TENQD,LOAIQD,HINHTHUC,SOTIEN)" + "values('" + SOQD + "',N'" + NGAYQD + "',N'" + MANV + "',N'" + TENQD + "',N'" + LOAIQD + "',N'" + HINHTHUC + "',N'" + SOTIEN + "')";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void suaktkl(string chon, string SOQD, string NGAYQD, string MANV, string TENQD, string LOAIQD, string HINHTHUC, string SOTIEN)
            {
                string sql = "UPDATE KHENTHUONGKYLUAT SET SOQD='" + SOQD + "', NGAYQD='" + NGAYQD + "',MANV='" + MANV + "',TENQD='" + TENQD + "',LOAIQD='" + LOAIQD + "',HINHTHUC='" + HINHTHUC + "',SOTIEN='" + SOTIEN + "' WHERE SOQD='" + chon + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }
            public void xoaktkl(string SOQD)
            {
                string sql = "DELETE FROM KHENTHUONGKYLUAT WHERE SOQD='" + SOQD + "'";
                SqlCommand scm = new SqlCommand(sql, ketnoi);
                scm.ExecuteNonQuery();
            }

        #endregion

        #region THỜI GIAN CÔNG TÁC

        public void themtgct(string MANV, string MACV, string NGAYNHAMCHUC)
        {
            string sql = "Insert into THOIGIANCONGTAC(MANV,MACV,NGAYNHAMCHUC)" + "values('" + MANV + "',N'" + MACV + "','" + NGAYNHAMCHUC + "')";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void suatgct(string chon, string MANV, string MACV, string NGAYNHAMCHUC)
        {
            string sql = "UPDATE THOIGIANCONGTAC SET MANV='" + MANV + "', MACV='" + MACV + "',NGAYNHAMCHUC='" + NGAYNHAMCHUC + "' WHERE MANV='" + chon + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        public void xoatgct(string MANV)
        {
            string sql = "DELETE FROM THOIGIANCONGTAC WHERE MANV='" + MANV + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }

        #endregion

        #region ĐỔI MẬT KHẨU
        public void doimk(string tendangnhap, string matkhau)
        {
            string sql = "UPDATE DANGNHAP SET password=N'" + matkhau + "' WHERE username='" + tendangnhap + "'";
            SqlCommand scm = new SqlCommand(sql, ketnoi);
            scm.ExecuteNonQuery();
        }
        #endregion
        internal DataTable taobang()
        {
            throw new NotImplementedException();
        }
    }
}
