﻿using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.QLGiangVien;
namespace SchoolManager.QLKhoa
{
    public class KHOA
    {
        private string makhoa;
        private string tenkhoa;
        List<GiangVien> listgv1;
        public string MAKHOA
        {
            set { makhoa = value; }
            get { return makhoa; }
        }
        public string TENKHOA
        {
            set { tenkhoa = value; }
            get { return tenkhoa; }
        }
        internal List<GiangVien> Listgv1
        {
            set { listgv1 = value; }
            get { return listgv1; }
        }

        public KHOA(string makhoa, string tenkhoa, List<GiangVien> listgv1)
        {
            this.makhoa = makhoa;
            this.tenkhoa = tenkhoa;
            this.listgv1 = listgv1;
        }
        public KHOA(KHOA khoa)
            : this(khoa.MAKHOA, khoa.TENKHOA, khoa.Listgv1)
        {
        }
        public KHOA()
        {
            this.makhoa = "";
            this.tenkhoa = "";
            this.listgv1 = null;
        }
    }
}
