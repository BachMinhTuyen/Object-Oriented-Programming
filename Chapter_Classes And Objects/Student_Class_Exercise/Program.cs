using System;
using System.Text;

namespace Student_Class_Exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region Bài 1: Thí Sinh - Student
            //ThiSinh ts = new ThiSinh();
            //ts.nhapThongTin();
            //ts.xuatThongTin();
            #endregion

            #region Bài 2: Danh Sách Thí Sinh - Student List
            DSThiSinh ds = new DSThiSinh();
            ds.nhapDanhSach_TuFileXML("dsThiSinh.xml");
            ds.xuatDanhSach();

            Console.WriteLine("\nDANH SÁCH THÍ SINH ĐẬU");
            ds.xuatDanhSach_ThiSinhDau();

            Console.WriteLine("\nDANH SÁCH TỔNG SỐ THÍ SINH ĐẬU - RỚT");
            ds.dem_ThiSinhDau_ThiSinhRot();

            Console.WriteLine("\nTÌM THÔNG TIN THÍ SINH");
            ds.timThiSinh();

            Console.WriteLine("\nSẮP XẾP DANH SÁCH GIẢM DẦN THEO ĐIỂM TỔNG KẾT");
            ds.sapXepGiamDan_TheoDiemTongKet();
            ds.xuatDanhSach();
            #endregion

            Console.ReadKey();
        }
    }
}