using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLGiangVien
{
    public class GiangVien : Person
    {
        private string chnganh;
        private string bomon;
        private string luong;
        private string hocvi;

        public string CHNGANG
        {
            set { chnganh = value; }
            get { return chnganh; }
        }
        public string BOMON
        {
            set { bomon = value; }
            get { return bomon; }
        }
        public string LUONG
        {
            set { luong = value; }
            get { return luong; }
        }
        public string HOCVI
        {
            set { hocvi = value; }
            get { return hocvi; }
        }
        public override void print()
        {
        }
        public override void sort()
        {
        }
        public override void search()
        {
        }
        public GiangVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string chnganh, string bomon, string luong, string hocvi)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.chnganh = chnganh;
            this.bomon = bomon;
            this.luong = luong;
            this.hocvi = hocvi;
        }
        public GiangVien(GiangVien gv) 
            : this(gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.HOCVI)
        {
        }    
        public GiangVien()
            : base ()
        {
            this.chnganh = "";
            this.bomon = "";
            this.luong = "0";
            this.hocvi = "";
        }
    }
}

/* namespace SchoolManager.QLGiangVien
{
    public class managerGiangVien : GiangVien
    {
        public static List<GiangVien> listgv = new List<GiangVien>();
        public static GiangVien checkGV(string MaGV)
        {
            foreach (GiangVien gv in listgv)
            {
                if (String.Compare(gv.MA, MaGV, false) == 0)
                    return gv;
            }
            return null;
        }
        public void inputGV(KHOA h)
        {
            GiangVien gv;         
            do
            {
                Console.Write("Ma Giang Vien: ");
                MA = Convert.ToString(Console.ReadLine());
                gv = checkGV(MA);
                if (gv != null)
                {
                    Console.WriteLine("Ma Giang Vien da ton tai!");
                    Console.WriteLine("Vui long nhap lai!!!");
                }
            } while (gv != null);
            base.input();
            Console.Write("Chuyen nganh: ");
            CHNGANG = Convert.ToString(Console.ReadLine());
            Console.Write("Bo mon: ");
            BOMON = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToString(Console.ReadLine());
            Console.Write("Hoc vi: ");
            HOCVI = Convert.ToString(Console.ReadLine());
            gv = new GiangVien(MA, TEN, NGSINH, GTINH, DIACHI, SDT, CHNGANG, BOMON, LUONG, HOCVI);
            listgv.Add(gv);
            h.Listgv1.Add(gv);
            Console.WriteLine("Them Giang Vien thanh cong!");
        }
        public static void deleteGV(KHOA h)
        {
            GiangVien k;
            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            k = checkGV(MaGV);
            if (k == null)
            {
                Console.WriteLine("Khong tim thay giang vien!");
            }
            else
            {
                listgv.Remove(k);
                h.Listgv1.Remove(k);
                Console.WriteLine("Da xoa thanh cong!");
            }
        }

        public void EventprintGV(SuKien sk)
        {
            sk.print += printGV;
        }
        public void printGV(KHOA k)
        { 
            Console.WriteLine("Khoa {0}", k.TENKHOA);
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong" , "Hoc Vi");
            foreach (GiangVien gv in k.Listgv1)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
                                  gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.HOCVI);
            }
            if(k.Listgv1.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong Khoa!");
            }    
            Console.WriteLine();
        }

        public override void print()
        {
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
                  "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Hoc Vi");
            foreach (GiangVien gv in listgv)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
                                  gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.HOCVI);
            }
            if (listgv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao trong danh sach!");
            }
            Console.WriteLine();
        }

        public static void searchIDGV(KHOA k)
        {

            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
              "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Hoc Vi");
            foreach (GiangVien gv in k.Listgv1)
            {
                if (String.Compare(gv.MA, MaGV, false) == 0)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
                                  gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.HOCVI);
                }
            }
            if (k.Listgv1.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien!");
            }
        }
        public override void search()
        {
            Console.Write("Nhap Ma Giang Vien: ");
            string MaGV = Console.ReadLine();
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
              "MaGV", "TenGV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Chuyen Nganh", "Bo mon", "Luong", "Hoc Vi");
            foreach (GiangVien gv in listgv)
            {
                if (String.Compare(gv.MA, MaGV, false) == 0)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -10} {9, -10}",
                                  gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.HOCVI);
                }
            }
            if (listgv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien!");
            }
        }

        // nhan sk
        /*public static void EventsortidGV(SuKien sk)
        {
            sk.print += sortIDGV;
        }*/
        /*
        static bool compareRise(GiangVien gv1, GiangVien gv2)
        {
            if (String.Compare(gv1.TEN, gv2.TEN, false) > 0)
                return false;
            return true;
        }
        public static void sortIDGV(KHOA k)
        {
            if (k.Listgv1.Count == 0)   
            {
                Console.WriteLine("Danh sach rong!");
            }
            else
            {
                GiangVien gv;
                for(int i = 0; i < k.Listgv1.Count - 1; i++)
                    for (int j = i + 1; j < k.Listgv1.Count; j++)
                        if (!compareRise(k.Listgv1[i], k.Listgv1[j])) 
                        {
                            gv = k.Listgv1[i];
                            k.Listgv1[i] = k.Listgv1[j];
                            k.Listgv1[j] = gv;
                        }
            }
        }
        public override void sort()
        {
            if (listgv.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
            }
            else
            {
                GiangVien gv;
                for (int i = 0; i < listgv.Count - 1; i++)
                    for (int j = i + 1; j < listgv.Count; j++)
                        if (!compareRise(listgv[i], listgv[j]))
                        {
                            gv = listgv[i];
                            listgv[i] = listgv[j];
                            listgv[j] = gv;
                        }
            }
        }

        public static int slGV_khoa(KHOA k)
        {
            return k.Listgv1.Count;
        }
        public static int slGV() 
        {
            return listgv.Count;
        }
        public static void dkimolop(MonHoc mh)
        {
            DangKi.DKiMoLop(mh);
        }
    }
} 
*/

           