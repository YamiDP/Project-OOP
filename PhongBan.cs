using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class PhongBan
    {
        private string mapb;
        private string tenpb;
        List<NhanVien> listnv1;
        public string MAPB
        {
            set { mapb = value; }
            get { return mapb; }
        }
        public string TENPB
        {
            set { tenpb = value; }
            get { return tenpb; }
        }
        public List<NhanVien> Listnv1
        {
            set { listnv1 = value; }
            get { return listnv1; }
        }

        public PhongBan(string mapb, string tenpb, List<NhanVien> listnv2)
        {
            this.mapb = mapb;
            this.tenpb = tenpb;
            this.listnv1 = listnv2;
        }
        public PhongBan(PhongBan phongban)
            : this(phongban.MAPB, phongban.TENPB, phongban.Listnv1)
        {
        }
        public PhongBan()
        {
            this.mapb = "";
            this.tenpb = "";
            this.listnv1 = null;
        }
    }
}

/*
namespace SchoolManager.QLNhanVienHanhChinh
{
    public class managerPhongBan : PhongBan
    {
        public static List<PhongBan> listpban = new List<PhongBan>();
        public static PhongBan checkPB(string MaPban)
        {
            foreach (PhongBan pb in listpban)
            {
                if (String.Compare(pb.MAPB, MaPban, false) == 0)
                    return pb;
            }
            return null;
        }
        public void inputPB(string mapban)
        {
            PhongBan pb;
            MAPB = mapban;
            Console.Write("Ten Phong Ban: ");
            TENPB = Convert.ToString(Console.ReadLine());
            pb = new PhongBan(MAPB, TENPB, new List<NhanVien>());
            listpban.Add(pb);
            Console.WriteLine("Them Phong Ban thanh cong!");
        }
        public static void printPB()
        {
            Console.WriteLine("{0, -7} {1, -20}",
                  "MaPB", "TenPB");
            foreach (PhongBan pb in listpban)
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
*/