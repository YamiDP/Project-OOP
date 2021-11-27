using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLGiangVien;
using SchoolManager.QLCuuSinhVien;
using SchoolManager.QLSinhVien;

namespace SchoolManager.QLKhoa
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
