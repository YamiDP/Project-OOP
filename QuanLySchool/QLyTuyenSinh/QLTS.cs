using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyTuyenSinh
{
    public class QLTS
    {
        private string sbd;
        public string SBD
        {
            set { sbd = value; }
            get { return sbd; }
        }
        private string hovaten;
        public string HoVaTen
        {
            set { hovaten = value; }
            get { return hovaten; }
        }
        private string khoithi;
        public string Khoithi
        {
            set { khoithi = value; }
            get { return khoithi; }
        }
        private double diemthi;
        public double Diemthi
        {
            set { diemthi = value; }
            get { return diemthi; }
        }
        private string nganh;
        public string Nganh
        {
            set { nganh = value; }
            get { return nganh; }
        }
        private string diachi;
        public string DiaChi
        {
            set { diachi = value; }
            get { return diachi; }
        }
        private int dienuutien;
        public int DienUuTien
        {
            set { dienuutien = value; }
            get { return dienuutien; }
        }
        private int soNVdangki;
        public int SoNVDangKi
        {
            set { soNVdangki = value; }
            get { return soNVdangki; }
        }
        private string phuongthucxettuyen;
        public string PhuongThucXetTuyen
        {
            set { phuongthucxettuyen = value; }
            get { return phuongthucxettuyen; }
        }
        public static int Count = 0;
        public void NopHoSo()
        {
            throw new NotImplementedException();
        }
        public void DangKyThamQuan()
        {
            throw new NotImplementedException();
        }
        public void DoSomeThing()
        {
            throw new NotImplementedException();
        }
        public void InThongTinHS()
        {
            Console.WriteLine("So bao danh: " + sbd + "\n");
            Console.WriteLine("Ho va ten: " + hovaten + "\n");
            Console.WriteLine("Khoi thi: " + khoithi + "\n");
            Console.WriteLine("Diem thi: " + diemthi + "\n");
            Console.WriteLine("Nganh: " + nganh + "\n");
            Console.WriteLine("Dia chi: " + diachi + "\n");
            Console.WriteLine("Dien uu tien: " + dienuutien + "\n");
            Console.WriteLine("So nguyen vong da dang ky: " + soNVdangki + "\n");
            Console.WriteLine("Phuong thuc xet tuyen: " + phuongthucxettuyen + "\n");
            Console.WriteLine("****************************************************** \n");
        }
        public QLTS()
        {
            Count++;
        }
        public QLTS(string sbd, string hovaten, string khoithi, double diemthi, string nganh,
        string diachi, int dienuutien, int soNVdangki, string phuongthucxettuyen)
        {
            this.sbd = sbd;
            this.hovaten = hovaten;
            this.khoithi = khoithi;
            this.diemthi = diemthi;
            this.nganh = nganh;
            this.diachi = diachi;
            this.dienuutien = dienuutien;
            this.soNVdangki = soNVdangki;
            this.phuongthucxettuyen = phuongthucxettuyen;
            Count++;
        }
    }
}
