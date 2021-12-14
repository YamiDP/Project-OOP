using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class PhongBan
    {
        private string mapb;
        private string tenpb;
        List<NhanVienHanhChinh> listnv1;
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
        public List<NhanVienHanhChinh> Listnv1
        {
            set { listnv1 = value; }
            get { return listnv1; }
        }
        // cac ham khoi tao
        public PhongBan(string mapb, string tenpb, List<NhanVienHanhChinh> listnv2)
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
        ~PhongBan() //ham huy
        {
        }
        //ham nhap thong tin 1 phong ban
        public void inputPB()
        {
            Console.Write("Ma Phong Ban: ");
            MAPB = Convert.ToString(Console.ReadLine());
            Console.Write("Ten Phong Ban: ");
            TENPB = Convert.ToString(Console.ReadLine());
        }
        //ham in thong tin 1 phong ban
        public void printPB()
        {
                Console.WriteLine("{0, -7} {1, -25}",
                                  MAPB, TENPB);
        }
    }
}
