using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyGiangVien
{
    public class KHOA
    {
        private string MaKhoa;
        private string TenKhoa;
        List<GiangVien> listgv1 = new List<GiangVien>();
        public string MAKHOA
        {
            set { MaKhoa = value; }
            get { return MaKhoa; }
        }
        public string TENKHOA
        {
            set { TenKhoa = value; }
            get { return TenKhoa; }
        }
        internal List<GiangVien> Listgv1
        {
            set { listgv1 = value; }
            get { return listgv1; }
        }
    }
}
