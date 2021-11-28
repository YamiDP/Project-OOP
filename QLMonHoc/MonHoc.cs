using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLMonHoc
{
    public class MonHoc
    {
        private int stt;
        private string mamh;
        private string tenmh;
        private int soTC;
        private int solop;
        private int gioihan;
        
        public int STT
        {
            set{ stt = value;}
            get{return stt;}
        }
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
            set{soTC = value;}
            get{return soTC;}
        }
        public int SoLop
        {
            set{solop = value;}
            get{return solop;}
        }
        public int GioiHan
        {
            set{ gioihan = value;}
            get{return gioihan;}
        }
        public MonHoc()
        {

        }
        public MonHoc(int stt, string mamh, string tenmh, int soTC, int solop, int gioihan)
        {
            this.stt = stt;
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.soTC = soTC;
            this.solop = solop;
            this.gioihan = gioihan;
        }
        public MonHoc(MonHoc mh)
        {
            this.stt = mh.stt;
            this.mamh = mh.mamh;
            this.tenmh = mh.tenmh;
            this.soTC = mh.soTC;
            this.solop = mh.solop;
            this.gioihan = mh.gioihan;
        }
    }
}
