using System;
using SchoolManager.QLGiangVien;
using SchoolManager.QLKhoa;
using SchoolManager.QLSinhVien;
using SchoolManager.QLTuyenSinh;
using SchoolManager.QLMonHoc;

namespace SchoolManager
{       
    class QLSchool
    {   
        static void Main(string[] args)
        {
            int chon;
            do
            {   
                Console.WriteLine("------------QUAN LY TRUONG HOC------------");
                Console.WriteLine("1.Quan ly giang vien");
                Console.WriteLine("2.Quan ly sinh vien");
                Console.WriteLine("3.Quan ly tuyen sinh");
                Console.WriteLine("4.Quan ly khoa hoc");
                Console.WriteLine("5.Quan ly nhan vien hanh chinh");
                Console.WriteLine("6.Quan ly mon hoc");
                Console.WriteLine("7.Quan ly diem");
                Console.WriteLine("8.Thoat");
                Console.WriteLine("----------------------------");
                Console.Write("Chon tinh nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        menuQlyGiangVien.MENU();
                        break;
                    case 2:
                        menuQLySinhVien.MENU();
                        break;
                    case 3:
                        menuTuyenSinh.MENU();
                        break;
                    case 4:
                        break;
                    case 5:
                       break;
                    case 6:
                        MENU_QLMH.MENU();
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-8!");
                        break;
                }
            } while (chon != 8);
        }
    }
}
