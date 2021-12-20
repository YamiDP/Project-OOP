using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSNhanVienHanhChinh
    {
        // Tao danh sach nhan vien hanh chinh
        public static List<NhanVienHanhChinh> listnv = new List<NhanVienHanhChinh>();
        //tao du lieu danh sach nhan vien hanh chinh co ban
        public static void base_listNVHC()
        {
            List<PhongBan> listpb = DSPhongBan.base_listPB();
            NhanVienHanhChinh nv1 = new NhanVienHanhChinh("901","Tran Quoc Anh","12/09/1983","Nam","TP HCM","0337981105", "Tu van sinh vien",12000000);
            listnv.Add(nv1);
            listpb[0].Listnv1.Add(nv1);
            NhanVienHanhChinh nv2 = new NhanVienHanhChinh("902","Nguyen Tuan Minh","15/08/1984","Nam","TP HCM","0337981789", "Giam sat thu chi",15000000);
            listnv.Add(nv2);
            listpb[1].Listnv1.Add(nv2);
            NhanVienHanhChinh nv3 = new NhanVienHanhChinh("903","Nguyen Kim Thuy","26/05/1985","Nu","TP HCM","0337981423", "To chuc dich vu", 10000000);
            listnv.Add(nv3);
            listpb[0].Listnv1.Add(nv3);
            NhanVienHanhChinh nv4 = new NhanVienHanhChinh("904","Tran Minh Long","27/04/1986","Nam","TP HCM","0337981298", "Quan ly tai chinh",15000000);
            listnv.Add(nv4);
            listpb[1].Listnv1.Add(nv4);
        }
        //ham kiem nhan vien hanh chinh co trong danh sach hay khong
        public static NhanVienHanhChinh checkNV(string MaNV)
        {
            foreach (NhanVienHanhChinh nv in listnv)
            {
                if (String.Compare(nv.MA, MaNV, false) == 0)
                    return nv;
            }
            return null;
        }
        //ham them nhan vien hanh chinh theo phong ban vao danh sach
        public static void addNVHC(PhongBan pb)
        {
            NhanVienHanhChinh nv = new NhanVienHanhChinh();
            nv.input();
            listnv.Add(nv);
            pb.Listnv1.Add(nv);
            Console.WriteLine("Them Nhan Vien thanh cong!");
        }
        //ham in danh sach nhan vien hanh chinh
        public static void printNVHC()
        {
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien nao trong Phong Ban!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -25} {7, -10}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Cong Viec", "Luong");
            foreach (NhanVienHanhChinh nv in listnv)
            {
                nv.print();
            }
        }
        //ham xoa nhan vien hanh chinh theo phong ban khoi danh sach 
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
        //ham Sap xep danh sach giang vien hanh chinh theo ten
        public static void sort()
        {
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien Hanh Chinh nao trong danh sach!");
                return;
            }
            var DSNVHC = listnv.OrderBy(nv => nv.TEN);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -25} {7, -10}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Cong Viec", "Luong");
            foreach (NhanVienHanhChinh nv in DSNVHC)
            {
                nv.print();
            }
        } 
        //ham tim kiem nhan vien hanh chinh trong danh sach
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
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -25} {7, -10}",
              "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Cong Viec", "Luong");
            nv.print();
        }
        //ham tinh so luong nhan vien hanh chinh trong danh sach
        public static int slNVHC()
        {
            return listnv.Count;
        }
    }
}