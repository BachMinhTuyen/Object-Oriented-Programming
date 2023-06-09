using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_HDT_OnTapLan1
{
    public class SachDoHoa :Sach, IDichVu
    {
        private int soLuongHinhVe;
        // true = sách màu
        // false = đen trắng
        private bool mauSach;
        public int SoLuongHinhVe
        {
            get { return soLuongHinhVe; }
            set { soLuongHinhVe = value; }
        }
        public bool MauSach
        {
            get { return mauSach; }
            set { mauSach = value; }
        }
        public SachDoHoa(string maSach, string tenSach, string tacGia, int soTrang, double giaBan, int soLuongHinhVe, bool mauSach):base(maSach, tenSach, tacGia, soTrang, giaBan)
        {
            this.soLuongHinhVe = soLuongHinhVe;
            this.mauSach = mauSach;
        }
        public override double chiPhi()
        {
            if (mauSach == true)
                return soLuongHinhVe * 2000;
            else
                return soLuongHinhVe * 1200;
        }
        public double phiBaoBiaBaoVe()
        {
            return 50000;
        }
        public double phiUopThomSach()
        {
            return SoTrang * 200;
        }
    }
}
