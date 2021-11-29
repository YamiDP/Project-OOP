using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLGiangVien;
using SchoolManager.QLKhoa;

namespace SchoolManager.QLMonHoc
{
    public class MENU_QLMH
    {
         public static void MENU()
        {
            managerMonHoc mhoc = new managerMonHoc();
            int chon;
            string MaMH;
            do
            {
                Console.WriteLine("--------QUAN LY MON HOC--------");
                Console.WriteLine("1.Them mon hoc");  
                Console.WriteLine("2.Huy mon hoc");
                Console.WriteLine("3.Danh sach cac mon hoc");
                Console.WriteLine("4.Danh sach cac lop hoc phan");
                Console.WriteLine("5.Thoat");
                Console.WriteLine("----------------------------------");
                Console.Write("Chon tinh nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap Ma Mon Hoc: ");
                        MaMH = Console.ReadLine();
                        MonHoc mh = managerMonHoc.checkmh(MaMH);
                        if (mh == null)
                        {
                            mhoc.inputMH(MaMH);
                        }
                        else
                            Console.WriteLine("Mon hoc nay da co!!!");
                        break;
                    case 2:
                        managerMonHoc.deleteMH();
                        break;
                    case 3:
                        managerMonHoc.printMonHoc();
                        break;
                    case 4:
                        Console.Write("Nhap Ma Mon Hoc: ");
                        MaMH = Console.ReadLine();
                        MonHoc mh3 = managerMonHoc.checkmh(MaMH);
                        if (mh3 != null)
                        {
                            managerMonHoc.printMHMoLop(mh3);
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-5!");
                        break;
                }
            }while(chon != 5);
        }
    }
}