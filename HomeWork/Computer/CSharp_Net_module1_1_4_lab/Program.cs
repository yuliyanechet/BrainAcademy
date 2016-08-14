using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType
        public enum ComputerType
        {
            Desctop,
            Laptop,
            Server
        }


        // 2) declare struct Computer

        struct Computer
        {
            public int CPUcount;
            public double HGz;
            public int Memory;
            public int HDD;
            public ComputerType ComputerType;

            public Computer(ComputerType compType, int cpu, double HGz, int memory, int HDD)
            {
                CPUcount = cpu;
                this.HGz = HGz;
                Memory = memory;
                this.HDD = HDD;
                ComputerType = compType;
            }
        }


        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] department = new Computer[4][];


            // 4) set the size of every array in jagged array (number of computers)

            department[0] = new Computer[5];
            department[1] = new Computer[3];
            department[2] = new Computer[5];
            department[3] = new Computer[4];


            // 5) initialize array
            // Note: use loops and if-else statements


            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    department[i][0] = new Computer(ComputerType.Desctop, 4, 2.5, 6, 500);
                    department[i][1] = new Computer(ComputerType.Desctop, 4, 2.5, 6, 500);
                    department[i][2] = new Computer(ComputerType.Laptop, 2, 1.7, 4, 250);
                    department[i][3] = new Computer(ComputerType.Laptop, 2, 1.7, 4, 250);
                    department[i][4] = new Computer(ComputerType.Server, 8, 3.0, 16, 2000);
                }

                if (i == 1)
                {
                    department[i][0] = new Computer(ComputerType.Laptop, 2, 1.7, 4, 250);
                    department[i][1] = new Computer(ComputerType.Laptop, 2, 1.7, 4, 250);
                    department[i][2] = new Computer(ComputerType.Laptop, 2, 1.7, 4, 250);
                }
                if (i == 2)
                {
                    department[i][0] = new Computer(ComputerType.Desctop, 4, 2.5, 6, 500);
                    department[i][1] = new Computer(ComputerType.Desctop, 4, 2.5, 6, 500);
                    department[i][2] = new Computer(ComputerType.Desctop, 4, 2.5, 6, 500);
                    department[i][3] = new Computer(ComputerType.Laptop, 2, 1.7, 4, 250);
                    department[i][4] = new Computer(ComputerType.Laptop, 2, 1.7, 4, 250);
                }
                if (i == 3)
                {

                    department[i][0] = new Computer(ComputerType.Desctop, 4, 2.5, 6, 500);
                    department[i][1] = new Computer(ComputerType.Laptop, 2, 1.7, 4, 250);
                    department[i][2] = new Computer(ComputerType.Server, 8, 3.0, 16, 2000);
                    department[i][3] = new Computer(ComputerType.Server, 8, 3.0, 16, 2000);
                }
            }


            // 6) count total number of every type of computers
            int countDesctop = 0;
            int countLaptop = 0;
            int countServer = 0;


            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (department[i][j].ComputerType == ComputerType.Desctop)
                    {
                        countDesctop++;
                    }
                    if (department[i][j].ComputerType == ComputerType.Laptop)
                    {
                        countLaptop++;
                    }
                    if (department[i][j].ComputerType == ComputerType.Server)
                    {
                        countServer++;
                    }
                }
            }

            Console.WriteLine("Total desctop number: " + countDesctop);
            Console.WriteLine("Total laptop number: " + countLaptop);
            Console.WriteLine("Total server number: " + countServer);

            // 7) count total number of all computers
            // Note: use loops and if-else statements
            //// Note: use the same loop for 6) and 7)

            int totalsum = 0;

            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    totalsum++;
                }
            }
            Console.WriteLine("Total Summ is: " + totalsum);


            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements


            int maxHDD = 0;

            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (maxHDD < department[i][j].HDD)
                    {
                        maxHDD = department[i][j].HDD;

                    }

                }
            }

            Console.WriteLine("Max HDD: " + maxHDD);
            Console.WriteLine("The indexes of computer with the largest storage (HDD): ");


            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (maxHDD == department[i][j].HDD)
                    {

                        Console.WriteLine(i + " " + j);
                    }

                }
            }

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            int minCpu = 0;
            int minmemory = 0;


            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (minCpu < department[i][j].CPUcount && minmemory < department[i][j].Memory)
                    {

                        minCpu = department[i][j].CPUcount;
                        minmemory = department[i][j].Memory;
                    }

                }
            }

            Console.WriteLine("The index of computer with the lowest productivity (CPU and memory): ");
            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (minCpu == department[i][j].CPUcount && minmemory == department[i][j].Memory)
                    {

                        Console.WriteLine(i + " " + j);
                    }

                }
            }

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (department[i][j].ComputerType == ComputerType.Desctop)
                    {
                        department[i][j].Memory = 8;
                    }

                }
            }

            Console.ReadKey();
        }


    }
}





















