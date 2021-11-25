using System;
using System.Text;
using System.Collections.Generic;
using SchoolManager.QLSinhVien;

namespace SchoolManager.QLSinhVien
{
    public class CuuSinhVien : SinhVien
    {
        private string nganhdahoc;
        public string NGANHDAHOC
        {
            set { nganhdahoc = value; }
            get { return nganhdahoc; }

        }
        private string thanhtich;
        public string THANHTICH
        {
            set { thanhtich = value; }
            get { return thanhtich; }
        }
        private string nghenghiep;
        public string NGHENGHIEP
        {
            set { nghenghiep = value; }
            get { return nghenghiep; }
        }
        
        public override void input()
        {
            base.input();
            // NGANH DA HOC
            Console.Write("Nhap nganh da hoc cua cuu sinh vien: ");
            NGANHDAHOC = Convert.ToString(Console.ReadLine());
            // THANH TICH DAT DUOC
            Console.Write("Nhap thanh tich cua cuu sinh vien: ");
            THANHTICH = Convert.ToString(Console.ReadLine());
            // NGHE NGHIEP
            Console.Write("Nhap nghe nghiep cua cuu sinh vien: ");
            NGHENGHIEP = Convert.ToString(Console.ReadLine());
        }
        public override void print()
        {
            Console.Write("MSSV cua sinh vien la: ");
            Console.WriteLine(MA);
            Console.Write("Ho va ten cua sinh vien la: ");
            Console.WriteLine(TEN);
            Console.Write("Ngay sinh cua sinh vien la: ");
            Console.WriteLine(NGSINH);
            Console.Write("Dia chi cua sinh vien la: ");
            Console.WriteLine(DIACHI);
            Console.Write("So dien thoai cua sinh vien la: ");
            Console.WriteLine(SDT);
            Console.Write("Nhap nganh hoc da hoc cua cuu sinh vien: ");
            Console.WriteLine(NGANHDAHOC);
            Console.Write("Nhap thanh tich cua cuu sinh vien: ");
            Console.WriteLine(THANHTICH);
            Console.Write("Nhap nghe nghiep cua cuu sinh vien: ");
            Console.WriteLine(NGHENGHIEP);
        }
        public override void search()
        {

        }
        public override void sort()
        {
            
        }
        public CuuSinhVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string nganh, string khoa, string thanhtich, string nghenghiep)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt, nganh, khoa)
        {
            this.nganhdahoc = nganh;
            this.thanhtich = thanhtich;
            this.nghenghiep = nghenghiep;
        }
        public CuuSinhVien(CuuSinhVien csv) 
            : this(csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANHDAHOC, csv.KHOAHOC, csv.THANHTICH, csv.NGHENGHIEP)
        {

        }    
        public CuuSinhVien()
            : base ()
        {
            this.nganhdahoc = "";
            this.thanhtich = "";
            this.nghenghiep = "";
        }
    }
}
