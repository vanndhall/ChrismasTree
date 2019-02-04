using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Swierk : ChristmasTree
    {
        public void DrawSwierk()
        {
            while (i <= 5)
            {
                j = 1;
                while (j <= sp)
                {
                    Console.Write(" ");
                    j++;
                }
                j = 1;
                while (j <= st)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                sp--;
                st += 2;
                i++;
            }
            Console.WriteLine("____________");
            Console.ReadLine();
        }
    }
}
