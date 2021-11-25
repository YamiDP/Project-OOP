using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLyGiangVien
{
    public class GiangVien : Person
    {
        private string chnganh;
        private string bomon;
        private string luong;
        private string lopday;
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
        public string LOPDAY
        {
            set { lopday = value; }
            get { return lopday; }
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
        public GiangVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string chnganh, string bomon, string luong, string lopday, string hocvi)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.chnganh = chnganh;
            this.bomon = bomon;
            this.luong = luong;
            this.lopday = lopday;
            this.hocvi = hocvi;
        }
        public GiangVien(GiangVien gv) 
            : this(gv.MA, gv.TEN, gv.NGSINH, gv.GTINH, gv.DIACHI, gv.SDT, gv.CHNGANG, gv.BOMON, gv.LUONG, gv.LOPDAY, gv.HOCVI)
        {
        }    
        public GiangVien()
            : base ()
        {
            this.chnganh = "";
            this.bomon = "";
            this.luong = "0";
            this.lopday = "";
            this.hocvi = "";
        }
    }
}
