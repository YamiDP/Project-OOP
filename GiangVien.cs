using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
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
        public GiangVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, 
                            string chnganh, string bomon, string luong, string hocvi)
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
            this.luong = "";
            this.hocvi = "";
        }
        public void addGV()
        {      
            base.input();
            Console.Write("Chuyen nganh: ");
            CHNGANG = Convert.ToString(Console.ReadLine());
            Console.Write("Bo mon: ");
            BOMON = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToString(Console.ReadLine());
            Console.Write("Hoc vi: ");
            HOCVI = Convert.ToString(Console.ReadLine());
        }
        public void priGV()
        {
            print();
            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -10}",
                                  CHNGANG, BOMON, LUONG, HOCVI);
        }

    }
}


           