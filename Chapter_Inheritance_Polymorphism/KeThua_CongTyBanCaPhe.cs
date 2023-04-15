using System;

namespace Cong_Ty_Mua_Ban_Ca_Phe
{
    internal class Program
    {
        public class CaPhe
        {
            string maCaPhe, tenCaPhe;
            int soLuong;
            double donGia;
            public string MaCaPhe { get => maCaPhe; set => maCaPhe = value; }
            public string TenCaPhe { get => tenCaPhe; set => tenCaPhe = value; }
            public int SoLuong { get => soLuong; set => soLuong = value; }
            public double DonGia { get => donGia; set => donGia = value; }
            public CaPhe()
            {
                MaCaPhe = "Cappuccino";
                TenCaPhe = "Ca phe Cappuccino";
            }
            public CaPhe(string MA, string TEN)
            {
                MaCaPhe = MA;
                TenCaPhe = TEN;
            }
            public CaPhe(string maCaPhe, string tenCaPhe, int soLuong, double donGia)
            {
                this.maCaPhe = maCaPhe;
                this.tenCaPhe = tenCaPhe;
                this.soLuong = soLuong;
                this.donGia = donGia;
            }
            public virtual double tinhTien()
            {
                return soLuong * donGia;
            }
            public void hienThiThongTin()
            {
                Console.WriteLine("\nMa ca phe: {0}, Ten ca phe: {1}, So luong: {2}, Don gia: {3}", maCaPhe,tenCaPhe, soLuong, donGia);
            }
        }
        public interface IHoTro
        {
            double KinhPhiHoTro();
        }
        public class CaPheHat : CaPhe, IHoTro
        {
            public CaPheHat()
            {
                MaCaPhe = "Ca Phe 02";
                TenCaPhe = "Ca Phe Espresso";
                SoLuong = 12;
                DonGia = 25000;
            }
            public CaPheHat(string maCaPhe, string tenCaPhe, int soLuong, double donGia) : base(maCaPhe, tenCaPhe, soLuong, donGia) { }
            public override double tinhTien()
            {
                return ((SoLuong * 1.0) * DonGia);
            }
            public double KinhPhiHoTro()
            {
                return SoLuong * 10;
            }
            public new void hienThiThongTin()
            {
                base.hienThiThongTin();
                Console.WriteLine("Kinh phi ho tro: {0}, Thanh tien: {1:F0}", KinhPhiHoTro(), tinhTien());
            }
        }
        public class CaPheXayNguyenChat:CaPhe, IHoTro
        {
            public CaPheXayNguyenChat()
            {
                MaCaPhe = "Ca Phe 03";
                TenCaPhe = "Ca Phe Arabica";
                SoLuong = 20;
                DonGia = 32000;
            }
            public CaPheXayNguyenChat(string maCaPhe, string tenCaPhe, int soLuong, double donGia) : base(maCaPhe, tenCaPhe, soLuong, donGia) { }
            public override double tinhTien()
            {
                double congXay = 0;
                if (SoLuong < 100)
                    congXay = 100 * SoLuong;
                else
                    congXay = 95 * SoLuong;
                return SoLuong * DonGia + congXay;
            }
            public double KinhPhiHoTro()
            {
                return SoLuong * 12;
            }
            public new void hienThiThongTin()
            {
                base.hienThiThongTin();
                Console.WriteLine("Kinh phi ho tro: {0}, Thanh tien: {1:F0}", KinhPhiHoTro(), tinhTien());
            }
        }
        public class CaPheXayCoHuongLieu:CaPhe
        {
            private int soLuong_HuongLieu;
            private double gia_HuongLieu;

            public int SoLuong_HuongLieu { get => soLuong_HuongLieu; set => soLuong_HuongLieu = value; }
            public double Gia_HuongLieu { get => gia_HuongLieu; set => gia_HuongLieu = value; }
            public CaPheXayCoHuongLieu()
            {
                MaCaPhe = "Ca Phe 04";
                TenCaPhe = "Ca Phe Xay Socola";
                SoLuong = 17;
                DonGia = 55000;
                SoLuong_HuongLieu = 10;
                gia_HuongLieu = 35000;
            }
            public CaPheXayCoHuongLieu(string maCaPhe, string tenCaPhe, int soLuong, double donGia, int soLuong_HuongLieu, double gia_HuongLieu):base(maCaPhe, tenCaPhe, soLuong, donGia)
            {
                this.soLuong_HuongLieu = soLuong_HuongLieu;
                this.gia_HuongLieu = gia_HuongLieu;
            }
            public override double tinhTien()
            {
                double congPhaChe = soLuong_HuongLieu * 2;
                return SoLuong * DonGia + soLuong_HuongLieu * gia_HuongLieu + congPhaChe;
            }
            public new void hienThiThongTin()
            {
                base.hienThiThongTin();
                Console.WriteLine("So luong huong lieu: {0}, Gia huong lieu: {1}, Thanh tien: {2:F0}", soLuong_HuongLieu, gia_HuongLieu, tinhTien());
            }
        }
        public class CaPheDongGoi:CaPhe
        {
            string loaiBB;
            public string LoaiBB { get => loaiBB; set => loaiBB = value; }
            public CaPheDongGoi()
            {
                MaCaPhe = "Ca Phe 04";
                TenCaPhe = "Ca Phe Xay Sieu Min";
                SoLuong = 17;
                DonGia = 55000;
                loaiBB = "giay";
            }
            public CaPheDongGoi(string maCaPhe, string tenCaPhe, int soLuong, double donGia, string loaiBB):base(maCaPhe, tenCaPhe, soLuong, donGia)
            {
                this.loaiBB = loaiBB;
            }
            public override double tinhTien()
            {
                if (loaiBB == "giay")
                    return SoLuong * DonGia * 1.1;
                else
                    return SoLuong * DonGia * 1.2;
            }
            public new void hienThiThongTin()
            {
                base.hienThiThongTin();
                Console.WriteLine("Loai bao bi: {0}, Thanh tien: {1:F0}", loaiBB, tinhTien());
            }
        }
        static void Main(string[] args)
        {
            CaPhe caPhe = new CaPhe("Ca Phe 01", "Ca Phe Trung Nguyen", 25, 50000);
            caPhe.hienThiThongTin();
            Console.WriteLine("Thanh tien: {0}", caPhe.tinhTien());

            CaPheHat caPheHat = new CaPheHat();
            caPheHat.hienThiThongTin();

            CaPheXayNguyenChat caPheXay = new CaPheXayNguyenChat();
            caPheXay.hienThiThongTin();

            CaPheXayCoHuongLieu caPheHuongLieu = new CaPheXayCoHuongLieu();
            caPheHuongLieu.hienThiThongTin();

            CaPheDongGoi caPheDongGoi = new CaPheDongGoi();
            caPheDongGoi.hienThiThongTin();

            Console.ReadKey();
        }
    }
}