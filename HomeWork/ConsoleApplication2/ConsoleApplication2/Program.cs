using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[8] { 5, 40, 31, 5, 2 , 23, 45, 1};
            MyClass myclass = new MyClass();
            myclass.arr = arr;
            //Console.WriteLine(myclass.arr.Length);
            //myclass.Delete(3);
            //myclass.Delete(1);
            //Console.WriteLine(myclass.arr.Length);

            //myclass.AddRange(new object[4] { 1, 2, 3, 4 });
            //foreach (var item in myclass.arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(myclass.Contain(1));

            //myclass.IndexOf(3);
            myclass.Sort();
        }
    }
}
  