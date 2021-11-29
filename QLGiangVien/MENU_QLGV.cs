using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLGiangVien;
using SchoolManager.QLKhoa;
using SchoolManager.QLMonHoc;

namespace SchoolManager.QLGiangVien
{
    public class menuQlyGiangVien
    {
        public static void MENU()
        {
            managerGiangVien gv = new managerGiangVien();
            managerKhoa k = new managerKhoa();
            managerMonHoc mhoc = new managerMonHoc();
            int chon;
            string MaKhoa;
            string MaMH;
            do
            {
                Console.WriteLine("--------QUAN LY GIANG VIEN--------");
                Console.WriteLine("1.Ky hop dong voi Giang Vien");  //Thêm giảng viên vào danh sách của khoa
                Console.WriteLine("2.Danh sach Giang Vien");
                Console.WriteLine("3.Tim kiem Giang Vien");
                Console.WriteLine("4.Huy hop dong Giang Vien");  //Xóa giảng viên khỏi danh sách của khoa
                Console.WriteLine("5.Sap xep Giang Vien");
                Console.WriteLine("6.So luong Giang Vien");
                Console.WriteLine("7.Giang Vien dang ki mo lop");
                Console.WriteLine("8.Thoat");
                Console.WriteLine("----------------------------------");
                Console.Write("Chon tinh nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa != null)
                        {
                            gv.inputGV(khoa);
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
                                        k.inputKhoa(MaKhoa);
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
                    case 2:
                        do
                        {
                            Console.WriteLine("--------DANH SACH GIANG VIEN--------");
                            Console.WriteLine("1.Danh sach giang vien theo khoa");
                            Console.WriteLine("2.Danh sach tat ca giang vien");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Khoa: ");
                                    MaKhoa = Console.ReadLine();
                                    KHOA khoa1 = managerKhoa.checkkhoa(MaKhoa);
                                    if (khoa1 != null)
                                    {
                                        managerGiangVien.EventprintGV(khoa1);
                                    }
                                    else
                                        Console.WriteLine("Ma Khoa khong hop le!");
                                    break;
                                case 2:
                                    gv.print();
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 1-2!");
                                    break;
                            }
                        } while (chon != 1 && chon != 2);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("--------TIM KIEM GIANG VIEN--------");
                            Console.WriteLine("1.Tim kiem giang vien theo khoa");
                            Console.WriteLine("2.Tim kiem giang vien cua tat ca cac khoa");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Khoa: ");
                                    MaKhoa = Console.ReadLine();
                                    KHOA khoa2 = managerKhoa.checkkhoa(MaKhoa);
                                    if (khoa2 != null)
                                    {
                                        managerGiangVien.searchIDGV(khoa2);
                                    }
                                    else
                                        Console.WriteLine("Ma Khoa khong hop le!");
                                    break;
                                case 2:
                                    gv.search();
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 1-2!");
                                    break;
                            }
                        } while (chon != 1 && chon != 2);
                        break;
                    case 4:
                        Console.Write("Nhap Ma Khoa: ");
                        MaKhoa = Console.ReadLine();
                        KHOA khoa3 = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa3 != null)
                        {
                            managerGiangVien.deleteGV(khoa3);
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
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Khoa: ");
                                    MaKhoa = Console.ReadLine();
                                    KHOA khoa4 = managerKhoa.checkkhoa(MaKhoa);
                                    if (khoa4 != null)
                                    {
                                        managerGiangVien.EventsortidGV(khoa4);
                                    }
                                    else
                                        Console.WriteLine("Ma Khoa khong hop le!");
                                    break;
                                case 2:
                                    gv.sort();
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 1-2!");
                                    break;
                            }
                        } while (chon != 1 && chon != 2);
                        break;
                    case 6:
                        do
                        {
                            Console.WriteLine("--------SO LUONG GIANG VIEN--------");
                            Console.WriteLine("1.So luong giang vien theo khoa");
                            Console.WriteLine("2.So luong tat ca giang vien");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Khoa: ");
                                    MaKhoa = Console.ReadLine();
                                    KHOA khoa5 = managerKhoa.checkkhoa(MaKhoa);
                                    if (khoa5 != null)
                                    {
                                        Console.Write("So luong: ");
                                        Console.WriteLine(managerGiangVien.slGV_khoa(khoa5));
                                    }
                                    else
                                        Console.WriteLine("Ma Khoa khong hop le!");
                                    break;
                                case 2:
                                    Console.Write("So luong: ");
                                    Console.WriteLine(managerGiangVien.slGV());
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 1-2!");
                                    break;
                            }
                        } while (chon != 1 && chon != 2);
                        break;
                    case 7:
                        Console.Write("Nhap Ma Mon Hoc ma Giang Vien muon dang ki: ");
                        MaMH = Console.ReadLine();
                        MonHoc mh = managerMonHoc.checkmh(MaMH);
                        if (mh != null)
                        {
                            managerGiangVien.dkimolop(mh);
                        }
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-8!");
                        break;
                }
            } while (chon != 8);
            Console.WriteLine();
        }
    }
}

