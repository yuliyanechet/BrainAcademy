using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Band
    {
        public int Count
        {
            get
            {
                return Stuff.Length;
            }
        }

        public DateTime FoundationDate
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Style
        {
            get
            {
                string result = "";
                foreach (var item in Stuff)
                {
                    if (item is Musician)
                    {
                        var musicianItem = (Musician)item;
                        result += musicianItem.Style + ",";
                    }
                }

                return result;
            }
        }

        public Human[] Stuff;

        public Band(string name, DateTime foundationDate, params Human[] stuff)
        {
            Name = name;
            FoundationDate = foundationDate;
            Stuff = stuff;
        }
    }
}
