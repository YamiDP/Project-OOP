using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLKhoa;
using SchoolManager.QLCuuSinhVien;

namespace SchoolManager.QLSinhVien
{
    class menuQLySinhVien
    {
        public static void MENU()
        {
            managerSinhVien sv = new managerSinhVien();
            managerKhoa k = new managerKhoa();
            int select;
            string MaKhoa;
            do
            {
                Console.WriteLine("--------QUAN LY SINH VIEN--------");
                Console.WriteLine("1.Sinh Vien dang ki hoc theo khoa");
                Console.WriteLine("2.Danh sach sinh vien");
                Console.WriteLine("3.Tim kiem sinh vien theo khoa");
                Console.WriteLine("4.Huy sinh vien");
                Console.WriteLine("5.Sap xep sinh vien theo khoa");
                Console.WriteLine("6.Danh sach so luong sinh vien");
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
                            sv.inputSV(khoa);
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
                                    k.add(MaKhoa);
                                    break;
                                case 2:
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("--------DANH SACH SINH VIEN--------");
                        Console.WriteLine("1.Danh sach sinh vien theo khoa");
                        Console.WriteLine("2.Danh sach tat ca sinh vien");
                        Console.WriteLine("------------------------------------");
                        Console.Write("Chon tinh nang: ");
                        select = int.Parse(Console.ReadLine());
                        switch (select)
                        {
                            case 1:
                                Console.Write("Nhap Ma Khoa: ");
                                MaKhoa = Console.ReadLine();
                                KHOA khoa1 = managerKhoa.checkkhoa(MaKhoa);
                                if (khoa1 != null)
                                {
                                    managerSinhVien.printSV(khoa1);
                                }
                                else
                                    Console.WriteLine("Ma Khoa khong hop le!");
                                break;
                            case 2:
                                sv.print();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("--------TIM KIEM SINH VIEN--------");
                        Console.WriteLine("1.Tim kiem sinh vien theo khoa");
                        Console.WriteLine("2.Tim kiem sinh vien cua tat ca cac khoa");
                        Console.WriteLine("------------------------------------");
                        Console.Write("Chon tinh nang: ");
                        select = int.Parse(Console.ReadLine());
                        switch (select)
                        {
                            case 1:
                                Console.Write("Nhap Ma Khoa: ");
                                MaKhoa = Console.ReadLine();
                                KHOA khoa2 = managerKhoa.checkkhoa(MaKhoa);
                                if (khoa2 != null)
                                {
                                    managerSinhVien.searchIDSV(khoa2);
                                }
                                else
                                    Console.WriteLine("Ma Khoa khong hop le!");
                                break;
                            case 2:
                                sv.search();
                                break;
                        }
                        break;
                    case 4:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa3 = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa3 != null)
                        {
                            managerSinhVien.deleteSV(khoa3);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 5:
                        Console.WriteLine("--------SAP XEP GIANG VIEN--------");
                        Console.WriteLine("1.Sap xep giang vien theo khoa");
                        Console.WriteLine("2.Sap xep giang vien cua tat ca cac khoa");
                        Console.WriteLine("------------------------------------");
                        Console.Write("Chon tinh nang: ");
                        select = int.Parse(Console.ReadLine());
                        switch (select)
                        {
                            case 1:
                                Console.Write("Nhap Ma Khoa: ");
                                MaKhoa = Console.ReadLine();
                                KHOA khoa4 = managerKhoa.checkkhoa(MaKhoa);
                                if (khoa4 != null)
                                {
                                    managerSinhVien.sortIDSV(khoa4);
                                }
                                else
                                    Console.WriteLine("Ma Khoa khong hop le!");
                                break;
                            case 2:
                                sv.sort();
                                break;
                        }
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
                                    Console.WriteLine(managerSinhVien.slSV_khoa(khoa5));
                                }
                                else
                                    Console.WriteLine("Ma Khoa khong hop le!");
                                break;
                            case 2:
                                Console.Write("So luong: ");
                                Console.WriteLine(managerSinhVien.slSV());
                                break;
                        }
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-6!");
                        break;
                }
            } while (select != 7);
            Console.WriteLine();
        }
    }
}
