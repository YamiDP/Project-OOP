using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLKhoa;

namespace SchoolManager.QLCuuSinhVien
{
    public class MENU_CSV
    {
        public static void MENU()
        {
            managerCuuSinhVien csv = new managerCuuSinhVien();
            managerKhoa k = new managerKhoa();
            int select;
            string MaKhoa;
            do
            {
                Console.WriteLine("--------QUAN LY SINH VIEN--------");
                Console.WriteLine("1.Them cuu sinh vien theo khoa");
                Console.WriteLine("2.Danh sach cuu sinh vien");
                Console.WriteLine("3.Tim kiem cuu sinh vien theo khoa");
                Console.WriteLine("4.Huy cuu sinh vien");
                Console.WriteLine("5.Sap xep cuu sinh vien theo khoa");
                Console.WriteLine("6.Danh sach so luong cuu sinh vien");
                Console.WriteLine("7.Thoat");
                Console.WriteLine("---------------------------------");
                Console.Write("Chon tinh nang: ");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa != null)
                        {
                            csv.inputCSV(khoa);
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay Khoa!");
                            Console.WriteLine("Ban co muon them vao danh sach Khoa khong!");
                            Console.WriteLine("----------------");
                            Console.WriteLine("1.Co");
                            Console.WriteLine("2.Khong");
                            Console.WriteLine("----------------");
                            Console.Write("Chon tinh nang: ");
                            select = int.Parse(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    k.inputKhoa(MaKhoa);
                                    break;
                                case 2:
                                    break;
                            }
                        }
                        break;
                    case 2:

                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa1 = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa1 != null)
                        {
                            managerCuuSinhVien.printCSV(khoa1);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 3:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa2 = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa2 != null)
                        {
                            managerCuuSinhVien.searchIDCSV(khoa2);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 4:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa3 = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa3 != null)
                        {
                            managerCuuSinhVien.deleteCSV(khoa3);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 5:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa4 = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa4 != null)
                        {
                            managerCuuSinhVien.sortIDCSV(khoa4);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 6:
                        Console.WriteLine("--------SO LUONG SINH VIEN--------");
                        Console.WriteLine("1.So luong sinh vien theo khoa");
                        Console.WriteLine("2.So luong tat ca sinh vien");
                        Console.WriteLine("------------------------------------");
                        Console.Write("Chon tinh nang: ");
                        select = int.Parse(Console.ReadLine());
                        switch (select)
                        {
                            case 1:
                                Console.Write("Nhap Ma Khoa: ");
                                MaKhoa = Console.ReadLine();
                                KHOA khoa5 = managerKhoa.checkkhoa(MaKhoa);
                                if (khoa5 != null)
                                {
                                    Console.Write("So luong: ");
                                    Console.WriteLine(managerCuuSinhVien.slCSV_khoa(khoa5));
                                }
                                else
                                    Console.WriteLine("Ma Khoa khong hop le!");
                                break;
                            case 2:
                                Console.Write("So luong: ");
                                Console.WriteLine(managerCuuSinhVien.slCSV());
                                break;
                        }
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-7!");
                        break;
                }
            } while (select != 7);
            Console.WriteLine();
        }
    }
}
