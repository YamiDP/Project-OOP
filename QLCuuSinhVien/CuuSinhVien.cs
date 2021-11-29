using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLSinhVien;
using SchoolManager.QLMonHoc;

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
        private int namketthuc;
        public int NAMKETTHUC
        {
            set { namketthuc = value; }
            get { return namketthuc; }
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
        public CuuSinhVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string nganh, int namnhaphoc, List<MonHoc> listmhsv, string thanhtich, string nghenghiep, int namketthuc)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt, nganh, namnhaphoc, listmhsv)
        {
            this.thanhtich = thanhtich;
            this.nghenghiep = nghenghiep;
            this.namketthuc = namketthuc;
        }
        public CuuSinhVien(CuuSinhVien csv)
            : this(csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANH, csv.NAMNHAPHOC, csv.ListmhSV,csv.THANHTICH, csv.NGHENGHIEP, csv.NAMKETTHUC)
        {
        }
        public CuuSinhVien()
            : base()
        {
            this.thanhtich = "";
            this.nghenghiep = "";
            this.namketthuc = 2004;
        }
    }
}