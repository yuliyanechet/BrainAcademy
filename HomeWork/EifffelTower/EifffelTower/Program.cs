using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EifffelTower
{
    class Program
    {
        static void Main(string[] args)
        {
            House EiffelTower = new House();
            
            House BigBen = new House();

            PartOfHouse First = new PartOfHouse();
            First.Create();

            Wall FirstWall = new Wall();
            FirstWall.Create();

            Roof FirstRoof = new Roof();
            FirstRoof.Create();




  

        }
    }
}
