﻿using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLGiangVien;
using SchoolManager.QLKhoa;

namespace SchoolManager.QLGiangVien
{
    public class MENU_QLGV
    {
        public static void MENU()
        {
            managerGiangVien gv = new managerGiangVien();
            managerKHOA k = new managerKHOA();
            int chon;
            string MaKhoa;
            do
            {
                Console.WriteLine("--------QUAN LY GIANG VIEN--------");
                Console.WriteLine("1.Ky hop dong voi giang vien");  //Thêm giảng viên vào danh sách của khoa
                Console.WriteLine("2.Danh sach giang vien");
                Console.WriteLine("3.Tim kiem giang vien");
                Console.WriteLine("4.Huy hop dong giang vien");  //Xóa giảng viên khỏi danh sách của khoa
                Console.WriteLine("5.Sap xep giang vien");
                Console.WriteLine("6.So luong giang vien");
                Console.WriteLine("7.Thoat");
                Console.WriteLine("----------------------------------");
                Console.Write("Chon tinh nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa = managerKHOA.checkkhoa(MaKhoa);
                        if (khoa != null)
                        {
                            gv.nhap(khoa);
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay Khoa!");
                            Console.WriteLine("Ban co muon them vao danh sach Khoa khong!");
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
                                        k.add(MaKhoa);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Chi duoc nhap tu 1-2!");
                                        break;
                                }
                            } while (chon != 2);
                        }
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("--------DANH SACH GIANG VIEN--------");
                            Console.WriteLine("1.Danh sach giang vien theo khoa");
                            Console.WriteLine("2.Danh sach tat ca giang vien");
                            Console.WriteLine("0.Thoat");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Khoa: ");
                                    MaKhoa = Console.ReadLine();
                                    KHOA khoa1 = managerKHOA.checkkhoa(MaKhoa);
                                    if (khoa1 != null)
                                    {
                                        managerGiangVien.print(khoa1);
                                    }
                                    else
                                        Console.WriteLine("Ma Khoa khong hop le!");
                                    break;
                                case 2:
                                    gv.print();
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 0-2!");
                                    break;
                            }
                        } while (chon != 0);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("--------TIM KIEM GIANG VIEN--------");
                            Console.WriteLine("1.Tim kiem giang vien theo khoa");
                            Console.WriteLine("2.Tim kiem giang vien cua tat ca cac khoa");
                            Console.WriteLine("0.Thoat");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Khoa: ");
                                    MaKhoa = Console.ReadLine();
                                    KHOA khoa2 = managerKHOA.checkkhoa(MaKhoa);
                                    if (khoa2 != null)
                                    {
                                        managerGiangVien.searchID(khoa2);
                                    }
                                    else
                                        Console.WriteLine("Ma Khoa khong hop le!");
                                    break;
                                case 2:
                                    gv.search();
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 0-2!");
                                    break;
                            }
                        } while (chon != 0);
                        break;
                    case 4:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa3 = managerKHOA.checkkhoa(MaKhoa);
                        if (khoa3 != null)
                        {
                            managerGiangVien.delete(khoa3);
                        }
                        else
                            Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 5:
                        do
                        {
                            Console.WriteLine("--------SAP XEP GIANG VIEN--------");
                            Console.WriteLine("1.Sap xep giang vien theo khoa");
                            Console.WriteLine("2.Sap xep giang vien cua tat ca cac khoa");
                            Console.WriteLine("0.Thoat");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Khoa: ");
                                    MaKhoa = Console.ReadLine();
                                    KHOA khoa4 = managerKHOA.checkkhoa(MaKhoa);
                                    if (khoa4 != null)
                                    {
                                        managerGiangVien.sortID(khoa4);
                                    }
                                    else
                                        Console.WriteLine("Ma Khoa khong hop le!");
                                    break;
                                case 2:
                                    gv.sort();
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 0-2!");
                                    break;
                            }
                        } while (chon != 0);
                        break;
                    case 6:
                        do
                        {
                            Console.WriteLine("--------SO LUONG GIANG VIEN--------");
                            Console.WriteLine("1.So luong giang vien theo khoa");
                            Console.WriteLine("2.So luong tat ca giang vien");
                            Console.WriteLine("0.Thoat");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Khoa: ");
                                    MaKhoa = Console.ReadLine();
                                    KHOA khoa5 = managerKHOA.checkkhoa(MaKhoa);
                                    if (khoa5 != null)
                                    {
                                        Console.Write("So luong: ");
                                        Console.WriteLine(managerGiangVien.sl_khoa(khoa5));
                                    }
                                    else
                                        Console.WriteLine("Ma Khoa khong hop le!");
                                    break;
                                case 2:
                                    Console.Write("So luong: ");
                                    Console.WriteLine(managerGiangVien.sl());
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 0-2!");
                                    break;
                            }
                        } while (chon != 0);
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-6!");
                        break;
                }
            } while (chon != 7);
            Console.WriteLine();
        }
    }
}

