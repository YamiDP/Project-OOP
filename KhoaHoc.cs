using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class KhoaHoc
    {
        private int nam;
        public int NAM
        {
            set { nam = value; }
            get { return nam; }
        }
        // cac ham khoi tao
        public KhoaHoc(int nam)
        {
            this.nam = nam;
        }
        public KhoaHoc(KhoaHoc kh) 
            : this(kh.nam)
        {
        }    
        public KhoaHoc()
        {
            this.nam = 2000;
        }
        //Ham huy
        ~KhoaHoc()
        {

        }
        public void print()
        {
            Console.Write("Nhap nam nhap hoc: ");
            NAM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh", "Khoa hoc");
            foreach (SinhVien sv in DSSinhVien.listsv)
            {
                if(sv.NAMNHAPHOC == NAM)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15}",
                                sv.MA, sv.TEN, sv.NGSINH, sv.GTINH, sv.DIACHI, sv.SDT, sv.NGANH, sv.NAMNHAPHOC);
                }
            }
        }
        public void print_CSV()
        {
            Console.Write("Nhap nam ket thuc: ");
            NAM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15} {9, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Nganh hoc", "Khoa hoc", "Thanh tich", "Nghe Nghiep");
            foreach (CuuSinhVien csv in DSCuuSinhVien.listcsv)
            {
                if(csv.NAMKETTHUC == NAM)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15} {9, -15}",
                                csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI, csv.SDT, csv.NGANH, csv.NAMNHAPHOC, csv.THANHTICH, csv.NGHENGHIEP, csv.NAMKETTHUC);
                }
            }
        }
    }
} 