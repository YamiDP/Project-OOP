using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLSinhVien;

namespace SchoolManager.QLCuuSinhVien
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

        public override void print()
        {
        }
        public override void search()
        {
        }
        public override void sort()
        {
        }
        public CuuSinhVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string nganh, int namnhaphoc, string thanhtich, string nghenghiep)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt, nganh, namnhaphoc)
        {
            this.thanhtich = thanhtich;
            this.nghenghiep = nghenghiep;
        }
        public CuuSinhVien(CuuSinhVien csv)
            : this(csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANH, csv.NAMNHAPHOC, csv.THANHTICH, csv.NGHENGHIEP)
        {
        }
        public CuuSinhVien()
            : base()
        {
            this.thanhtich = "";
            this.nghenghiep = "";
        }
    }
}