using System;
using System.Collections.Generic;
using System.Text;
namespace SchoolManager
{
    public class ThoiKhoaBieu
    {
        private int namhoc;
        private string hocky;
        private int tuan;
        private string diachiphonghoc;
        private MonHoc thongtinmonhoc;
        public int Namhoc
        {
            set { namhoc = value; }
            get { return namhoc; }
        }
        public string Hocky
        {
            set { hocky = value; }
            get { return hocky; }
        }
        public int Tuan
        {
            set { tuan = value; }
            get { return tuan; }
        }
        public string Diachiphonghoc
        {
            set { diachiphonghoc = value; }
            get { return diachiphonghoc; }
        }
        public MonHoc Thongtinmonhoc
        {
            set { thongtinmonhoc = value; }
            get { return thongtinmonhoc; }
        }
        public ThoiKhoaBieu()
        {
            this.namhoc = 2021;
            this.hocky = "I";
            this.tuan = 0;
            this.diachiphonghoc = "Unknown";
            this.thongtinmonhoc = null;
        }
        public ThoiKhoaBieu(int namhoc, string hocky, int tuan, string diachiphonghoc, MonHoc thongtinmonhoc)
        {
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.tuan = tuan;
            this.diachiphonghoc = diachiphonghoc;
            this.thongtinmonhoc = thongtinmonhoc;
        }
        public ThoiKhoaBieu(ThoiKhoaBieu tkb) : this(tkb.namhoc, tkb.hocky, tkb.tuan, tkb.diachiphonghoc, tkb.thongtinmonhoc)
        {

        }
        ~ThoiKhoaBieu()
        {
            
        }
    }       
}