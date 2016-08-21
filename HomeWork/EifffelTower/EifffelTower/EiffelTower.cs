using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EifffelTower
{
    public enum Color { red, blue, white };
    public enum Material { concrete, gypsum_plasterboard };

    public class PartOfHouse
    {
        public int width;
        public int height;

        public virtual void Create() { Console.WriteLine("You can create"); }


    }

    public class Wall : PartOfHouse
    {
        Color Color;
        Material Material;

        public override void Create() { Console.WriteLine("You can create wall"); }
    }

    public class Roof : PartOfHouse
    {
       public int strength;

       public override void Create() { Console.WriteLine("You can create roof"); }

    }

    public class House
    {
        public Wall Wall;
        public Roof Roof;
    }


}









