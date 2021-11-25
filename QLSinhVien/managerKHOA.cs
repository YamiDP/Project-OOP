using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLSinhVien
{
    public class managerKHOA : KHOA
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
        public void add(string makhoa)
        {
            KHOA k;
            MAKHOA = makhoa;
            Console.Write("Ten Khoa: ");
            TENKHOA = Convert.ToString(Console.ReadLine());
            k = new KHOA(MAKHOA, TENKHOA, new List<SinhVien>());
            listkhoa.Add(k);
            Console.WriteLine("Them Khoa thanh cong!");
        }
        public static void xuat()
        {
            int check = 0;
            Console.WriteLine("{0, -7} {1, -20}",
                  "MaKhoa", "TenKhoa");
            foreach (KHOA khoa in listkhoa)
            {
                check++;
                Console.WriteLine("{0, -7} {1, -20}",
                                  khoa.MAKHOA, khoa.TENKHOA);
            }
            if (check == 0)
            {
                Console.WriteLine("Khong co Khoa de hien thi!");
            }
            Console.WriteLine();
        }
    }
}
