using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLCuuSinhVien;
using SchoolManager.QLSinhVien;

namespace SchoolManager.QLKhoahoc
{
    public class managerKhoaHoc : KhoaHoc   
    {
        public static void print()
        {
            Console.Write("Nhap nam nhap hoc: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh", "Khoa hoc");
            foreach (SinhVien sv in managerSinhVien.listsv)
            {
                if(sv.NAMNHAPHOC == t)
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15}",
                                sv.MA, sv.TEN, sv.NGSINH, sv.GTINH, sv.DIACHI, sv.SDT, sv.NGANH, sv.NAMNHAPHOC);
            }
            if (managerSinhVien.listsv.Count == 0)
                Console.WriteLine("Khong co Sinh Vien nao!");


            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15} {9, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc", "Thanh tich", "Nghe Nghiep");
            foreach (CuuSinhVien csv in managerCuuSinhVien.listcsv)
            {
                if(csv.NAMNHAPHOC == t)
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15} {9, -15}",
                                csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANH, csv.NAMNHAPHOC, csv.THANHTICH, csv.NGHENGHIEP);
            }
            if (managerCuuSinhVien.listcsv.Count == 0)
                Console.WriteLine("Khong co Cuu Sinh Vien nao!");
        }
        public static void print_CSV()
        {
            Console.Write("Nhap nam ket thuc: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15} {9, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc", "Thanh tich", "Nghe Nghiep");
            foreach (CuuSinhVien csv in managerCuuSinhVien.listcsv)
            {
                //if(csv.NAMKETTHUC == t)
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15} {9, -15}",
                                csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANH, csv.NAMNHAPHOC, csv.THANHTICH, csv.NGHENGHIEP);
            }
            if (managerCuuSinhVien.listcsv.Count == 0)
                Console.WriteLine("Khong co Cuu Sinh Vien nao!");
        }
    }
}