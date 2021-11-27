using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager;
namespace SchoolManager.QLKhoahoc
{
    public class KhoaHoc{
        private int nambatdau;
        private int namdukienkt;
        public int NAMBATDAU
        {
            set { nambatdau = value; }
            get { return nambatdau; }
        }
        public int NAMDUKIENKT
        {
            set { namdukienkt = value; }
            get { return namdukienkt; }
        }
        public KhoaHoc(int nambatdau, int namdukienkt)
        {
            this.nambatdau = nambatdau;
            this.namdukienkt = namdukienkt;
        }
        public KhoaHoc(KhoaHoc kh) 
            : this(kh.nambatdau, kh.namdukienkt)
        {
        }    
        public KhoaHoc()
            : base ()
        {
            this.nambatdau = 2000;
            this.namdukienkt = 2004;
        }
    }
}