using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    public enum CurrencyTypes
    {
        UAH,
        USD,
        EU
    }

    public class MoneyFloat
    {
        public float Amount;
        public CurrencyTypes Currency;
    }

    public class MoneyString
    {
        public string Amount;
        public CurrencyTypes Currency;
    }

    public class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public int Amount;
        public CurrencyTypes Currency;


        // 3) declare parameter constructor for properties initialization
        public Money()
        {

        }


        public Money(int amount, CurrencyTypes currency)
        {
            Amount = amount;
            Currency = currency;
        }

        // 4) declare overloading of operator + to add 2 objects of Money

        public static Money operator +(Money obj1, Money obj2)
        {
            Money arr = new Money();

            if (obj1.Currency == obj2.Currency)
            {
                arr.Amount = obj1.Amount + obj2.Amount;
                arr.Currency = obj1.Currency;
            }
            else
            {
                Console.WriteLine("Different Currency");
            }
            return arr;
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1

        public static Money operator --(Money obj1)
        {
            obj1.Amount -= 1;
            return obj1;
        }

        // 6) declare overloading of operator * to increase object of Money 3 times

        public static Money operator *(Money obj1, int increased)
        {
            obj1.Amount *= increased;
            return obj1;
        }


        // 7) declare overloading of operator > and < to compare 2 objects of Money

        public static bool operator >(Money obj1, Money obj2)
        {
            if (obj1.Amount > obj2.Amount && obj1.Amount == obj2.Amount)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Money obj1, Money obj2)
        {
            if (obj1.Amount < obj2.Amount && obj1.Amount == obj2.Amount)
            {
                return true;
            }
            return false;
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object

        public static bool operator ==(Money obj1, Money obj2)
        {
            if (obj1.Currency == obj2.Currency)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Money obj1, Money obj2)
        {
            if (obj1.Amount != obj2.Amount)
            {
                return true;
            }
            return false;
        }

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa

        public static explicit operator MoneyFloat(Money obj)
        {
            MoneyFloat moneyFloat = new MoneyFloat();
            moneyFloat.Currency = obj.Currency;
            moneyFloat.Amount = obj.Amount;
            return moneyFloat;
        }

        public static implicit operator MoneyString(Money obj)
        {
            MoneyString moneyString = new MoneyString();
            moneyString.Currency = obj.Currency;
            moneyString.Amount = obj.Amount.ToString();
            return moneyString;
        }
    }
}
