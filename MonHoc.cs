using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class MonHoc
    {
        private string mamh;
        private string tenmh;
        private int sotc;
        private string loaimon; // thực hành hay lý thuyết
        
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
        // cac ham khoi tao
        public MonHoc()
        {      
            this.mamh = "MHxx";
            this.tenmh = "Unknown";
            this.sotc = 0;
            this.loaimon = "Unknown";
        }
        public MonHoc(string mamh, string tenmh, int sotc, string loaimon)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.sotc = sotc;
            this.loaimon = loaimon;
        }
        public MonHoc(MonHoc mh)
            : this (mh.mamh,mh.tenmh, mh.sotc, mh.loaimon)
        {

        }
        //ham huy
        ~MonHoc()
        {
                
        }
        //ham nhap mot mon hoc
        public void inputMH()
        {
            Console.Write("Nhap ma mon hoc: ");
            Mamh = Convert.ToString(Console.ReadLine());
            Console.Write("Ten mon hoc: ");
            TenMH = Convert.ToString(Console.ReadLine());
            Console.Write("So tin chi: ");
            SoTC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Loai mon : ");
            LoaiMon = Convert.ToString(Console.ReadLine());
        }
        //ham in mot mon hoc
        public void print()
        {
                Console.WriteLine("{0, -7} {1, -20} {2,-10}{3,-15}",
                                  this.Mamh, this.TenMH, this.SoTC, this.LoaiMon);
        }
    }
} 

