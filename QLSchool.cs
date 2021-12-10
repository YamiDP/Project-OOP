using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{       
    /*public delegate void printDel(KHOA K);
    // phat di su kien 
    public class SuKien
    {
        public event printDel print;
        public void Send(KHOA K) 
        {
            print?.Invoke(K);
        }
    }*/
    class QLSchool
    {   
        static void Main(string[] args)
        {
            List<GiangVien> listgv = new List<GiangVien>();
            List<KHOA> listkhoa = new List<KHOA>();
            KHOA khoa = new KHOA("000", "DTCLC", new List<GiangVien>(), new List<SinhVien>(), new List<CuuSinhVien>());
                managerKhoa.listkhoa.Add(khoa);
            GiangVien gv1 = new GiangVien("111", "tran quoc tuan", "11/10/1992", "Nam", "TPHCM", "0337981963", "ktpm", "OOP", "150000000", "Thac si");
                managerGiangVien.listgv.Add(gv1);
                khoa.Listgv1.Add(gv1);
            GiangVien gv2 = new GiangVien("222", "tran quoc anh", "11/9/1992", "Nu", "TPHCM", "0337981963", "ktpm", "OOP", "150000000", "Thac si");
                managerGiangVien.listgv.Add(gv2);
                khoa.Listgv1.Add(gv2);
            SinhVien sv1 = new SinhVien("333", "Phuong", "23/10/2002", "Nam", "Dong Xoai", "0123456789", "CNTT", 2020, null);
                managerSinhVien.listsv.Add(sv1);
                khoa.Listsv1.Add(sv1);
            SinhVien sv2 = new SinhVien("444", "Dat", "23/9/2002", "Nam", "Dong Xoai", "0123456789", "CNTT", 2020, null);
                managerSinhVien.listsv.Add(sv2);
                khoa.Listsv1.Add(sv2);
            managerSinhVien sv = new managerSinhVien();
            managerGiangVien gv = new managerGiangVien();
            SuKien sk = new SuKien();
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
                Console.WriteLine("8.Quan ly thoi khoa bieu");
                Console.WriteLine("9.Danh sach Sinh Vien và Giang Vien trong Khoa");
                Console.WriteLine("10.Thoat");
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
                        menuQLyNVHC.MENU();
                       break;
                    case 6:
                        MENU_QLMH.MENU();
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        Console.Write("Nhap Ma Khoa: ");
                        string MaKhoa = Console.ReadLine();
                        KHOA khoa1 = managerKhoa.checkkhoa(MaKhoa);
                        if (khoa1 != null)
                        {
                            gv.EventprintGV(sk); //Nhan su kien tu sk
                            sv.EventprintSV(sk);
                            sk.Send(khoa1);
                        }
                        else
                           Console.WriteLine("Ma Khoa khong hop le!");
                        break;
                    case 10:
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap tu 1-9!");
                        break;
                }
            } while (chon != 10);
        }
    }
}
