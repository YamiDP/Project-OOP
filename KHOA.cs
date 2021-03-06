using System;
using System.Collections.Generic;
using System.Text;
namespace SchoolManager
{
    public class KHOA
    {
        private string makhoa;
        private string tenkhoa;
        private List<GiangVien> listgv1;
        private List<SinhVien> listsv1;
        private List<CuuSinhVien> listcsv1;
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
        // cac ham khoi tao
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
            this.makhoa = "123";
            this.tenkhoa = "DTCLC";
            this.listgv1 = null;
            this.listsv1 = null;
            this.listcsv1 = null;
        }
        ~KHOA() // ham huy
        {
        }
        //ham nhap thong tin 1 khoa
        public void inputKhoa()
        {
            Console.Write("Ma Khoa: ");
            MAKHOA = Convert.ToString(Console.ReadLine());
            Console.Write("Ten Khoa: ");
            TENKHOA = Convert.ToString(Console.ReadLine());
        }
        //ham in thong tin 1 khoa
        public void printKhoa()
        {
            Console.WriteLine("{0, -7} {1, -20}",
                                  MAKHOA, TENKHOA);
        }
    }
}
