using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLSinhVien
{
    public class KHOA
    {
        private string makhoa;
        private string tenkhoa;
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
        internal List<SinhVien> Listsv1
        {
            set { listsv1 = value; }
            get { return listsv1; }
        }
        internal List<CuuSinhVien> Listcsv1
        {
            set { listcsv1 = value; }
            get { return listcsv1; }
        }
        public KHOA(string makhoa, string tenkhoa, List<SinhVien> listsv1)
        {
            this.makhoa = makhoa;
            this.tenkhoa = tenkhoa;
            this.listsv1 = listsv1;
        }
        public KHOA(KHOA khoa)
        : this(khoa.MAKHOA, khoa.TENKHOA, khoa.Listsv1)
        {
        }
        public KHOA()
        {
            this.makhoa = "";
            this.tenkhoa = "";
            this.listsv1 = null;
        }
        
    }
}
