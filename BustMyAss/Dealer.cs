using System;

namespace BustMyAss
{
    class Dealer
    {
        private Cards deck { get; }
        public int DealerCount { get; set; }
        public int PlayerCount { get; set; }

        public Dealer()
        {
            deck = new Cards();
            DealerCount = deck.getRandomCard();
            PlayerCount = deck.getRandomCard();
            Console.WriteLine($"Dealer starts with {DealerCount}");
            Console.WriteLine($"You start with {PlayerCount}");
        }

        public void HitDealer()
        {
            Console.WriteLine($"Dealer hit with {DealerCount}...");
            DealerCount += deck.getRandomCard();

            if (DealerCount > 21)
            {
                Console.WriteLine($"Dealer busts with {DealerCount}!");
            } else if (DealerCount >= 17)
            {
                Console.WriteLine("Dealer stays");
            }
        }

        public void HitPlayer()
        {
            Console.WriteLine($"You hit with {PlayerCount}");
            PlayerCount += deck.getRandomCard();

            if (PlayerCount > 21)
            {
                Console.WriteLine("You busted");
            }
            else
            {
                Console.WriteLine($"You have {PlayerCount}");
            }
        }


    }
}
