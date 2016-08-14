using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        public struct Film
        {
            public string Name;
            public int Year;
            public int Duration;
            public string[] Actors;
        }

        static void Main(string[] args)
        {
            //string text = File.ReadAllText(@"C:\Users\Student\Downloads\data.csv");
            //Console.WriteLine(text);

            Film[] films = new Film[3];
            string line;
            int counter = 1;



            // Read the file and display it line by line.
            StreamReader sr = new StreamReader(@"C:\Users\Philipp\Downloads\data.csv");
            while ((line = sr.ReadLine()) != null)
            {
                string[] arr = line.Split(';');
                Film film = new Film();
                film.Name = arr[0];
                film.Year = int.Parse(arr[1]);
                film.Duration = int.Parse(arr[2]);
                film.Actors = arr[3].Split(',');
                Console.WriteLine("#{0}. Film: {1} ({2})",counter, arr[0], arr[1]);
                Console.WriteLine("\tDuration: {0} minutes", arr[2]);
                Console.WriteLine("\tActors ({0})", film.Actors.Length);
                for (int i=0; i< film.Actors.Length; i++)
                {

                    Console.WriteLine("\t\t#{0}: {1}", i+1, film.Actors[i].Replace("\"", ""));
                }
                counter++;
            }
            



            Console.ReadKey();
        }



    }
}



