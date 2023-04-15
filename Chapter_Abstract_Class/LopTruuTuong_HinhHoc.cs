using System;

namespace OOP_Abstract_Class
{
    internal class Program
    {
        public abstract class Hinh
        {
            public abstract double tinhChuVi();
            public abstract double tinhDienTich();
        }
        public class HinhTron:Hinh
        {
            private double banKinh;
            public double BanKinh { get => banKinh; set => banKinh = value; }
            public HinhTron()
            {
                banKinh = 3;
            }
            public HinhTron(double banKinh)
            {
                this.banKinh = banKinh;
            }
            public override double tinhChuVi()
            {
                return banKinh * 2 * Math.PI;
            }
            public override double tinhDienTich()
            {
                return banKinh * banKinh * Math.PI;
            }
        }
        public class HinhVuong : Hinh
        {
            private double canh;
            public double Canh { get => canh; set => canh = value; }
            public HinhVuong()
            {
                canh = 7;
            }
            public HinhVuong(double canh)
            {
                this.canh = canh;
            }
            public override double tinhChuVi()
            {
                return canh * 4;
            }
            public override double tinhDienTich()
            {
                return canh * canh;
            }
        }
        public class HinhChuNhat:Hinh
        {
            private double dai;
            private double rong;
            public double Dai { get => dai; set => dai = value; }
            public double Rong { get => rong; set => rong = value; }
            public HinhChuNhat()
            {
                dai = 5;
                rong = 3;
            }
            public HinhChuNhat(double chieuDai, double chieuRong)
            {
                dai = chieuDai;
                rong = chieuRong;
            }
            public override double tinhChuVi()
            {
                return (dai + rong) * 2;
            }
            public override double tinhDienTich()
            {
                return dai * rong;
            }
        }
        static void Main(string[] args)
        {
            HinhTron hinhTron = new HinhTron();
            Console.WriteLine("\nHinh Tron Co Ban Kinh = {0}", hinhTron.BanKinh);
            Console.WriteLine("Chu vi cua hinh tron la: {0:F2}", hinhTron.tinhChuVi());
            Console.WriteLine("Dien tich cua hinh la: {0:F2}", hinhTron.tinhDienTich());

            HinhVuong hinhVuong = new HinhVuong();
            Console.WriteLine("\nHinh Tron Co Canh = {0}", hinhVuong.Canh);
            Console.WriteLine("Chu vi cua hinh vuong la: {0:F2}", hinhVuong.tinhChuVi());
            Console.WriteLine("Dien tich cua hinh vuong la: {0:F2}", hinhVuong.tinhChuVi());

            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            Console.WriteLine("\nHinh Chu Nhat Co Dai = {0}, Rong = {1}", hinhChuNhat.Dai, hinhChuNhat.Rong);
            Console.WriteLine("Chu vi cua hinh chu nat la: {0:F2}", hinhChuNhat.tinhChuVi());
            Console.WriteLine("Dien tich cua hinh chu nhat la: {0:F2}", hinhChuNhat.tinhDienTich());
        }
    }
}