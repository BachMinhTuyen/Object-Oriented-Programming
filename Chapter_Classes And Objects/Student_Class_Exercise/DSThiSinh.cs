using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Student_Class_Exercise
{
    public class DSThiSinh
    {
        List<ThiSinh> lst = new List<ThiSinh>();
        public List<ThiSinh> Lst { get => lst; set => lst = value; }
        public void nhapDanhSach_TuFileXML(string filename)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filename);
            XmlNodeList nodelist = read.SelectNodes("/DSThiSinh/ThiSinh");
            foreach(XmlNode node in nodelist)
            {
                ThiSinh ts = new ThiSinh();
                ts.MaThiSinh = node["MaTS"].InnerText;
                ts.HoTen = node["HoTen"].InnerText;
                ts.GioiTinh = node["GTinh"].InnerText;
                ts.DiemLyThuyet = float.Parse(node["DiemLyThuyet"].InnerText);
                ts.DiemThucHanh = float.Parse(node["DiemThucHanh"].InnerText);
                lst.Add(ts);
            }
        }
        public void xuatDanhSach()
        {
            Console.WriteLine("{0,-10}|{1,-20}|{2,-10}|{3,15}|{4,15}|{5,10}|{6,10}", "Mã TS", "Họ Tên", "Giới Tính", "Điểm Lý Thuyết", "Điểm Thực Hành", "Tổng Kết", "Xét Tuyển");
            foreach(ThiSinh ts in lst)
            {
                ts.xuatThongTin();
            }
        }
        private List<ThiSinh> locThiSinhDau()
        {
            return lst.Where(t => t.xetTuyen().Equals("Đậu") == true).ToList();
        }
        public void xuatDanhSach_ThiSinhDau()
        {
            List<ThiSinh> dsLoc = locThiSinhDau();
            foreach(ThiSinh ts in dsLoc)
            {
                ts.xuatThongTin();
            }
        }
        public void dem_ThiSinhDau_ThiSinhRot()
        {
            int count_Dau = 0;
            int count_Rot = 0;
            foreach(ThiSinh ts in lst)
            {
                if(ts.xetTuyen().Equals("Đậu") == true)
                    count_Dau++;
                else
                    count_Rot++;
            }
            Console.WriteLine("Tổng số thí sinh đậu: {0}, thí sinh rớt: {1}", count_Dau, count_Rot);
        }
        public void timThiSinh()
        {
            int check = 0;
            Console.Write("Nhập mã thí sinh: ");
            string id = Console.ReadLine();
            foreach(ThiSinh ts in lst)
            {
                if (ts.MaThiSinh == id)
                {
                    check++;
                    Console.WriteLine("{0,-10}|{1,-20}|{2,-10}|{3,15}|{4,15}|{5,10}|{6,10}", "Mã TS", "Họ Tên", "Giới Tính", "Điểm Lý Thuyết", "Điểm Thực Hành", "Tổng Kết", "Xét Tuyển");
                    ts.xuatThongTin();
                    break;
                }
                else
                    continue;
            }
            if (check == 0)
                Console.WriteLine("Không tìm thấy thông tin");
        }
        public void sapXepGiamDan_TheoDiemTongKet()
        {
            lst = lst.OrderByDescending(t => t.diemTongKet()).ToList();
        }
    }
}
