using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentNumber;
            List<int> found = new List<int>();

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    currentNumber = i * j;
                    string temp = currentNumber.ToString();
                    if (temp.Length == 6)
                    {
                        if (temp.Substring(0, 1) == temp.Substring(5,1) && temp.Substring(1, 1) == temp.Substring(4, 1) && temp.Substring(2, 1) == temp.Substring(3, 1)) 
                        {
                            found.Add(Convert.ToInt32(temp));
                        }
                    }

                  }
            }
            int theBiggest = 0;
            foreach (var item in found)
            {
                if (theBiggest < item)
                {
                    theBiggest = item;
                }
            }
            Console.WriteLine(theBiggest);
        }
    }
}

