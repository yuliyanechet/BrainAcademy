using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects

            Money money1 = new Money(25, CurrencyTypes.EU);
            Money money2 = new Money(35, CurrencyTypes.EU);

            // 11) do operations
            // add 2 objects of Money

            Money money3 = new Money();
            money3 = money1 + money2;

            // add 1st object of Money and double
            // decrease 2nd object of Money by 1 

            money2--;

            // increase 1st object of Money
            // compare 2 objects of Money

            if (money1 > money2)
            {
                Console.WriteLine("Money2 bigger");
            }

            // compare 2nd object of Money and string
            // check CurrencyType of every object

            Console.WriteLine("Object 1 currency: " + money1.Currency);
            Console.WriteLine("Object 2 currency: " + money2.Currency);
            Console.WriteLine("Object 3 currency: " + money3.Currency);

            // convert 1st object of Money to string

            Console.ReadKey();

        }
    }
}
