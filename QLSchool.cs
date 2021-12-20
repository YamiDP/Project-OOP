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
            // phat su kien in ra danh sach
            print?.Invoke();
        }
    }
    public class QLSchool
    {   
        static void Main(string[] args)
        {
            // tạo dữ liệu cho danh sách sinh viên
            DSSinhVien.base_list();
            // tạo dữ liệu cho danh sách giảng viên
            DSGiangVien.base_listGV();
            // in danh sách sinh viên
            Console.WriteLine("\t\t-------------DANH SACH SINH VIEN---------------");
            DSSinhVien.printSV();
            // thực hiện 1 số phương thức cơ bản trên 1 đối tượng
            // Sắp xếp danh sách sinh viên tăng dần theo tên học sinh
            Console.WriteLine("\t\t---------DANH SACH SINH VIEN TANG DAN THEO TEN-----------");
            DSSinhVien.sort();
            Console.WriteLine();
            // Tìm kiếm 1 sinh viên có trong danh sách sinh viên
            Console.WriteLine("Tim kiem mot sinh viên");
            DSSinhVien.searchSV();
            Console.WriteLine();
            // Xóa 1 sinh viên ra khỏi danh sách sinh viên
            Console.WriteLine("Xoa mot sinh viên");
            DSSinhVien.deleteSV();
            Console.WriteLine();
            // Số lượng sinh viên còn trong danh sách
            Console.Write("So luong sinh vien con trong danh sach: ");
            Console.WriteLine(DSSinhVien.slSV());
            Console.WriteLine();
            //ứng dụng delegate và event để in DSGV và DSSV
            DSGiangVien gv = new DSGiangVien();
            DSSinhVien sv = new DSSinhVien();
            DS ds = new DS();
            gv.EventprintGV(ds); // đki in danh sách giảng viên từ ds 
            sv.EventprintSV(ds); // đki in danh sách sinh viên từ ds
            Console.WriteLine("----------DANH SACH SINH VIEN VA DANH SACH GIANG VIEN----------");
            ds.printDS();

            // tạo dữ liệu cho danh sách môn học
            DSMonHoc.base_list();
            // in danh sách môn học
            Console.WriteLine("\t---------DANH SACH MON HOC----------");
            DSMonHoc.printDSMH();

            Console.Write("So lan dang ki mo lop cua 1 giang vien: ");
            int t = Convert.ToInt32(Console.ReadLine());
            for(int i =0 ; i <t; i++)
            {
                //Giảng viên đăng kí mở lớp
                //Nhập mã giảng viên đầu danh sách
                GiangVien.dkimoplop();
            }
            // in thông tin môn học của giảng viên đã đăng kí
            Console.WriteLine();
            Console.WriteLine("Thong tin cac mon hoc");
            DSMonHoc.printMHGVDKiML(DSGiangVien.listgv[0]);

            //sinh viên thực hiện dang ki mon hoc
            //Nhập mã sinh viên đầu danh sách
            Console.WriteLine();
            SinhVien.DKiMonHoc();

            // in thông tin môn học sinh viên vừa đăng kí
            Console.WriteLine();
            Console.WriteLine("Thong tin cac mon hoc");
            DSMonHoc.printMHSVdki(DSSinhVien.listsv[0]);
        }
    }
}
