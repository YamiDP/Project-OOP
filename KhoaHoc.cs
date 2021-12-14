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
        // hàm in sinh vien và cuu sinh vien cua nam bat dau nhap hoc
        public void print()
        {
            Console.Write("Nhap nam nhap hoc: ");
            NAM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Nganh");
            foreach (SinhVien sv in DSSinhVien.listsv)
            {
                if(sv.NAMNHAPHOC == NAM)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                sv.MA, sv.TEN, sv.NGSINH, sv.GTINH, sv.NGANH);
                }
            }
            foreach (CuuSinhVien csv in DSCuuSinhVien.listcsv)
            {
                if(csv.NAMKETTHUC == NAM)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.NGANH);
                }
            }
        }
        // ham in cuu sinh vien cua nam tot nghiep
        public void print_CSV()
        {
            Console.Write("Nhap nam tot nghiep: ");
            NAM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Nganh hoc");
            foreach (CuuSinhVien csv in DSCuuSinhVien.listcsv)
            {
                if(csv.NAMKETTHUC == NAM)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.NGANH);
                }
            }
        }
    }
} 