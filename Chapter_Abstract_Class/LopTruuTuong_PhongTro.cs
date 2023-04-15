using System;

namespace PhongTro
{
    internal class Program
    {
        public abstract class PhongTro
        {
            private string maPhong;
            private int soNuoc;
            private int soNguoiO;
            private int soDien;

            protected string MaPhong { get => maPhong; set => maPhong = value; }
            protected int SoNguoiO { get => soNguoiO; set => soNguoiO = value; }
            protected int SoDien { get => soDien; set => soDien = value; }
            protected int SoNuoc { get => soNuoc; set => soNuoc = value; }
            public PhongTro()
            {
                maPhong = "PhongVIP_01";
                soDien = 400;
                soNuoc = 200;
                soNguoiO = 10;
            }
            public PhongTro(string maPhong, int soNguoiO, int soDien, int soNuoc)
            {
                this.maPhong = maPhong;
                this.soNguoiO = soNguoiO;
                this.soDien = soDien;
                this.soNuoc = soNuoc;
            }
            public void xuat()
            {
                Console.WriteLine("MaPhong: {0}, So nguoi o: {1}, So dien: {2}, So nuoc: {3}", maPhong, soNguoiO, soDien, soNuoc);
            }
            public abstract double tinhTien();
        }
        public class PhongLoaiA:PhongTro
        {
            private int soNguoiThan;

            protected int SoNguoiThan { get => soNguoiThan; set => soNguoiThan = value; }
            public PhongLoaiA()
            {
                soNguoiThan = 9;
            }
            public PhongLoaiA(string maPhong, int soNguoiO, int soDien, int soNuoc, int soNguoiThan):base(maPhong,soNguoiO,soDien, soNuoc)
            {
                this.soNguoiThan = soNguoiThan;
            }
            public new void xuat()
            {
                base.xuat();
                Console.WriteLine("So nguoi than: {0}", soNguoiThan);
            }
            public override double tinhTien()
            {
                return 1400 + 2 * SoDien + 8 * SoNuoc + 50 * SoNguoiThan;
            }
        }
        static void Main(string[] args)
        {
            PhongTro P1 = new PhongLoaiA();
            P1.xuat();

            PhongLoaiA P2 = new PhongLoaiA("PhongVip_02", 3, 60, 5, 6);
            P2.xuat();
            Console.WriteLine("So tien can tra: {0}", P2.tinhTien());
        }
    }
}