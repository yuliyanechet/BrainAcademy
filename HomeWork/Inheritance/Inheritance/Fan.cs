using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Fan: Human
    {
        public Fan(DateTime birthdate, Address birhtplace, params Band[] band)
            :base (birthdate, birhtplace)
        {

        }

        public Band[] Groups { get; set; }


        public void Shout()
        {
            string str = "";
            Console.WriteLine("I can shout");
               
        }
    }
}
