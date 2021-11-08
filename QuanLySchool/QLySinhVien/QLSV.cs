using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLySinhVien
{
    public class QLSV
    {
        public int MASO { get; set; }
        public string HOVATEN { get; set; }
        public int TUOI { get; set; }
        public string GIOITINH { get; set; }
        public string DIACHI { get; set; }
        public int SDT { get; set; }
        public string NGANH { get; set; }
        public string KHOA { get; set; }
        struct DIEM
        {

        }
        struct TKB
        {

        }
        public int DRl { get; set; }
        public int DCTXH { get; set; }
        public void THEMSV()
        {
            QLSV sv = new QLSV();
            Console.Write("Nhap MSSV cua sinh vien: ");
            sv.MASO = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten cua sinh vien: ");
            sv.HOVATEN = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap tuoi cua sinh vien: ");
            sv.TUOI = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gioi tinh cua sinh vien: ");
            sv.GIOITINH = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap dia chi cua sinh vien: ");
            sv.DIACHI = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap sdt cua sinh vien: ");
            sv.SDT = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nganh hoc cua sinh vien: ");
            sv.NGANH = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap khoa hoc cua sinh vien: ");
            sv.KHOA = Convert.ToString(Console.ReadLine());
        }
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
    }
}
