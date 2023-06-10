using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopDongCaSi
{
    public class BieuDienTaiRapLon:HopDong, IHoTro
    {
        private int sLKhanGia;
        public int SLKhanGia
        {
            get { return sLKhanGia; }
            set { sLKhanGia = value; }
        }
        public BieuDienTaiRapLon(string maHD, string tenCS, int donGia, int soTietMuc, DateTime ngayBieuDien, double phuPhi, int sLKhanGia):base(maHD, tenCS, donGia, soTietMuc,ngayBieuDien,phuPhi)
        {
            this.SLKhanGia = sLKhanGia;
        }
        public override double phiQuangCao()
        {
            if (sLKhanGia < 1000000)
            {
                return 30000000;
            }
            else
                return 50000000;
        }
        public double chinhSachHoTro()
        {
            
            if(sLKhanGia >= 100000)
            {
                //Tỉ lệ khán giả trên 100.000 người
                double tiLe = (sLKhanGia * 1.0) / 100000;
                double tienHoTro = tiLe * 1000000;
                if (tienHoTro > 20000000)
                    return 20000000;
                return tienHoTro;
            }
            else
                return 0;
        }
    }
}
