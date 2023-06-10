using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopDongCaSi
{
    public class BieuDienTaiNha:HopDong
    {
        private double khoangCach;

        public double KhoangCach
        {
            get { return khoangCach; }
            set { khoangCach = value;}
        }
        public BieuDienTaiNha(string maHD, string tenCS, int donGia, int soTietMuc, DateTime ngayBieuDien, double phuPhi, double khoangCach) :base(maHD, tenCS, donGia, soTietMuc, ngayBieuDien, phuPhi)
        {
            this.KhoangCach = khoangCach;
        }
        public override double phiQuangCao()
        {
            if(khoangCach < 20)
                return 400000 * khoangCach;
            else
            {
                if (300000 * khoangCach <= 15000000)
                    return 300000 * khoangCach;
                else
                    return 15000000;
            }
        }
    }
}
