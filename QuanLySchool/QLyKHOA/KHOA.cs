using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLyGiangVien;
using SchoolManager.QLySinhVien;
using SchoolManager.QLyCuuSinhVien;

namespace SchoolManager.QLyKHOA
{
    public class KHOA
    {
        private string makhoa;
        private string tenkhoa;
        List<GiangVien> listgv1;
        List<SinhVien> listsv1;
        List<CuuSinhVien> listcsv1;
        public string MAKHOA
        {
            set { makhoa = value; }
            get { return makhoa; }
        }
        public string TENKHOA
        {
            set { tenkhoa = value; }
            get { return tenkhoa; }
        }
        public List<GiangVien> Listgv1
        {
            set { listgv1 = value; }
            get { return listgv1; }
        }
        public List<SinhVien> Listsv1
        {
            set { listsv1 = value; }
            get { return listsv1; }
        }
        public List<CuuSinhVien> Listcsv1
        {
            set { listcsv1 = value; }
            get { return listcsv1; }
        }
        public KHOA(string makhoa, string tenkhoa, List<GiangVien> listgv1, List<SinhVien> listsv1, List<CuuSinhVien> listcsv1)
        {
            this.makhoa = makhoa;
            this.tenkhoa = tenkhoa;
            this.listgv1 = listgv1;
            this.listsv1 = listsv1;
            this.listcsv1 = listcsv1;
        }
        public KHOA(KHOA khoa)
            : this(khoa.MAKHOA, khoa.TENKHOA, khoa.Listgv1, khoa.Listsv1, khoa.Listcsv1)
        {
        }
        public KHOA()
        {
            this.makhoa = "";
            this.tenkhoa = "";
            this.listgv1 = null;
            this.listsv1 = null;
            this.listcsv1 = null;
        }
    }
}
