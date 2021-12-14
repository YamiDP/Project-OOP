using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    public class BangDiem
    {
        private int stt;
        public int STT
        {
            set { STT = value; }
            get { return STT; }
        }
        private string mahocphan;
        public string MAHOCPHAN
        {
            set { mahocphan = value; }
            get { return mahocphan; }
        }
        private string tenhocphan;
        public string TENHOCPHAN
        {
            set { tenhocphan = value; }
            get { return tenhocphan; }
        }
        private int tinchi;
        public int TINCHI
        {
            set { tinchi = value; }
            get { return tinchi; }
        }
        private string loaimon;
        public string LOAIMON
        {
            set { loaimon = value; }
            get { return loaimon; }
        }
        private int diem;
        public int DIEM
        {
            set { diem = value; }
            get { return diem; }
        }
        private string diemchu;
        public string DIEMCHU
        {
            set { diemchu = value; }
            get { return diemchu; }
        }
        private string ketqua;
        public string KETQUA
        {
            set { ketqua = value; }
            get { return ketqua; }
        }
        // Hàm khởi tạo bảng điểm
        public BangDiem(int stt, string mahocphan, string tenhocphan, int tinchi, string loaimon, int diem, string diemchu, string ketqua)
        {
            
        }
        public BangDiem()
            : base()
        {
            this.stt = 1;
            this.mahocphan = "";
            this.tenhocphan = "";
            this.tinchi = 3;
            this.loaimon = "";
            this.diem = 9;
            this.diemchu = "A";
            this.ketqua = "Qua môn";
        }
        ~BangDiem() // Hàm hủy bảng điểm
        {
        }
        public void input() // Hàm nhập bảng điểm
        {
            Console.Write("Số thứ tự: ");
            STT = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mã học phần: ");
            MAHOCPHAN = Convert.ToString(Console.ReadLine());
            Console.Write("Tên học phần: ");
            TENHOCPHAN = Convert.ToString(Console.ReadLine());  
            Console.Write("Số tín chỉ: ");
            TINCHI = Convert.ToInt32(Console.ReadLine());
            Console.Write("Loại môn: ");
            LOAIMON = Convert.ToString(Console.ReadLine());
            Console.Write("Điểm: ");
            DIEM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Điểm chữ: ");
            DIEMCHU = Convert.ToString(Console.ReadLine());
            Console.Write("Kết quả: ");
            KETQUA = Convert.ToString(Console.ReadLine());
        }
        public void print() // Hàm xuất bảng điểm
        {
            Console.WriteLine("{0, -7} {1, -10} {2, -10} {3, -10} {4, -10} {5, -15} {6, -10} {7, -10}",
                                STT, MAHOCPHAN, TENHOCPHAN, TINCHI, LOAIMON, DIEM, DIEMCHU, KETQUA);
        }
    }
}