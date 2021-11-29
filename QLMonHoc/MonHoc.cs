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
