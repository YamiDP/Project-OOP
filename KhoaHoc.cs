using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class KhoaHoc
    {
        private int nambatdau;
        private int namdukienkt;
        public int NAMBATDAU
        {
            set { nambatdau = value; }
            get { return nambatdau; }
        }
        public int NAMDUKIENKT
        {
            set { namdukienkt = value; }
            get { return namdukienkt; }
        }
        public KhoaHoc(int nambatdau, int namdukienkt)
        {
            this.nambatdau = nambatdau;
            this.namdukienkt = namdukienkt;
        }
        public KhoaHoc(KhoaHoc kh) 
            : this(kh.nambatdau, kh.namdukienkt)
        {
        }    
        public KhoaHoc()
        {
            this.nambatdau = 2000;
            this.namdukienkt = 2004;
        }
    }
}
/* namespace SchoolManager.QLKhoahoc
{
    public class managerKhoaHoc : KhoaHoc   
    {
        public static void print_SV()
        {
            int d = 0;
            Console.Write("Nhap nam nhap hoc: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh", "Khoa hoc");
            foreach (SinhVien sv in managerSinhVien.listsv)
            {
                if(sv.NAMNHAPHOC == a)
                {
                    d = 1;
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15}",
                                sv.MA, sv.TEN, sv.NGSINH, sv.GTINH, sv.DIACHI, sv.SDT, sv.NGANH, sv.NAMNHAPHOC);
                }
            }
            if (managerSinhVien.listsv.Count == 0 || d == 0)
                Console.WriteLine("Khong co Sinh Vien nao!");
        }
        public static void print_CSV()
        {
            int d = 0;
            Console.Write("Nhap nam ket thuc: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15} {9, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc", "Thanh tich", "Nghe Nghiep");
            foreach (CuuSinhVien csv in managerCuuSinhVien.listcsv)
            {
                if(csv.NAMKETTHUC == b)
                {
                    d = 1;
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15} {9, -15}",
                                csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANH, csv.NAMNHAPHOC, csv.THANHTICH, csv.NGHENGHIEP, csv.NAMKETTHUC);
                }
            }
            if (managerCuuSinhVien.listcsv.Count == 0 || d == 0)
                Console.WriteLine("Khong co Cuu Sinh Vien nao!");
        }
    }
} */