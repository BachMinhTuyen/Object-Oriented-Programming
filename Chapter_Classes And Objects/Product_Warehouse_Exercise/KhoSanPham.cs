using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Product_Warehouse_Exercise
{
    public class KhoSanPham
    {
        private string tenKho;
        private string diaChiKho;
        List<SanPham> lst = new List<SanPham>();

        public string TenKho { get => tenKho; set => tenKho = value; }
        public string DiaChiKho { get => diaChiKho; set => diaChiKho = value; }
        public List<SanPham> Lst { get => lst; set => lst = value; }

        public void nhapDanhSach_TuFileXML(string filename)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filename);
            XmlNode productNode = read.SelectSingleNode("/khosanpham");
            tenKho = productNode["ten"].InnerText;
            diaChiKho = productNode["diachi"].InnerText;
            XmlNodeList nodelist = read.SelectNodes("/khosanpham/SanPhams/SanPham");
            foreach (XmlNode node in nodelist)
            {
                SanPham sp = new SanPham();
                sp.MaSP = node["masp"].InnerText;
                sp.TenSP = node["tensp"].InnerText;
                sp.NamSX = int.Parse(node["namsx"].InnerText);
                sp.DonGia = float.Parse(node["gia"].InnerText);
                sp.LoaiSP = char.Parse(node["loai"].InnerText);
                lst.Add(sp);
            }
        }
        public double tinhTongTienSanPham()
        {
            double tong = 0;
            foreach (SanPham sp in lst)
            {
                tong += sp.DonGia;
            }
            return tong;
        }
        public void xuatDanhSach()
        {
            Console.WriteLine("Tên kho: {0}", tenKho);
            Console.WriteLine("Địa chỉ kho: {0}", diaChiKho);
            Console.WriteLine("Tổng tiền: {0}", tinhTongTienSanPham());
            Console.WriteLine("{0,-10}|{1,-30}|{2,10}|{3,10}|{4,10}", "Mã SP", "Tên SP", "Năm SX", "Đơn Giá", "Loại SP");
            foreach (SanPham sp in lst)
            {
                sp.xuatThongTin();
            }    
        }
        //Sử dụng LinQ
        public void timSanPhamBanNhieuNhat()
        {
            var sanPhamBanNhieuNhat = lst.GroupBy(sp => sp.MaSP).OrderByDescending(g => g.Count()).First();
            Console.WriteLine("\nSản phẩm được bán nhiều nhất ({0} lần):", sanPhamBanNhieuNhat.Count());
            foreach (SanPham sp in sanPhamBanNhieuNhat)
            {
                sp.xuatThongTin();
                break;
            }
            
        }
        public void sapXepTangDan_TheoDonGia()
        {
            lst = lst.OrderBy(t => t.DonGia).ToList();
        }
    }
}
