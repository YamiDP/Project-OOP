using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSNhanVienHanhChinh
    {
        public static List<NhanVienHanhChinh> listnv = new List<NhanVienHanhChinh>();
        public static NhanVienHanhChinh checkNV(string MaNV)
        {
            foreach (NhanVienHanhChinh nv in listnv)
            {
                if (String.Compare(nv.MA, MaNV, false) == 0)
                    return nv;
            }
            return null;
        }
        public static void inputNVHC(PhongBan pb)
        {
            NhanVienHanhChinh nv = new NhanVienHanhChinh();
            listnv.Add(nv);
            pb.Listnv1.Add(nv);
            Console.WriteLine("Them Nhan Vien thanh cong!");
        }
        public static void printNVHC()
        {
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien nao trong Phong Ban!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -10}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "Cong Viec", "Luong");
            foreach (NhanVienHanhChinh nv in listnv)
            {
                nv.priNVHC();
            }
        }
        public static void deleteNVHC(PhongBan p)
        {
            NhanVienHanhChinh k;
            Console.Write("Nhap Ma Nhan Vien: ");
            string MaNV = Console.ReadLine();
            k = checkNV(MaNV);
            if (k == null)
            {
                Console.WriteLine("Khong tim thay Nhan Vien!");
                return;
            }
                listnv.Remove(k);
                p.Listnv1.Remove(k);
            Console.WriteLine("Da xoa thanh cong!");
        }

        public static void sort()
        {
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien Hanh Chinh nao trong danh sach!");
                return;
            }
            var DSNVHC = listnv.OrderByDescending(nv => nv.TEN);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -10}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "Cong Viec", "Luong");
            foreach (NhanVienHanhChinh nv in DSNVHC)
            {
                nv.priNVHC();
            }
        } 
        public static void search()
        {
            Console.Write("Nhap Ma Giang Vien: ");
            string MaNV = Console.ReadLine();
            NhanVienHanhChinh nv = checkNV(MaNV);
            if (listnv.Count == 0 || nv == null)
            {
                Console.WriteLine("Khong tim thay Nhan Vien nao!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -10}",
              "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Cong Viec", "Luong");
            nv.priNVHC();
        }
        public static int slNVHC()
        {
            return listnv.Count;
        }
    }
}