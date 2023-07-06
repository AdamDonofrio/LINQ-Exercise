using System;
using System.Linq;

namespace LINQ
{
    public class Program
    {

        private static string[] videoGamesList = { "Psychonauts", "Halo", "Team Fortris 2", "Starfield", "Psychonauts 2"};
        //private static string[] newGameList = { "" };
        static void Main(string[] args)
        {
            /*var newGameList = from game in videoGamesList
                              where game != null
                              orderby game ascending
                              select game;
            */

            var newGameList = videoGamesList.OrderBy(x => x.Length).ToList();
            

            foreach (var i in videoGamesList)
            {
                Console.WriteLine(i.ToString());
            }
            
            
            Console.WriteLine();

            foreach (var i in newGameList)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
