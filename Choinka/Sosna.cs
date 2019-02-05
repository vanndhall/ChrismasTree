using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Sosna : ChristmasTree
    {
        int i, j, k,m=30 ;
        public void DrawSosna()
        {
            //Liście
          for (i = 1; i <= 30; i++)
          {

            for (j = 1; j <= m; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= (2 * i - 1); k++)
            {
                    if(k ==0)
                    { Console.Write("$"); }
                Console.Write("^");
            }
            Console.WriteLine();

                m--;
          }
                    //Kora
            for (i = 1; i <=3; i++)
            {
                for(j=1;j<30;j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= 3; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("________________________________________________________");
            
        }

    }
}
