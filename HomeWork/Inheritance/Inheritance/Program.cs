using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var band = new Band("CSharp-2016-3", new DateTime(2016, 07, 27), 
                new Human(new DateTime(), new Address("Country1", "City1", "Street1", 10, 10)),
                new Musician(new DateTime(), new Address("Country1", "City1", "Street1", 10, 11))
                {
                    Name = "Mike Jagger",
                    Tool = MusicTool.Vocal,
                    Education = "Oxford",
                });
            Console.WriteLine("Band: {0}, founded in {1}", band.Name, band.FoundationDate);
            Console.WriteLine("Number of players: {0}", band.Count);

            Musician homelessMusician = new Musician(new DateTime(), new Address("Country1", "City1", "Street1", 10, 11))
            {
                Name = "Mickel Jackson",
                Tool = MusicTool.Vocal,
                Education = "Harvard",
            };

            DoSomethingWithHuman(homelessMusician);

            foreach (var item in band.Stuff)
                DoSomethingWithHuman(item);

            Human entity = new Musician(DateTime.Now, new Address());
        }

        static void DoSomethingWithHuman(Human human)
        {
            human.Walk();
            (human as Musician)?.Sing();
            human.Die();
        }
    }
}
