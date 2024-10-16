namespace RaceManager
{
    internal class ProgramBase
    {

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1.Racegoer");
            Console.WriteLine("2. Horse Owner");
            Console.WriteLine("3. Racecourse/Event Manager");
            Console.WriteLine("4.Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case 1:
                    RacegoerMenu();
                    return true;

                case 2:
                    return true;
                case 3:
                    return true;
                case 4:
                    return false;
            }
        }
    }
}