using System;
using System.Text;

namespace LT_HDT_OnTapLan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            #region Chạy lớp con (subclass)

            ////Code test ràng buộc get, set (giá sách > 10.000)
            //SachCaoCap b = new SachCaoCap("S002", "Lập trình web", "50", 20, 9500, 5000);

            SachCaoCap a = new SachCaoCap("S002", "Lập trình web", "50", 20, 45000, 5000);
            a.xuatThongTin();
            Console.WriteLine("Chi phí: {0}", a.chiPhi());
            Console.WriteLine("Lợi nhuận: {0}", a.loiNhuan());
            
            
            #endregion

            Console.ReadKey();
        }
    }
}