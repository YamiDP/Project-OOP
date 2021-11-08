using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySchool.QLyGiangVien
{
    public class GiangVien : thuoctinhCB
    {
        private string MaKhoa;
        private string ChNganh;
        private string Bomon;
        private string Luong;
        private string Lopday;
        private string Mahocvi; // thạc sĩ, tiến sĩ

        public string MAKHOA
        {
            set { MaKhoa = value; }
            get { return MaKhoa; }
        }
        public string CHNGANG
        {
            set { ChNganh = value; }
            get { return ChNganh; }
        }
        public string BOMON
        {
            set { Bomon = value; }
            get { return Bomon; }
        }
        public string LUONG
        {
            set { Luong = value; }
            get { return Luong; }
        }
        public string LOPDAY
        {
            set { Lopday = value; }
            get { return Lopday; }
        }
        public string MAHOCVI
        {
            set { Mahocvi = value; }
            get { return Mahocvi; }
        }
    }
}
