using System;
using SchoolManager.QLGiangVien;
using SchoolManager.QLKhoa;
using SchoolManager.QLSinhVien;
using SchoolManager.QLTuyenSinh;
namespace SchoolManager
{       
    class QLSchool
    {   
        static void Main(string[] args)
        {
            int chon;
            do
            {   //test lan cuoi
                // test lan cuoi +1
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
                        MENU_QLGV.MENU();
                        break;
                    case 2:
                        MENU_QLSV.MENU();
                        break;
                    case 3:
                        MENU_TUYENSINH.MENU();
                        break;
                    case 4:
                        break;
                    case 5:
                       break;
                    case 6:
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
