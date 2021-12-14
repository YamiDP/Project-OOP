using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSGiangVien 
    {
        //khoi tao danh sach giang vien
        public static List<GiangVien> listgv = new List<GiangVien>();
        //tao du lieu danh sach giang vien co ban
        public static void base_listGV()
        {
            List<KHOA> listk = DSKhoa.base_listkhoa();
            GiangVien gv1 = new GiangVien("100","Tran Quoc Tuan","11/10/1983","Nam","TP HCM","0337981963", "Phan mem", 20000000, "Thac si", new List<MonHoc>());
            listgv.Add(gv1);
            listk[0].Listgv1.Add(gv1);
            GiangVien gv2 = new GiangVien("101","Huynh Thuy An","23/01/1984","Nu","TP HCM","0337981452", "Kien truc", 15000000, "Thac si", new List<MonHoc>());
            listgv.Add(gv2);
            listk[1].Listgv1.Add(gv2);
            GiangVien gv3 = new GiangVien("102","Phan Tan Hung","05/02/1985","Nam","Binh Duong","0335301963", "Phan mem", 22000000, "Thac si", new List<MonHoc>());
            listgv.Add(gv3);
            listk[0].Listgv1.Add(gv3);
            GiangVien gv4 = new GiangVien("103","Tran Tuan Minh","02/03/1986","Nam","TP HCM","0337981103", "Kien Truc", 17000000, "Thac si", new List<MonHoc>());
            listgv.Add(gv4);
            listk[1].Listgv1.Add(gv4);
        }
        //ham kiem tra giang vien co trong danh sach hay khong
        public static GiangVien checkGV(string MaGV)
        {
            foreach (GiangVien gv in listgv)
            {
                if (String.Compare(gv.MA, MaGV, false) == 0)
                    return gv;
            }
            return null;
        }
        //ham them giang vien theo khoa vao danh sach
        public static void inputGV(KHOA h)
        {
            GiangVien gv = new GiangVien();  
            gv.input();       
            listgv.Add(gv);
            h.Listgv1.Add(gv);
            Console.WriteLine("Them Giang Vien thanh cong!");
        }
        //ham in giang vien trong danh sach
        public static void printGV()
        {
            if (listgv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong danh sach!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -15}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Luong", "Hoc Vi");
            foreach (GiangVien gv in listgv)
            {
                gv.print();
            }
        }
        //ham Sap xep danh sach giang vien theo ten
        public static void sort()
        {
            if (listgv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong danh sach!");
                return;
            }
            var DSGV = listgv.OrderBy(gv => gv.TEN);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -15}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Luong", "Hoc Vi");
            foreach (GiangVien gv in DSGV)
            {
                gv.print();
            }
        }
        //ham xoa giang vien theo khoa khoi danh sach
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
        //ham tim kiem giang vien trong danh sach
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
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10}",
              "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Luong", "Hoc Vi");
            gv.print();
        }
        //ham tinh so luong giang vien trong danh sach
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