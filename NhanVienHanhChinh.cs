using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class NhanVienHanhChinh : Person
    {
        private string cviec;
        private int luong;

        public string CVIEC
        {
            set { cviec = value; }
            get { return cviec; }
        }
        public int LUONG
        {
            set { luong = value; }
            get { return luong; }
        }
        // cac ham khoi tao
        public NhanVienHanhChinh(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt,
                                 string cviec, int luong)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.cviec = cviec;
            this.luong = luong;
        }
        public NhanVienHanhChinh(NhanVienHanhChinh nhanVien)
            : this(nhanVien.MA, nhanVien.TEN, nhanVien.NGSINH, nhanVien.GTINH, nhanVien.DIACHI, nhanVien.SDT, 
                    nhanVien.CVIEC, nhanVien.LUONG)
        {
        }
        public NhanVienHanhChinh()
            : base()
        {
            this.cviec = "";
            this.luong = 0;
        }
        ~NhanVienHanhChinh() // ham huy
        {          
        }
        // nhap thong tin cua 1 nhan vien hanh chinh
        public override void input()
        {      
            base.input();
            Console.Write("Cong viec: ");
            CVIEC = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToInt32(Console.ReadLine());
        }
        // in thong tin cua 1 nhan vien hanh chinh
        public override void print()
        {
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -25} {7, -10}",
                                 MA, TEN, NGSINH, GTINH, DIACHI, SDT, CVIEC, LUONG);
        }
          
    }
}
