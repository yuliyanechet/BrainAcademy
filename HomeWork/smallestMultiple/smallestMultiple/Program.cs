using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int number = 1; ; number++)
            {
                bool state = true;
                foreach (var item in arr)
                {
                    if (number % item != 0)
                    {
                        state = false;
                        break;
                    }

                }

                if(state)
                {
                    Console.WriteLine(number);
                    break;
                }
            }

        }
    }
}
   
