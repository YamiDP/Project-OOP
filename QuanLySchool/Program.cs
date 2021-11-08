using System;
using QuanLySchool.QLyGiangVien;

namespace QuanLySchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("--------MENU--------");
                Console.WriteLine("1.Ky hop dong voi giang vien");  //Thêm giảng viên vào Danh sách
                Console.WriteLine("2.Danh sach giang vien");
                Console.WriteLine("3.Search giang vien");
                Console.WriteLine("4.Huy hop dong giang vien");  //Xóa giảng viên khỏi danh sách    
                Console.WriteLine("5.Sort giang vien");
                Console.WriteLine("6.Exit");
                Console.WriteLine("--------------------");
                Console.Write("Chon tinh nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap Ma Khoa: ");
                        string MaKhoa = Console.ReadLine();
                        KHOA khoa = managerKHOA.checkkhoa(MaKhoa);
                        if (khoa != null)
                        {
                            managerGiangVien.add(MaKhoa, khoa);
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay Khoa!");
                            Console.WriteLine("Ban co muon them vao danh sach Khoa khong!");
                            Console.WriteLine("1.Co");
                            Console.WriteLine("2.Khong");
                            int chon1;
                            chon1 = int.Parse(Console.ReadLine());
                            switch (chon1)
                            {
                                case 1:
                                    managerKHOA.add(MaKhoa);
                                    break;
                                case 2:
                                    break;
                            }    
                        }
                        break;
                    case 2:
                        Console.Write("Nhap Ma Khoa: ");
                        string MaKhoa1 = Console.ReadLine();
                        KHOA khoa1 = managerKHOA.checkkhoa(MaKhoa1);
                        if (khoa1 != null)
                        {
                            managerGiangVien.xuat(khoa1);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 3:
                        Console.Write("Nhap Ma Khoa: ");
                        string MaKhoa2 = Console.ReadLine();
                        KHOA khoa2 = managerKHOA.checkkhoa(MaKhoa2);
                        if (khoa2 != null)
                        {
                            managerGiangVien.searchID(khoa2);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 4:
                        Console.Write("Nhap Ma Khoa: ");
                        string MaKhoa3 = Console.ReadLine();
                        KHOA khoa3 = managerKHOA.checkkhoa(MaKhoa3);
                        if (khoa3 != null)
                        {
                            managerGiangVien.delete(khoa3);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 5:
                        Console.Write("Nhap Ma Khoa: ");
                        string MaKhoa4 = Console.ReadLine();
                        KHOA khoa4 = managerKHOA.checkkhoa(MaKhoa4);
                        if (khoa4 != null)
                        {
                            managerGiangVien.sort(khoa4);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
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
