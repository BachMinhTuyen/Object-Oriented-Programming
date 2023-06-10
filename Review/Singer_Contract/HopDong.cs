using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopDongCaSi
{
    public abstract class HopDong
    {
        protected string maHD;
        protected string tenCS;
        protected int soTietMuc;
        protected DateTime ngayBD;
        protected int donGia;
        protected double phuPhi;

        public string MaHD
        {
            get { return maHD; } 
            set
            {
                if (value.Length == 6 && value.StartsWith("HD") && int.TryParse(value.Substring(2), out _))
                {
                    maHD = value;
                }
                else
                {
                    throw new ArgumentException("Lỗi! Định dạng mã hợp đồng");
                }
            }
        }
        public string TenCS
        {
            get { return tenCS; }
            set { tenCS = value; }
        }
        public int SoTietMuc
        {
            get { return soTietMuc; }
            set { soTietMuc = value; }
        }
        public DateTime NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }
        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public double PhuPhi
        {
            get { return phuPhi; }
            set { phuPhi = value; }
        }
        static double tiLeThue = 0.15;
        public HopDong()
        {
            MaHD = "HD3418";
            TenCS = "Lý Không Hay";
            SoTietMuc = 3;
            NgayBD = new DateTime(2020, 10, 24);
            DonGia = 4000000;
            PhuPhi = 2000000;
        }
        public HopDong(string maHD, string tenCS, int donGia)
        {
            this.MaHD = maHD;
            this.TenCS = tenCS;
            this.DonGia = donGia;
            this.SoTietMuc= 2;
            this.NgayBD = new DateTime(2020,12,24);
            this.PhuPhi = 0;
        }
        public HopDong(string maHD, string tenCS, int donGia, int soTietMuc, DateTime ngayBieuDien, double phuPhi)
        {
            this.MaHD = maHD;
            this.TenCS = tenCS;
            this.DonGia = donGia;
            this.SoTietMuc = soTietMuc;
            this.NgayBD = ngayBieuDien;
            this.PhuPhi = phuPhi;
        }
        public abstract double phiQuangCao();
        public double thanhTien()
        {
            return donGia * soTietMuc + phuPhi + phiQuangCao();
        }
        public double Thue()
        {
            return tiLeThue * thanhTien();
        }
        public void xuatThongTin()
        {
            string ngayBDFormatted = ngayBD.ToString("dd/MM/yyyy");
            Console.WriteLine("\nMã HD: {0}\nTên Ca Sĩ: {1}\nSố tiết mục: {2}\nNgày biểu diễn: {3}\nĐơn giá: {4}\nPhụ phí: {5}", maHD, tenCS, soTietMuc, ngayBDFormatted, donGia, phuPhi);
        }
    }
}
