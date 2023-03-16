using System;
using System.Text;

namespace OOP_Generic
{
    internal class Program
    {
        public class SinhVien
        {
            private string maSV;
            private string hoTen;
            private float diem;
            public string MaSV { get => maSV; set => maSV = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public float Diem
            {
                get { return diem;}
                set
                {
                    if (value > 10 || value < 0)
                    {
                        Console.WriteLine("\nDiem khong hop le!");
                        //throw new ArgumentOutOfRangeException("Diem khong hop le!");
                    }
                    else
                        diem = value;
                }
            }
            public SinhVien() { }
            public SinhVien(string maSV, string hoTen, float diem)
            {
                MaSV = maSV;
                HoTen = hoTen;
                Diem = diem;
            }
            public void nhapThongTinSinhVien()
            {
                Console.Write("Ma sinh vien: ");
                MaSV = Console.ReadLine();
                Console.Write("Ten sinh vien: ");
                HoTen = Console.ReadLine();
                Console.Write("Diem: ");
                Diem = float.Parse(Console.ReadLine());
            }
            public void xuatThongTinSinhVien()
            {
                Console.WriteLine("\n Ma sinh vien: {0}\n Ten sinh vien: {1}\n Diem sinh vien: {2}\n Xep loai: {3}", maSV, hoTen, diem, xepLoaiHocLuc());
            }
            public string xepLoaiHocLuc()
            {
                string xepLoai = "Xuat Sac";
                if (diem < 4)
                    xepLoai = "Kem";
                else if (diem < 5.5)
                    xepLoai = "Yeu";
                else if (diem < 6.5)
                    xepLoai = "Trung Binh";
                else if (diem < 8)
                    xepLoai = "Kha";
                else if (diem < 9.5)
                    xepLoai = "Gioi";
                return xepLoai;
            }
        }
        public class DanhSachSinhVien
        {
            List<SinhVien> listSV = new List<SinhVien>();
            public void taoDanhSach()
            {
                Console.Write("Nhap so luong sinh vien: ");
                int n = int.Parse(Console.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine("\n-- Sinh vien thu {0} --", i + 1);
                    SinhVien sv = new SinhVien();
                    sv.nhapThongTinSinhVien();
                    listSV.Add(sv);
                }
            }
            public void xuatDanhSach()
            {
                Console.WriteLine("\n---------- Danh Sach Sinh Vien ----------");
                foreach(SinhVien sv in listSV)
                {
                    sv.xuatThongTinSinhVien();
                }    
            }
            public void timSinhVien_DiemHon8()
            {
                Console.WriteLine("\n---------- Danh Sach Sinh Vien ----------");
                foreach (SinhVien sv in listSV)
                {
                    if (sv.Diem > 8)
                        sv.xuatThongTinSinhVien();
                }
            }
            public void timSinhVien_TheoMaSV()
            {
                string maSV;
                Console.Write("\nNhap ma SV can tim: ");
                maSV = Console.ReadLine();

                Console.WriteLine("\n---------- Danh Sach Sinh Vien ----------");
                foreach (SinhVien sv in listSV)
                {
                    if (String.Compare(maSV, sv.MaSV, false) == 0)
                    {
                        sv.xuatThongTinSinhVien();
                    }
                }
            }
            public void xuatSinhVien_DiemKhoangGiuaMinMax()
            {
                float min, max;
                Console.Write("\nNhap diem min: ");
                min = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem max: ");
                max = float.Parse(Console.ReadLine());

                Console.WriteLine("\n---------- Danh Sach Sinh Vien ----------");
                foreach (SinhVien sv in listSV)
                {
                    if (sv.Diem >= min && sv.Diem <= max)
                    {
                        sv.xuatThongTinSinhVien();
                    }
                }
            }
            public void timSinhVien_TheoXepLoai()
            {
                string xepLoai;
                Console.Write("Nhap xep loai can tim: ");
                xepLoai = Console.ReadLine();

                Console.WriteLine("\n---------- Danh Sach Sinh Vien ----------");
                foreach (SinhVien sv in listSV)
                {
                    //So sánh chuỗi:
                    //          true - không phân biệt hoa thường
                    //          false - có phân biệt hoa thường
                    if (String.Compare(xepLoai, sv.xepLoaiHocLuc(), true) == 0)
                    {
                        sv.xuatThongTinSinhVien();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Lệnh hỗ trợ viết tiếng Việt trong C#
            //Console.OutputEncoding = Encoding.UTF8;
            DanhSachSinhVien listSV = new DanhSachSinhVien();
            listSV.taoDanhSach();
            listSV.xuatDanhSach();
            //listSV.timSinhVien_DiemHon8();
            //listSV.timSinhVien_TheoMaSV();
            //listSV.xuatSinhVien_DiemKhoangGiuaMinMax();
            //listSV.timSinhVien_TheoXepLoai();
        }
    }
}