using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class DSPhongBan
    {
        //khoi tao danh sach phong ban
        public static List<PhongBan> listpban = new List<PhongBan>();
        //tao du lieu dau vao cho danh sach phong ban
        public static List<PhongBan> base_listPB()
        {
            PhongBan pTSinh = new PhongBan("222", "TS va CT sinh vien", new List<NhanVienHanhChinh>());
            listpban.Add(pTSinh);
            PhongBan pTChinh = new PhongBan("333", "Ke hoach tai chinh", new List<NhanVienHanhChinh>());
            listpban.Add(pTChinh);
            return listpban;
        }
        // ham kiem tra phong ban co trong danh sach hay khong
        public static PhongBan checkPB(string MaPban)
        {
            foreach (PhongBan pb in listpban)
            {
                if (String.Compare(pb.MAPB, MaPban, false) == 0)
                    return pb;
            }
            return null;
        }
        //ham them phong ban vao danh sach
        public static void addPB()
        {
            PhongBan pb = new PhongBan();
            pb.inputPB();
            listpban.Add(pb);
            Console.WriteLine("Them Phong Ban thanh cong!");
        }
        //ham in phong ban trong danh sach
        public static void printPB()
        {
            if (listpban.Count == 0)
            {
                Console.WriteLine("Khong co Phong Ban de hien thi!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -25}",
                  "MaPB", "TenPB");
            foreach (PhongBan pb in listpban)
            {
                pb.printPB();
            }
        }
        //ham xoa phong ban khoi danh sach
        public static void deletePB()
        {
            PhongBan pb;
            Console.Write("Nhap Ma Phong Ban: ");
            string MaPB = Console.ReadLine();
            pb = checkPB(MaPB);
            if (pb == null)
            {
                Console.WriteLine("Khong co Khoa!");
                return;
            }
                listpban.Remove(pb);
                Console.WriteLine("Da xoa thanh cong!");
        }
    }
}