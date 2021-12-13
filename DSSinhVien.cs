using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SchoolManager
{
    public class DSSinhVien
    {
        
        // Khởi tạo danh sách sinh viên
        public static List<SinhVien> listsv = new List<SinhVien>();
        // Tạo dữ liệu danh sách sinh viên cơ bản
        public static void base_list()
        {
            SinhVien sv1 = new SinhVien("201","Phuong","02/02/2002","Nam","Binh Phuoc","032342342","CNTT",2020);
            listsv.Add(sv1);
            SinhVien sv2 = new SinhVien("202","Dat","04/03/2002","Nam","Dong Nai","032342656","DDT",2020);
            listsv.Add(sv1);
            SinhVien sv3 = new SinhVien("203","Tuan","02/04/2002","Nam","Binh Dinh","0343564342","CNTT",2020);
            listsv.Add(sv3);
            SinhVien sv4 = new SinhVien("204","Hung","11/02/2002","Nam","Vung Tau","032323642","XD",2020);
            listsv.Add(sv4);
        }
        // Hàm kiểm tra mã sinh viên trong danh sách
        public static SinhVien checkSV(string MASV)
        {
            foreach (SinhVien sv in listsv)
            {
                if (String.Compare(sv.MA, MASV, true) == 0)
                    return sv;
            }
            return null;
        }
        // Thêm sinh viên vào danh sách
        public static void addSV()
        {
            SinhVien sv = new SinhVien();
            sv.input();
            listsv.Add(sv);
            Console.WriteLine("Thêm sinh viên thành công!");
            Console.WriteLine();
        }
        // In danh sách sinh viên        
        public static void printSV()
        {
            if(listsv.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào trong danh sách!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                                 "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Nganh Hoc", "Nam Nhap Hoc");
            foreach (SinhVien sv in listsv)
            {
                sv.print();
            }
            Console.WriteLine();
        }
        // Sắp xếp danh sách sinh viên theo tên
        public static void sort_nameSV()
        {
            if(listsv.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào trong danh sách!");
                return;
            }
            var DSSV = listsv.OrderBy(sv=>sv.TEN);
            Console.WriteLine("Danh sách sau khi sắp xếp theo tên:");
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                                 "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Nganh Hoc", "Nam Nhap Hoc");
            foreach (SinhVien sv in DSSV)
            {
                sv.print();
            }
            Console.WriteLine();
        }
        // Sắp xếp sinh viên theo mã số
        public static void sort_MASV()
        {
            if(listsv.Count == 0)
            {
                Console.WriteLine("Không có sinh viên nào trong danh sách!");
                return;
            }
            var DSSV = listsv.OrderBy(sv=>sv.MA);
            Console.WriteLine("Danh sách sau khi sắp xếp theo mã sinh viên:");
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                                 "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Nganh Hoc", "Nam Nhap Hoc");
            foreach (SinhVien sv in DSSV)
            {
                sv.print();
            }
            Console.WriteLine();
        }  
        // Tìm kiếm sinh viên trong danh sách
        public static void searchSV()
        {
            Console.Write("Nhập mã sinh viên muốn tìm kiếm: ");
            string Masv = Console.ReadLine();
            SinhVien sv = checkSV(Masv);
            if (listsv.Count == 0 || sv == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                                 "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Nganh Hoc", "Nam Nhap Hoc");
            sv.print();
            Console.WriteLine();
        }
        // Xóa sinh viên ra khỏi danh sách
        public static void deleteSV()
        {
            Console.Write("Nhập mã sinh viên: ");
            string Masv = Console.ReadLine();
            SinhVien sv = checkSV(Masv);
            if (sv == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
                return;
            }
            listsv.Remove(sv);
            Console.WriteLine("Đã xóa thành công!");
            Console.WriteLine();

        }
        // Hàm trả về số lượng sinh viên trong danh sách
        public static int SLSV() 
        {
            return listsv.Count;
        }
    }   
}