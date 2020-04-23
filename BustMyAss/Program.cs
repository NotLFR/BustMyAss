using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BustMyAss
{
    class Program
    {
        static void Main(string[] args)
        {

            Cards cards = new Cards();

            Console.WriteLine("This is me trying to learn Blackjack");
            Console.WriteLine($"The cards are {cards.getFriendlyCards()}");



            Console.ReadKey();
        }

    }
}
