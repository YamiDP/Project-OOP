using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class SinhVien : Person
    {
        private string nganh;
        public string NGANH
        {
            set { nganh = value; }
            get { return nganh; }
        }
        private int namnhaphoc;
        public int NAMNHAPHOC
        {
            set { namnhaphoc = value; }
            get { return namnhaphoc; }
        }
        private List<MonHoc> listmhsv;
        public List<MonHoc> ListmhSV
        {
            set { listmhsv = value; }
            get { return listmhsv; }
        }
        private int drl;
        public int DRL
        {
            set { drl = value; }
            get { return drl; }
        }
        private int dctxh;
        public int DCTXH
        {
            set { dctxh = value; }
            get { return dctxh; }
        }
        // Hàm khởi tạo sinh viên
        public SinhVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string nganh, int namnhaphoc, List<MonHoc> listmhsv)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.nganh = nganh;
            this.namnhaphoc = namnhaphoc;
            this.listmhsv = listmhsv;
        }
        public SinhVien(SinhVien sv)
            : this(sv.MA, sv.TEN, sv.NGSINH, sv.GTINH, sv.DIACHI, sv.SDT, sv.NGANH, sv.NAMNHAPHOC, sv.ListmhSV)
        {

        }
        public SinhVien()
            : base()
        {
            this.nganh = "";
            this.namnhaphoc = 2000;
            this.listmhsv = null;
        }
        ~SinhVien() // Hàm hủy sinh viên
        {
        }
        public override void input() // Hàm nhập sinh viên
        {      
            base.input();
            Console.Write("Nganh hoc: ");
            NGANH = Convert.ToString(Console.ReadLine());
            Console.Write("Nam nhap hoc: ");
            NAMNHAPHOC = Convert.ToInt32(Console.ReadLine());
        }
        public override void print() // Hàm xuất sinh viên
        {
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                                 MA, TEN, NGSINH, GTINH, DIACHI, SDT, NGANH, NAMNHAPHOC);
        }
        // Ham dang ki mon hoc 
        public static void DKiMonHoc()
        {
            SinhVien sv;
            MonHoc mh;
            string ma;
            do
            {
                Console.Write("Nhap Ma Sinh Vien muon dang ki mon hoc: ");
                ma = Console.ReadLine();
                sv = DSSinhVien.checkSV(ma);
                if (sv == null)
                {
                    Console.WriteLine("Khong co Sinh Vien nay!");
                    Console.WriteLine("Vui long nhap lai Ma Sinh Vien!!!");
                }
            } while (sv == null);

            do
            {
                Console.Write("Nhap Ma Mon Hoc muon dang ki: ");
                ma = Convert.ToString(Console.ReadLine());
                mh = DSMonHoc.checkmh(ma);
                if (!DSMonHoc.checkMHSV(ma, sv))
                {
                    Console.WriteLine("Mon hoc nay da duoc dang ki!");
                    Console.WriteLine("Vui long nhap lai Ma Mon hoc moi !!!");
                }
            }while(!DSMonHoc.checkMHSV(ma, sv));

            Console.WriteLine("{0, -7} {1, -20} {2,-10} {3,-15} {4, -7} {5, -20} {6, -15}",
                  "Ma MH", "Ten MH","So TC","Loai mon", "MaGV", "TenGV", "Chuyen Nganh");
            int d = 0;
            foreach (GiangVien gv1 in DSGiangVien.listgv)
            {
                foreach (MonHoc mh1 in gv1.Listmh1)
                {
                    if (String.Compare(mh1.Mamh, ma, false) == 0)
                    {
                        d = 1;
                        Console.WriteLine("{0, -7} {1, -20} {2,-10} {3,-15} {4, -7} {5, -20} {6, -15}",
                                  mh1.Mamh, mh1.TenMH, mh1.SoTC, mh1.LoaiMon, gv1.MA, gv1.TEN, gv1.CHNGANG);
                    }
                }
            }
            if(d == 0)
            {
               Console.WriteLine("Dang ki Mon Hoc khong thanh cong!!!");
               return; 
            }
            Console.Write("Nhap Ma Giang Vien: ");
            ma = Convert.ToString(Console.ReadLine());
            foreach (GiangVien gv in DSGiangVien.listgv)
            {
                if (String.Compare(gv.MA, ma, false) == 0)
                {
                    sv.ListmhSV.Add(mh);
                    Console.WriteLine("Dang ki Mon Hoc thanh cong!!!");
                }
            }
        }
    }
}