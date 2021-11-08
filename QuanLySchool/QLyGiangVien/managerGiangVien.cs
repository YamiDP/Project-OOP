using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyGiangVien
{
    public class managerGiangVien
    {
        public static List<GiangVien> listgv = new List<GiangVien>();
        public static GiangVien check(string MaGV)
        {
            foreach (GiangVien gv in listgv)
            {
                if (String.Compare(gv.MAGV, MaGV, false) == 0) // so sánh tính cả chữ hoa và thường
                    return gv;
            }
            return null;
        }
        public static void add(string makhoa, KHOA h)
        {
            GiangVien k;         
            GiangVien gv = new GiangVien();
            do
            {
                Console.Write("Ma Giao Vien: ");
                gv.MAGV = Convert.ToString(Console.ReadLine());
                k = check(gv.MAGV);
                if (k != null)
                {
                    Console.WriteLine("Ma Giao Vien da ton tai!");
                    Console.WriteLine("Vui long nhap lai!!!");
                }
            } while (k != null);
            Console.Write("Ten Giao Vien: ");
            gv.TENGV = Convert.ToString(Console.ReadLine());
            Console.Write("Ngay sinh: ");
            gv.NGSINH = Convert.ToString(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            gv.GTINH = Convert.ToString(Console.ReadLine());
            Console.Write("Dia Chi: ");
            gv.DIACHI = Convert.ToString(Console.ReadLine());
            
            listgv.Add(gv);
            h.Listgv1.Add(gv);
            //managerKHOA.checkkhoa(makhoa).Listgv1.Add(gv);
            Console.WriteLine("Them Giang Vien thanh cong!");
        }
        public static void delete(KHOA h)
        {
            GiangVien k;
            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            k = check(MaGV);
            if (k == null)
            {
                Console.WriteLine("Khong tim thay giang vien!");
            }
            else
            {
                listgv.Remove(k);
                h.Listgv1.Remove(k);
            }
            Console.WriteLine("Da xoa thanh cong!");
        }
        public static void xuat(KHOA k)
        {
            //int check = 0;
            Console.WriteLine("Khoa {0}", k.TENKHOA);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi");
            foreach (GiangVien gv in k.Listgv1)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                  gv.MAGV, gv.TENGV, gv.NGSINH, gv.GTINH, gv.DIACHI);
            }
            if(k.Listgv1.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong Khoa!");
            }    
            Console.WriteLine();
        }
        public static void searchID(KHOA k)
        {
            if(k.Listgv1 == null)
                Console.WriteLine("Danh sach rong!");
            else               
            {
                Console.Write("Nhap Ma Giang Vien: ");
                string MaGV = Console.ReadLine();
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi");
                foreach (GiangVien gv in k.Listgv1)
                {
                    if (String.Compare(gv.MAGV, MaGV, false) == 0)
                    {
                        Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                      gv.MAGV, gv.TENGV, gv.NGSINH, gv.GTINH, gv.DIACHI);
                    }
                }
                if (k.Listgv1.Count == 0)
                {
                    Console.WriteLine("Khong co Giang Vien nao trong danh sach!");
                }
            }
        }
        public static void sort(KHOA k)
        {
            k.Listgv1.Sort(delegate (GiangVien gv1, GiangVien gv2) 
            {
                return gv1.TENGV.CompareTo(gv2.TENGV);
            });
        }   
    }
}
