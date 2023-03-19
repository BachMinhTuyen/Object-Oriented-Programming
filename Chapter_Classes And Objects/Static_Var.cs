using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static_Var
{
    class SinhVien // ta muốn quản lý số lượng sinh viên đang có (giả sử đối tượng mới được tạo ra là 1sv)
    {
        private int maSV;
        private string tenSV;
        public int MaSV // khai báo các property tương ứng với các thuộc tính
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public string TENSV //property
        {
            get { return tenSV; }
            set { tenSV = value; }
        }
        public static int tuoi = 20; //khai báo biến tĩnh vì yêu cầu thuộc tính tuổi cho all là 20-->tiết kiệm bộ nhớ
        public static int Dem = 0; // khai báo biến static Dem để chứa số lượng sv hiện tại, mỗi lần có 1 đối tượng tạo ra thì tăng Dem lên 1
        public SinhVien(int maSV, string tenSV) // hàm khởi tạo
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            Dem++;
            //Vì constructor chỉ được gọi khi có đối tượng được tạo ra nên ta sẽ tăng Count ở đây
        }
        public void xuat()
        {
            Console.WriteLine("Tuoi sinh vien {0}, Ten sinh vien {1}, Ma sinh vien {2}", tuoi, tenSV, maSV);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So luong sinh vien ban dau {0}", SinhVien.Dem);
            SinhVien sv1 = new SinhVien(123, "Nguyen Dinh Chieu");
            sv1.xuat();
            SinhVien sv2 = new SinhVien(124, "Nguyen Van Teo");
            sv2.xuat();
            SinhVien sv3 = new SinhVien(125, "Nguyen Chi Pheo");
            sv3.xuat();
            SinhVien sv4 = new SinhVien(126, "Ly Thuong Kiet");
            sv4.xuat();
            Console.WriteLine("So luong sinh vien da khoi tao {0}", SinhVien.Dem);
            Console.ReadLine();
        }
    }
}
