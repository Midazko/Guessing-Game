using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inlamingsuppgift;
using Inlamingsuppgift;

namespace inlamingsuppgift
{
    public class Highscore
    {
        public void Newhighscore(int counter, bool IsListFull)
        {
            bool IsNewHS = false;
            var score = new Score();
            var players = new Players();
            var game = new TheGame();
            var list = score.List();
            if (IsListFull == true)
            {
                foreach (var entry in list)
                {
                    if (entry.Counter > counter)
                    {
                        IsNewHS = true;
                        break;
                    }
                }
                if (IsNewHS)
                {
                    Players lowestentry = list[0];
                    foreach (var entry in list)
                    {
                        if (entry.Counter > lowestentry.Counter)
                        {
                            lowestentry = entry;
                        }
                    }
                    Console.WriteLine($"Congrats, you got a new highscore!\nYou overtook {lowestentry.Name}!");
                    Console.Write("\nType your name: ");
                    var name = Console.ReadLine();
                    var date = DateTime.Now;
                    list.Remove(lowestentry);
                    list.Add(new Players { Name = name, Counter = counter, Date = date });
                    score.Savefiles(list);
                    IsNewHS = false;
                }
            }           
        }
    }
}
