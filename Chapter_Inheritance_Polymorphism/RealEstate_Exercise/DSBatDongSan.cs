using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai_8_1
{
    public class DSBatDongSan
    {
        List<BatDongSan> lst = new List<BatDongSan>();
        public void nhapDanhSach_TuFileXML(string fileName)
        {
            XmlDocument read = new XmlDocument();
            read.Load(fileName);
            XmlNodeList nodeList = read.SelectNodes("/BDSs/BDS");
            foreach (XmlNode node in nodeList)
            {
                BatDongSan bds;
                int loai = Convert.ToInt32(node["Loai"].InnerText);
                string ma = node["Ma"].InnerText;
                double dai = Convert.ToDouble(node["Dai"].InnerText);
                double rong = Convert.ToDouble(node["Rong"].InnerText);
                if (loai == 1)
                {
                    int soLau = Convert.ToInt32(node["So"].InnerText);
                    bds = new NhaO(dai, rong, ma, soLau);
                }
                else if (loai == 2)
                {
                    bds = new DatTrong(dai, rong, ma);
                }
                else if (loai == 3)
                {
                    bds = new BietThu(dai, rong, ma);
                }
                else
                {
                    int soSao = Convert.ToInt32(node["So"].InnerText);
                    bds = new KhachSan(dai, rong, ma, soSao);
                }
                lst.Add(bds);
            }
        }
        public void xuatDanhSach()
        {
            Console.WriteLine("Danh sách bất động sản:");
            Console.WriteLine("{0,-10}|{1,-10}|{2,10}|{3,10}|{4,10}|{5,10}|", "Mã", "Loại", "Chiều dài", "Chiều rộng", "Diện tích", "Giá bán");
            foreach (BatDongSan bds in lst)
                bds.xuatThongTin();
        }
        public double tongThue()
        {
            double tong = 0;
            foreach(BatDongSan bds in lst)
            {
                if(bds is IPhi)
                {
                    IPhi t = (IPhi)bds;
                    tong += t.phiKinhDoanh();
                }
            }
            return tong;
        }
        public double tongGiaTri()
        {
            double tong = 0;
            foreach (BatDongSan bds in lst)
                tong += bds.giaBan();
            return tong;
        }
    }
}