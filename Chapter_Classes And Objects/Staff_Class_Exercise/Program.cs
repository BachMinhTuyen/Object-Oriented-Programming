using System;
using System.Text;

namespace Staff_Class_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            DSNhanVien ds = new DSNhanVien();
            ds.nhapThongTin_TuFileXML("NV.xml");
            ds.xuatDanhSach();

            ds.xuatDanhSachNhom_TheoHeSoThiDua();

            //Tìm danh sách có phòng ban cho trước. Ví dụ là "Kinh tế"
            ds.timDanhSach_TheoPhong("Kinh tế");

            Console.WriteLine("\nLấy ra danh sách các nhân viên có chức vụ \"Lãnh đạo\"");
            ds.danhSachNhanVien_LanhDao();

            Console.WriteLine("\nTổng lương công ty phải trả: {0:F2}", ds.tongLuong());

            Console.WriteLine("\nLấy ra danh sách nhân viên không phải là lãnh đạo và ngày làm việc lớn hơn 22");
            ds.xuatDanhSach_ChucVuNhanVien_LamViecHon22Ngay();

            Console.WriteLine("\nLấy ra danh sách các nhân viên có hệ số lương từ 4.34 trở lên và ở phòng \"Tài vụ\"");
            ds.xuatDanhSach_HSL434_PhongTaiVu();

            Console.Write("\nLoại bỏ nhân viên có ngày làm việc nhỏ hơn 10. ");
            ds.loaiBoNhanVien_NgayLamViecNhoHon10();
            ds.xuatDanhSach();

            Console.ReadKey();
        }
    }
}