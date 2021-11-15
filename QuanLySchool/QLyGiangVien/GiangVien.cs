using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyGiangVien
{
    public class GiangVien : thuoctinhCB
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
        public override void xuat()
        {

        }
        public override void sort()
        {

        }
        public override void search()
        {

        }
        public GiangVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string chnganh, string bomon, string luong, string lopday, string hocvi)
            : base (ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.chnganh = chnganh;
            this.bomon = bomon;
            this.luong = luong;
            this.lopday = lopday;
            this.hocvi = hocvi;
        }
        public GiangVien()
        {

        }
    }
}
