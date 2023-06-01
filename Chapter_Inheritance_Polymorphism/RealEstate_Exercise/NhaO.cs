using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_1
{
    public class NhaO : BatDongSan
    {
        int soLau;
        public int SoLau { get => soLau; set => soLau = value; }
        public NhaO(double chieuDai, double chieuRong, string maSo, int soLau):base(chieuDai, chieuRong, maSo) { }
        public override double giaBan()
        {
            return dienTich() * 10000 + SoLau * 100000;
        }
    }
}
