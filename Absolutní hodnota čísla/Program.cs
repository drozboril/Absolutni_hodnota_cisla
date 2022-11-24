using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolutní_hodnota_čísla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Absolutní hodnota čísla\nZadejte číslo");
            int cislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Absolutní hodnota zadaného čísla je {0}", Abs(cislo1));
            Console.ReadLine();
        }
        static int Abs(int cislo1)
        {
            int vypocet = Math.Abs(cislo1);
            return vypocet;
        }
    }
}