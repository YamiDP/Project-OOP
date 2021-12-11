using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class CuuSinhVien : SinhVien
    {
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
        private int namketthuc;
        public int NAMKETTHUC
        {
            set { namketthuc = value; }
            get { return namketthuc; }
        }
        public CuuSinhVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string nganh, int namnhaphoc, string thanhtich, string nghenghiep, int namketthuc)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt, nganh, namnhaphoc)
        {
            this.thanhtich = thanhtich;
            this.nghenghiep = nghenghiep;
            this.namketthuc = namketthuc;
        }
        public CuuSinhVien(CuuSinhVien csv)
            : this(csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANH, csv.NAMNHAPHOC, csv.THANHTICH, csv.NGHENGHIEP, csv.NAMKETTHUC)
        {
        }
        public CuuSinhVien()
            : base()
        {
            this.thanhtich = "";
            this.nghenghiep = "";
            this.namketthuc = 2004;
        }
        public static List<CuuSinhVien> listcsv = new List<CuuSinhVien>();
        public static CuuSinhVien checkCSV(string MaSV)
        {
            foreach (CuuSinhVien csv in listcsv)
            {
                if (String.Compare(csv.MA, MaSV, false) == 0)
                    return csv;
            }
            return null;
        }
        public void inputCSV() // Hàm nhập sinh viên
        {
            CuuSinhVien csv;
            do
            { 
                Console.Write("Ma Cuu Sinh Vien: ");
                MA = Convert.ToString(Console.ReadLine());
                csv = checkCSV(MA);
                if (csv != null)
                {
                    Console.WriteLine("Ma Cuu Sinh Vien da ton tai !");
                    Console.WriteLine("Vui long nhap lai !");
                }
            } while (csv != null);
            base.input();
            Console.Write("Nhap nganh hoc cua cuu sinh vien: ");
            NGANH = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap nam nhap hoc cua cuu sinh vien: ");
            NAMNHAPHOC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thanh tich cua cuu sinh vien: ");
            THANHTICH = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap nghe nghiep cua cuu sinh vien: ");
            NGHENGHIEP = Convert.ToString(Console.ReadLine());
            csv = new CuuSinhVien(MA, TEN, NGSINH, GTINH, DIACHI, SDT, NGANH, NAMNHAPHOC,THANHTICH, NGHENGHIEP, NAMKETTHUC);
            listcsv.Add(csv);
            Console.WriteLine("Them Cuu Sinh Vien thanh cong !");
        }
        public override void print() // Hàm xuất sinh viên
        {
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -10}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc", "Thanh tich", "Nghe Nghiep");
            foreach (CuuSinhVien csv in listcsv)
            {
                Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -10} {6, -10} {7, -10} {8, -10} {9, -10}",
                                  csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANH, csv.NAMNHAPHOC, csv.THANHTICH, csv.NGHENGHIEP, csv.NAMKETTHUC);
            }
        }
    }
}