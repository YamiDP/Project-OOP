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
        //tao du lieu danh sach hoc sinh co ban
        public static void base_list()
        {
            HocSinh hs1 = new HocSinh("125","Phuong","02/02/2002","Nam","Binh Phuoc","032342342",25.5,"A1","CNTT",1,4,"Dai Hoc");
            lisths.Add(hs1);
            HocSinh hs2 = new HocSinh("124","Nam","12/02/2002","Nam","Da Lat","0321242",23.5,"A1","CNTT",1,4,"Dai Hoc");
            lisths.Add(hs2);
            HocSinh hs3 = new HocSinh("121","Tuan","02/04/2002","Nam","Binh Dinh","0343534342",24,"A","CNTT",1,4,"Dai Hoc");
            lisths.Add(hs3);
            HocSinh hs4 = new HocSinh("122","Hung","11/02/2002","Nam","Vung Tau","032323642",26.5,"D","May",1,4,"Dai Hoc");
            lisths.Add(hs4);
        }
        //ham kiem tra ma hoc sinh trong danh sach
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
        public static void addHS()
        {
            HocSinh hs = new HocSinh();
            hs.input();
            lisths.Add(hs);
            Console.WriteLine("Them hoc sinh thanh cong!");
            Console.WriteLine();
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
            Console.WriteLine();
        }
        //sap xep danh sach hoc sinh theo ten
        public static void sort_name()
        {
            if(lisths.Count == 0)
            {
                Console.WriteLine("Khong co hoc sinh nao trong danh sach!");
                return;
            }
            var DSHS = lisths.OrderBy(hs=>hs.TEN);
            Console.WriteLine("Danh sach sau khi sap xep theo ten:");
            Console.WriteLine("{0, -7} {1, -20} {2, -10} {3, -10} {4, -15} {5,-15} {6,-10} {7,-9} {8,-10} {9,-10} {10,-12} {11,-10}",
                             "MaHS", "TenHS", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Diem Thi", "Khoi thi", "Nganh", "Dien UT", "So luong NV", "Phuong thuc xet tuyen");
            foreach (HocSinh hs in DSHS)
            {
                hs.print();
            }
            Console.WriteLine();
        }
        //sap xep hoc sinh theo ma so
        public static void sort_MA()
        {
            if(lisths.Count == 0)
            {
                Console.WriteLine("Khong co hoc sinh nao trong danh sach!");
                return;
            }
            var DSHS = lisths.OrderBy(hs=>hs.MA);
            Console.WriteLine("Danh sach sau khi sap xep theo ma hoc sinh:");
            Console.WriteLine("{0, -7} {1, -20} {2, -10} {3, -10} {4, -15} {5,-15} {6,-10} {7,-9} {8,-10} {9,-10} {10,-12} {11,-10}",
                             "MaHS", "TenHS", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "SĐT", "Diem Thi", "Khoi thi", "Nganh", "Dien UT", "So luong NV", "Phuong thuc xet tuyen");
            foreach (HocSinh hs in DSHS)
            {
                hs.print();
            }
            Console.WriteLine();
        }  
        //tim kiem hoc sinh trong danh sach
        public static void searchHS()
        {
            Console.Write("Nhap ma hoc sinh muon tim kiem: ");
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
            Console.WriteLine();
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
            Console.WriteLine();

        }
        //ham tra ve so luong hoc sinh trong danh sach
        public static int SLHS() 
        {
            return lisths.Count;
        }
    }   

}