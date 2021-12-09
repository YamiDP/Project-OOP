using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLMonHoc
{
    public class MonHoc
    {
        private string mamh;
        private string tenmh;
        private int sotc;
        private string loaimon; // thực hành hay lý thuyết
        List<DangKi> listdki;       // Danh sach cac lop hoc phan
        
        public string Mamh
        {
            set{ mamh = value;}
            get {return mamh;}
        }
        public string TenMH
        {
            set{tenmh = value;}
            get{return tenmh;}
        }
        public int SoTC
        {
            set{sotc = value;}
            get{return sotc;}
        }
        public string LoaiMon
        {
            set{loaimon = value;}
            get{return loaimon;}
        }
        public List<DangKi> Listdk
        {
            set {listdki = value; }
            get { return listdki; }
        }
        public MonHoc()
        {      
        }
        public MonHoc(string mamh, string tenmh, int sotc, string loaimon, List<DangKi> listdki)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.sotc = sotc;
            this.loaimon = loaimon;
            this.listdki = listdki;
        }
        public MonHoc(MonHoc mh)
            : this (mh.mamh,mh.tenmh, mh.sotc, mh.loaimon, mh.listdki)
        {
        }
    }
}
/* namespace SchoolManager.QLMonHoc
{
    public class managerMonHoc: MonHoc
    {
        public static List<MonHoc> listmh = new List<MonHoc>();
        public static MonHoc checkmh(string MaMH)
        {
            foreach (MonHoc mh in listmh)
            {
                if (String.Compare(mh.Mamh, MaMH, false) == 0)
                    return mh;
            }
            return null;
        }
        public void inputMH(string mamh)
        {
            MonHoc mh;
            Mamh = mamh;
            Console.Write("Ten mon hoc: ");
            TenMH = Convert.ToString(Console.ReadLine());
            Console.Write("So tin chi: ");
            SoTC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Loai mon : ");
            LoaiMon = Convert.ToString(Console.ReadLine());
            mh = new MonHoc(Mamh, TenMH, SoTC, LoaiMon, new List<DangKi>());
            listmh.Add(mh);
            Console.WriteLine("Them Mon hoc thanh cong!");
        }
        public static void deleteMH()
        {
            MonHoc monHoc;
            do{
                Console.Write("Nhap Ma mon hoc muon huy: ");
                string MaMH = Console.ReadLine();
                monHoc = checkmh(MaMH);
                if (monHoc == null)
                {
                    Console.WriteLine("Khong tim thay mon hoc!");
                    Console.WriteLine("Vui long nhap lai Ma moi!!!");
                }
            }while(monHoc == null);
            listmh.Remove(monHoc);
            Console.WriteLine("Da xoa thanh cong!");
        }
        public static void printMonHoc()
        {
            Console.WriteLine("{0, -7} {1, -20}",
                  "MaMH", "TenMH");
            foreach (MonHoc mh in listmh)
            {
                Console.WriteLine("{0, -7} {1, -20}",
                                  mh.Mamh, mh.TenMH);
            }
            if (listmh.Count == 0)
            {
                Console.WriteLine("Khong co Mon Hoc de hien thi!");
            }
            Console.WriteLine();
        }
        public static void printMHMoLop(MonHoc mh)
        {
            Console.WriteLine("Mon hoc: {0}", mh.TenMH);
            Console.WriteLine("{0, -10} {1, -20} {2, -5} {3, -10} {4, -10} {5, -20} {6, -20}",
                  "Loai Mon", "Lop HP", "STC", "Gioi Han", "Dang Ki", "Giang Vien", "Lich Hoc");
            foreach (DangKi dk in mh.Listdk)
            {
                Console.WriteLine("{0, -10} {1, -20} {2, -5} {3, -10} {4, -10} {5, -20} {6, -20}",
                                dk.LoaiMon, dk.LopHP, dk.SoTC, dk.GioiHan, dk.SoLuongDKi, dk.TenGV, dk.LichHoc);
            }
            if (mh.Listdk.Count == 0)
            {
                Console.WriteLine("Khong co Mon hoc de hien thi!");
            }
            Console.WriteLine();
        }
    }
} */

