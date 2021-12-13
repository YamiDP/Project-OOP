using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSGiangVien 
    {
        public static List<GiangVien> listgv = new List<GiangVien>();
        public static GiangVien checkGV(string MaGV)
        {
            foreach (GiangVien gv in listgv)
            {
                if (String.Compare(gv.MA, MaGV, false) == 0)
                    return gv;
            }
            return null;
        }
        public static void inputGV(KHOA h)
        {
            GiangVien gv = new GiangVien();  
            gv.input();       
            listgv.Add(gv);
            h.Listgv1.Add(gv);
            Console.WriteLine("Them Giang Vien thanh cong!");
        }
        public static void printGV()
        {
            if (listgv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong danh sach!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -19} {6, -15} {7, -15} {8, -15} {9, -10}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Hoc Vi");
            foreach (GiangVien gv in listgv)
            {
                gv.print();
            }
        }

        public static void sort()
        {
            if (listgv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong danh sach!");
                return;
            }
            var DSGV = listgv.OrderByDescending(gv => gv.TEN);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -19} {6, -15} {7, -15} {8, -15} {9, -10}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Hoc Vi");
            foreach (GiangVien gv in DSGV)
            {
                gv.print();
            }
        }
        public static void deleteGV(KHOA h)
        {
            GiangVien k;
            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            k = checkGV(MaGV);
            if (k == null)
            {
                Console.WriteLine("Khong co Giang Vien!");
                return;
            }
                listgv.Remove(k);
                h.Listgv1.Remove(k);
                Console.WriteLine("Da xoa thanh cong!");
        }
        public static void searchGV()
        {
            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            GiangVien gv = checkGV(MaGV);
            if (listgv.Count == 0 || gv == null)
            {
                Console.WriteLine("Khong tim thay Giang Vien!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
              "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Hoc Vi");
            gv.print();
        }
        public static int slGV() 
        {
            return listgv.Count;
        }
    }
}
/* 
    public static void EventprintGV(SuKien sk)
        {
            sk.print += printGV;
        }   
} 
*/