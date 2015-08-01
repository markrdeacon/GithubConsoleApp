using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<< Hello World! >>");
            Console.WriteLine("<< DO YOU WANT TO QUIT? y/n >>");

            while (Console.ReadKey(intercept: true).KeyChar != 'y')
            {
                Console.WriteLine("You're obviously not a quitter!");
            }

            Console.WriteLine("QUITTER!");
            Console.WriteLine("\n<< PRESS ANY KEY TO EXIT >>");
            Console.ReadKey(intercept: true);

        }
    }
}
