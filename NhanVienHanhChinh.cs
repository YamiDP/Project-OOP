using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class NhanVienHanhChinh : Person
    {
        private string cviec;
        private string luong;

        public string CVIEC
        {
            set { cviec = value; }
            get { return cviec; }
        }
        public string LUONG
        {
            set { luong = value; }
            get { return luong; }
        }

        public NhanVienHanhChinh(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt,
                                 string cviec, string luong)
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
            this.luong = "";
        }
        ~NhanVienHanhChinh()
        {          
        }
        public override void input()
        {      
            base.input();
            Console.Write("Cong viec: ");
            CVIEC = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToString(Console.ReadLine());
        }
        public override void print()
        {
            Console.WriteLine("{0, -7} {1, -20} {2, -10} {3, -10} {4, -15} {5,-15} {6, -15} {7, -10}",
                                 MA, TEN, NGSINH, GTINH, DIACHI, SDT, CVIEC, LUONG);
        }
          
    }
}
