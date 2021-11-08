/*using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyGiangVien
{
    public class QLGV : thuoctinhCB
    {
        private string MaKhoa;
        private string TenKhoa;
        private string ChNganh;
        private string Luong;
        private string Lopday;
        private string Hocvi;
        public string MAKHOA
        {
            set { MaKhoa = value; }
            get { return MaKhoa; }
        }
        public string TENKHOA
        {
            set { TenKhoa = value; }
            get { return TenKhoa; }
        }
        public string CHNGANG
        {
            set { ChNganh = value; }
            get { return ChNganh; }
        }
        public string LUONG
        {
            set { Luong = value; }
            get { return Luong; }
        }
        public string LOPDAY
        {
            set { Lopday = value; }
            get { return Lopday; }
        }
        public string HOCVI
        {
            set { Hocvi = value; }
            get { return Hocvi; }
        }
        public void KyHopDong()
        {
            QLGV gv = new QLGV();   
            Console.Write("Nhap Ma Giang Vien: ");
            gv.MAGV = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Ten Giang Vien: ");
            gv.TENGV = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Ngay Sinh Giang Vien: ");
            gv.NGSINH = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Gioi Tinh Giang Vien: ");
            gv.GTINH = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Dia Chi Giang Vien: ");
            gv.DIACHI = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Ma Khoa cua Giang Vien: ");
            gv.MAKHOA = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Ten Khoa cua Giang Vien: ");
            gv.TENKHOA = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Chuyen Nganh cua Giang Vien: ");
            gv.CHNGANG = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Luong Giang Vien: ");
            gv.LUONG = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Lop Day cua Giang Vien: ");
            gv.LOPDAY = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap Hoc Vi cua Giang Vien: ");
            gv.HOCVI = Convert.ToString(Console.ReadLine());
        }
        public void HuyHopDong()
        {
            throw new NotImplementedException();
        }
        public void CheckMaGV()
        {
            throw new NotImplementedException();
        }
        public void ThongTinGV()
        {
            QLGV gv;
            Console.WriteLine("Ma Giang Vien: " + gv.MAGV);
            Console.WriteLine("Ten Giang Vien: " + gv.TENGV);
            Console.WriteLine("Ngay Sinh: " + gv.NGSINH);
            Console.WriteLine("Gioi Tinh: " + gv.GTINH);
            Console.WriteLine("Dia Chi: " + gv.DIACHI);
            Console.WriteLine("Ma Khoa: " + gv.MAKHOA);
            Console.WriteLine("Ten Khoa: " + gv.TENKHOA);
            Console.WriteLine("Chuyen Nganh: " + gv.CHNGANG);
            Console.WriteLine("Luong: " + gv.LUONG);
            Console.WriteLine("Lop Day: " + gv.LOPDAY);
            Console.WriteLine("Hoc Vi: " + gv.HOCVI);
        }
        public QLGV(string maGV, string tenGV, string ngSinh, string gTinh, string diaChi, string maKhoa, string tenKhoa, string chNganh, string luong, string lopday, string hocvi)
            : base (maGV,tenGV,ngSinh,gTinh,diaChi)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            ChNganh = chNganh;
            Luong = luong;
            Lopday = lopday;
            Hocvi = hocvi;
        }
        public QLGV() : base()
        { }    
    }
}*/
