using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLyNhanVienHanhChinh
{
    class managerNhanVien : NhanVien
    {
        public static List<NhanVien> listnv = new List<NhanVien>();
        public static NhanVien checkNV(string MaNV)
        {
            foreach (NhanVien nv in listnv)
            {
                if (String.Compare(nv.MA, MaNV, false) == 0)
                    return nv;
            }
            return null;
        }
        public void inputNV(Pban pb)
        {
            NhanVien nv;
            do
            {
                Console.Write("Ma Nhan Vien: ");
                MA = Convert.ToString(Console.ReadLine());
                nv = checkNV(MA);
                if (nv != null)
                {
                    Console.WriteLine("Ma Nhan Vien da ton tai!");
                    Console.WriteLine("Vui long nhap lai!!!");
                }
            } while (nv != null);
            base.input();
            Console.Write("Cong viec: ");
            CVIEC = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToString(Console.ReadLine());
            nv = new NhanVien(MA, TEN, NGSINH, GTINH, DIACHI, SDT, CVIEC, LUONG);
            listnv.Add(nv);
            pb.Listnv1.Add(nv);
            Console.WriteLine("Them Nhan Vien thanh cong!");
        }
        public static void deleteNV(Pban p)
        {
            NhanVien k;
            Console.Write("Nhap Ma Nhan Vien: ");
            string MaNV = Console.ReadLine();
            k = checkNV(MaNV);
            if (k == null)
            {
                Console.WriteLine("Khong tim thay Nhan Vien!");
            }
            else
            {
                listnv.Remove(k);
                p.Listnv1.Remove(k);
            }
            Console.WriteLine("Da xoa thanh cong!");
        }
        public static void printNV(Pban p)
        {
            Console.WriteLine("Khoa {0}", p.TENPB);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -10}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "Cong Viec", "Luong");
            foreach (NhanVien nv in p.Listnv1)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -10}",
                                  nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI, nv.CVIEC, nv.LUONG);
            }
            if (p.Listnv1.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien nao trong Phong Ban nay!");
            }
            Console.WriteLine();
        }
        public override void print()
        {
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -10}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "Cong Viec", "Luong");
            foreach (NhanVien nv in listnv)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -10}",
                                  nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI, nv.CVIEC, nv.LUONG);
            }
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien nao trong Phong Ban!");
            }
            Console.WriteLine();
        }
        public static void searchIDNV(Pban p)
        {
            Console.Write("Nhap Ma Nhan Vien: ");
            string MaNV = Console.ReadLine();
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -10}",
              "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Cong Viec", "Luong");
            foreach (NhanVien nv in p.Listnv1)
            {
                if (String.Compare(p.MAPB, MaNV, false) == 0)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -10}",
                                  nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI, nv.SDT, nv.CVIEC, nv.LUONG);
                }
            }
            if (p.Listnv1.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien nao trong danh sach!");
            }
        }
        public override void search()
        {
            Console.Write("Nhap Ma Giang Vien: ");
            string MaNV = Console.ReadLine();
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -10}",
              "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Cong Viec", "Luong");
            foreach (NhanVien nv in listnv)
            {
                if (String.Compare(nv.MA, MaNV, false) == 0)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -10}",
                                  nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI, nv.SDT, nv.CVIEC, nv.LUONG);
                }
            }
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien!");
            }
        }
        public delegate bool DelSort(NhanVien nv1, NhanVien nv2);
        public static bool compareRise(NhanVien nv1, NhanVien nv2)
        {
            if (String.Compare(nv1.TEN, nv2.TEN, false) > 0)
                return false;
            return true;
        }
        public static void sortIDNV(Pban pb)
        {
            DelSort d = new DelSort(compareRise);
            if (pb.Listnv1.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
            }
            else
            {
                NhanVien nv;
                for (int i = 0; i < pb.Listnv1.Count - 1; i++)
                    for (int j = i + 1; j < pb.Listnv1.Count; j++)
                        if (!d(pb.Listnv1[i], pb.Listnv1[j]))
                        {
                            nv = pb.Listnv1[i];
                            pb.Listnv1[i] = pb.Listnv1[j];
                            pb.Listnv1[j] = nv;
                        }
            }
        }
        public override void sort()
        {
            DelSort d1 = new DelSort(compareRise);
            if (listnv.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
            }
            else
            {
                NhanVien nv;
                for (int i = 0; i < listnv.Count - 1; i++)
                    for (int j = i + 1; j < listnv.Count; j++)
                        if (!d1(listnv[i], listnv[j]))
                        {
                            nv = listnv[i];
                            listnv[i] = listnv[j];
                            listnv[j] = nv;
                        }
            }
        }
        public static int slNV_pb(Pban p)
        {
            return p.Listnv1.Count;
        }
        public static int slNV()
        {
            return listnv.Count;
        }
    }
}
