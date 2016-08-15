using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector firstVector = new Vector(5, 6);
            Vector secondVector = new Vector(4, 2);

            Vector thirdVector = new Vector();
            thirdVector = firstVector + secondVector;
            Console.WriteLine(thirdVector.CoordinateX + " " + thirdVector.CoordinateY);
            thirdVector = firstVector - secondVector;
            Console.WriteLine(thirdVector.CoordinateX + " " + thirdVector.CoordinateY);
            int result = firstVector * secondVector;
            Console.WriteLine(result);
            int resultforanotheraction = firstVector * 4;
            Console.WriteLine(resultforanotheraction);


            Console.ReadLine();
        }
    }
}
