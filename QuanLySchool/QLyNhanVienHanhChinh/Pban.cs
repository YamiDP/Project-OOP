using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLyNhanVienHanhChinh
{
    class Pban
    {
        private string mapb;
        private string tenpb;
        List<NhanVien> listnv1;
        public string MAPB
        {
            set { mapb = value; }
            get { return mapb; }
        }
        public string TENPB
        {
            set { tenpb = value; }
            get { return tenpb; }
        }
        public List<NhanVien> Listnv1
        {
            set { listnv1 = value; }
            get { return listnv1; }
        }

        public Pban(string mapb, string tenpb, List<NhanVien> listnv2)
        {
            this.mapb = mapb;
            this.tenpb = tenpb;
            this.listnv1 = listnv2;
        }
        public Pban(Pban phongban)
            : this(phongban.MAPB, phongban.TENPB, phongban.Listnv1)
        {
        }
        public Pban()
        {
            this.mapb = "";
            this.tenpb = "";
            this.listnv1 = null;
        }
    }
}
