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
        public void addNVHC()
        {      
            base.input();
            Console.Write("Cong viec: ");
            CVIEC = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToString(Console.ReadLine());
        }
        public void priNVHC()
        {
            print();
            Console.WriteLine("{0, -15} {1, -10}",
                                  CVIEC, LUONG);
        }
          
    }
}
