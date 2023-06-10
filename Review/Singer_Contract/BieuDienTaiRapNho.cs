using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopDongCaSi
{
    public class BieuDienTaiRapNho:HopDong, IHoTro
    {
        private int quyMo;

        public int QuyMo
        {
            get { return quyMo; }
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentException("Lỗi! Quy mô chỉ từ 1 tới 5");
                else 
                    quyMo = value;
            }
        }
        public BieuDienTaiRapNho(string maHD, string tenCS, int donGia, int soTietMuc, DateTime ngayBieuDien, double phuPhi, int quyMo):base(maHD, tenCS, donGia, soTietMuc, ngayBieuDien, phuPhi)
        {
            this.QuyMo = quyMo;
        }
        public override double phiQuangCao()
        {
            return 10000000 + 2000000 * soTietMuc;
        }
        public double chinhSachHoTro()
        {
            if (quyMo > 0 && quyMo <= 3)
                return 1000000;
            return 0;
        }
    }
}
