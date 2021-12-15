using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{   
    public delegate void printDel();
    public class DS
    {
        public event printDel print;
        public void printDS() 
        {
            print?.Invoke();
        }
    }
    public class QLSchool
    {   
        static void Main(string[] args)
        {
            //DSHocSinh.base_list();
            //DSHocSinh.printHS();
            //DSHocSinh.sort_MA();
            //DSHocSinh.sort_name();
            DSMonHoc.base_list();
            DSMonHoc.printDSMH();
            DSSinhVien.base_list();
            DSSinhVien.printSV();
            DSGiangVien.base_listGV();
            DSGiangVien.printGV();
            for(int i =0 ; i <2; i++)
            {
                GiangVien.dkimoplop();
            }
            DSMonHoc.printMHGVDKiML(DSGiangVien.listgv[0]);

            SinhVien.DKiMonHoc();

            Console.WriteLine("Sau khi sinh vien dang ki thi se khong con");
            DSMonHoc.printMHGVDKiML(DSGiangVien.listgv[0]);
            //ứng dụng delegate và event để in DSGV và DSSV
            DSGiangVien gv = new DSGiangVien();
            DSSinhVien sv = new DSSinhVien();
            DS ds = new DS();
            gv.EventprintGV(ds);
            sv.EventprintSV(ds);
            ds.printDS();
        }
    }
}
