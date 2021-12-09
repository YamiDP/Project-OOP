using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLGiangVien;
using SchoolManager.QLSinhVien;
using SchoolManager.QLCuuSinhVien;

namespace SchoolManager.QLKhoa
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
            this.makhoa = "123";
            this.tenkhoa = "DTCLC";
            this.listgv1 = null;
            this.listsv1 = null;
            this.listcsv1 = null;
        }
    }
}
/* namespace SchoolManager.QLKhoa
{
   public class managerKhoa :KHOA
    {
        public static List<KHOA> listkhoa = new List<KHOA>();
        public static KHOA checkkhoa(string MaKhoa)
        {
            foreach (KHOA khoa in listkhoa)
            {
                if (String.Compare(khoa.MAKHOA, MaKhoa, false) == 0)
                    return khoa;
            }
            return null;
        }
        public void inputKhoa(string makhoa)
        {
            KHOA k;
            MAKHOA = makhoa;
            Console.Write("Ten Khoa: ");
            TENKHOA = Convert.ToString(Console.ReadLine());
            k = new KHOA(MAKHOA, TENKHOA, new List<GiangVien>(), new List<SinhVien>(), new List<CuuSinhVien>());
            listkhoa.Add(k);
            Console.WriteLine("Them Khoa thanh cong!");
        }
        public static void printKhoa()
        {
            Console.WriteLine("{0, -7} {1, -20}",
                  "MaKhoa", "TenKhoa");
            foreach (KHOA khoa in listkhoa)
            {
                Console.WriteLine("{0, -7} {1, -20}",
                                  khoa.MAKHOA, khoa.TENKHOA);
            }
            if (listkhoa.Count == 0)
            {
                Console.WriteLine("Khong co Khoa de hien thi!");
            }
            Console.WriteLine();
        }
    }
}
 */