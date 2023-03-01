using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._23_dz
{
    internal class Piece:IDisposable
    {
        string name { get; set; }
        string autor { get; set; }
        string ganre { get; set; }
        DateTime dateTime { get; set; }
        public Piece() { }
        public Piece(string name, string autor, string ganre, DateTime dateTime)
        {
            this.name = name;
            this.autor = autor;
            this.ganre = ganre;
            this.dateTime = dateTime;
        }
        ~Piece() 
        {
            Console.WriteLine("Destuctor");
            Console.Beep();
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed piece");
            Console.Beep(5000,2);
        }
    }
}
