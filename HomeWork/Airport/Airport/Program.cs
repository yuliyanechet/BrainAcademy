using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public enum Status
    {
        Check_in,
        GateClosed,
        Arrived,
        Departed_at,
        Unknown,
        Canceled,
        Expected_at,
        Delayed,
        In_flight,
    };


    public struct Flight
    {
        public DateTime Date;
        public int Number;
        public string City;
        public string Airline;
        public int Terminal;
        public Status Status;

        public Flight(DateTime data, int number, string city, string airline, int terminal, Status status)
        {
            Date = data;
            Number = number;
            City = city;
            Airline = airline;
            Terminal = terminal;
            Status = status;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Flight[] arrivals = new Flight[]
            {
                new Flight(Convert.ToDateTime("13/08/2016 14:50:50.42"), 5, "Antalia", "Air Alps Aviation", 1, Status.Arrived),
                new Flight(Convert.ToDateTime("13/08/2016 15:50:50.42"), 526, "Rimini", "Air Berlin", 2, Status.Delayed),
                new Flight(Convert.ToDateTime("13/08/2016 17:20:50.42"), 122, "Krakov", "Air Bucharest", 5, Status.Arrived),
                new Flight(Convert.ToDateTime("13/08/2016 18:25:50.42"), 45, "Stambul", "Air Italy Polska", 6, Status.In_flight),
                new Flight(Convert.ToDateTime("13/08/2016 19:55:50.42"), 55, "Kiev", "Carpatair", 3, Status.In_flight),
                new Flight(Convert.ToDateTime("13/08/2016 22:50:50.42"), 15, "Tivat", "Contact Air Flugdienst", 8, Status.Unknown),
                new Flight(Convert.ToDateTime("13/08/2016 23:55:50.42"), 1, "Dalaman", "Direct Aero Services", 9, Status.In_flight),
            };

            Flight[] departures = new Flight[]
  {
                new Flight(Convert.ToDateTime("13/08/2016 10:50:50.42"), 7, "Dalaman", "Air Italy Polska", 1, Status.Delayed),
                new Flight(Convert.ToDateTime("13/08/2016 11:15:50.42"), 536, "Tivat", "Air Berlin", 2, Status.Expected_at),
                new Flight(Convert.ToDateTime("13/08/2016 12:20:50.42"), 162, "Kiev", "Direct Aero Services", 5, Status.Expected_at),
                new Flight(Convert.ToDateTime("13/08/2016 16:25:50.42"), 6, "Stambul", "Air Italy Polska", 6, Status.Expected_at),
                new Flight(Convert.ToDateTime("13/08/2016 19:55:50.42"), 69, "Krakov", "Carpatair", 3, Status.Expected_at),
                new Flight(Convert.ToDateTime("13/08/2016 22:40:50.42"), 9, "Rimini", "Contact Air Flugdienst", 8, Status.Canceled),
                new Flight(Convert.ToDateTime("13/08/2016 23:50:50.42"), 58, "Antalia", "Direct Aero Services", 9, Status.Arrived),
  };
            for (int i = 0; i < 85; i++)
            {
                Console.Write("—");

            }
            Console.WriteLine();

            Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(8) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(11) + "|");
            for (int i = 0; i < 85; i++)
            {
                Console.Write("—");

            }
            Console.WriteLine();

            Console.WriteLine("|" + "Arrivals".PadRight(83) + "|");

            for (int i = 0; i < 85; i++)
            {
                Console.Write("—");

            }
            Console.WriteLine();


            foreach (var line in arrivals)
            {

                string output = "|";

                output += (line.Date.ToString()).PadRight(20) + "|";
                output += (line.Number.ToString()).PadRight(7) + "|";
                output += (line.City.ToString()).PadRight(8) + "|";
                output += (line.Airline.ToString()).PadRight(23) + "|";
                output += (line.Terminal.ToString()).PadRight(9) + "|";
                output += (line.Status.ToString()).PadRight(11) + "|";
                Console.WriteLine(output);
            }
            for (int i = 0; i < 85; i++)
            {
                Console.Write("—");


            }
            Console.WriteLine();

            Console.WriteLine("|" + "Departures".PadRight(83) + "|");

            for (int i = 0; i < 85; i++)
            {
                Console.Write("—");

            }
            Console.WriteLine();

            foreach (var line in departures)
            {

                string output = "|";

                output += (line.Date.ToString()).PadRight(20) + "|";
                output += (line.Number.ToString()).PadRight(7) + "|";
                output += (line.City.ToString()).PadRight(8) + "|";
                output += (line.Airline.ToString()).PadRight(23) + "|";
                output += (line.Terminal.ToString()).PadRight(9) + "|";
                output += (line.Status.ToString()).PadRight(11) + "|";
                Console.WriteLine(output);
            }
            for (int i = 0; i < 85; i++)
            {
                Console.Write("—");
            }
        }
    }
}