/* namespace SchoolManager.QLMonHoc
{
    public class DangKi : MonHoc
    {
        private string magv;
        private string tengv;
        private string lophp;
        private int gioihan;
        private int soluongdki;
        private string lichhoc;
        public string MaGV
        {
            set{magv = value;}
            get{return magv;}
        }
        public string TenGV
        {
            set{tengv = value;}
            get{return tengv;}
        }
        public string LopHP
        {
            set{lophp = value;}
            get{return lophp;}
        }
        public int GioiHan
        {
            set{gioihan = value;}
            get{return gioihan;}
        }
        public int SoLuongDKi
        {
            set{soluongdki = value;}
            get{return soluongdki;}
        }
        public string LichHoc
        {
            set{lichhoc = value;}
            get{return lichhoc;}
        }
        public DangKi()
        {   
        }
        public DangKi(string mamh, string tenmh, int sotc, string loaimon, List<DangKi> listdki, string magv, string tengv, string lophp ,int gioihan, int soluongdki,string lichhoc)
            : base(mamh, tenmh, sotc, loaimon, listdki)
        {
            this.magv = magv;
            this.tengv = tengv;
            this.lophp = lophp;
            this.gioihan = gioihan;
            this.soluongdki = soluongdki;
            this.lichhoc = lichhoc;
        }
        public DangKi(DangKi dk)
            : this (dk.Mamh, dk.TenMH, dk.SoTC, dk.LoaiMon, dk.Listdk, dk.MaGV, dk.TenGV, dk.LopHP, dk.GioiHan, dk.SoLuongDKi, dk.LichHoc)
        {
        }

        public static List<DangKi> listdk = new List<DangKi>();
        public static DangKi checkDK(MonHoc mh, string MaGV) // check mã GV
        {
            foreach (DangKi dk in mh.Listdk)
            {
                if (String.Compare(dk.MaGV, MaGV, false) == 0)
                    return dk;
            }
            return null;
        }
        public static DangKi checkLopHP(MonHoc mh, string LopHP) // check Lop HP
        {
            foreach (DangKi dk in mh.Listdk)
            {
                if (String.Compare(dk.LopHP, LopHP, false) == 0)
                    return dk;
            }
            return null;
        }
        public static void DKiMoLop(MonHoc mh)
        {
            GiangVien gv; 
            DangKi dk;  
            string MaGV;    
            do
            {
                Console.Write("Nhap Ma Giang Vien muon dang ki mo lop: ");
                MaGV = Console.ReadLine();
                gv = managerGiangVien.checkGV(MaGV);
                if (gv == null)
                {
                    Console.WriteLine("Khong co Giang Vien nay trong truong!");
                    Console.WriteLine("Vui long nhap lai Ma Giang Vien!!!");
                }
            } while (gv == null);

            dk = checkDK(mh, MaGV);
            if (dk != null)
            {
                Console.WriteLine("Giang Vien nay da dang ki mon hoc nay!");
                return;
            }
            DangKi dki = new DangKi();
            Console.Write("Lop hoc phan: ");
            dki.lophp = Convert.ToString(Console.ReadLine());
            Console.Write("Gioi han: ");
            dki.gioihan = Convert.ToInt32(Console.ReadLine());
            dki.soluongdki = 0;
            Console.Write("Lich hoc: ");
            dki.lichhoc = Convert.ToString(Console.ReadLine());
            dk = new DangKi(mh.Mamh, mh.TenMH, mh.SoTC, mh.LoaiMon, mh.Listdk, gv.MA, gv.TEN, dki.lophp, dki.gioihan, dki.soluongdki, dki.lichhoc);
            mh.Listdk.Add(dk);
            Console.WriteLine("Dang ki mo lop thanh cong!!!");
        }
        public static void DKiMonHoc(MonHoc mh)
        {
            SinhVien sv;
            string MaSV;
            DangKi dangKi; 
            string LopHP;    

            if(mh.Listdk.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien nao dang ki mo lop mon nay!");
                return;
            }
            do
            {
                Console.Write("Nhap Ma Sinh Vien muon dang ki mon hoc: ");
                MaSV = Console.ReadLine();
                sv = managerSinhVien.checkSV(MaSV);
                if (sv == null)
                {
                    Console.WriteLine("Khong co Sinh Vien nay trong truong!");
                    Console.WriteLine("Vui long nhap lai Ma Sinh Vien!!!");
                }
            } while (sv == null);

            managerMonHoc.printMHMoLop(mh);

            do
            {
                Console.Write("Chon Lop hoc phan: ");
                LopHP = Console.ReadLine();
                dangKi = checkLopHP(mh, LopHP);
                if (dangKi == null)
                {
                    Console.WriteLine("Khong co Lop hoc phan nay!");
                    Console.WriteLine("Vui long nhap lai Lop hoc phan!!!");
                }
            } while (dangKi == null);

            foreach (DangKi dk in mh.Listdk)
            {
                if (String.Compare(dk.LopHP, dangKi.LopHP, false) == 0)
                {
                    if(dk.SoLuongDKi == dk.GioiHan)
                    {
                        Console.WriteLine("Lop hoc phan nay da du so luong!!!");
                        return;
                    }
                    dk.SoLuongDKi++;
                }
            }
            // bị trùng mã lớp hp vẫn đki đc
            //sv.ListmhSV.Add(mh);
            Console.WriteLine("Dang ki Mon Hoc thanh cong!!!");
        }
    }
} */