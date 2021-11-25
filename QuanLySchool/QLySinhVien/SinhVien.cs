using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLySinhVien
{
    public class SinhVien : Person
    {
        private string khoahoc;
        public string KHOAHOC
        {
            set { khoahoc = value; }
            get { return khoahoc; }
        }
        private string nganh;
        public string NGANH
        {
            set { nganh = value; }
            get { return nganh; }

        }
        struct DIEM
        {

        }
        struct TKB
        {

        }
        public int DRl { get; set; }
        public int DCTXH { get; set; }
        public void DANGKIHOC()
        {
            throw new NotImplementedException();
        }
        public void DANGKIDOAN()
        {
            throw new NotImplementedException();
        }
        public void TTHOCPHI()
        {
            throw new NotImplementedException();
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
        public SinhVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string nganh, string khoahoc)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.nganh = nganh;
            this.khoahoc = khoahoc;
        }
        public SinhVien(SinhVien sv)
            : this(sv.MA, sv.TEN, sv.NGSINH, sv.GTINH, sv.DIACHI, sv.SDT, sv.NGANH, sv.KHOAHOC)
        {

        }
        public SinhVien()
            : base()
        {
            this.nganh = "";
            this.khoahoc = "";
        }
    }
}
