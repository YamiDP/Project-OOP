using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager.QLNhanVienHanhChinh
{
    public class PhongBan
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

        public PhongBan(string mapb, string tenpb, List<NhanVien> listnv2)
        {
            this.mapb = mapb;
            this.tenpb = tenpb;
            this.listnv1 = listnv2;
        }
        public PhongBan(PhongBan phongban)
            : this(phongban.MAPB, phongban.TENPB, phongban.Listnv1)
        {
        }
        public PhongBan()
        {
            this.mapb = "";
            this.tenpb = "";
            this.listnv1 = null;
        }
    }
}
