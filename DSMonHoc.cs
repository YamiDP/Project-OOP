using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SchoolManager
{
    public class DSMonHoc
    {
        //khoi tao danh sach cac mon hoc
        public static List<MonHoc> listmh = new List<MonHoc>();
        //tao du lieu danh sach mon hoc co ban
        public static void base_list()
        {
            MonHoc mh1 = new MonHoc("MH1","Dai so tuyen tinh",4,"Ly thuyet");
            listmh.Add(mh1);
            MonHoc mh2 = new MonHoc("MH2","Toan roi rac va LTDT",3,"Ly thuyet");
            listmh.Add(mh2);
            MonHoc mh5 = new MonHoc("MH5","Nhap mon lap trinh",3,"Ly thuyet");
            listmh.Add(mh5);
            MonHoc mh3 = new MonHoc("MH3","Vat ly 1",3,"Ly thuyet");
            listmh.Add(mh3);
            MonHoc mh4 = new MonHoc("MH4","Thi nghiem vat ly 1",2,"Thuc hanh");
            listmh.Add(mh4);
            MonHoc mh6 = new MonHoc("MH6","Tu tuong HCM",3,"Ly thuyet");
            listmh.Add(mh6);
        }
        //kiem tra mon hoc co ton tai trong danh sach
        public static MonHoc checkmh(string MaMH)
        {
            foreach (MonHoc mh in listmh)
            {
                if (String.Compare(mh.Mamh, MaMH, false) == 0)
                    return mh;
            }
            return null;
        }
        //
        public static bool checkMHGV(string MaMH, GiangVien gv)
        {
            foreach (MonHoc mh in gv.Listmh1)
            {
                if (String.Compare(mh.Mamh, MaMH, false) == 0)
                    return false;
            }
            return true;
        }
        public static bool checkMHSV(string MaMH, SinhVien sv)
        {
            foreach (MonHoc mh in sv.ListmhSV)
            {
                if (String.Compare(mh.Mamh, MaMH, false) == 0)
                    return false;
            }
            return true;
        }
        //them mon hoc vao danh sach
        public static void addMH()
        {
            MonHoc mh = new MonHoc();
            mh.inputMH();
            listmh.Add(mh);
            Console.WriteLine("Them mon hoc thanh cong!");
            Console.WriteLine();
        }
        //in danh sach mon hoc
        public static void printDSMH()
        {
            Console.WriteLine("{0, -7} {1, -20} {2,-10}{3,-15}",
                  "Ma MH", "Ten MH","So TC","Loai mon");
            foreach (MonHoc mh in listmh)
            {
                mh.print();
            }
            if (listmh.Count == 0)
            {
                Console.WriteLine("Khong co Mon Hoc de hien thi!");
            }
            Console.WriteLine();
        }
        //ham in danh sach mon hoc cua 1 giang vien da dang ki mo lop
        public static void printMHGVDKiML(GiangVien gv)
        {
            if (gv.Listmh1.Count == 0)
            {
                Console.WriteLine("Khong co Mon Hoc nao trong danh sach!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2,-10}{3,-15}",
                  "Ma MH", "Ten MH","So TC","Loai mon");
            foreach (MonHoc mh in gv.Listmh1)
            {
                mh.print();
            }
        }
        //ham in danh sach mon hoc cua 1 sinh da dang ki
        public static void printMHSVdki(SinhVien sv)
        {
            if (sv.ListmhSV.Count == 0)
            {
                Console.WriteLine("Khong co Mon Hoc nao trong danh sach!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2,-10}{3,-15}",
                  "Ma MH", "Ten MH","So TC","Loai mon");
            foreach (MonHoc mh in sv.ListmhSV)
            {
                mh.print();
            }
        }
        //xoa mon hoc ra khoi danh sach
        public static void deleteMH()
        {
            MonHoc monHoc;
            do{
                Console.Write("Nhap Ma mon hoc muon huy: ");
                string MaMH = Console.ReadLine();
                monHoc = checkmh(MaMH);
                if (monHoc == null)
                {
                    Console.WriteLine("Khong tim thay mon hoc!");
                    Console.WriteLine("Vui long nhap lai Ma moi!!!");
                }
            }while(monHoc == null);
            listmh.Remove(monHoc);
            Console.WriteLine("Da xoa thanh cong!");
        }
        //sap xep mon hoc theo ma mon hoc
        public static void sort_MA()
        {
            if(listmh.Count == 0)
            {
                Console.WriteLine("Khong co mon hoc nao trong danh sach!");
                return;
            }
            var DSMH = listmh.OrderBy(mh=>mh.Mamh);
            Console.WriteLine("Danh sach sau khi sap xep theo ma mon hoc:");
            Console.WriteLine("{0, -7} {1, -20} {2,-10}{3,-15}",
                  "Ma MH", "Ten MH","So TC","Loai mon");
            foreach (MonHoc mh in DSMH)
            {
                mh.print();
            }
            Console.WriteLine();
        }
        //sap xep mon hoc theo ten
        public static void sort_name()
        {
            if(listmh.Count == 0)
            {
                Console.WriteLine("Khong co mon hoc nao trong danh sach!");
                return;
            }
            var DSMH = listmh.OrderBy(mh=>mh.TenMH);
            Console.WriteLine("Danh sach sau khi sap xep theo ten:");
            Console.WriteLine("{0, -7} {1, -20} {2,-10}{3,-15}",
                  "Ma MH", "Ten MH","So TC","Loai mon");
            foreach (MonHoc mh in DSMH)
            {
                mh.print();
            }
            Console.WriteLine();
        }
        //Ham tra ve so luong mon hoc
        public static int SLMH()
        {
            return listmh.Count;
        }
    }
}