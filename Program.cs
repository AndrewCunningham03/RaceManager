namespace RaceManager
{
    internal class Program
    {
        static List<Event> events = new List<Event>();


        static void Main(string[] args)
        {
            Horse horse1 = new Horse("Wizard of odds", new DateOnly(2022, 1, 24), "WOO2022", "Heaney Group", "Eoin Powell");
            Horse horse2 = new Horse("Midnight Runner", new DateOnly(2019, 8, 21), "MR2019", "Riley Farms", "Liam O'Connor");
            Horse horse3 = new Horse("Blazing Fury", new DateOnly(2021, 6, 30), "BF2021", "McCarthy Racing", "Paul McGrath");
            Horse horse4 = new Horse("Silver Bullet", new DateOnly(2018, 2, 18), "SB2018", "Murphy Bros", "Declan Finn");
            Horse horse5 = new Horse("Eagle Eye", new DateOnly(2022, 3, 25), "EE2022", "Kennedy Farms", "Sean Donnelly");
            Horse horse6 = new Horse("Golden Arrow", new DateOnly(2019, 4, 14), "GA2019", "Murphy Bros", "Kevin Daly");
            Horse horse7 = new Horse("Thunderstrike", new DateOnly(2020, 11, 5), "TS2020", "Collins Racing", "Ryan Kelly");
            Horse horse8 = new Horse("Wildfire", new DateOnly(2021, 7, 9), "WF2021", "Flanagan Stables", "Patrick O'Reilly");
            Horse horse9 = new Horse("Shadow Dancer", new DateOnly(2020, 9, 15), "SD2020", "Doyle Equestrian", "Conor Byrne");
            Horse horse10 = new Horse("Highlander", new DateOnly(2017, 12, 1), "HL2017", "Gallagher Farms", "Brian Mahon");
            Horse horse11 = new Horse("Lightning Bolt", new DateOnly(2021, 5, 27), "LB2021", "Farrell Racing", "Aidan Quinn");
            Horse horse12 = new Horse("Firestorm", new DateOnly(2019, 10, 30), "FS2019", "O'Shea Stables", "Cian Keane");
            Horse horse13 = new Horse("Star Voyager", new DateOnly(2020, 3, 19), "SV2020", "Ryan Stables", "Brendan Murphy");
            Horse horse14 = new Horse("Ocean Breeze", new DateOnly(2021, 8, 11), "OB2021", "Collins Racing", "Fionn Brady");
            Horse horse15 = new Horse("Moonlight Shadow", new DateOnly(2018, 11, 2), "MS2018", "Nolan Stables", "James Hughes");
            Horse horse16 = new Horse("Delta Work", new DateOnly(2016, 12, 24), "DW2016", "Heaney Group", "Micheal Blaney");
            Horse horse17 = new Horse("Mighty Potter", new DateOnly(2020, 1, 20), "MP2020", "Collins Racing", "Jack Collins");
            Horse horse18 = new Horse("Sir Bob", new DateOnly(2017, 5, 2), "SB2017", "Murphy Bros", "Gareth Murphy");

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

            List<Race> races = new List<Race>();
            races.Add(r1);
            races.Add(r2);
            List<Race> racesTwo = new List<Race>();
            racesTwo.Add(r3);
            racesTwo.Add(r4);
            List<Race> racesThree = new List<Race>();
            racesThree.Add(r5);
            racesThree.Add(r6);

            Event event1 = new Event("Easter races", "Fairyhouse", races.Count, races);
            Event event2 = new Event("Irish derby festival", "Galway", racesTwo.Count, racesTwo);
            Event event3 = new Event("October festival", "Curragh", racesThree.Count, racesThree);

            events.Add(event1);
            events.Add(event2);
            events.Add(event3);

        }

    }
}
