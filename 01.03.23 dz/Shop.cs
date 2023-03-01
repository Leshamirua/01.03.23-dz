using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._23_dz
{
    enum typeofshop { grocery, hardware, clothes, shoes };
    internal class Shop:IDisposable
    {
        string name { get; set; }
        string address { get; set; }
        typeofshop type;
        public Shop() { }
        public Shop(string name, string address, typeofshop type)
        {
            this.name = name;
            this.address = address;
            this.type = type;
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed");
            Console.Beep();
        }
        ~Shop()
        {
            Console.WriteLine("Destructor shop");
            Console.Beep(3000,33);
        }

    }
}
