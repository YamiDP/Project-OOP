using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyGiangVien
{
    class managerKHOA
    {
        public static List<KHOA> listkhoa = new List<KHOA>();
        public static KHOA checkkhoa(string MaKhoa)
        {   
            foreach (KHOA khoa in listkhoa)
            {
                if (String.Compare(khoa.MAKHOA, MaKhoa, false) == 0) // so sánh tính cả chữ hoa và thường
                    return khoa;
            }
            return null;
        }
        public static void add(string makhoa)
        {
            //KHOA k;
            KHOA khoa = new KHOA();
            khoa.MAKHOA = makhoa;
            Console.Write("Ten Khoa: ");
            khoa.TENKHOA = Convert.ToString(Console.ReadLine());
            listkhoa.Add(khoa);
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
