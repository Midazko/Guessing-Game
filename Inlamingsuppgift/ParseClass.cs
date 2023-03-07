using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlamingsuppgift;

namespace Inlamingsuppgift
{
    public class ParseClass
    {
        public  int Parse()
        {
            int tal;
            while (int.TryParse(Console.ReadLine(), out tal) == false)
            {              
                Console.Write("Numbers are required to continue: ");
            }
            return tal;
        }
    }
}
