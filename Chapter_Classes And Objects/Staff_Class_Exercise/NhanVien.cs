using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Class_Exercise
{
    public class NhanVien
    {
        string maNV, tenNV, phongBan, chucVu;
        float heSoLuong;
        int thamNienCongTac, soNgayLVTrongThang;
        static float luongCB = 1210f;
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string ChucVu
        {
            get { return  chucVu;}
            set
            {
                if(value.Equals("Lãnh đạo") == true)
                {
                    chucVu = value;
                }
                else
                {
                    chucVu = value;
                }    
            }
        }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int ThamNienCongTac { get => thamNienCongTac; set => thamNienCongTac = value; }
        public int SoNgayLVTrongThang { get => soNgayLVTrongThang; set => soNgayLVTrongThang = value; }
        public float HeSoThiDua
        {
            get
            {
                if (chucVu.Equals("Lãnh đạo"))
                    return 1;
                else
                {
                    if (soNgayLVTrongThang > 22)
                        return 1.0f;
                    else if (soNgayLVTrongThang > 20)
                        return 0.8f;
                    else
                        return 0.6f;
                }
            }
        }
        public int PhuCap
        {
            get
            {
                if (chucVu.Equals("Lãnh đạo"))
                    return 2000;
                else
                    return 0;
            }
        }
        public double tinhLuong()
        {
            return heSoLuong * luongCB * HeSoThiDua + 1100 + PhuCap;
        }
        public void xuatThongTin()
        {
            Console.WriteLine("{0,-6}|{1,-15}|{2,-20}|{3,-10}|{4,11}|{5,16}|{6,13}|{7,8}|{8,10:F2}", maNV, tenNV, phongBan, chucVu, heSoLuong, soNgayLVTrongThang, HeSoThiDua, PhuCap, tinhLuong());
        }
    }
}
