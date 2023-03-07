using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamingsuppgift
{
    public class App
    {
        public void Run()
        {
            var initiate = new Consoleprint();
            var Parser = new ParseClass();
            var score = new Score();
            bool Menuloop = true;
            var launch = new TheGame();
            
            while (Menuloop)
            {
                Console.Clear();
                Console.WriteLine("---- The guessing game -----\n");
                Console.Write("1. Guess the number\n" +
                    "2. List the Guesses\n" +
                    "3. Exit\n\n" +
                    "Type your answer: ");
                int Menu = Parser.Parse();
                {
                    switch (Menu)
                    {
                        case 1: launch.Game();
                            break;

                        case 2:
                            initiate.ConsolePrint();
                            break;

                        case 3:
                            Console.WriteLine("Finally...");
                            Menuloop = false; 
                            break;
                    }                   
                }
            }
        }       
    }
}

