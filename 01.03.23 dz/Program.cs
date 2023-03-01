using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._23_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Piece piece = new Piece();
            }
            Console.WriteLine("Over");
            for (int i = 0; i < 3; i++)
            {
                Shop shop = new Shop();
                shop.Dispose();
            }
            Console.WriteLine("Over2");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for(int i= 0; i < 3; i++)
            {
                Piece piece2 = new Piece();
                piece2.Dispose();
            }
            for(int i = 0; i < 3; i++)
            {
                Shop shop3 = new Shop();
            }
        }
    }
}
