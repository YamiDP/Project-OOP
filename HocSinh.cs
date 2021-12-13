using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
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
        //Ham nhap thong tin hoc sinh
        public override void input()
        {
            base.input();
            Console.Write("Diem thi: ");
            Diemthi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Khoi thi: ");
            Khoithi = Convert.ToString(Console.ReadLine());
            Console.Write("Nganh: ");
            Nganh = Convert.ToString(Console.ReadLine());
            Console.Write("Dien uu tien: ");
            DienUT = Convert.ToInt16(Console.ReadLine());
            Console.Write("So luong nguyen vong: ");
            SoluongNV = Convert.ToInt16(Console.ReadLine());
            Console.Write("Phuong thuc xet tuyen: ");
            Phuongthucxettuyen = Convert.ToString(Console.ReadLine());
        }
        //Ham in thong tin mot hoc sinh
        public override void print()
        {
            Console.WriteLine("{0, -7} {1, -20} {2, -10} {3, -10} {4, -15} {5,-15} {6,-10} {7,-9} {8,-10} {9,-10} {10,-12} {11,-10}",
                                   MA, TEN, NGSINH, GTINH, DIACHI, SDT, Diemthi, Khoithi, Nganh, DienUT, SoluongNV, Phuongthucxettuyen);
        }

        //Cac ham khoi tao
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
        //Ham huy
        ~HocSinh()
        {
            
        }
    }
}
