using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyNhanVienHanhChinh
{
    class Pban
    {
        private string MaPb;
        private string TenPb;
        List<NhanVien> listgv2 = new List<NhanVien>();
        public string MAPB
        {
            set { MaPb = value; }
            get { return MaPb; }
        }
        public string TENPB
        {
            set { TenPb = value; }
            get { return TenPb; }
        }
        internal List<NhanVien> Listgv2
        {
            set { listgv2 = value; }
            get { return listgv2; }
        }
    }
}
