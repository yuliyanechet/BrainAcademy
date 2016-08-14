using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] FirstNames = new string[10] { "Святослав", "Самсон", "Степан", "Ксения", "Кристина", "Кира", "Юлия", "Карина", "Алена", "Виктор" };
            string[] LastNames = new string[10] { "Абрамов", "Авдеев", "Агафонов", "Беспалов", "Большаков", "Брагин", "Виноградов", "Воробьёв", "Гущин", "Дроздов" };
            Random random = new Random();
            Watcher[,] cinema = new Watcher[10, 10];
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int value = random.Next(0, 2);
                    if (value == 1)
                    {
                        Watcher watcher = new Watcher();
                        int index = random.Next(0, 10);
                        watcher.FirstName = FirstNames[index];
                        watcher.LastName = LastNames[index];
                        int indexForGender = random.Next(0, 2);
                        watcher.Gender = (gender)indexForGender;
                        watcher.Ages = random.Next(22, 39);
                        cinema[i, j] = watcher;
                        count++;
                    }
                }
            }
            int totalAge = 0;
            int totalmen = 0;
            int totalwomen = 0;
            int totalAgeMen = 0;
            int totalAgeWomen = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (cinema[i, j] != null)
                    {
                        totalAge = totalAge + cinema[i, j].Ages;
                        if (cinema[i, j].Gender == (gender)1)
                        {
                            totalmen++;
                            totalAgeMen = totalAgeMen + cinema[i, j].Ages;
                        }
                        else
                        {
                            totalwomen++;
                            totalAgeWomen = totalAgeWomen + cinema[i, j].Ages;
                        }
                    }
                }
            }
            Console.WriteLine("Watchers in the cinema: " + count);
            Console.WriteLine("Average age is: " + totalAge / count);
            Console.WriteLine("Man count is: " + totalmen);
            Console.WriteLine("Woman count is: " + totalwomen);
            Console.WriteLine("Average man age is: " + totalAgeMen / totalmen);
            Console.WriteLine("Average woman age is: " + totalAgeWomen / totalwomen);
            Console.ReadLine();

        }
    }
}
