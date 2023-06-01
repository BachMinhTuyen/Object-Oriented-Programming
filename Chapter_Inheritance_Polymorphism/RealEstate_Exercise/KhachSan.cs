using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_8_1
{
    public class KhachSan : BatDongSan, IPhi
    {
        int soSao;

        public int SoSao { get => soSao; set => soSao = value; }
        public KhachSan(double chieuDai, double chieuRong, string maSo, int soSao):base(chieuDai, chieuRong, maSo)
        {
            this.soSao = soSao;
        }
        public override double giaBan()
        {
            return 100000 + SoSao * 50000;
        }
        public double phiKinhDoanh()
        {
            return ChieuRong * 5000;
        }
    }
}
