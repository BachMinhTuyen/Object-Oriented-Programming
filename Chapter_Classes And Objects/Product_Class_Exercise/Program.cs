using System;
using System.Text;

namespace Product_Warehouse_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region Bài 1: Lớp Sản Phẩm - Product Class
            //SanPham sp = new SanPham();
            //Console.WriteLine("{0,-7}|{1,-20}|{2,10}|{3,10}|{4,10}", "Mã SP", "Tên SP", "Năm SX", "Đơn Giá", "Loại SP");
            //sp.xuatThongTin();
            #endregion

            #region Bài 2: Kho Sản Phẩm - Product Warehouse
            KhoSanPham a = new KhoSanPham();
            a.nhapDanhSach_TuFileXML("KhoSanPham.xml");
            a.xuatDanhSach();

            a.timSanPhamBanNhieuNhat();

            Console.WriteLine("\nDANH SÁCH ĐƯỢC SẮP XẾP GIẢM DẦN THEO ĐƠN GIÁ");
            a.sapXepTangDan_TheoDonGia();
            a.xuatDanhSach();
            #endregion

            Console.ReadKey();
        }
    }
}