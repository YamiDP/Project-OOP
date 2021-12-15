using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class GiangVien : Person
    {
        private string chnganh;
        private int luong;
        private string hocvi;
        private List<MonHoc> listmh1;

        public string CHNGANG
        {
            set { chnganh = value; }
            get { return chnganh; }
        }
        public int LUONG
        {
            set { luong = value; }
            get { return luong; }
        }
        public string HOCVI
        {
            set { hocvi = value; }
            get { return hocvi; }
        }
        public List<MonHoc> Listmh1
        {
            set { listmh1 = value; }
            get { return listmh1; }
        }
        // cac ham khoi tao
        public GiangVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, 
                            string chnganh, int luong, string hocvi, List<MonHoc> listmh1)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.chnganh = chnganh;
            this.luong = luong;
            this.hocvi = hocvi;
            this.listmh1 = listmh1;
        }
        public GiangVien(GiangVien gv) 
            : this(gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.LUONG, gv.HOCVI, gv.Listmh1)
        {
        }    
        public GiangVien()
            : base ()
        {
            this.chnganh = "";
            this.luong = 0;
            this.hocvi = "";
            this.listmh1 = null;
        }
        ~GiangVien() // ham huy
        {    
        }
        //ham nhap thong tin cua 1 giang vien
        public override void input()
        {      
            base.input();
            Console.Write("Chuyen nganh: ");
            CHNGANG = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hoc vi: ");
            HOCVI = Convert.ToString(Console.ReadLine());
        }
        //ham in thong tin cua 1 giang vien
        public override void print()
        {
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -15} {8, -15}",
                                 MA, TEN, NGSINH, GTINH, DIACHI, SDT, CHNGANG, LUONG, HOCVI);
        }
        // ham dki mo lop cua giang vien
        public static void dkimoplop()
        {
            GiangVien gv;
            MonHoc mh;
            string ma;
            do
            {
                Console.Write("Nhap Ma Giang Vien: ");
                ma = Convert.ToString(Console.ReadLine());
                gv = DSGiangVien.checkGV(ma);
                if (gv == null)
                {
                    Console.WriteLine("Khong co Giang Vien nay!");
                    Console.WriteLine("Vui long nhap lai Ma Giang Vien!!!");
                }
            }while(gv == null);
            
            do
            {
                Console.Write("Nhap Ma Mon Hoc muon dang ki mo lop: ");
                ma = Convert.ToString(Console.ReadLine());
                mh = DSMonHoc.checkmh(ma);
                if (!DSMonHoc.checkMHGV(ma, gv))
                {
                    Console.WriteLine("Giang Vien da dang ki mon hoc nay!");
                    Console.WriteLine("Vui long nhap lai Ma Mon hoc moi!!!");
                }
            }while(!DSMonHoc.checkMHGV(ma, gv));
            gv.Listmh1.Add(mh);
            Console.WriteLine("Dang ki mo lop thanh cong!!!");
        }
    }
}


           