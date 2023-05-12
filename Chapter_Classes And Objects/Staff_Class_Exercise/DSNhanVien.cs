using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Staff_Class_Exercise
{
    public class DSNhanVien
    {
        List<NhanVien> lst = new List<NhanVien>();

        public List<NhanVien> Lst { get => lst; set => lst = value; }
        public void nhapThongTin_TuFileXML(string fileName)
        {
            XmlDocument read = new XmlDocument();
            read.Load(fileName);
            XmlNodeList nodelist = read.SelectNodes("/DSNV/NV");
            foreach(XmlNode node in nodelist)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = node["MaSo"].InnerText;
                nv.TenNV = node["HoTen"].InnerText;
                nv.PhongBan = node["PhongBan"].InnerText;
                nv.ChucVu = node["ChucVu"].InnerText;
                nv.HeSoLuong = float.Parse(node["HeSoLuong"].InnerText);
                nv.ThamNienCongTac = int.Parse(node["ThamNien"].InnerText);
                nv.SoNgayLVTrongThang = int.Parse(node["SoNgayLamViec"].InnerText);
                lst.Add(nv);
            }
        }
        public void xuatDanhSach()
        {
            Console.WriteLine("{0,-6}|{1,-15}|{2,-20}|{3,-10}|{4,11}|{5,16}|{6,13}|{7,8}|{8,10}", "Mã NV", "Họ Tên", "Phòng Ban", "Chức Vụ", "Hệ Số Lương", "Số Ngày Làm Việc", "Hệ Số Thi Đua", "Phụ Cấp", "Lương");
            foreach(NhanVien nv in lst)
            {
                nv.xuatThongTin();
            }    
        }
        public void xuatDanhSachNhom_TheoHeSoThiDua()
        {
            //Sắp xếp danh sách tăng dần theo hệ số thi đua
            lst = lst.OrderBy(t => t.HeSoThiDua).ToList();

            Console.WriteLine("\n\tDANH SÁCH NHÂN VIÊN CÓ HỆ SỐ THI ĐUA 1.0");
            Console.WriteLine("{0,-6}|{1,-15}|{2,-20}|{3,-10}|{4,11}|{5,16}|{6,13}|{7,8}|{8,10}", "Mã NV", "Họ Tên", "Phòng Ban", "Chức Vụ", "Hệ Số Lương", "Số Ngày Làm Việc", "Hệ Số Thi Đua", "Phụ Cấp", "Lương");
            foreach (NhanVien nv in lst)
            {
                if(nv.HeSoThiDua == 1.0f)
                {
                    nv.xuatThongTin();
                }
            }
            Console.WriteLine("\n\tDANH SÁCH NHÂN VIÊN CÓ HỆ SỐ THI ĐUA 0.8");
            Console.WriteLine("{0,-6}|{1,-15}|{2,-20}|{3,-10}|{4,11}|{5,16}|{6,13}|{7,8}|{8,10}", "Mã NV", "Họ Tên", "Phòng Ban", "Chức Vụ", "Hệ Số Lương", "Số Ngày Làm Việc", "Hệ Số Thi Đua", "Phụ Cấp", "Lương");
            foreach (NhanVien nv in lst)
            {
                if (nv.HeSoThiDua == 0.8f)
                {
                    nv.xuatThongTin();
                }
            }
            Console.WriteLine("\n\tDANH SÁCH NHÂN VIÊN CÓ HỆ SỐ THI ĐUA 0.6");
            Console.WriteLine("{0,-6}|{1,-15}|{2,-20}|{3,-10}|{4,11}|{5,16}|{6,13}|{7,8}|{8,10}", "Mã NV", "Họ Tên", "Phòng Ban", "Chức Vụ", "Hệ Số Lương", "Số Ngày Làm Việc", "Hệ Số Thi Đua", "Phụ Cấp", "Lương");
            foreach (NhanVien nv in lst)
            {
                if (nv.HeSoThiDua == 0.6f)
                {
                    nv.xuatThongTin();
                }
            }
        }
        public void timDanhSach_TheoPhong(string phongBan)
        {
            int count = 0;
            Console.WriteLine("\nDanh sách theo phòng ban \"{0}\"", phongBan);
            foreach (NhanVien nv in lst)
            {
                //if(phongBan.ToLower() == nv.PhongBan.ToLower())
                if(phongBan.Equals(nv.PhongBan) == true)
                {
                    nv.xuatThongTin();
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("==> Không tìm thấy !!!");
            }    
        }
        public void danhSachNhanVien_LanhDao()
        {
            Console.WriteLine("{0,-6}|{1,-15}|{2,-20}|{3,-10}|{4,11}|{5,16}|{6,13}|{7,8}|{8,10}", "Mã NV", "Họ Tên", "Phòng Ban", "Chức Vụ", "Hệ Số Lương", "Số Ngày Làm Việc", "Hệ Số Thi Đua", "Phụ Cấp", "Lương");
            foreach (NhanVien nv in lst)
            {
                if (nv.ChucVu.Equals("Lãnh đạo") == true)
                {
                    nv.xuatThongTin();
                }
            }
        }
        public double tongLuong()
        {
            double sum = 0;
            foreach(NhanVien nv in lst)
            {
                sum += nv.tinhLuong();
            }
            return sum;
        }
        public void loaiBoNhanVien_NgayLamViecNhoHon10()
        {
            lst = lst.Where(t => t.SoNgayLVTrongThang >= 10).ToList();
            Console.WriteLine("Loại bỏ thành công");
        }
        public void xuatDanhSach_ChucVuNhanVien_LamViecHon22Ngay()
        {
            Console.WriteLine("{0,-6}|{1,-15}|{2,-20}|{3,-10}|{4,11}|{5,16}|{6,13}|{7,8}|{8,10}", "Mã NV", "Họ Tên", "Phòng Ban", "Chức Vụ", "Hệ Số Lương", "Số Ngày Làm Việc", "Hệ Số Thi Đua", "Phụ Cấp", "Lương");
            foreach (NhanVien nv in lst)
            {
                if(String.Compare(nv.ChucVu,"Nhân viên") == 0 && nv.SoNgayLVTrongThang > 22)
                {
                    nv.xuatThongTin();
                }
            }    
        }
        public void xuatDanhSach_HSL434_PhongTaiVu()
        {
            Console.WriteLine("{0,-6}|{1,-15}|{2,-20}|{3,-10}|{4,11}|{5,16}|{6,13}|{7,8}|{8,10}", "Mã NV", "Họ Tên", "Phòng Ban", "Chức Vụ", "Hệ Số Lương", "Số Ngày Làm Việc", "Hệ Số Thi Đua", "Phụ Cấp", "Lương");
            foreach (NhanVien nv in lst)
            {
                if(nv.HeSoLuong >= 4.34 && String.Compare(nv.PhongBan, "Tài vụ") == 0)
                {
                    nv.xuatThongTin();
                }
            }
        }
    }
}
