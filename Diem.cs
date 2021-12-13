using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class Diem
    {
        private int diemqtr1;
        public int DIEMQTR1
        {
            set { diemqtr1 = value; }
            get { return diemqtr1; }
        }
        private int diemqtr2;
        public int DIEMQTR2
        {
            set { diemqtr2 = value; }
            get { return diemqtr2; }
        }
        private int diemthi;
        public int DIEMTHI
        {
            set { diemthi = value; }
            get { return diemthi; }
        }
        // Hàm khởi tạo điểm
        public Diem()
            : base()
        {

        }
        ~Diem() // Hàm hủy điểm
        {
        }
        public void input() // Hàm nhập điểm
        {      
            Console.Write("Diem Qua Trinh 1: ");
            DIEMQTR1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diem Qua Trinh 2: ");
            DIEMQTR2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Diem Thi: ");
            DIEMTHI = Convert.ToInt32(Console.ReadLine());
        }
        public void print() // Hàm xuất điểm
        {
            Console.WriteLine("{0, -7} {1, -10} {2, -10}",
                                DIEMQTR1, DIEMQTR2, DIEMTHI);
        }
    }
}