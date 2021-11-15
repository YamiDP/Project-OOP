using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyNhanVienHanhChinh
{
    class managerPBan
    {
        public static List<Pban> listpban = new List<Pban>();
        public static Pban checkkhoa(string MaPban)
        {
            foreach (Pban pb in listpban)
            {
                if (String.Compare(pb.MAPB, MaPban, false) == 0) // so sánh tính cả chữ hoa và thường
                    return pb;
            }
            return null;
        }
        public static void add(string mapban)
        {
            Pban pb = new Pban();
            pb.MAPB = mapban;
            Console.Write("Ten Phong Ban: ");
            pb.MAPB = Convert.ToString(Console.ReadLine());
            listpban.Add(pb);
            Console.WriteLine("Them Phong Ban thanh cong!");
        }
        public static void xuat()
        {
            int check = 0;
            Console.WriteLine("{0, -7} {1, -20}",
                  "MaKhoa", "TenKhoa");
            foreach (Pban pb in listpban)
            {
                check++;
                Console.WriteLine("{0, -7} {1, -20}",
                                  pb.MAPB, pb.TENPB);
            }
            if (check == 0)
            {
                Console.WriteLine("Khong co Phong Ban de hien thi!");
            }
            Console.WriteLine();
        }
    }
}
