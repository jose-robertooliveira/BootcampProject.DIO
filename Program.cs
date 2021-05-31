using System;

namespace InternationalSeries.D
{
    class Program
    {
        static RepositorySerie repository = new RepositorySerie();
        static void Main(string[] args)
        {

            string makeYourChoice = userChoice();

            while (makeYourChoice.ToUpper() != "X")
            {
                switch (makeYourChoice)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSeries();
                        break;
                    case "3":
                        UpdateSeries();
                        break;
                    case "4":
                        EraseSeries();
                        break;
                    case "5":
                        ViewSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                makeYourChoice = userChoice();

            }

            Console.WriteLine("Thanks for using our services");
            Console.ReadLine();
        }

        private static void EraseSeries() 
        {
            Console.Write("Type the serie id: ");
            int indexSerie = int.Parse(Console.ReadLine());

            repository.Erase(indexSerie);
        }

        private static void ViewSeries() 
        {
            Console.Write("Type the serie id: ");
            int indexSerie = int.Parse(Console.ReadLine());

            var serie = repository.ReturnsById(indexSerie);
            Console.WriteLine(serie);
        }

        private static void ListSeries()
        {
            Console.WriteLine("Get list of series");
            var list = repository.List();
            if (list.Count == 0)
            {
                Console.WriteLine("There are no series.");
            }

            foreach (var serie in list)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.showId(), serie.showTitle());
            }
        }

        private static void UpdateSeries()
        {
            Console.Write("Insert a new serie");
            int indexSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genres))) 
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genres), i));
            }
            Console.Write("Type the genre among options: ");
            int enterGenres = int.Parse(Console.ReadLine());

            Console.Write("Type the title of serie: ");
            string enterTitle = Console.ReadLine();


            Console.Write("Type the release year: ");
            int enterReleaseYear = int.Parse(Console.ReadLine());


            Console.Write("Type the description: ");
            string enterDescription = Console.ReadLine();

            Serie updateSerie = new Serie(id: indexSerie,

                                                            genres: (Genres)enterGenres,
                                                            title: enterTitle,
                                                            release_year: enterReleaseYear,
                                                            description: enterDescription);
            repository.Update(indexSerie, updateSerie);
        }


        private static void InsertSeries()
        {
            Console.Write("Insert a new serie");
            

            foreach (int i in Enum.GetValues(typeof(Genres)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genres), i));
            }
            Console.Write("Type the genre among options: ");
            int enterGenres = int.Parse(Console.ReadLine());

            Console.Write("Type the title of serie: ");
            string enterTitle = Console.ReadLine();


            Console.Write("Type the release year: ");
            int enterReleaseYear = int.Parse(Console.ReadLine());


            Console.Write("Type the description: ");
            string enterDescription = Console.ReadLine();

            Serie newSerie = new Serie(id: repository.NextId(),

                                                            genres: (Genres)enterGenres,
                                                            title: enterTitle,
                                                            release_year: enterReleaseYear,
                                                            description: enterDescription);
            repository.Insert(newSerie);
        }

        private static string userChoice() 
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to International Series DIO!!!");
            Console.WriteLine("Please, type a number of your choice!!!");

            Console.WriteLine("1 Get a list of series");
            Console.WriteLine("2 Insert new series");
            Console.WriteLine("3 Update series");
            Console.WriteLine("4 Erase series");
            Console.WriteLine("5 View series");
            Console.WriteLine("C Clear screen");
            Console.WriteLine("X to exit");
            Console.WriteLine();

            string userChoice = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userChoice;
        }
    }
}
