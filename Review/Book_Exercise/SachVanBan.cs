using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_HDT_OnTapLan1
{
    public class SachVanBan:Sach
    {
        private double chiPhiThietKeBia;
        public double ChiPhiThietKeBia
        {
            get { return chiPhiThietKeBia; }
            set { chiPhiThietKeBia = value; }
        }
        public SachVanBan(string maSach, string tenSach, string tacGia, int soTrang, double giaBan, double chiPhiThietKeBia):base(maSach, tenSach, tacGia, soTrang, giaBan)
        {
            this.chiPhiThietKeBia = chiPhiThietKeBia;
        }
        public override double chiPhi()
        {
            return GiaBan * 0.4 + chiPhiThietKeBia;
        }
    }
}
