using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_1
{
    public class DatTrong : BatDongSan
    {
        public DatTrong(double chieuDai, double chieuRong, string maSo):base(chieuDai, chieuRong, maSo) { }
        public override double giaBan()
        {
            return dienTich() * 10000;
        }
    }
}
