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
            string choice;
            Flight[] arrivals = new Flight[]
                {
                new Flight(Convert.ToDateTime("21/08/2016 23:29:50.42"), 5, "Antalia", "Air Alps Aviation", 1, Status.Arrived),
                new Flight(Convert.ToDateTime("13/08/2016 15:50:50.42"), 5, "Rimini", "Air Berlin", 2, Status.Delayed),
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

            while (true)
            {
                Console.WriteLine("Please choose the action: ");
                Console.WriteLine("1 - show the panel");
                Console.WriteLine("2 - input information");
                Console.WriteLine("3 - edit information");
                Console.WriteLine("4 - delete information");
                Console.WriteLine("5 - search by");
                Console.WriteLine("6 - search the nearest flight");
                Console.WriteLine();
                bool noResultFound = true;
                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    #region ShowPannel 
                    case "1":
                        Console.WriteLine(new string('-', 96));
                        Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                        Console.WriteLine(new string('-', 96));
                        Console.WriteLine("|" + "Arrivals".PadRight(94) + "|");
                        Console.WriteLine(new string('-', 96));
                        foreach (var line in arrivals)
                        {
                            string output = "|";
                            output += (line.Date.ToString()).PadRight(20) + "|";
                            output += (line.Number.ToString()).PadRight(7) + "|";
                            output += (line.City.ToString()).PadRight(15) + "|";
                            output += (line.Airline.ToString()).PadRight(23) + "|";
                            output += (line.Terminal.ToString()).PadRight(9) + "|";
                            output += (line.Status.ToString()).PadRight(15) + "|";
                            Console.WriteLine(output);
                        }
                        Console.WriteLine(new string('-', 96));
                        Console.WriteLine("|" + "Departures".PadRight(94) + "|");
                        Console.WriteLine(new string('-', 96));
                        foreach (var line in departures)
                        {
                            string output = "|";
                            output += (line.Date.ToString()).PadRight(20) + "|";
                            output += (line.Number.ToString()).PadRight(7) + "|";
                            output += (line.City.ToString()).PadRight(15) + "|";
                            output += (line.Airline.ToString()).PadRight(23) + "|";
                            output += (line.Terminal.ToString()).PadRight(9) + "|";
                            output += (line.Status.ToString()).PadRight(15) + "|";
                            Console.WriteLine(output);
                        }
                        Console.WriteLine(new string('-', 96));
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    #endregion

                    #region AddInfo
                    case "2":
                        string panelChoice;
                        Console.WriteLine("Please enter:");
                        Console.WriteLine("1 - for adding new flight to arrivels panel");
                        Console.WriteLine("2 - for adding new flight to departures panel");
                        panelChoice = Console.ReadLine();
                        Flight userFlight = new Flight();
                        Console.WriteLine("Enter date/time in the folowing format dd/mm/yyyy hh:mm:ss");
                        userFlight.Date = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter flight number");
                        userFlight.Number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter City");
                        userFlight.City = Console.ReadLine();
                        Console.WriteLine("Enter Airline");
                        userFlight.Airline = Console.ReadLine();
                        Console.WriteLine("Enter Terminal");
                        userFlight.Terminal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter Status:");
                        Console.WriteLine("1 - Check_in");
                        Console.WriteLine("2 - GateClosed");
                        Console.WriteLine("3 - Arrived");
                        Console.WriteLine("4 - Departed_at");
                        Console.WriteLine("5 - Unknown");
                        Console.WriteLine("6 - Canceled");
                        Console.WriteLine("7 - Expected_at");
                        Console.WriteLine("8 - Delayed");
                        Console.WriteLine("9 - In_flight");
                        string tempStatus = Console.ReadLine();
                        var statusForAddInfo = new Status[] { Status.Check_in, Status.GateClosed, Status.Arrived, Status.Departed_at, Status.Unknown, Status.Canceled, Status.Expected_at, Status.Delayed, Status.In_flight };

                        if (tempStatus != "")
                        {
                            userFlight.Status = statusForAddInfo[Int32.Parse(tempStatus) - 1];
                        }

                        Console.WriteLine(new string('-', 96));
                        if (panelChoice == "1")
                        {
                            Flight[] arrTemp = new Flight[arrivals.Length + 1];
                            for (int i = 0; i < arrivals.Length; i++)
                            {
                                arrTemp[i] = arrivals[i];
                            }
                            arrTemp[arrivals.Length] = userFlight;
                            arrivals = arrTemp;
                        }
                        if (panelChoice == "2")
                        {
                            Flight[] arrTemp = new Flight[departures.Length + 1];
                            for (int i = 0; i < departures.Length; i++)
                            {
                                arrTemp[i] = departures[i];
                            }
                            arrTemp[departures.Length] = userFlight;
                            departures = arrTemp;
                        }
                        Console.WriteLine();
                        Console.WriteLine("New flight has been succesfully added");
                        Console.WriteLine();
                        break;
                    #endregion

                    #region EditInfo
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Enter flight number you want to edit: ");
                        int editFlifghtNumber = Convert.ToInt32(Console.ReadLine());
                        noResultFound = true;
                        Flight currentFlight = arrivals[0];
                        bool isFirst = false;
                        int count = 0;
                        int longestLenght = arrivals.Length > departures.Length ? arrivals.Length : departures.Length;
                        for (int i = 0; i < longestLenght; i++)
                        {
                            if (i < arrivals.Length && editFlifghtNumber == arrivals[i].Number)
                            {
                                noResultFound = false;
                                currentFlight = arrivals[i];
                                count = i;
                                isFirst = true;
                                break;
                            }
                            if (i < departures.Length && editFlifghtNumber == departures[i].Number)
                            {
                                noResultFound = false;
                                currentFlight = departures[i];
                                count = i;
                                break;
                            }
                        }
                        if (!noResultFound)
                        {
                            Console.WriteLine("Enter new Data value in the folowing format dd/mm/yyyy hh:mm:ss or click Enter to skip");
                            string newDate = Console.ReadLine();
                            if (newDate != "")
                            {
                                currentFlight.Date = Convert.ToDateTime(newDate);
                            }
                            Console.WriteLine("Enter new flight Number or click Enter to skip");
                            string newNumber = Console.ReadLine();
                            if (newNumber != "")
                            {
                                currentFlight.Number = Convert.ToInt32(newNumber);
                            }
                            Console.WriteLine("Enter new City or click Enter to skip");
                            string newCity = Console.ReadLine();
                            if (newCity != "")
                            {
                                currentFlight.City = newCity;
                            }
                            Console.WriteLine("Enter new Airline or click Enter to skip");
                            string newAirline = Console.ReadLine();
                            if (newAirline != "")
                            {
                                currentFlight.Airline = newAirline;
                            }
                            Console.WriteLine("Enter new Terminal or click Enter to skip");
                            string newTerminal = Console.ReadLine();
                            if (newTerminal != "")
                            {
                                currentFlight.Terminal = Convert.ToInt32(newTerminal);
                            }
                            Console.WriteLine("Please enter Status:");
                            Console.WriteLine("1 - Check_in");
                            Console.WriteLine("2 - GateClosed");
                            Console.WriteLine("3 - Arrived");
                            Console.WriteLine("4 - Departed_at");
                            Console.WriteLine("5 - Unknown");
                            Console.WriteLine("6 - Canceled");
                            Console.WriteLine("7 - Expected_at");
                            Console.WriteLine("8 - Delayed");
                            Console.WriteLine("9 - In_flight");
                            string newStatus = Console.ReadLine();

                            var statusForEditInfo = new Status[] { Status.Check_in, Status.GateClosed, Status.Arrived, Status.Departed_at, Status.Unknown, Status.Canceled, Status.Expected_at, Status.Delayed, Status.In_flight };

                            if (newStatus != "")
                            {
                                currentFlight.Status = statusForEditInfo[Int32.Parse(newStatus) - 1];
                            }
                            if (isFirst)
                            {
                                arrivals[count] = currentFlight;
                            }
                            else
                            {
                                departures[count] = currentFlight;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Results Found");
                        }

                        break;
                    #endregion

                    #region DeleteInfo
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("Enter flight number you want to delete: ");
                        int deleteFlifghtNumber = Convert.ToInt32(Console.ReadLine());
                        noResultFound = true;
                        for (int i = 0; i < arrivals.Length; i++)
                        {
                            if (arrivals[i].Number == deleteFlifghtNumber)
                            {
                                noResultFound = false;
                                Flight[] arrTempDelete = new Flight[arrivals.Length - 1];
                                int reserved = 0;
                                for (int j = 0; j < arrivals.Length; j++)
                                {
                                    if (j != i)
                                    {
                                        arrTempDelete[reserved] = arrivals[j];
                                        reserved++;
                                    }
                                }
                                arrivals = arrTempDelete;
                                Console.WriteLine();
                                Console.WriteLine("The flight has been succesfully deleted");
                                Console.WriteLine();
                                break;
                            }
                        }
                        for (int i = 0; i < departures.Length; i++)
                        {
                            if (departures[i].Number == deleteFlifghtNumber)
                            {
                                noResultFound = false;
                                Flight[] arrTempDelete = new Flight[departures.Length - 1];
                                int reserved = 0;
                                for (int j = 0; j < departures.Length; j++)
                                {
                                    if (j != i)
                                    {
                                        arrTempDelete[reserved] = departures[j];
                                        reserved++;
                                    }
                                }
                                departures = arrTempDelete;
                                Console.WriteLine();
                                Console.WriteLine("The flight has been succesfully deleted");
                                Console.WriteLine();
                                break;
                            }
                        }
                        if (noResultFound)
                        {
                            Console.WriteLine("No Results Found");
                        }
                        break;
                    #endregion

                    #region SearchBy
                    case "5":
                        Console.WriteLine("Choose the parameter for searching: ");
                        Console.WriteLine("1 - by flight number");
                        Console.WriteLine("2 - by time");
                        Console.WriteLine("3 - by city");
                        string searchParam = Console.ReadLine();
                        noResultFound = true;
                        switch (searchParam)
                        {
                            #region SearchbyNumber
                            case "1":
                                Console.WriteLine("Please enter the flight number");
                                int searhNumber = Convert.ToInt32(Console.ReadLine());
                                for (int x = 0; x < arrivals.Length; x++)
                                {
                                    if (arrivals[x].Number == searhNumber)
                                    {
                                        noResultFound = false;
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Arrivals".PadRight(94) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        string output = "|";
                                        output += (arrivals[x].Date.ToString()).PadRight(20) + "|";
                                        output += (arrivals[x].Number.ToString()).PadRight(7) + "|";
                                        output += (arrivals[x].City.ToString()).PadRight(15) + "|";
                                        output += (arrivals[x].Airline.ToString()).PadRight(23) + "|";
                                        output += (arrivals[x].Terminal.ToString()).PadRight(9) + "|";
                                        output += (arrivals[x].Status.ToString()).PadRight(15) + "|";
                                        Console.WriteLine(output);
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine();
                                        Console.WriteLine();
                                    }
                                }
                                for (int x = 0; x < departures.Length; x++)
                                {
                                    if (departures[x].Number == searhNumber)
                                    {
                                        noResultFound = false;
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Departures".PadRight(94) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        string output = "|";
                                        output += (departures[x].Date.ToString()).PadRight(20) + "|";
                                        output += (departures[x].Number.ToString()).PadRight(7) + "|";
                                        output += (departures[x].City.ToString()).PadRight(15) + "|";
                                        output += (departures[x].Airline.ToString()).PadRight(23) + "|";
                                        output += (departures[x].Terminal.ToString()).PadRight(9) + "|";
                                        output += (departures[x].Status.ToString()).PadRight(15) + "|";
                                        Console.WriteLine(output);
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine();
                                        Console.WriteLine();
                                    }
                                }
                                if (noResultFound)
                                {
                                    Console.WriteLine("No Results Found");
                                }
                                break;
                            #endregion

                            #region SearchByDate
                            case "2":
                                Console.WriteLine("Please enter date and time in the following format dd/mm/yyyy hh:mm:ss");
                                DateTime searhDate = Convert.ToDateTime(Console.ReadLine());
                                noResultFound = true;
                                for (int x = 0; x < arrivals.Length; x++)
                                {
                                    if (arrivals[x].Date == searhDate)
                                    {
                                        noResultFound = false;
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Arrivals".PadRight(94) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        string output = "|";
                                        output += (arrivals[x].Date.ToString()).PadRight(20) + "|";
                                        output += (arrivals[x].Number.ToString()).PadRight(7) + "|";
                                        output += (arrivals[x].City.ToString()).PadRight(15) + "|";
                                        output += (arrivals[x].Airline.ToString()).PadRight(23) + "|";
                                        output += (arrivals[x].Terminal.ToString()).PadRight(9) + "|";
                                        output += (arrivals[x].Status.ToString()).PadRight(15) + "|";
                                        Console.WriteLine(output);
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine();
                                        Console.WriteLine();
                                    }
                                }
                                for (int x = 0; x < departures.Length; x++)
                                {
                                    if (departures[x].Date == searhDate)
                                    {
                                        noResultFound = false;
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Departures".PadRight(94) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        string output = "|";
                                        output += (departures[x].Date.ToString()).PadRight(20) + "|";
                                        output += (departures[x].Number.ToString()).PadRight(7) + "|";
                                        output += (departures[x].City.ToString()).PadRight(15) + "|";
                                        output += (departures[x].Airline.ToString()).PadRight(23) + "|";
                                        output += (departures[x].Terminal.ToString()).PadRight(9) + "|";
                                        output += (departures[x].Status.ToString()).PadRight(15) + "|";
                                        Console.WriteLine(output);
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine();
                                        Console.WriteLine();
                                    }
                                }
                                if (noResultFound)
                                {
                                    Console.WriteLine("No Results Found");
                                }
                                break;
                            #endregion

                            #region SearchbyCity
                            case "3":
                                Console.WriteLine("Please enter City");
                                string searhCity = Console.ReadLine();
                                noResultFound = true;
                                for (int x = 0; x < arrivals.Length; x++)
                                {
                                    if (arrivals[x].City == searhCity)
                                    {
                                        noResultFound = false;
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Arrivals".PadRight(94) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        string output = "|";
                                        output += (arrivals[x].Date.ToString()).PadRight(20) + "|";
                                        output += (arrivals[x].Number.ToString()).PadRight(7) + "|";
                                        output += (arrivals[x].City.ToString()).PadRight(15) + "|";
                                        output += (arrivals[x].Airline.ToString()).PadRight(23) + "|";
                                        output += (arrivals[x].Terminal.ToString()).PadRight(9) + "|";
                                        output += (arrivals[x].Status.ToString()).PadRight(15) + "|";
                                        Console.WriteLine(output);
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine();
                                        Console.WriteLine();
                                    }
                                }
                                for (int x = 0; x < departures.Length; x++)
                                {
                                    if (departures[x].City == searhCity)
                                    {
                                        noResultFound = false;
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine("|" + "Departures".PadRight(94) + "|");
                                        Console.WriteLine(new string('-', 96));
                                        string output = "|";
                                        output += (departures[x].Date.ToString()).PadRight(20) + "|";
                                        output += (departures[x].Number.ToString()).PadRight(7) + "|";
                                        output += (departures[x].City.ToString()).PadRight(15) + "|";
                                        output += (departures[x].Airline.ToString()).PadRight(23) + "|";
                                        output += (departures[x].Terminal.ToString()).PadRight(9) + "|";
                                        output += (departures[x].Status.ToString()).PadRight(15) + "|";
                                        Console.WriteLine(output);
                                        Console.WriteLine(new string('-', 96));
                                        Console.WriteLine();
                                        Console.WriteLine();
                                    }
                                }
                                if (noResultFound)
                                {
                                    Console.WriteLine("No Results Found");
                                }
                                break;
                                #endregion
                        }
                        break;
                    #endregion

                    #region SearchNearest
                    case "6":
                        Console.WriteLine("Please enter date and time in the following format dd/mm/yyyy hh:mm:ss");
                        DateTime searchDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Please enter the Cite departure/arrival");
                        string searhCityForNearestRace = Console.ReadLine();
                        noResultFound = true;

                        for (int y = 0; y < arrivals.Length; y++)
                        {
                            if (searchDate.AddHours(1) > arrivals[y].Date && searchDate.AddHours(-1) < arrivals[y].Date && arrivals[y].City == searhCityForNearestRace)
                            {
                                noResultFound = false;
                                Console.WriteLine(new string('-', 96));
                                Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                                Console.WriteLine(new string('-', 96));
                                Console.WriteLine("|" + "Arrivals".PadRight(94) + "|");
                                Console.WriteLine(new string('-', 96));
                                string output = "|";
                                output += (arrivals[y].Date.ToString()).PadRight(20) + "|";
                                output += (arrivals[y].Number.ToString()).PadRight(7) + "|";
                                output += (arrivals[y].City.ToString()).PadRight(15) + "|";
                                output += (arrivals[y].Airline.ToString()).PadRight(23) + "|";
                                output += (arrivals[y].Terminal.ToString()).PadRight(9) + "|";
                                output += (arrivals[y].Status.ToString()).PadRight(15) + "|";
                                Console.WriteLine(output);
                                Console.WriteLine(new string('-', 96));
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        for (int x = 0; x < departures.Length; x++)
                        {
                            if (searchDate.AddHours(1) > departures[x].Date && searchDate.AddHours(-1) < departures[x].Date && departures[x].City == searhCityForNearestRace)
                            {
                                noResultFound = false;
                                Console.WriteLine(new string('-', 96));
                                Console.WriteLine("|" + "Date".PadRight(20) + "|" + "Number".PadRight(7) + "|" + "City".PadRight(15) + "|" + "Airline".PadRight(23) + "|" + "Terminal".PadRight(9) + "|" + "Status".PadRight(15) + "|");
                                Console.WriteLine(new string('-', 96));
                                Console.WriteLine("|" + "Departures".PadRight(94) + "|");
                                Console.WriteLine(new string('-', 96));
                                string output = "|";
                                output += (departures[x].Date.ToString()).PadRight(20) + "|";
                                output += (departures[x].Number.ToString()).PadRight(7) + "|";
                                output += (departures[x].City.ToString()).PadRight(15) + "|";
                                output += (departures[x].Airline.ToString()).PadRight(23) + "|";
                                output += (departures[x].Terminal.ToString()).PadRight(9) + "|";
                                output += (departures[x].Status.ToString()).PadRight(15) + "|";
                                Console.WriteLine(output);
                                Console.WriteLine(new string('-', 96));
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                        }
                        if (noResultFound)
                        {
                            Console.WriteLine("No Results Found");
                        }
                        break;
                        #endregion
                }
            }
        }
    }
}

