using System;
using System.Collections.Generic;

namespace BustMyAss
{
    class Cards
    {
        public List<int> AllTheCards { get; } = new List<int> {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};

        private Random random = new Random();

        public int getRandomCard()
        {
            return AllTheCards[random.Next(0, AllTheCards.Count - 1)];
        }
    }
}
