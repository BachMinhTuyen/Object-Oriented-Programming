using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Exercise
{
    public class SachCaoCap:Sach, IDichVu
    {
        private double chiPhiThueLamBia;
        public double ChiPhiThueLamBia
        {
            get { return chiPhiThueLamBia; }
            set { chiPhiThueLamBia = value; }
        }
        public SachCaoCap(string maSach, string tenSach, string tacGia, int soTrang, double giaBan, double chiPhiThueLamBia):base(maSach, tenSach, tacGia, soTrang, giaBan)
        {
            this.chiPhiThueLamBia = chiPhiThueLamBia;
        }
        public override double chiPhi()
        {
            return chiPhiThueLamBia + GiaBan * 0.5;
        }
        public double phiBaoBiaBaoVe()
        {
            return 80000;
        }
        public double phiUopThomSach()
        {
            return SoTrang * 300;
        }
    }
}
