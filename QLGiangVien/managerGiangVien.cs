﻿using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLKhoa;

namespace SchoolManager.QLGiangVien
{
    public delegate void printDel(KHOA K);
    public class managerGiangVien : GiangVien
    {
        public static List<GiangVien> listgv = new List<GiangVien>();
        public static List<MonHoc> listmh = new List<MonHoc>(); // luu cac mon hoc ma giang vien da dang ky mo lop
        public static GiangVien checkGV(string MaGV)
        {
            foreach (GiangVien gv in listgv)
            {
                if (String.Compare(gv.MA, MaGV, false) == 0)
                    return gv;
            }
            return null;
        }
        public void inputGV(KHOA h)
        {
            GiangVien gv;         
            do
            {
                Console.Write("Ma Giang Vien: ");
                MA = Convert.ToString(Console.ReadLine());
                gv = checkGV(MA);
                if (gv != null)
                {
                    Console.WriteLine("Ma Giang Vien da ton tai!");
                    Console.WriteLine("Vui long nhap lai!!!");
                }
            } while (gv != null);
            base.input();
            Console.Write("Chuyen nganh: ");
            CHNGANG = Convert.ToString(Console.ReadLine());
            Console.Write("Bo mon: ");
            BOMON = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToString(Console.ReadLine());
            Console.Write("Lop day: ");
            LOPDAY = Convert.ToString(Console.ReadLine());
            Console.Write("Hoc vi: ");
            HOCVI = Convert.ToString(Console.ReadLine());
            gv = new GiangVien(MA, TEN, NGSINH, GTINH, DIACHI, SDT, CHNGANG, BOMON, LUONG, LOPDAY, HOCVI);
            listgv.Add(gv);
            h.Listgv1.Add(gv);
            Console.WriteLine("Them Giang Vien thanh cong!");
        }
        public static void deleteGV(KHOA h)
        {
            GiangVien k;
            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            k = checkGV(MaGV);
            if (k == null)
            {
                Console.WriteLine("Khong tim thay giang vien!");
            }
            else
            {
                listgv.Remove(k);
                h.Listgv1.Remove(k);
                Console.WriteLine("Da xoa thanh cong!");
            }
        }
        static event printDel printgv;
        public static void EventprintGV(KHOA k)
        {
            printgv = new printDel(printGV);
            printgv?.Invoke(k);
        }
        static void printGV(KHOA k)
        { 
            Console.WriteLine("Khoa {0}", k.TENKHOA);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10} {10, -10}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Lop Day" , "Hoc Vi");
            foreach (GiangVien gv in k.Listgv1)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10} {10, -10}",
                                  gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.LOPDAY, gv.HOCVI);
            }
            if(k.Listgv1.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong Khoa!");
            }    
            Console.WriteLine();
        }

        public override void print()
        {
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10} {10, -10}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Lop Day", "Hoc Vi");
            foreach (GiangVien gv in listgv)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10} {10, -10}",
                                  gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.LOPDAY, gv.HOCVI);
            }
            if (listgv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong danh sach!");
            }
            Console.WriteLine();
        }

        public static void searchIDGV(KHOA k)
        {

            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10} {10, -10}",
              "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Lop Day", "Hoc Vi");
            foreach (GiangVien gv in k.Listgv1)
            {
                if (String.Compare(gv.MA, MaGV, false) == 0)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10} {10, -10}",
                                  gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.LOPDAY, gv.HOCVI);
                }
            }
            if (k.Listgv1.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien!");
            }
        }
        public override void search()
        {
            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10} {10, -10}",
              "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Lop Day", "Hoc Vi");
            foreach (GiangVien gv in listgv)
            {
                if (String.Compare(gv.MA, MaGV, false) == 0)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10} {10, -10}",
                                  gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.LOPDAY, gv.HOCVI);
                }
            }
            if (listgv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien!");
            }
        }

        static event printDel sortidgv;
        public static void EventsortidGV(KHOA k)
        {
            sortidgv = new printDel(sortIDGV);
            sortidgv?.Invoke(k);
        }
        public static bool compareRise(GiangVien gv1, GiangVien gv2)
        {
            if (String.Compare(gv1.TEN, gv2.TEN, false) > 0)
                return false;
            return true;
        }
        static void sortIDGV(KHOA k)
        {
            if (k.Listgv1.Count == 0)   
            {
                Console.WriteLine("Danh sach rong!");
            }
            else
            {
                GiangVien gv;
                for(int i = 0; i < k.Listgv1.Count - 1; i++)
                    for (int j = i + 1; j < k.Listgv1.Count; j++)
                        if (!compareRise(k.Listgv1[i], k.Listgv1[j])) 
                        {
                            gv = k.Listgv1[i];
                            k.Listgv1[i] = k.Listgv1[j];
                            k.Listgv1[j] = gv;
                        }
            }
        }
        public override void sort()
        {
            if (listgv.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
            }
            else
            {
                GiangVien gv;
                for (int i = 0; i < listgv.Count - 1; i++)
                    for (int j = i + 1; j < listgv.Count; j++)
                        if (!compareRise(listgv[i], listgv[j]))
                        {
                            gv = listgv[i];
                            listgv[i] = listgv[j];
                            listgv[j] = gv;
                        }
            }
        }

        public static int slGV_khoa(KHOA k)
        {
            return k.Listgv1.Count;
        }
        public static int slGV() 
        {
            return listgv.Count;
        }
        public void dkimolop()
        {
            MonHoc mh;         
            do
            {
                Console.Write("Nhap Ma Giang Vien muon dang ki mo lop: ");
                string MaGV = Console.ReadLine();
                gv = checkGV(MaGV);
                if (gv == null)
                {
                    Console.WriteLine("Khong co Giang Vien nay!");
                    Console.WriteLine("Vui long nhap lai Ma Giang Vien!!!");
                }
            } while (gv == null);
            Console.Write("Ten mon hoc: ");
            string Tenmh = Console.ReadLine();
            Console.Write("Loai hoc phan: ");
            string LoaiHP = Console.ReadLine();
            Console.Write("Lop hoc phan: ");
            string LopHP = Console.ReadLine();
            Console.Write("So tin chi: ");
            int STC = Console.ReadLine();
            Console.Write("Gioi han: ");
            int GH = Console.ReadLine();
            Console.Write("Lich hoc: ");
            string Lichhoc = Console.ReadLine();
            Console.WriteLine("Dang ki mo lop thanh cong!!!");
        }
    }
}
