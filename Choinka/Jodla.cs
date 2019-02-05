using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Jodla : ChristmasTree
    {
        public Jodla() { } // konstruktor


        public void DrawJodla()
        {
            for(int i =1;i<=5;i++)
            {
                for(int j = 4;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(int k =1;k<=(2*i-1);k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
