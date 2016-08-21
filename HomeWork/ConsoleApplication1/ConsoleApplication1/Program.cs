using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public  interface NechetNaZlo
    {
        NechetNaZlo()
        {
            Console.WriteLine("dfgsdfg");
        }
        public abstract void Method1();

    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new NechetNaZlo();
        }
    }
}
