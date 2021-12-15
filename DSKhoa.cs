using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class DSKhoa
    {
        //khoi tao danh sach khoa
        public static List<KHOA> listkhoa = new List<KHOA>();
        //tao du lieu dau vao cho danh sach khoa
        public static List<KHOA> base_listkhoa()
        {
            KHOA cntt = new KHOA("111","CNTT", new List<GiangVien>(), new List<SinhVien>(), new List<CuuSinhVien>());
            listkhoa.Add(cntt);
            KHOA xaydung = new KHOA("112","Xay Dung", new List<GiangVien>(), new List<SinhVien>(), new List<CuuSinhVien>());
            listkhoa.Add(xaydung);
            return listkhoa;
        }
        // ham kiem tra khoa co trong danh sach hay khong
        public static KHOA checkkhoa(string MaKhoa)
        {
            foreach (KHOA khoa in listkhoa)
            {
                if (String.Compare(khoa.MAKHOA, MaKhoa, false) == 0)
                    return khoa;
            }
            return null;
        }
        //ham them khoa vao danh sach
        public static void addKhoa()
        {
            KHOA k = new KHOA();
            k.inputKhoa();
            listkhoa.Add(k);
            Console.WriteLine("Them Khoa thanh cong!");
        }
        //ham in khoa trong danh sach
        public static void printKhoa()
        {
            if (listkhoa.Count == 0)
            {
                Console.WriteLine("Khong co Khoa de hien thi!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20}",
                  "MaKhoa", "TenKhoa");
            foreach (KHOA khoa in listkhoa)
            {
                khoa.printKhoa();
            }
        }
        //ham xoa khoa khoi danh sach
        public static void deleteKhoa()
        {
            KHOA k;
            Console.Write("Nhap Ma Khoa: ");
            string MaKhoa = Console.ReadLine();
            k = checkkhoa(MaKhoa);
            if (k == null)
            {
                Console.WriteLine("Khong co Khoa!");
                return;
            }
                listkhoa.Remove(k);
                Console.WriteLine("Da xoa thanh cong!");
        }
    }
}