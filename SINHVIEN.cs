using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class SinhVien : Person
    {
        private string nganh;
        public string NGANH
        {
            set { nganh = value; }
            get { return nganh; }

        }
        private int namnhaphoc;
        public int NAMNHAPHOC
        {
            set { namnhaphoc = value; }
            get { return namnhaphoc; }

        }
        /*List<MonHoc> listmhsv;
        public List<MonHoc> ListmhSV
        {
            set { listmhsv = value; }
            get { return listmhsv; }
        } */
        struct DIEM
        {

        }
        struct TKB
        {

        }
        public int DRl { get; set; }
        public int DCTXH { get; set; }
        public void DANGKIHOC()
        {
            throw new NotImplementedException();
        }
        public void DANGKIDOAN()
        {
            throw new NotImplementedException();
        }
        public void TTHOCPHI()
        {
            throw new NotImplementedException();
        }
        // Hàm khởi tạo sinh viên
        public SinhVien(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string nganh, int namnhaphoc)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.nganh = nganh;
            this.namnhaphoc = namnhaphoc;
            //this.listmhsv = listmhsv;
        }
        public SinhVien(SinhVien sv)
            : this(sv.MA, sv.TEN, sv.NGSINH, sv.GTINH, sv.DIACHI, sv.SDT, sv.NGANH, sv.NAMNHAPHOC)
        {

        }
        public SinhVien()
            : base()
        {
            this.nganh = "";
            this.namnhaphoc = 2000;
            //this.listmhsv = null;
        }
        ~SinhVien() // Hàm hủy sinh viên
        {

        }
        public void addSV() // Hàm nhập sinh viên
        {      
            base.input();
            Console.Write("Nganh hoc: ");
            NGANH = Convert.ToString(Console.ReadLine());
            Console.Write("Nam nhap hoc: ");
            NAMNHAPHOC = Convert.ToInt32(Console.ReadLine());
        }
        public void printSV() // Hàm xuất sinh viên
        {
            print();
            Console.WriteLine("{0, -15} {1, -15}",
                                  NGANH, NAMNHAPHOC);
        }
    }
}