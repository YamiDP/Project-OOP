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

        public NhanVienHanhChinh(string ma, string ten, string ngsinh, string gtinh, string diachi, string sdt, string cviec, string luong)
            : base(ma, ten, ngsinh, gtinh, diachi, sdt)
        {
            this.cviec = cviec;
            this.luong = luong;
        }
        public NhanVienHanhChinh(NhanVienHanhChinh nhanVien)
            : this(nhanVien.MA, nhanVien.TEN, nhanVien.NGSINH, nhanVien.GTINH, nhanVien.DIACHI, nhanVien.SDT, nhanVien.CVIEC, nhanVien.LUONG)
        {
        }
        public NhanVienHanhChinh()
            : base()
        {
            this.cviec = "";
            this.luong = "";
        }
        public static List<NhanVienHanhChinh> listnv = new List<NhanVienHanhChinh>();
        public static NhanVienHanhChinh checkNV(string MaNV)
        {
            foreach (NhanVienHanhChinh nv in listnv)
            {
                if (String.Compare(nv.MA, MaNV, false) == 0)
                    return nv;
            }
            return null;
        }
        public void inputNV(PhongBan pb)
        {
            NhanVienHanhChinh nv;
            do
            {
                Console.Write("Ma Nhan Vien: ");
                MA = Convert.ToString(Console.ReadLine());
                nv = checkNV(MA);
                if (nv != null)
                {
                    Console.WriteLine("Ma Nhan Vien da ton tai!");
                    Console.WriteLine("Vui long nhap lai!!!");
                }
            } while (nv != null);
            base.input();
            Console.Write("Cong viec: ");
            CVIEC = Convert.ToString(Console.ReadLine());
            Console.Write("Luong: ");
            LUONG = Convert.ToString(Console.ReadLine());
            nv = new NhanVienHanhChinh(MA, TEN, NGSINH, GTINH, DIACHI, SDT, CVIEC, LUONG);
            listnv.Add(nv);
            pb.Listnv1.Add(nv);
            Console.WriteLine("Them Nhan Vien thanh cong!");
        }
        public static void deleteNV(PhongBan p)
        {
            NhanVienHanhChinh k;
            Console.Write("Nhap Ma Nhan Vien: ");
            string MaNV = Console.ReadLine();
            k = checkNV(MaNV);
            if (k == null)
            {
                Console.WriteLine("Khong tim thay Nhan Vien!");
            }
            else
            {
                listnv.Remove(k);
                p.Listnv1.Remove(k);
            }
            Console.WriteLine("Da xoa thanh cong!");
        }
        public override void print()
        {
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Nhan Vien nao trong Phong Ban!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -10}",
                  "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "Cong Viec", "Luong");
            foreach (NhanVienHanhChinh nv in listnv)
            {
                Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -15} {6, -10}",
                                  nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI, nv.CVIEC, nv.LUONG);
            }
            Console.WriteLine();
        }
        public static bool compareRise(NhanVienHanhChinh nv1, NhanVienHanhChinh nv2)
        {
            if (String.Compare(nv1.TEN, nv2.TEN, false) > 0)
                return false;
            return true;
        }
        public override void sort()
        {
            if (listnv.Count == 0)
            {
                Console.WriteLine("Danh sach rong!");
            }
            else
            {
                NhanVienHanhChinh nv;
                for (int i = 0; i < listnv.Count - 1; i++)
                    for (int j = i + 1; j < listnv.Count; j++)
                        if (!compareRise(listnv[i], listnv[j]))
                        {
                            nv = listnv[i];
                            listnv[i] = listnv[j];
                            listnv[j] = nv;
                        }
            }
        } 
        public override void search()
        {
            Console.Write("Nhap Ma Giang Vien: ");
            string MaNV = Console.ReadLine();
            if (listnv.Count == 0)
            {
                Console.WriteLine("Khong co Giang Vien!");
                return;
            }
            Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -10}",
              "MaNV", "TenNV", "Ngay Sinh", "Gioi Tinh", "Dia Chi", "So Dien Thoai", "Cong Viec", "Luong");
            foreach (NhanVienHanhChinh nv in listnv)
            {
                if (String.Compare(nv.MA, MaNV, false) == 0)
                {
                    Console.WriteLine("{0, -7} {1, -20} {2, -15} {3, -15} {4, -15} {5, -20} {6, -15} {7, -10}",
                                  nv.MA, nv.TEN, nv.NGSINH, nv.GTINH, nv.DIACHI, nv.SDT, nv.CVIEC, nv.LUONG);
                }
            }
        }
        public static int slNV_pb(PhongBan p)
        {
            return p.Listnv1.Count;
        }
        public static int slNV()
        {
            return listnv.Count;
        }  
    }
}
/* namespace SchoolManager.QLNhanVienHanhChinh
{
    public class managerNhanVien : NhanVien
    {

        public delegate bool DelSort(NhanVien nv1, NhanVien nv2);
        
    
    }
}
 */