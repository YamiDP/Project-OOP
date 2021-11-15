using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyNhanVienHanhChinh
{
    class managerNhanVien : thuoctinhCB
    {
        public static List<NhanVien> listnv = new List<NhanVien>();
        public static NhanVien check(string MaNV)
        {
            foreach (NhanVien nv in listnv)
            {
                if (String.Compare(nv.MA, MaNV, false) == 0)
                    return nv;
            }
            return null;
        }
        public static void add(string maPban, Pban p)
        {
            NhanVien k;
            NhanVien nv = new NhanVien();
            do
            {
                Console.Write("Ma Nhan Vien: ");
                nv.MA = Convert.ToString(Console.ReadLine());
                k = check(nv.MA);
                if (k != null)
                {
                    Console.WriteLine("Ma Nhan Vien da ton tai!");
                    Console.WriteLine("Vui long nhap lai!!!");
                }
            } while (k != null);
            nv.input();
            listnv.Add(nv);
            p.Listgv2.Add(nv);
            Console.WriteLine("Them Nhan Vien thanh cong!");
        }
        public static void delete(Pban p)
        {
            NhanVien k;
            Console.Write("Nhap Ma Nhan Vien: ");
            string MaNV = Console.ReadLine();
            k = check(MaNV);
            if (k == null)
            {
                Console.WriteLine("Khong tim thay Nhan Vien!");
            }
            else
            {
                listnv.Remove(k);
                p.Listgv2.Remove(k);
            }
            Console.WriteLine("Da xoa thanh cong!");
        }
        public static void xuat(Pban p)
        {
            Console.WriteLine("Khoa {0}", p.TENPB);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi");
            foreach (NhanVien nv in p.Listgv2)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                  nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI);
            }
            if (p.Listgv2.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien nao trong Phong Ban nay!");
            }
            Console.WriteLine();
        }
        public override void xuat()
        {
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi");
            foreach (NhanVien nv in listnv)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                  nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI);
            }
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien nao trong Phong Ban!");
            }
            Console.WriteLine();
        }
        public static void searchID(Pban p)
        {
            if (p.Listgv2 == null)
                Console.WriteLine("Danh sach rong!");
            else
            {
                Console.Write("Nhap Ma Nhan Vien: ");
                string MaNV = Console.ReadLine();
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi");
                foreach (NhanVien nv in p.Listgv2)
                {
                    if (String.Compare(p.MAPB, MaNV, false) == 0)
                    {
                        Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                      nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI);
                    }
                }
                if (p.Listgv2.Count == 0)
                {
                    Console.WriteLine("Khong co Nhan Vien nao trong danh sach!");
                }
            }
        }
        public static void sort(Pban p)
        {
            p.Listgv2.Sort(delegate (NhanVien nv1, NhanVien nv2)
            {
                return nv1.TEN.CompareTo(nv2.TEN);
            });
        }
        public override void sort()
        {

        }
        public override void search()
        {

        }
    }
}
