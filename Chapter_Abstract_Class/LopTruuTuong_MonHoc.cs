using System;

namespace DiemTrungBinh
{
    internal class Program
    {
        abstract public class MonHoc
        {
            private string tenMH;
            private int soTC;
            private string maMH;
            protected string MaMH { get => maMH; set => maMH = value; }
            protected string TenMH { get => tenMH; set => tenMH = value; }
            protected int SoTC { get => soTC; set => soTC = value; }
            public MonHoc()
            {
                maMH = "HDT1";
                tenMH = "Lap Trinh Huong Doi Tuong";
                soTC = 3;
            }
            public MonHoc(string maMH, string tenMH, int soTC)
            {
                this.maMH = maMH;
                this.tenMH = tenMH;
                this.soTC = soTC;
            }
            public void xuat()
            {
                Console.WriteLine("\nMaMH: {0}, TenMH: {1}, soTC: {2}", maMH,tenMH, soTC);
            }
            public abstract double tinhDTB();
            public string diemChu()
            {
                double DTB = tinhDTB();
                if (DTB < 4)
                    return "F";
                else if (DTB < 4.9)
                    return "D";
                else if (DTB < 5.4)
                    return "D+";
                else if (DTB < 5.9)
                    return "C";
                else if (DTB < 6.9)
                    return "C+";
                else if (DTB < 7.9)
                    return "B";
                else if (DTB < 8.4)
                    return "B+";
                else if (DTB < 9.4)
                    return "A";
                else
                    return "A+";
            }
        }
        class LyThuyet:MonHoc
        {
            private double diemCK;
            private double diemTL;
            protected double DiemTL { get => diemTL; set => diemTL = value; }
            protected double DiemCK { get => diemCK; set => diemCK = value; }
            public LyThuyet()
            {
                diemTL = 8;
                diemCK = 6;
            }
            public LyThuyet(string maMH, string tenMH, int soTC, double diemTL, double diemCK):base(maMH, tenMH, soTC)
            {
                this.diemTL = diemTL;
                this.diemCK = diemCK;
            }
            public new void xuat()
            {
                base.xuat();
                Console.WriteLine("DiemTL: {0}, diemCK: {1}, diemTB: {2:F2}, diemChu: {3}", diemTL, diemCK, tinhDTB(), diemChu());
            }
            public override double tinhDTB()
            {
                return DiemTL * 0.3 + DiemCK * 0.7;
            }
        }
        class ThucHanh:MonHoc
        {
            double diemKT1, diemKT2, diemKT3;
            public double DiemKT1 { get => diemKT1; set => diemKT1 = value; }
            public double DiemKT2 { get => diemKT2; set => diemKT2 = value; }
            public double DiemKT3 { get => diemKT3; set => diemKT3 = value; }
            public ThucHanh()
            {
                diemKT1 = 8;
                diemKT2 = 8.5;
                diemKT3 = 9.5;
            }
            public ThucHanh(string maMH, string tenMH, int soTC, double diemKT1, double diemKT2, double diemKT3) : base(maMH, tenMH, soTC)
            {
                this.diemKT1 = diemKT1;
                this.diemKT2 = diemKT2;
                this.diemKT3 = diemKT3;
            }
            public new void xuat()
            {
                base.xuat();
                Console.WriteLine("Diem KT1: {0}, Diem KT2: {1}, Diem KT3: {2}, DiemTB: {3:F2}", diemKT1, diemKT2, diemKT3, tinhDTB());
            }
            public override double tinhDTB()
            {
                return (DiemKT1 + DiemKT2 + DiemKT3) / 3;
            }
        }
        class DoAn:MonHoc
        {
            double diemGVHD, diemGVPB;
            public double DiemGVHD { get => diemGVHD; set => diemGVHD = value; }
            public double DiemGVPB { get => diemGVPB; set => diemGVPB = value; }
            public DoAn()
            {
                diemGVHD = 8.5;
                diemGVPB = 8.5;
            }
            public DoAn(string maMH, string tenMH, int soTC, double diemGVHD, double diemGVPB):base(maMH, tenMH, soTC)
            {
                this.diemGVHD = diemGVHD;
                this.diemGVPB = diemGVPB;
            }
            public new void xuat()
            {
                base.xuat();
                Console.WriteLine("Diem GVHD: {0}, Diem GVPB: {1}, Diem TB: {2:F2}", diemGVHD, diemGVPB, tinhDTB());
            }
            public override double tinhDTB()
            {
                return (DiemGVHD + DiemGVPB)/2;
            }
        }
        static void Main(string[] args)
        {
            MonHoc MH1 = new LyThuyet();
            MH1.xuat();
            LyThuyet MH2 = new LyThuyet();
            MH2.xuat();
            ThucHanh MH3 = new ThucHanh();
            MH3.xuat();
            DoAn MH4 = new DoAn();
            MH4.xuat();
            Console.ReadLine();
        }
    }
}