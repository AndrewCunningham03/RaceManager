using com.sun.org.apache.xml.@internal.resolver.helpers;
using NPOI.OpenXmlFormats.Dml;
using System.Diagnostics;
using static com.sun.tools.@internal.xjc.reader.xmlschema.bindinfo.BIConversion;
using static RaceManager.User;

namespace RaceManager
{
    internal class Program
    {
        static List<Event> events = new List<Event>();
        static List<Race> races = new List<Race>();
        static List<Race> racesTwo = new List<Race>();
        static List<Race> racesThree = new List<Race>();

        

        static void Main(string[] args)
        {
            UserManager user = new UserManager();

            Horse horse1 = new Horse("Wizard of odds", 4, "WOO2022", "Heaney Group", "Eoin Powell");
            Horse horse2 = new Horse("Midnight Runner", 7, "MR2019", "Riley Farms", "Liam O'Connor");
            Horse horse3 = new Horse("Blazing Fury", 5, "BF2021", "McCarthy Racing", "Paul McGrath");
            Horse horse4 = new Horse("Silver Bullet", 5, "SB2018", "Murphy Bros", "Declan Finn");
            Horse horse5 = new Horse("Eagle Eye", 3, "EE2022", "Kennedy Farms", "Sean Donnelly");
            Horse horse6 = new Horse("Golden Arrow", 5, "GA2019", "Murphy Bros", "Kevin Daly");
            Horse horse7 = new Horse("Thunderstrike", 7, "TS2020", "Collins Racing", "Ryan Kelly");
            Horse horse8 = new Horse("Wildfire", 9, "WF2021", "Flanagan Stables", "Patrick O'Reilly");
            Horse horse9 = new Horse("Shadow Dancer", 6, "SD2020", "Doyle Equestrian", "Conor Byrne");
            Horse horse10 = new Horse("Highlander", 7, "HL2017", "Gallagher Farms", "Brian Mahon");
            Horse horse11 = new Horse("Lightning Bolt", 5, "LB2021", "Farrell Racing", "Aidan Quinn");
            Horse horse12 = new Horse("Firestorm", 3, "FS2019", "O'Shea Stables", "Cian Keane");
            Horse horse13 = new Horse("Star Voyager", 10, "SV2020", "Ryan Stables", "Brendan Murphy");
            Horse horse14 = new Horse("Ocean Breeze", 8, "OB2021", "Collins Racing", "Fionn Brady");
            Horse horse15 = new Horse("Moonlight Shadow", 5, "MS2018", "Nolan Stables", "James Hughes");
            Horse horse16 = new Horse("Delta Work", 9, "DW2016", "Heaney Group", "Micheal Blaney");
            Horse horse17 = new Horse("Mighty Potter", 6, "MP2020", "Collins Racing", "Jack Collins");
            Horse horse18 = new Horse("Sir Bob", 8, "SB2017", "Murphy Bros", "Gareth Murphy");

            List<Horse> horseListOne = new List<Horse>();
            horseListOne.Add(horse1);
            horseListOne.Add(horse2);
            horseListOne.Add(horse3);

            List<Horse> horseListTwo = new List<Horse>();
            horseListTwo.Add(horse4);
            horseListTwo.Add(horse5);
            horseListTwo.Add(horse6);

            List<Horse> horseListThree = new List<Horse>();
            horseListThree.Add(horse7);
            horseListThree.Add(horse8);
            horseListThree.Add(horse9);

            List<Horse> horseListFour = new List<Horse>();
            horseListFour.Add(horse10);
            horseListFour.Add(horse11);
            horseListFour.Add(horse12);

            List<Horse> horseListFive = new List<Horse>();
            horseListFive.Add(horse13);
            horseListFive.Add(horse14);
            horseListFive.Add(horse15);

            List<Horse> horseListSix = new List<Horse>();
            horseListSix.Add(horse16);
            horseListSix.Add(horse17);
            horseListSix.Add(horse18);

            Race r1 = new Race("race 1", new DateTime(2024, 3, 25, 12, 20, 0), horseListOne);
            Race r2 = new Race("Race 2", new DateTime(2024, 3, 25, 13, 0, 0), horseListTwo);
            Race r3 = new Race("Race 3", new DateTime(2024, 5, 25, 13, 30, 0), horseListThree);
            Race r4 = new Race("Race 4", new DateTime(2024, 5, 25, 14, 0, 0), horseListFour);
            Race r5 = new Race("Race 5", new DateTime(2024, 10, 25, 14, 45, 0), horseListFive);
            Race r6 = new Race("Race 6", new DateTime(2024, 10, 25, 15, 30, 0), horseListSix);


            races.Add(r1);
            races.Add(r2);

            racesTwo.Add(r3);
            racesTwo.Add(r4);

            racesThree.Add(r5);
            racesThree.Add(r6);

            Event event1 = new Event("Easter races", "Fairyhouse", races.Count, races);
            Event event2 = new Event("Irish derby festival", "Galway", racesTwo.Count, racesTwo);
            Event event3 = new Event("October festival", "Curragh", racesThree.Count, racesThree);

            events.Add(event1);
            events.Add(event2);
            events.Add(event3);




            int num = 0;
            while (num != 2)
            {
                String[] array = new String[2];

                array[0] = "1. Register";
                array[1] = "2. Sign in";


                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine("Enter a number");
                String intput = Console.ReadLine();

                num = int.Parse(intput);

                if (num <= 0 || num > array.Length)
                {
                    Console.WriteLine("Number is not on menu");
                }


                switch (num)
                {
                    case 1:
                        if (UserManager.RegisterUser(user))
                        {
                            if (UserManager.Login(user))
                            {
                                switch (user.Type)
                                {
                                    case UserType.Racegoer:
                                        RacegoerMenu();
                                        break;
                                    case UserType.HorseOwner:
                                        HorseOwnerMenu();
                                        break;
                                    case UserType.RaceManager:
                                        RaceManagerMenu();
                                        break;
                                    default:
                                        Console.WriteLine("Unknown user type.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Login failed. Please check your email and password.");
                            }

                        }
                        break;
                    case 2:
                        if (UserManager.Login(user))
                        {
                            switch (user.Type)
                            {
                                case UserType.Racegoer:
                                    RacegoerMenu();
                                    break;
                                case UserType.HorseOwner:
                                    HorseOwnerMenu();
                                    break;
                                case UserType.RaceManager:
                                    RaceManagerMenu();
                                    break;
                                default:
                                    Console.WriteLine("Unknown user type.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Login failed. Please check your email and password.");
                        }
                break;
                    case 6:
                        Console.WriteLine("Please select Number 1 or 2");
                        break;
                
            }
            }
            static void RacegoerMenu()
            {
                int num = 0;
                while (num != 3)
                {
                    String[] array = new String[3];

                    array[0] = "1. View all events";
                    array[1] = "2. Enter name of Event to view Races and the horses";
                    array[2] = "3. Sign out";

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    Console.WriteLine("Enter a number");
                    String intput = Console.ReadLine();

                    num = int.Parse(intput);

                    if (num <= 0 || num > array.Length)
                    {
                        Console.WriteLine("Number is not on menu");
                    }


                    switch (num)
                    {
                        case 1:
                            AllEvents();
                            break;
                        case 2:
                            AllEvents();
                            DisplayAllRacesAndHorsesForEvent();
                            break;
                        case 3:
                            Console.WriteLine("Signing out...");
                            break;
                        default:
                            break;
                    }

                }
            }
            
            static void AllEvents()
            {
                if (events.Count == 0)
                {
                    Console.WriteLine("There are no events available at this time");
                }
                for (int i = 0; i < events.Count; i++)
                {
                    Console.WriteLine(events[i].ToString());
                }
            }
            static void DisplayAllRacesAndHorsesForEvent()
            {
                Console.WriteLine("Enter event name of races you want to view");
                String eventName = Console.ReadLine();
                Event selectedEvent = events.FirstOrDefault(x => x.Name.ToLower() == eventName.ToLower());
                if (selectedEvent == null)
                {
                    Console.WriteLine("Event not found.Please re-enter");
                    return;
                }
                Console.WriteLine($"Races for the event: {selectedEvent.Name}");
                if (selectedEvent.NumberOfRaces == 0)
                {
                    Console.WriteLine("No races available for this event.");
                }
                else
                {
                    Console.WriteLine("Races in this event:");
                    foreach (Race race in selectedEvent.Racelist)
                    {
                        Console.WriteLine(race.ToString());

                        if (race.HorseList.Count == 0)
                        {
                            Console.WriteLine("No horses are entered in this race.");
                        }
                        else
                        {
                            Console.WriteLine("Horses in this race:");
                            foreach (Horse horse in race.HorseList)
                            {
                                Console.WriteLine(horse.ToString());
                            }
                        }
                    }
                }
            }
            static void HorseOwnerMenu()
            {
                AllEvents();
                Console.WriteLine("Enter name of event you would like to your horse to");
                String eventName = Console.ReadLine();
                Event selectedEvent = events.FirstOrDefault(x => x.Name.ToLower() == eventName.ToLower());
                if (selectedEvent == null)
                {
                    Console.WriteLine("Event not found.Please re-enter");
                    return;
                }
                Console.WriteLine($"Races for the event: {selectedEvent.Name}");
                if (selectedEvent.NumberOfRaces == 0)
                {
                    Console.WriteLine("No races available for this event.");
                }
                else
                {
                    Console.WriteLine("Races in this event:");
                    foreach (Race race in selectedEvent.Racelist)
                    {
                        Console.WriteLine(race.ToString());
                    }
                }
                Console.WriteLine("Enter name of race you want to enter horse into");
                String raceName = Console.ReadLine();

                Race selectRace = selectedEvent.Racelist.FirstOrDefault(r => r.RaceName.ToLower() == raceName.ToLower());

                if (selectRace == null)
                {
                    Console.WriteLine("Race not found.Please re-enter");
                    return;
                }
                Console.WriteLine("Enter horse name");
                String horseName = Console.ReadLine();
                int horseAge = 0;
                while (horseAge < 1 || horseAge > 50)
                {
                    Console.WriteLine("Enter horse age (must be between 1 and 50):");
                    String horseAgeString = Console.ReadLine();

                    
                    if (int.TryParse(horseAgeString, out horseAge))
                    {
                        if (horseAge < 1 || horseAge > 50)
                        {
                            Console.WriteLine("Invalid age. Please enter a number between 1 and 50.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                Console.WriteLine("Enter horse ID");
                String horseID = Console.ReadLine();
                Console.WriteLine("Enter owners name");
                String ownersName = Console.ReadLine();
                Console.WriteLine("Enter jockey name");
                String jockey = Console.ReadLine();

                Horse horse = new Horse(horseName, horseAge, horseID, ownersName, jockey);

                selectRace.AddHorse(horse);

                Console.WriteLine($"Horse {horse.Name} has been added to {selectRace.RaceName}, in {selectedEvent.Name}");
            }
            static void RaceManagerMenu()
            {
                int num = 0;
                while (num != 6)
                {
                    String[] array = new String[6];

                    array[0] = "1. View all events";
                    array[1] = "2. Enter name of Event to view Races and the horses";
                    array[2] = "3. Add event";
                    array[3] = "4. Add race to an event";
                    array[4] = "5. Add a horse or multiple horses";
                    array[5] = "6. Sign out";

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    Console.WriteLine("Enter a number");
                    String intput = Console.ReadLine();

                    num = int.Parse(intput);

                    if (num <= 0 || num > array.Length)
                    {
                        Console.WriteLine("Number is not on menu");
                    }


                    switch (num)
                    {
                        case 1:
                            AllEvents();
                            break;
                        case 2:
                            AllEvents();
                            DisplayAllRacesAndHorsesForEvent();
                            break;
                        case 3:
                            CreateEvent();
                            break;
                        case 4:
                            AddRaceToAnEvent();
                            break;
                        case 5:
                            HorseOwnerMenu();
                            break;
                        case 6:
                            Console.WriteLine("Signing out....");
                            break;
                    }

                }
            }
            static void CreateEvent()
            {
                List<Race> raceList = new List<Race>();

                Console.Write("Enter event name: ");
                string name = Console.ReadLine();
                Console.Write("Enter location: ");
                string location = Console.ReadLine();
                Console.WriteLine("Would you like to add races to this event now? Yes/No");
                String answer = Console.ReadLine();
                if (answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    bool done = false;
                    while (!done)
                    {

                        Console.WriteLine("How many races would you like to add");
                        String numberOfRaces = Console.ReadLine();
                        int numberOfRacesAnswer = int.Parse(numberOfRaces);
                        for (int i = 0; i < numberOfRacesAnswer; i++)
                        {
                            List<Horse> horseList = new List<Horse>();

                            Console.WriteLine("Enter race name");
                            String race = Console.ReadLine();
                            
                            bool dateValid = false;
                            String date = Console.ReadLine();
                            while (!dateValid)
                            {
                                Console.WriteLine("Enter date and time (yyyy-MM-dd HH:mm:ss)");
                                date = Console.ReadLine();
                                
                                dateValid = validateTime(date);
                                
                            }
                            DateTime dateTime;
                            DateTime.TryParse(date, out dateTime);

                            Console.WriteLine("Would you like to add a list of horses to this Race? Yes/No");
                            String answer2 = Console.ReadLine();

                            if (answer2.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                            {

                                Console.WriteLine("how many horses would you like to add");
                                String numberOfHorses = Console.ReadLine();
                                int numberOfHorsesAnswer = int.Parse(numberOfHorses);
                                for (int j = 0; j < numberOfHorsesAnswer; j++)
                                {


                                    Console.WriteLine("Enter horse name");
                                    String horseName = Console.ReadLine();
                                    int horseAge = 0;
                                    while (horseAge < 1 || horseAge > 50)
                                    {
                                        Console.WriteLine("Enter horse age (must be between 1 and 50):");
                                        String horseAgeString = Console.ReadLine();

                                        
                                        if (int.TryParse(horseAgeString, out horseAge))
                                        {
                                            if (horseAge < 1 || horseAge > 50)
                                            {
                                                Console.WriteLine("Invalid age. Please enter a number between 1 and 50.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input. Please enter a valid number.");
                                        }
                                    }
                                    Console.WriteLine("Enter horse ID");
                                    String horseID = Console.ReadLine();
                                    Console.WriteLine("Enter owners name");
                                    String ownersName = Console.ReadLine();
                                    Console.WriteLine("Enter jockey name");
                                    String jockey = Console.ReadLine();

                                    Horse horse = new Horse(horseName, horseAge, horseID, ownersName, jockey);
                                    horseList.Add(horse);
                                }
                            }
                                Race newRace = new Race(race, dateTime, horseList);
                                raceList.Add(newRace);


                            

                            
                        }
                        done = true;
                    }
                }
                 Event newevent = new Event(name, location, raceList.Count, raceList);
                    events.Add(newevent);
                    Console.WriteLine($"New event has been added:{newevent.Name}");
            }
                static void AddRaceToAnEvent()
                {
                    
                    
                    Console.WriteLine("Enter event name you want to add a race to");
                    String eventName = Console.ReadLine();
                    Event selectedEvent = events.FirstOrDefault(x => x.Name.ToLower() == eventName.ToLower());
                    if (selectedEvent == null)
                    {
                        Console.WriteLine("Event not found.Please re-enter");
                        return;
                    }
                    bool done = false;
                while (!done)
                {

                    Console.WriteLine("How many races would you like to add");
                    String numberOfRaces = Console.ReadLine();
                    int numberOfRacesAnswer = int.Parse(numberOfRaces);
                    for (int i = 0; i < numberOfRacesAnswer; i++)
                    {
                        List<Horse> horseList = new List<Horse>();

                        Console.WriteLine("Enter race name");
                        String race = Console.ReadLine();
                        bool dateValid = false;
                        String date = Console.ReadLine();
                        while (!dateValid)
                        {
                            Console.WriteLine("Enter date and time (yyyy-MM-dd HH:mm:ss)");
                            date = Console.ReadLine();

                            dateValid = validateTime(date);

                        }
                        DateTime dateTime;
                        DateTime.TryParse(date, out dateTime);

                        Console.WriteLine("Would you like to add a list of horses to this Race? Yes/No");
                        String answer2 = Console.ReadLine();

                        if (answer2.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                        {

                            Console.WriteLine("How many horses would you like to add");
                            String numberOfHorses = Console.ReadLine();
                            int numberOfHorsesAnswer = int.Parse(numberOfHorses);
                            for (int j = 0; j < numberOfHorsesAnswer; j++)
                            {


                                Console.WriteLine("Enter horse name");
                                String horseName = Console.ReadLine();
                                int horseAge = 0;
                                while (horseAge < 1 || horseAge > 50)
                                {
                                    Console.WriteLine("Enter horse age (must be between 1 and 50):");
                                    String horseAgeString = Console.ReadLine();

                                    
                                    if (int.TryParse(horseAgeString, out horseAge))
                                    {
                                        if (horseAge < 1 || horseAge > 50)
                                        {
                                            Console.WriteLine("Invalid age. Please enter a number between 1 and 50.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Please enter a valid number.");
                                    }
                                }
                                Console.WriteLine("Enter horse ID");
                                String horseID = Console.ReadLine();
                                Console.WriteLine("Enter owners name");
                                String ownersName = Console.ReadLine();
                                Console.WriteLine("Enter jockey name");
                                String jockey = Console.ReadLine();

                                Horse horse = new Horse(horseName, horseAge, horseID, ownersName, jockey);
                                horseList.Add(horse);
                            }
                        }
                            Race newRace = new Race(race, dateTime, horseList);
                            selectedEvent.AddRace(newRace);
                            Console.WriteLine($"New race has been added:{selectedEvent.Name}, racename is {newRace.RaceName}");

                        }
                        done = true;
                    }
                }
            static bool validateTime(string dateInString)
            {
                DateTime temp;
                if (DateTime.TryParse(dateInString, out temp))
                {
                    return true;
                }
                return false;
            }
        }
        }
    }
