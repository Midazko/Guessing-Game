using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamingsuppgift
{
    public class TheGame
    {
        public void Game()
        {
            bool sel = true;
            while(sel)
            {
                Console.Clear();
                var Parser = new ParseClass();
                var score = new Score();
                var random = new Random();
                Console.Write("Guess a number between 1 and 100: ");
                int secretNumber = random.Next(1, 100);
                int counter = 0;

                while (true)
                {
                    int tal = Parser.Parse();
                    counter++;
                    if (secretNumber < tal)
                    {
                        Console.WriteLine("Shorter!");
                    }
                    else if (secretNumber > tal)
                    {
                        Console.WriteLine("Bigger!");
                    }
                    else if (tal == secretNumber)
                    {
                        Console.WriteLine("You guessed correct!\n");
                        score.IsListFull(counter);
                        break;
                    }
                }
                Console.Write("Do you want to play again? Yes or no?\n\n" + "Type: ");
                var choice = Console.ReadLine();
                if (choice == "Yes" || choice == "yes")
                {
                    sel = true;
                }
                else
                {
                    sel = false;
                }
            }         
        }
    }
}
