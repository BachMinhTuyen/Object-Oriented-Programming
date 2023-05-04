using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class_Exercise
{
    public class ThiSinh
    {
        private string maThiSinh;
        private string hoTen;
        private string gioiTinh;
        private float diemLyThuyet, diemThucHanh;

        public string MaThiSinh { get => maThiSinh; set => maThiSinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public float DiemLyThuyet { get => diemLyThuyet; set => diemLyThuyet = value; }
        public float DiemThucHanh { get => diemThucHanh; set => diemThucHanh = value; }
        public ThiSinh()
        {
            maThiSinh = "";
            hoTen = "";
            gioiTinh = "";
            diemLyThuyet = diemThucHanh = 0;
        }
        public ThiSinh(ThiSinh a)
        {
            maThiSinh = a.maThiSinh;
            hoTen = a.hoTen;
            gioiTinh = a.gioiTinh;
            diemLyThuyet = a.diemLyThuyet;
            diemThucHanh = a.diemThucHanh;
        }
        public ThiSinh(string maThiSinh, string hoTen, string gioiTinh, float diemLyThuyet,float diemThucHanh)
        {
            this.maThiSinh = maThiSinh;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diemLyThuyet = diemLyThuyet;
            this.diemThucHanh = diemThucHanh;
        }
        public float diemTongKet()
        {
            return (diemLyThuyet + diemThucHanh) / 2;
        }
        public string xetTuyen()
        {
            if (diemTongKet() >= 5 && diemLyThuyet >= 5 && diemThucHanh >= 5)
                return "Đậu";
            else
                return "Rớt";
        }
        public void nhapThongTin()
        {
            Console.Write("Nhập mã số thí sinh: ");
            maThiSinh = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            gioiTinh = Console.ReadLine();
            Console.Write("Nhập điểm lý thuyết: ");
            diemLyThuyet = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm thực hành: ");
            diemThucHanh = float.Parse(Console.ReadLine());
        }
        public void xuatThongTin()
        {
            Console.WriteLine("{0,-10}|{1,-20}|{2,-10}|{3,15}|{4,15}|{5,10}|{6,10}", maThiSinh, hoTen, gioiTinh, diemLyThuyet, diemThucHanh, diemTongKet(), xetTuyen());
        }
    }
}