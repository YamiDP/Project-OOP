using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSCuuSinhVien 
    {
        // Tạo danh sách cựu sinh viên
        public static List<CuuSinhVien> listcsv = new List<CuuSinhVien>();
        // Tạo dữ liệu danh sách cựu sinh viên cơ bản
        public static void base_list()
        {
            CuuSinhVien csv1 = new CuuSinhVien("191","Long","24/04/2001","Nam","Binh Phuoc","032342342","CNTT",2019, new List<MonHoc>(),"GIOI","KI SU",2024);
            listcsv.Add(csv1);
            CuuSinhVien csv2 = new CuuSinhVien("192","Hoang","08/03/2001","Nam","Dong Nai","032342656","DDT",2019, new List<MonHoc>(),"KHA","THO DIEN",2024);
            listcsv.Add(csv1);
            CuuSinhVien csv3 = new CuuSinhVien("193","Hai","02/04/2001","Nam","Binh Dinh","0343564342","CNTT",2019, new List<MonHoc>(),"GIOI","GIANG VIEN",2024);
            listcsv.Add(csv3);
            CuuSinhVien csv4 = new CuuSinhVien("194","Minh","11/02/2001","Nam","Vung Tau","032323642","XD",2019, new List<MonHoc>(),"KHA","KI SU",2024);
            listcsv.Add(csv4);
        }
        // Hàm kiểm tra mã cựu sinh viên trong danh sách
        public static CuuSinhVien checkCSV(string MaCSV)
        {
            foreach (CuuSinhVien csv in listcsv)
            {
                if (String.Compare(csv.MA, MaCSV, false) == 0)
                    return csv;
            }
            return null;
        }
        // Hàm nhập cựu sinh viên vào danh sách
        public static void addCSV()
        {
            CuuSinhVien csv = new CuuSinhVien();  
            csv.input();       
            listcsv.Add(csv);
            Console.WriteLine("Them Cuu Sinh Vien thanh cong!");
        }
        // Hàm xuất cựu sinh viên trong danh sách
        public static void printCSV()
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
        // Hàm sắp xếp cựu sinh viên theo tên trong danh sách
        public static void sort()
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
        // Hàm xóa cựu sinh viên trong danh sách
        public static void deleteCSV()
        {
            CuuSinhVien k;
            Console.Write("Nhap Ma Cuu Sinh Vien: ");
            string MaCSV = Console.ReadLine();
            k = checkCSV(MaCSV);
            if (k == null)
            {
                Console.WriteLine("Khong co Cuu Sinh Vien!");
                return;
            }
                listcsv.Remove(k);
                Console.WriteLine("Da xoa thanh cong!");
        }
        // Hàm tìm kiếm cựu sinh viên trong danh sách
        public static void searchCSV()
        {
            Console.Write("Nhap Ma Cuu Sinh Vien: ");
            string MaCSV = Console.ReadLine();
            CuuSinhVien csv = checkCSV(MaCSV);
            if (listcsv.Count == 0 || csv == null)
            {
                Console.WriteLine("Khong tim thay Cuu Sinh Vien!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -15} {10, -10}",
                  "MaCSV", "TencSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc", "Thanh Tich", "Nghe Nghiep", "Nam Ket Thuc");
            csv.print();
        }
        // Hàm trả về số lượng cựu sinh viên trong danh sách
        public static int slCSV() 
        {
            return listcsv.Count;
        }
    }
}
