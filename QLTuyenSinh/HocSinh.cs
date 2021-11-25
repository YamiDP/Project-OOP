using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLTuyenSinh
{
    public class HocSinh : Person
    {
        private double diemthi;
        private string khoithi;
        private string nganh;
        private int dienUT;
        private int soluongNV;
        private string phuongthucxettuyen;
        public double Diemthi
        {
            set { diemthi = value; }
            get { return diemthi; }
        }
        public string Khoithi
        {
            set { khoithi = value; }
            get { return khoithi; }
        }
        public string Nganh
        {
            set { nganh = value; }
            get { return nganh; }
        }
        public int DienUT
        {
            set { dienUT = value; }
            get { return dienUT; }
        }
        public int SoluongNV
        {
            set { soluongNV = value; }
            get { return soluongNV; }
        }
        public string Phuongthucxettuyen
        {
            set { phuongthucxettuyen = value; }
            get { return phuongthucxettuyen; }
        }
        public override void sort()
        {
        }
        public override void search()
        {
        }
        public override void print()
        {
        }


        public HocSinh(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt,
        double diemthi, string khoithi, string nganh, int dienUT, int soluongNV, string phuongthucxettuyen)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.diemthi = diemthi;
            this.khoithi = khoithi;
            this.nganh = nganh;
            this.dienUT = dienUT;
            this.soluongNV = soluongNV;
            this.phuongthucxettuyen = phuongthucxettuyen;
        }
        public HocSinh(HocSinh hs) : this(hs.MA, hs.TEN, hs.NGSINH, hs.GTINH, hs.DIACHI, hs.SDT,
        hs.Diemthi, hs.Khoithi, hs.Nganh, hs.DienUT, hs.SoluongNV, hs.Phuongthucxettuyen)
        {
        }
        public HocSinh() 
            : base()
        {
            diemthi = 0.0;
            khoithi = "N/A";
            nganh = "N/A";
            dienUT = 0;
            soluongNV = 0;
            phuongthucxettuyen = "N/A";
        }
    }
}
