using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlamingsuppgift;

namespace Inlamingsuppgift
{
    public class Consoleprint
    {
        public void ConsolePrint()
        {
            Console.Clear();
            var score = new Score();
            var list = score.List();
            var sortedplayer = list.OrderBy(s => s.Counter);
            foreach (var item in sortedplayer)
            {
                Console.WriteLine($"{item.Name} " + "has " + item.Counter + " Points," + " the date was " + item.Date + "!");
            }
            Console.WriteLine("\nRanking can be found in PlayerScores.txt");
            Console.ReadLine();
        }
    }
}
