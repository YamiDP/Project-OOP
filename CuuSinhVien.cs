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
        // Hàm khởi tạo cựu sinh viên
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
        ~CuuSinhVien() // Hàm hủy cựu sinh viên
        {

        }
        public void addCSV() // Hàm nhập cựu sinh viên
        {      
            base.input();
            Console.Write("Thanh tich: ");
            THANHTICH = Convert.ToString(Console.ReadLine());
            Console.Write("Nghe nghiep: ");
            NGHENGHIEP = Convert.ToString(Console.ReadLine());
            Console.Write("Nam ket thuc: ");
            NAMKETTHUC = Convert.ToInt32(Console.ReadLine());
        }
        public void printCSV() // Hàm xuất cựu sinh viên
        {
            print();
            Console.WriteLine("{0, -15} {1, -15} {2, -15}",
                                  THANHTICH, NGHENGHIEP, NAMKETTHUC);
        }
    }
}