using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLSinhVien
{
    public class managerCSV : CuuSinhVien
    {
        public static List<CuuSinhVien> listcsv = new List<CuuSinhVien>();
        public static CuuSinhVien check(string MaSV)
        {
            foreach (CuuSinhVien csv in listcsv)
            {
                if (String.Compare(csv.MA, MaSV, false) == 0)
                return csv;
            }
            return null;
        }
        public void nhap(KHOA h)
        {
            CuuSinhVien csv;
            do
            {
                Console.Write("Ma Cuu Sinh Vien: ");
                MA = Convert.ToString(Console.ReadLine());
                csv = check(MA);
                if(csv != null)
                {
                    Console.WriteLine("Ma Cuu Sinh Vien da ton tai !");
                    Console.WriteLine("Vui long nhap lai !");
                }
            }while (csv != null);
            base.input();
            listcsv.Add(csv);
            Console.WriteLine("Them Cuu Sinh Vien thanh cong !");
        }
        public static void xuat(KHOA k)
        {
            Console.WriteLine("Khoa {0}", k.TENKHOA);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi");
            foreach (CuuSinhVien csv in k.Listcsv1)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                  csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI);
            }
            if(k.Listcsv1.Count == 0)
            {
                Console.WriteLine("Khong co Cuu Sinh Vien nao trong Khoa!");
            }    
        }
        public static void searchID(KHOA k)
        {
            if(k.Listcsv1 == null)
                Console.WriteLine("Danh sach rong!");
            else               
            {
                Console.Write("Nhap Ma Sinh Vien: ");
                string MaSV = Console.ReadLine();
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                  "MaSV", "TenSV", "Ngay Sinh", "Gioi Tinh", "Dia Chi");
                foreach (CuuSinhVien csv in k.Listcsv1)
                {
                    if (String.Compare(csv.MA, MaSV, false) == 0)
                    {
                        Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15}",
                                      csv.MA, csv.TEN, csv.NGSINH, csv.GTINH, csv.DIACHI);
                    }
                }
                if (k.Listcsv1.Count == 0)
                {
                    Console.WriteLine("Khong co Sinh Vien nao trong danh sach!");
                }
            }
        }
        public delegate bool DelSort(CuuSinhVien csv1, CuuSinhVien csv2);
        public static bool compareRise(CuuSinhVien csv1, CuuSinhVien csv2)
        {
            if (String.Compare(csv1.TEN, csv2.TEN, false) > 0)
                return false;
            return true;
        }
        public static void sortID(KHOA k)
        {
            DelSort d = new DelSort(compareRise);
            if (k.Listcsv1.Count == 0) 
            {
                Console.WriteLine("Danh sach rong!");
            }
            else
            {
            CuuSinhVien csv;
            for(int i = 0; i < k.Listcsv1.Count - 1; i++)
                for (int j = i + 1; j < k.Listcsv1.Count; j++)
                    if (!d(k.Listcsv1[i], k.Listcsv1[j])) 
                    {
                        csv = k.Listcsv1[i];
                        k.Listcsv1[i] = k.Listcsv1[j];
                        k.Listcsv1[j] = csv;
                    }

            }
        }
        public static void delete(KHOA h)
        {
            CuuSinhVien c;
            Console.Write("Nhap Ma Sinh Vien: ");
            string MaSV = Console.ReadLine();
            c = check(MaSV);
            if(c == null)
            {
                Console.WriteLine("Khong tim thay cuu sinh vien !");
            }
            else
            {
                listcsv.Remove(c);
                h.Listcsv1.Remove(c);
            }
            Console.WriteLine("Da xoa thanh cong !");
        }
        public static int sl_khoa(KHOA k)
        {
            return k.Listcsv1.Count;
        }
        public static int sl()
        {
            return listcsv.Count;
        }
    }
}