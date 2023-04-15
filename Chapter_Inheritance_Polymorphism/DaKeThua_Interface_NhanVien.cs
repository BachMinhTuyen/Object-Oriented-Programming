using System;

namespace Example_Interface
{
    internal class Program
    {
        public interface INguoi
        {
            public void hienThiThongTin();
            public double thanhTien();
        }
        public class NhanVien:INguoi
        { 
            private string maNV, tenNV, loaiNV;
            private double heSoLuong, mucLuong;
            public string MaNV { get => maNV; set => maNV = value; }
            public string TenNV { get => tenNV; set => tenNV = value; }
            public string LoaiNV { get => loaiNV; set => loaiNV = value; }
            public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
            public double MucLuong { get => mucLuong; set => mucLuong = value; }
            public NhanVien()
            {
                maNV = string.Empty;
                tenNV = string.Empty;
                loaiNV = string.Empty;
                heSoLuong = 0;
            }
            public NhanVien(string maNV, string  tenNV, string loaiNV, double heSoLuong)
            {
                this.maNV = maNV;
                this.tenNV = tenNV;
                this.loaiNV = loaiNV;
                this.heSoLuong = heSoLuong;
            }
            public double tinhMucLuong()
            {
                //if (loaiNV == "NVHC")
                if (String.Compare(loaiNV, "NVHC") == 0)
                    return 5.0;
                else if (String.Compare(loaiNV, "NVCa") == 0)
                    return 10.0;
                else
                    return 0;
            }
            public double thanhTien()
            {
                mucLuong = tinhMucLuong();
                if (heSoLuong < 3 && heSoLuong > 0)
                    return heSoLuong * mucLuong + 5;
                else
                    return heSoLuong * mucLuong;
            }
            public void hienThiThongTin()
            {
                Console.WriteLine("Ma NV: {0}, Ten NV: {1}, Loai NV: {2}, He so luong: {3}, Thanh Tien: {4}", maNV, tenNV, loaiNV, heSoLuong, thanhTien());
            }
        }
        static void Main(string[] args)
        {
            NhanVien NV1 = new NhanVien();
            NhanVien NV2 = new NhanVien("NV2", "Tran Huu B", "NVCa", 6);
            NV1.hienThiThongTin();
            NV2.hienThiThongTin();
            Console.ReadKey();
        }
    }
}