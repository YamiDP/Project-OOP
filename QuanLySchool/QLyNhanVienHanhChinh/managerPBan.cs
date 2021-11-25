using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLyNhanVienHanhChinh
{
    class managerPBan : Pban
    {
        public static List<Pban> listpban = new List<Pban>();
        public static Pban checkkhoa(string MaPban)
        {
            foreach (Pban pb in listpban)
            {
                if (String.Compare(pb.MAPB, MaPban, false) == 0)
                    return pb;
            }
            return null;
        }
        public void add(string mapban)
        {
            Pban pb;
            MAPB = mapban;
            Console.Write("Ten Phong Ban: ");
            TENPB = Convert.ToString(Console.ReadLine());
            pb = new Pban(MAPB, TENPB, new List<NhanVien>());
            listpban.Add(pb);
            Console.WriteLine("Them Phong Ban thanh cong!");
        }
        public static void xuat()
        {
            Console.WriteLine("{0, -7} {1, -20}",
                  "MaPB", "TenPB");
            foreach (Pban pb in listpban)
            {
                Console.WriteLine("{0, -7} {1, -20}",
                                  pb.MAPB, pb.TENPB);
            }
            if (listpban.Count == 0)
            {
                Console.WriteLine("Khong co Phong Ban de hien thi!");
            }
            Console.WriteLine();
        }
    }
}
