using System;

namespace Example_Interface
{
    internal class Program
    {
        public interface ITraoDoi
        {
            public void hienThiThongTin();
            public double thanhTien();
        }
        public class ChiTietTraoDoi:ITraoDoi
        {
            private string maSP, tenSP;
            private int loaiSP, soLuong;
            private double donGia;
            public string MaSP { get => maSP; set => maSP = value; }
            public string TenSP { get => tenSP; set => tenSP = value; }
            public int LoaiSP { get => loaiSP; set => loaiSP = value; }
            public int SoLuong { get => soLuong; set => soLuong = value; }
            public double DonGia { get => donGia; set => donGia = value; }
            public ChiTietTraoDoi()
            {
                maSP = "SP01";
                tenSP = "Noi Com Dien";
                loaiSP = 1;
                soLuong = 2;
                donGia = 1200000;
            }
            public ChiTietTraoDoi(string maSP, string tenSP, int loaiSP, int soLuong, double donGia)
            {
                this.maSP = maSP;
                this.tenSP = tenSP;
                this.loaiSP = loaiSP;   
                this.soLuong = soLuong;
                this.donGia = donGia;
            }
            public double thanhTien()
            {
                if (loaiSP == 1)
                    donGia = 50000;
                else if (loaiSP == 2)
                    donGia = 100000;
                else
                    donGia = 0;
                return donGia * soLuong;
            }
            public void hienThiThongTin()
            {
                Console.WriteLine("Ma SP: {0}, Ten SP: {1}, Loai SP: {2}, So luong: {3}, Don gia: {4}, Thanh tien: {5}", maSP, tenSP, loaiSP, soLuong, donGia, thanhTien());
            }
        }
        static void Main(string[] args)
        {
            ChiTietTraoDoi GD1 = new ChiTietTraoDoi();
            ChiTietTraoDoi GD2 = new ChiTietTraoDoi("SP02", "Bep Ga", 1, 1, 750000);
            GD1.hienThiThongTin();
            GD2.hienThiThongTin();
            Console.ReadLine();
        }
    }
}