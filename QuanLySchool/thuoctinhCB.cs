using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool
{
    public class thuoctinhCB
    {
        private string MaGV;
        private string TenGV;
        private string NgSinh;
        private string GTinh;
        private string DiaChi;

        public string MAGV
        {
            set { MaGV = value; }
            get { return MaGV; }
        }
        public string TENGV
        {
            set { TenGV = value; }
            get { return TenGV; }
        }
        public string NGSINH
        {
            set { NgSinh = value; }
            get { return NgSinh; }
        }
        public string GTINH
        {
            set { GTinh = value; }
            get { return GTinh; }
        }
        public string DIACHI
        {
            set { DiaChi = value; }
            get { return DiaChi; }
        }

        /*public thuoctinhCB(string maGV, string tenGV, string ngSinh, string gTinh, string diaChi)
        {
            MaGV = maGV;
            TenGV = tenGV;
            NgSinh = ngSinh;
            GTinh = gTinh;
            DiaChi = diaChi;
        }
        public thuoctinhCB()
        { }*/
    }
}
