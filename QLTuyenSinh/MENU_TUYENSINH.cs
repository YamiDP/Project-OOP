using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLTuyenSinh
{
    public class menuTuyenSinh
    {
        public static void MENU()
        {
            managerHocSinh hs = new managerHocSinh();
            int chon;
            do
            {
                Console.WriteLine("------------QUAN LY TUYEN SINH------------");
                Console.WriteLine("1.Ghi danh hoc sinh");
                Console.WriteLine("2.Xuat danh sach hoc sinh");
                Console.WriteLine("3.Tim kiem hoc sinh");
                Console.WriteLine("4.Xoa hoc sinh ra khoi danh sach"); 
                Console.WriteLine("5.Sap xep hoc sinh");
                Console.WriteLine("6.Thoat");
                Console.WriteLine("----------------------------");
                Console.Write("Chon tinh nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        hs.inputHS();
                        break;
                    case 2:
                        Console.WriteLine("Danh sach hoc sinh da dang ki:");
                        hs.print();
                        break;
                    case 3:
                        hs.search();
                        break;
                    case 4:
                        hs.deleteHS();
                        break;
                    case 5:
                        hs.sort();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-6!");
                        break;
                }
            } while (chon != 6);
            Console.WriteLine();

        }
    }
}
