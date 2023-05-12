using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class NhanVien
    {
        string maNV, tenNV;
        int soNgayCong;
        char xepLoai;
        public static int luongNgay = 200000;
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int SoNgayCong
        {
            get { return soNgayCong; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Dữ Liệu Bị Lỗi !!!");
                else
                    soNgayCong = value;
            }
        }
        public char XepLoai
        {
            get
            {
                if (soNgayCong > 26)
                    return 'A';
                else if (soNgayCong == 26 && soNgayCong >= 22)
                    return 'B';
                else
                    return 'C';
            }
        }
        public NhanVien()
        {
            maNV = string.Empty;
            tenNV = string.Empty;
            SoNgayCong = 0;
        }
        public NhanVien(string maNV, string tenNV, int soNgayCong)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.soNgayCong = soNgayCong;
        }
        public NhanVien(NhanVien a) // khởi tạo sao chép
        {
            this.maNV = a.maNV;
            this.tenNV = a.tenNV;
            this.soNgayCong = a.soNgayCong;
        }
        // Hàm huỷ
        ~NhanVien() { }
        public void nhapThongTin()
        {
            Console.Write("Nhập mã NV: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhập họ tên NV: ");
            TenNV = Console.ReadLine();
            Console.Write("Nhập số ngày công: ");
            SoNgayCong = int.Parse(Console.ReadLine());
        }
        public void xuatThongTin()
        {
            Console.WriteLine("Mã NV: {0}, Tên NV: {1}, Số ngày công: {2}, Xếp loại: {3}, Luong: {4}", maNV, tenNV, soNgayCong, XepLoai, tinhLuong());
        }
        public int tinhLuong()
        {
            return soNgayCong * luongNgay;
        }
        public float tinhThuong()
        {
            if (XepLoai == 'A')
                return tinhLuong() * 5 / 100;
            else if (XepLoai == 'B')
                return tinhLuong() * 2 / 100;
            else
                return 0;
        }
    }
}
