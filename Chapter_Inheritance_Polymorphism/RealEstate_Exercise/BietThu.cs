using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_1
{
    public class BietThu : BatDongSan, IPhi
    {
        public BietThu(double chieuDai, double chieuRong, string maSo):base(chieuDai,chieuRong, maSo) { }
        public override double giaBan()
        {
            return dienTich() * 400000;
        }
        public double phiKinhDoanh()
        {
            return dienTich() * 1000;
        }
    }
}
