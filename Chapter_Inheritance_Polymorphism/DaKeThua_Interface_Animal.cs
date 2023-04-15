using System;

namespace OOP_DaKeThua
{
    internal class Program
    {
        public interface ITrenCan
        {
            public void nhay();
        }
        public interface IDuoiNuoc
        {
            public void boi();
        }
        public class Ech:ITrenCan, IDuoiNuoc
        {
            public void boi()
            {
                Console.WriteLine("Ech dang boi ...");
            }
            public void nhay()
            {
                Console.WriteLine("Ech dang nhay ...");
            }
        }
        static void Main(string[] args)
        {
            Ech ech01 = new Ech();
            ech01.nhay();
            ech01.boi();
        }
    }
}