using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyNhanVienHanhChinh
{
    public class NhanVien : thuoctinhCB
    {
        private string Pban;
        private string Cviec;
        private string Luong;

        public string PBAN
        {
            set { Pban = value; }
            get { return Pban; }
        }
        public string CVIEC
        {
            set { Cviec = value; }
            get { return Cviec; }
        }
        public string LUONG
        {
            set { Luong = value; }
            get { return Luong; }
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
    }
}
