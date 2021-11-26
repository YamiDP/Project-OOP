using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLNhanVienHanhChinh
{
    public class NhanVien : Person
    {
        private string cviec;
        private string luong;

        public string CVIEC
        {
            set { cviec = value; }
            get { return cviec; }
        }
        public string LUONG
        {
            set { luong = value; }
            get { return luong; }
        }
        public override void print()
        {
        }
        public override void sort()
        {
        }    
        public override void search()
        {
        }

        public NhanVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string cviec, string luong)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.cviec = cviec;
            this.luong = luong;
        }
        public NhanVien(NhanVien nhanVien)
            : this(nhanVien.MA, nhanVien.TEN, nhanVien.NGSINH, nhanVien.GTINH, nhanVien.DIACHI, nhanVien.SDT, nhanVien.CVIEC, nhanVien.LUONG)
        {
        }
        public NhanVien()
            : base()
        {
            this.cviec = "";
            this.luong = "";
        }
    }
}
