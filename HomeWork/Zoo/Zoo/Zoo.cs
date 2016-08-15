using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zoo
    {

    }


    public abstract class Mammals
    {
        public abstract void Walk();
        public virtual void Speed()
        {

        }
    }

    public abstract class Rodents : Mammals
    {
        public override void Walk()
        {
            Console.WriteLine("Mammals can walk, rodents often run");
        }

        public override void Speed()
        {
            Console.WriteLine("Rodents could run with different speed");
        }

        public abstract void Gnaw();
    }

    public abstract class Prey : Mammals
    {
        public override void Walk()
        {
            Console.WriteLine("Mammals can walk, prey often run");
        }      

        public override void Speed()
        {
            Console.WriteLine("Rodents could run with different speed");
        }

        public abstract void Bite();
    }

    public class Hare : Rodents
    {
        public override void Gnaw()
        {
            Console.WriteLine("Hare can gnaw");
        }
    }

    public class Mouse : Rodents
    {
        public override void Gnaw()
        {
            Console.WriteLine("Mouse can gnaw");
        }
    }

    public class Cat : Prey
    {
        public override void Bite()
        {
            Console.WriteLine("Cats can bite");
        }
    }

    public class Canids : Prey
    {
        public override void Bite()
        {
            Console.WriteLine("Canids can bite");
        }
    }


}
