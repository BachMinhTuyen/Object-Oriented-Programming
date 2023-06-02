using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Warehouse_Exercise
{
    public class SanPham
    {
        private string maSP;
        private string tenSP;
        private int namSX;
        private float donGia;
        private char loaiSP;

        public string MaSP
        {
            get { return maSP; }
            set
            {
                if (value.Length == 6 && value.StartsWith("SP"))
                    maSP = value;
                else
                    maSP = "SP0001";
            }
        }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public char LoaiSP { get => loaiSP; set => loaiSP = value; }
        public SanPham()
        {
            MaSP = "SP0003";
            TenSP = "xe Toyota Camry";
            NamSX = 2021;
            DonGia = 30000;
            LoaiSP = 'A';
        }
        public SanPham(SanPham sp)
        {
            MaSP = sp.MaSP;
            TenSP = sp.TenSP;
            NamSX = sp.NamSX;
            DonGia = sp.DonGia;
            LoaiSP = sp.LoaiSP;
        }
        public SanPham(string maSP, string tenSP, int namSX, float donGia, char loaiSP)
        {
            MaSP = maSP;
            TenSP = tenSP;
            NamSX = namSX;
            DonGia = donGia;
            LoaiSP = loaiSP;
        }
        public double tinhThanhTien(int soLuong)
        {
            const double VAT = 0.1;
            return soLuong * donGia * (1 + VAT);
        }
        public void xuatThongTin()
        {
            Console.WriteLine("{0,-10}|{1,-30}|{2,10}|{3,10}|{4,10}", maSP, tenSP, namSX, donGia, loaiSP);
        }
    }
}
