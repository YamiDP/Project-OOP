using System;
namespace SchoolManager
{
    public abstract class Person
    {
        private string ma;
        private string ten;
        private string ngsinh;
        private string gtinh;
        private string diachi;
        private string sdt;

        public string MA
        {
            set { ma = value; }
            get { return ma; }
        }
        public string SDT
        {
            set { sdt = value; }
            get { return sdt; }
        }
        public string TEN
        {
            set { ten = value; }
            get { return ten; }
        }
        public string NGSINH
        {
            set { ngsinh = value; }
            get { return ngsinh; }
        }
        public string GTINH
        {
            set { gtinh = value; }
            get { return gtinh; }
        }
        public string DIACHI
        {
            set { diachi = value; }
            get { return diachi; }
        }


        // constractor
        public Person(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt)
        {
            this.ma = ma;
            this.ten = ten;
            this.ngsinh = ngsinh;
            this.gtinh = gtinh;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        public Person(Person ps)
        :this(ps.ma, ps.ten, ps.ngsinh, ps.gtinh, ps.diachi, ps.sdt)
        {

        }
        public Person()
        {
            ma = "";
            ten = "";
            ngsinh = "dd/mm/yyyy";
            gtinh = "unknown";
            diachi = "not given";
            sdt = "0xxxxxxxxxx";
        }
        // các phương thức chung nhằm để tối ưu việc quản lý
        public virtual void input()
        {
            Console.Write("Ten: ");
            TEN = Convert.ToString(Console.ReadLine());
            Console.Write("Ngay Sinh: ");
            NGSINH = Convert.ToString(Console.ReadLine());
            Console.Write("Gioi Tinh: ");
            GTINH = Convert.ToString(Console.ReadLine());
            Console.Write("Dia Chi: ");
            DIACHI = Convert.ToString(Console.ReadLine());
            Console.Write("So dien thoai: ");
            SDT = Convert.ToString(Console.ReadLine());
        }
        public abstract void search();
        public abstract void sort();
        public abstract void print();
    }
}
