using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLNhanVienHanhChinh
{
    public class MENU_NVHC
    {
        public static void MENU()
        {
            managerNhanVien nv = new managerNhanVien();
            managerPhongBan pb = new managerPhongBan();
            int chon;
            string MaPB;
            do
            {
                Console.WriteLine("--------QUAN LY GIANG VIEN--------");
                Console.WriteLine("1.Ky hop dong voi nhan vien");  
                Console.WriteLine("2.Danh sach nhan vien");
                Console.WriteLine("3.Tim kiem nhan vien");
                Console.WriteLine("4.Huy hop dong nhan vien");  
                Console.WriteLine("5.Sap xep nhan vien");
                Console.WriteLine("6.So luong nhan vien");
                Console.WriteLine("7.Thoat");
                Console.WriteLine("----------------------------------");
                Console.Write("Chon tinh nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap Ma Phong Ban: ");
                        MaPB = Console.ReadLine();
                        PhongBan pban = managerPhongBan.checkPB(MaPB);
                        if (pban != null)
                        {
                            nv.inputNV(pban);
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay Phong ban!");
                            Console.WriteLine("Ban co muon them vao danh sach Phong Ban khong!");
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
                                        pb.inputPB(MaPB);
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
                            Console.WriteLine("--------DANH SACH NHAN VIEN--------");
                            Console.WriteLine("1.Danh sach nhan vien theo phong ban");
                            Console.WriteLine("2.Danh sach tat ca nhan vien");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Phong Ban: ");
                                    MaPB = Console.ReadLine();
                                    PhongBan pban1 = managerPhongBan.checkPB(MaPB);
                                    if (pban1 != null)
                                    {
                                        managerNhanVien.printNV(pban1);
                                    }
                                    else
                                        Console.WriteLine("Ma Phong Ban khong hop le!");
                                    break;
                                case 2:
                                    nv.print();
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
                            Console.WriteLine("--------TIM KIEM NHAN VIEN--------");
                            Console.WriteLine("1.Tim kiem nhan vien theo phong ban");
                            Console.WriteLine("2.Tim kiem nhan vien cua tat ca cac phong ban");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Phong Ban: ");
                                    MaPB = Console.ReadLine();
                                    PhongBan pban2 = managerPhongBan.checkPB(MaPB);
                                    if (pban2 != null)
                                    {
                                        managerNhanVien.searchIDNV(pban2);
                                    }
                                    else
                                        Console.WriteLine("Ma Phong Ban khong hop le!");
                                    break;
                                case 2:
                                    nv.search();
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 1-2!");
                                    break;
                            }
                        } while (chon != 1 && chon != 2);
                        break;
                    case 4:
                        Console.Write("Nhap Ma Phong ban: ");
                        MaPB = Console.ReadLine();
                        PhongBan pban3 = managerPhongBan.checkPB(MaPB);
                        if (pban3 != null)
                        {
                            managerNhanVien.deleteNV(pban3);
                        }
                        else
                            Console.WriteLine("Ma Phong Ban khong hop le!");
                        break;
                    case 5:
                        do
                        {
                            Console.WriteLine("--------SAP XEP NHAN VIEN--------");
                            Console.WriteLine("1.Sap xep nhan vien theo phong ban");
                            Console.WriteLine("2.Sap xep nhan vien cua tat ca cac phong ban");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Phong Ban: ");
                                    MaPB = Console.ReadLine();
                                    PhongBan pban4 = managerPhongBan.checkPB(MaPB);
                                    if (pban4 != null)
                                    {
                                        managerNhanVien.sortIDNV(pban4);
                                    }
                                    else
                                        Console.WriteLine("Ma Phong Ban khong hop le!");
                                    break;
                                case 2:
                                    nv.sort();
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
                            Console.WriteLine("--------SO LUONG NHAN VIEN--------");
                            Console.WriteLine("1.So luong nhan vien theo phong ban");
                            Console.WriteLine("2.So luong tat ca nhan vien");
                            Console.WriteLine("------------------------------------");
                            Console.Write("Chon tinh nang: ");
                            chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    Console.Write("Nhap Ma Phong Ban: ");
                                    MaPB = Console.ReadLine();
                                    PhongBan pban5 = managerPhongBan.checkPB(MaPB);
                                    if (pban5 != null)
                                    {
                                        Console.Write("So luong: ");
                                        Console.WriteLine(managerNhanVien.slNV_pb(pban5));
                                    }
                                    else
                                        Console.WriteLine("Ma Phong ban khong hop le!");
                                    break;
                                case 2:
                                    Console.Write("So luong: ");
                                    Console.WriteLine(managerNhanVien.slNV());
                                    break;
                                default:
                                    Console.WriteLine("Chi duoc nhap tu 1-2!");
                                    break;
                            }
                        } while (chon != 1 && chon != 2);
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-7!");
                        break;
                }
            } while (chon != 7);
            Console.WriteLine();
        }   
    }
}