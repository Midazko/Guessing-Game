using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using inlamingsuppgift;
using Inlamingsuppgift;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;

namespace Inlamingsuppgift
{
    public class Score
    {
        public List<Players> List()
        {
            var score = new List<Players>();
            if (!File.Exists("PlayerScores.txt")) return score;

            foreach (var line in File.ReadLines("PlayerScores.txt"))
            {
                var parts = line.Split(", ");
                var player = new Players(); 
                player.Name = parts[0];
                player.Counter = Convert.ToInt32(parts[1]);
                player.Date = Convert.ToDateTime(parts[2]);
                score.Add(player);
            }
            return score;
        }

        public void Savefiles(List<Players> list) 
        {
            var strings = new List<string>();
            var sortedplayer = list.OrderBy(s => s.Counter);
            foreach (var player in sortedplayer)
            {
                string Scorestring = player.Name + ", " + player.Counter + ", " + player.Date; 
                strings.Add(Scorestring);
            }
            File.WriteAllLines("PlayerScores.txt", strings);
        }

        public void IsListFull(int counter, bool IsListFull = false)
        { 
            var check = new Highscore();
            var player = new Players();          
            var game = new TheGame();
            var list = List();
            int listcount = list.Count;
            if (listcount > 4)
            {              
                IsListFull = true;
            }
            else if (IsListFull == false)
            {
                Console.Write("Type your name: ");
                var name  = Console.ReadLine();
                var date = DateTime.Now;
                Console.WriteLine("You have been added to the list!");
                list.Add(new Players { Name = name, Counter = counter, Date = date });
                Savefiles(list);
            }
            check.Newhighscore(counter, IsListFull);
        }
    }
}