using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLMonHoc
{
    public class managerMonHoc: MonHoc
    {
        public static List<MonHoc> listmh = new List<MonHoc>();
        public static MonHoc checkmh(string MaMH)
        {
            foreach (MonHoc mh in listmh)
            {
                if (String.Compare(mh.Mamh, MaMH, false) == 0)
                    return mh;
            }
            return null;
        }
        public void inputMH(string mamh)
        {
            MonHoc mh;
            Mamh = mamh;
            Console.Write("Ten mon hoc: ");
            TenMH = Convert.ToString(Console.ReadLine());
            Console.Write("So tin chi: ");
            SoTC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Loai mon : ");
            LoaiMon = Convert.ToString(Console.ReadLine());
            mh = new MonHoc(Mamh, TenMH, SoTC, LoaiMon, new List<DangKi>());
            listmh.Add(mh);
            Console.WriteLine("Them Mon hoc thanh cong!");
        }
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
        public static void printMonHoc()
        {
            Console.WriteLine("{0, -7} {1, -20}",
                  "MaMH", "TenMH");
            foreach (MonHoc mh in listmh)
            {
                Console.WriteLine("{0, -7} {1, -20}",
                                  mh.Mamh, mh.TenMH);
            }
            if (listmh.Count == 0)
            {
                Console.WriteLine("Khong co Mon Hoc de hien thi!");
            }
            Console.WriteLine();
        }
        public static void printMHMoLop(MonHoc mh)
        {
            Console.WriteLine("Mon hoc: {0}", mh.TenMH);
            Console.WriteLine("{0, -10} {1, -20} {2, -5} {3, -10} {4, -10} {5, -20} {6, -20}",
                  "Loai Mon", "Lop HP", "STC", "Gioi Han", "Dang Ki", "Giang Vien", "Lich Hoc");
            foreach (DangKi dk in mh.Listdk)
            {
                Console.WriteLine("{0, -10} {1, -20} {2, -5} {3, -10} {4, -10} {5, -20} {6, -20}",
                                dk.LoaiMon, dk.LopHP, dk.SoTC, dk.GioiHan, dk.SoLuongDKi, dk.TenGV, dk.LichHoc);
            }
            if (mh.Listdk.Count == 0)
            {
                Console.WriteLine("Khong co Mon hoc de hien thi!");
            }
            Console.WriteLine();
        }
    }
}