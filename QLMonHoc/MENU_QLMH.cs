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
                Console.WriteLine("3.Giang Vien dang ki mo lop");
                Console.WriteLine("4.Sinh Vien dang ki mon hoc");
                Console.WriteLine("5.Danh sach Giang Vien da dang ki mo lop 1 mon hoc");
                Console.WriteLine("6.Thoat");
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
                        break;
                    case 3:
                        Console.Write("Nhap Ma Mon Hoc: ");
                        MaMH = Console.ReadLine();
                        MonHoc mh1 = managerMonHoc.checkmh(MaMH);
                        if (mh1 != null)
                        {
                            DangKi.dkimolop(mh1);
                        }
                        break;
                    case 4:
                        Console.Write("Nhap Ma Mon Hoc muon dang ki: ");
                        MaMH = Console.ReadLine();
                        MonHoc mh2 = managerMonHoc.checkmh(MaMH);
                        if (mh2 != null)
                        {
                            DangKi.dkimhoc(mh2);
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay Mon Hoc!");
                            Console.WriteLine("Ban co muon them vao danh sach Mon Hoc khong!");
                            do
                            {
                                Console.WriteLine("----------------");
                                Console.WriteLine("1.Co");
                                Console.WriteLine("2.Khong");
                                Console.WriteLine("----------------");
                                Console.Write("Chon tinh nang: ");
                                chon = int.Parse(Console.ReadLine());
                                switch (chon)
                                {
                                    case 1:
                                        mhoc.inputMH(MaMH);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Chi duoc nhap tu 1-2!");
                                        break;
                                }
                            } while (chon != 1 && chon != 2);
                        }
                        break;
                    case 5:
                        Console.Write("Nhap Ma Mon Hoc: ");
                        MaMH = Console.ReadLine();
                        MonHoc mh3 = managerMonHoc.checkmh(MaMH);
                        if (mh3 != null)
                        {
                            managerMonHoc.printMHMoLop(mh3);
                        }
                        break;
                    case 6:
                        break;
                }
            }while(chon != 6);
        }
    }
}