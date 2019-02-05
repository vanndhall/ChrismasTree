using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Swierk swierk = new Swierk();
            Sosna sosna = new Sosna();

            // wypisz
            Console.WriteLine("Pora na świerk:  "); 
            swierk.DrawSwierk();
            Console.WriteLine("Pora na Sosnę: ");
            sosna.DrawSosna();

            

        }   
    }
    
}
