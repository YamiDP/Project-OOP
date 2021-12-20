using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSSinhVien 
    {
        // Hàm tạo danh sách sinh viên
        public static List<SinhVien> listsv = new List<SinhVien>();
        // Tạo dữ liệu danh sách sinh viên cơ bản
        public static void base_list()
        {
            SinhVien sv1 = new SinhVien("201","Phuong","02/02/2002","Nam","Binh Phuoc","032342342","CNTT",2020, new List<MonHoc>());
            listsv.Add(sv1);
            SinhVien sv2 = new SinhVien("202","Dat","04/03/2002","Nam","Dong Nai","032342656","DDT",2020, new List<MonHoc>());
            listsv.Add(sv2);
            SinhVien sv3 = new SinhVien("203","Tuan","02/04/2002","Nam","Binh Dinh","0343564342","CNTT",2020, new List<MonHoc>());
            listsv.Add(sv3);
            SinhVien sv4 = new SinhVien("204","Hung","11/02/2002","Nam","Vung Tau","032323642","XD",2020, new List<MonHoc>());
            listsv.Add(sv4);
        }
        // Hàm kiểm tra mã sinh viên trong danh sách
        public static SinhVien checkSV(string MaSV)
        {
            foreach (SinhVien sv in listsv)
            {
                if (String.Compare(sv.MA, MaSV, false) == 0)
                    return sv;
            }
            return null;
        }
        // Hàm nhập sinh viên vào danh sách
        public static void addSV()
        {
            SinhVien sv = new SinhVien();  
            sv.input();       
            listsv.Add(sv);
            Console.WriteLine("Them Sinh Vien thanh cong!");
        }
        public void EventprintSV(DS ds)
        {
            ds.print += printSV;
        }
        // Hàm xuất sinh viên trong danh sách
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
                sv.print();
            }
            Console.WriteLine();
        }
        // Hàm sắp xếp sinh viên trong danh sách
        public static void sort()
        {
            if (listsv.Count == 0)
            {
                Console.WriteLine("Khong co Sinh Vien nao trong danh sach!");
                return;
            }
            var DSSV = listsv.OrderBy(sv => sv.TEN);
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc");
            foreach (SinhVien sv in DSSV)
            {
                sv.print();
            }
        }
        // Hàm xóa sinh viên trong danh sách
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
        // Hàm tìm kiếm sinh viên trong danh sách
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
            sv.print();
        }
        // Hàm trả về số lượng sinh viên trong danh sách
        public static int slSV() 
        {
            return listsv.Count;
        }
    }
}
