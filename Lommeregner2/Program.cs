using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Lommeregner lm = new Lommeregner();

            lm+= lm.Plus(5, 7);

            lm.Beep();

            Console.WriteLine(lm.Plus(1, 2));
            Console.ReadKey();
        }

    }

    class Lommeregner
    {
        public delegate int dd(int x, int y);

        public Func<int, int, int> Plus = (x, y) => x + y;
        public Func<int, int, int> Minus = (x, y) => x - y;
        public Action Beep = () => Console.Beep();    
    }
}
