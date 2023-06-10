using System;
using System.Text;

namespace HopDongCaSi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region Biểu diễn tại nhà

            BieuDienTaiNha a = new BieuDienTaiNha("HD0001","Lý Vẫn Không Hay", 3000000, 2, new DateTime(2022,04,12), 2000000, 35);
            a.xuatThongTin();
            Console.WriteLine("Phí quảng cáo: {0}", a.phiQuangCao());
            Console.WriteLine("Thành tiền: {0}", a.thanhTien());
            Console.WriteLine("Thuế: {0}", a.Thue());

            #endregion

            #region Biểu diễn tại rạp nhỏ

            BieuDienTaiRapNho b = new BieuDienTaiRapNho("HD0002", "Lý Cũng Không Hay", 2000000, 3, new DateTime(2023, 01, 27), 1000000, 2);
            b.xuatThongTin();
            Console.WriteLine("Phí quảng cáo: {0}", b.phiQuangCao());
            Console.WriteLine("Thành tiền: {0}", b.thanhTien());
            Console.WriteLine("Thuế: {0}", b.Thue());
            Console.WriteLine("Chính sách hỗ trợ: {0}", b.chinhSachHoTro());

            #endregion

            #region Biểu diễn tại rạp lớn

            BieuDienTaiRapLon c = new BieuDienTaiRapLon("HD0003", "Lý Còn Không Hay", 5000000, 5, new DateTime(2022, 08, 19), 3500000, 2250000);
            c.xuatThongTin();
            Console.WriteLine("Phí quảng cáo: {0}", c.phiQuangCao());
            Console.WriteLine("Thành tiền: {0}", c.thanhTien());
            Console.WriteLine("Thuế: {0}", c.Thue());
            Console.WriteLine("Chính sách hỗ trợ: {0}", c.chinhSachHoTro());

            #endregion

            Console.ReadKey();
        }
    }
}