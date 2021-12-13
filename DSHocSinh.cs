using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SchoolManager
{
    public class DSHocSinh
    {
        //khoi tao danh sach hoc sinh
        public static List<HocSinh> lisths = new List<HocSinh>();
        public static HocSinh checkHS(string Sbd)
        {
            foreach (HocSinh hs in lisths)
            {
                if (String.Compare(hs.MA, Sbd, true) == 0)
                    return hs;
            }
            return null;
        }
        //them hoc sinh vao danh sach
        public static void inputHS()
        {
            HocSinh hs = new HocSinh();
            hs.input();
            lisths.Add(hs);
            Console.WriteLine("Them hoc sinh thanh cong!");
        }
        //in danh sach hoc sinh        
        public static void printHS()
        {
            if(lisths.Count == 0)
            {
                Console.WriteLine("Khong co hoc sinh nao trong danh sach!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -10} {3, -10} {4, -15} {5,-15} {6,-10} {7,-9} {8,-10} {9,-10} {10,-12} {11,-10}",
                             "MaHS", "TenHS", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Diem Thi", "Khoi thi", "Nganh", "Dien UT", "So luong NV", "Phuong thuc xet tuyen");
            foreach (HocSinh hs in lisths)
            {
                hs.print();
            }
        }
        //sap xep danh sach hoc sinh
        public static void sort()
        {
            if(lisths.Count == 0)
            {
                Console.WriteLine("Khong co hoc sinh nao trong danh sach!");
                return;
            }
            var DSHS = lisths.OrderByDescending(hs=>hs.TEN);
            Console.WriteLine("{0, -7} {1, -20} {2, -10} {3, -10} {4, -15} {5,-15} {6,-10} {7,-9} {8,-10} {9,-10} {10,-12} {11,-10}",
                             "MaHS", "TenHS", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Diem Thi", "Khoi thi", "Nganh", "Dien UT", "So luong NV", "Phuong thuc xet tuyen");
            foreach (HocSinh hs in lisths)
            {
                hs.print();
            }
        }
        //tim kiem hoc sinh trong danh sach
        public static void searchHS()
        {
            Console.Write("Nhap ma hoc sinh: ");
            string Mahs = Console.ReadLine();
            HocSinh hs = checkHS(Mahs);
            if (lisths.Count == 0 || hs == null)
            {
                Console.WriteLine("Khong tim thay hoc sinh!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -10} {3, -10} {4, -15} {5,-15} {6,-10} {7,-9} {8,-10} {9,-10} {10,-12} {11,-10}",
                             "MaHS", "TenHS", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Diem Thi", "Khoi thi", "Nganh", "Dien UT", "So luong NV", "Phuong thuc xet tuyen");
            hs.print();
        }
        //xoa hoc sinh ra khoi danh sach
        public static void deleteHS()
        {
            Console.Write("Nhap ma hoc sinh: ");
            string Mahs = Console.ReadLine();
            HocSinh hs = checkHS(Mahs);
            if (hs == null)
            {
                Console.WriteLine("Khong tim thay hoc sinh!");
                return;
            }
            lisths.Remove(hs);
            Console.WriteLine("Da xoa thanh cong!");

        }
        public static int SLHS() 
        {
            return lisths.Count;
        }
    }   

}