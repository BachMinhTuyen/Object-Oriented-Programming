using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_1
{
    public abstract class BatDongSan
    {
        private double chieuDai;
        private double chieuRong;
        string maSo;

        protected double ChieuDai { get => chieuDai; set => chieuDai = value; }
        protected double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public string MaSo { get => maSo; set => maSo = value; }
        public BatDongSan(double chieuDai, double chieuRong, string maSo)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.maSo = maSo;
        }

        public abstract double giaBan();
        public double dienTich()
        {
            return ChieuDai * ChieuRong;
        }
        public void xuatThongTin()
        {
            Console.WriteLine($"{maSo,-10}|{GetType().Name,-10}|{chieuDai,10}|{chieuRong,10}|{dienTich(),10}|{giaBan(),10}|");
        }
    }
}
