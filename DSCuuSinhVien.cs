using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSCuuCuuSinhVien 
    {
        // Tạo danh sách cựu sinh viên
        public static List<CuuSinhVien> listcsv = new List<CuuSinhVien>();
        public static CuuSinhVien checkSV(string MaCSV)
        {
            foreach (CuuSinhVien csv in listcsv)
            {
                if (String.Compare(csv.MA, MaCSV, false) == 0)
                    return csv;
            }
            return null;
        }
        public static void inputCSV() // Hàm nhập cựu sinh viên vào danh sách
        {
            CuuSinhVien csv = new CuuSinhVien();  
            csv.input();       
            listcsv.Add(csv);
            Console.WriteLine("Them Cuu Sinh Vien thanh cong!");
        }
        public static void printCSV() // Hàm xuất cựu sinh viên trong danh sách
        {
            if (listcsv.Count == 0)
            {
                Console.WriteLine("Khong co Cuu Sinh Vien nao trong danh sach!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -15} {10, -10}",
                  "MaCSV", "TenCSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai","Nganh hoc", "Khoa hoc", "Thanh Tich", "Nghe Nghiep", "Nam Ket Thuc");
            foreach (CuuSinhVien csv in listcsv)
            {
                csv.print();
            }
        }
        public static void sort() // Hàm sắp xếp cựu sinh viên theo tên trong danh sách
        {
            if (listcsv.Count == 0)
            {
                Console.WriteLine("Khong co Cuu Sinh Vien nao trong danh sach!");
                return;
            }
            var DSCSV = listcsv.OrderByDescending(csv => csv.TEN);
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -15} {10, -10}",
                  "MaCSV", "TenCSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc", "Thanh Tich", "Nghe Nghiep", "Nam Ket Thuc");
            foreach (CuuSinhVien csv in DSCSV)
            {
                csv.print();
            }
        }
        public static void deleteCSV() // Hàm xóa cựu sinh viên trong danh sách
        {
            CuuSinhVien k;
            Console.Write("Nhap Ma Cuu Sinh Vien: ");
            string MaCSV = Console.ReadLine();
            k = checkSV(MaCSV);
            if (k == null)
            {
                Console.WriteLine("Khong co Cuu Sinh Vien!");
                return;
            }
                listcsv.Remove(k);
                Console.WriteLine("Da xoa thanh cong!");
        }
        public static void searchCSV() // Hàm tìm kiếm cựu sinh viên trong danh sách
        {
            Console.Write("Nhap Ma Cuu Sinh Vien: ");
            string MaCSV = Console.ReadLine();
            CuuSinhVien csv = checkSV(MaCSV);
            if (listcsv.Count == 0 || csv == null)
            {
                Console.WriteLine("Khong tim thay Cuu Sinh Vien!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -15} {10, -10}",
                  "MaCSV", "TencSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc", "Thanh Tich", "Nghe Nghiep", "Nam Ket Thuc");
            csv.print();
        }
        public static int slCSV() 
        {
            return listcsv.Count;
        }
    }
}
