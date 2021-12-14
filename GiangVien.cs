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
        // cac ham khoi tao
        public GiangVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, 
                            string chnganh, int luong, string hocvi)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.chnganh = chnganh;
            this.luong = luong;
            this.hocvi = hocvi;
        }
        public GiangVien(GiangVien gv) 
            : this(gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.LUONG, gv.HOCVI)
        {
        }    
        public GiangVien()
            : base ()
        {
            this.chnganh = "";
            this.luong = 0;
            this.hocvi = "";
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
    }
}


           