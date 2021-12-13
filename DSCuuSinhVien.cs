using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SchoolManager
{
    public class DSCuuSinhVien
    {
        
        // Khởi tạo danh sách cựu sinh viên
        public static List<CuuSinhVien> listcsv = new List<CuuSinhVien>();
        // Tạo dữ liệu danh sách cựu sinh viên cơ bản
        public static void base_list()
        {
            CuuSinhVien csv1 = new CuuSinhVien("191","Long","24/04/2001","Nam","Binh Phuoc","032342342","CNTT",2019,"GIOI","KI SU", 2024);
            listcsv.Add(csv1);
            CuuSinhVien csv2 = new CuuSinhVien("192","Hoang","08/03/2001","Nam","Dong Nai","032342656","DDT",2019,"KHA","THO DIEN", 2024);
            listcsv.Add(csv1);
            CuuSinhVien csv3 = new CuuSinhVien("193","Hai","02/04/2001","Nam","Binh Dinh","0343564342","CNTT",2019,"GIOI","GIANG VIEN", 2024);
            listcsv.Add(csv3);
            CuuSinhVien csv4 = new CuuSinhVien("194","Minh","11/02/2001","Nam","Vung Tau","032323642","XD",2019,"KHA","KI SU", 2024);
            listcsv.Add(csv4);
        }
        // Hàm kiểm tra mã cựu sinh viên trong danh sách
        public static CuuSinhVien checkcsv(string MAcsv)
        {
            foreach (CuuSinhVien csv in listcsv)
            {
                if (String.Compare(csv.MA, MAcsv, true) == 0)
                    return csv;
            }
            return null;
        }
        // Thêm cựu sinh viên vào danh sách
        public static void addcsv()
        {
            CuuSinhVien csv = new CuuSinhVien();
            csv.input();
            listcsv.Add(csv);
            Console.WriteLine("Thêm cựu sinh viên thành công!");
            Console.WriteLine();
        }
        // In danh sách cựu sinh viên        
        public static void printcsv()
        {
            if(listcsv.Count == 0)
            {
                Console.WriteLine("Không có cựu sinh viên nào trong danh sách!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -15} {10, -10}",
                                 "Macsv", "Tencsv", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Nganh Hoc", "Nam Nhap Hoc", "Thanh Tich", "Nghe Nghiep", "Nam Ket Thuc");
            foreach (CuuSinhVien csv in listcsv)
            {
                csv.print();
            }
            Console.WriteLine();
        }
        // Sắp xếp danh sách cựu sinh viên theo tên
        public static void sort_namecsv()
        {
            if(listcsv.Count == 0)
            {
                Console.WriteLine("Không có cựu sinh viên nào trong danh sách!");
                return;
            }
            var DScsv = listcsv.OrderBy(csv=>csv.TEN);
            Console.WriteLine("Danh sách sau khi sắp xếp theo tên:");
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -15} {10, -10}",
                                 "Macsv", "Tencsv", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Nganh Hoc", "Nam Nhap Hoc", "Thanh Tich", "Nghe Nghiep", "Nam Ket Thuc");
            foreach (CuuSinhVien csv in DScsv)
            {
                csv.print();
            }
            Console.WriteLine();
        }
        // Sắp xếp cựu sinh viên theo mã số
        public static void sort_MAcsv()
        {
            if(listcsv.Count == 0)
            {
                Console.WriteLine("Không có cựu sinh viên nào trong danh sách!");
                return;
            }
            var DScsv = listcsv.OrderBy(csv=>csv.MA);
            Console.WriteLine("Danh sách sau khi sắp xếp theo mã cựu sinh viên:");
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -15} {10, -10}",
                                 "Macsv", "Tencsv", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Nganh Hoc", "Nam Nhap Hoc", "Thanh Tich", "Nghe Nghiep", "Nam Ket Thuc");
            foreach (CuuSinhVien csv in DScsv)
            {
                csv.print();
            }
            Console.WriteLine();
        }  
        // Tìm kiếm cựu sinh viên trong danh sách
        public static void searchcsv()
        {
            Console.Write("Nhập mã cựu sinh viên muốn tìm kiếm: ");
            string Macsv = Console.ReadLine();
            CuuSinhVien csv = checkcsv(Macsv);
            if (listcsv.Count == 0 || csv == null)
            {
                Console.WriteLine("Không tìm cựu thấy sinh viên!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10} {8, -15} {9, -15} {10, -10}",
                                 "Macsv", "Tencsv", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Nganh Hoc", "Nam Nhap Hoc", "Thanh Tich", "Nghe Nghiep", "Nam Ket Thuc");
            csv.print();
            Console.WriteLine();
        }
        // Xóa cựu sinh viên ra khỏi danh sách
        public static void deletecsv()
        {
            Console.Write("Nhập mã cựu sinh viên: ");
            string Macsv = Console.ReadLine();
            CuuSinhVien csv = checkcsv(Macsv);
            if (csv == null)
            {
                Console.WriteLine("Không tìm thấy cựu sinh viên!");
                return;
            }
            listcsv.Remove(csv);
            Console.WriteLine("Đã xóa thành công!");
            Console.WriteLine();

        }
        // Hàm trả về số lượng cựu sinh viên trong danh sách
        public static int SLcsv() 
        {
            return listcsv.Count;
        }
    }   
}