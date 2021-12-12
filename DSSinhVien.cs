using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSSinhVien 
    {
        public static List<SinhVien> listsv = new List<SinhVien>();
        public static SinhVien checkSV(string MaSV)
        {
            foreach (SinhVien sv in listsv)
            {
                if (String.Compare(sv.MA, MaSV, false) == 0)
                    return sv;
            }
            return null;
        }
        public static void inputSV()
        {
            SinhVien sv = new SinhVien();  
            sv.addSV();       
            listsv.Add(sv);
            Console.WriteLine("Them Sinh Vien thanh cong!");
        }
        public static void printSV()
        {
            if (listsv.Count == 0)
            {
                Console.WriteLine("Khong co Sinh Vien nao trong danh sach!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc");
            foreach (SinhVien sv in listsv)
            {
                sv.printSV();
            }
        }

        public static void sort()
        {
            if (listsv.Count == 0)
            {
                Console.WriteLine("Khong co Sinh Vien nao trong danh sach!");
                return;
            }
            var DSSV = listsv.OrderByDescending(sv => sv.TEN);
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc");
            foreach (SinhVien sv in DSSV)
            {
                sv.printSV();
            }
        }
        public static void deleteSV()
        {
            SinhVien k;
            Console.Write("Nhap Ma Sinh Vien: ");
            string MaSV = Console.ReadLine();
            k = checkSV(MaSV);
            if (k == null)
            {
                Console.WriteLine("Khong co Sinh Vien!");
                return;
            }
                listsv.Remove(k);
                Console.WriteLine("Da xoa thanh cong!");
        }
        public static void searchSV()
        {
            Console.Write("Nhap Ma Sinh Vien: ");
            string MaSV = Console.ReadLine();
            SinhVien sv = checkSV(MaSV);
            if (listsv.Count == 0 || sv == null)
            {
                Console.WriteLine("Khong tim thay Sinh Vien!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
              "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc");
            sv.printSV();
        }
        public static int slSV() 
        {
            return listsv.Count;
        }
    }
}
