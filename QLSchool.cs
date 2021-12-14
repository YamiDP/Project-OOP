using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{       
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
            DSGiangVien.base_listGV();
            DSGiangVien.printGV();
            for(int i =0 ; i <2; i++)
            {
                GiangVien.dkimoplop();
            }
            DSMonHoc.printMHGVDKiML(DSGiangVien.listgv[0]);
            Console.Write(DSGiangVien.listgv[0].Listmh1.Count);
        }
    }
}
