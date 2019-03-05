using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ZarName
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              C#um i  tarberutyun C++ karox e linel naev string ev yuraqanchyur Case-i tak partadir petq e lini kam goto

            Ashxatanqi algoritmy
                1. hashvum e parametri arjeqy
                2. Cragiry mtnum e voronman rejim, ev sksum e stacvac arjeqy hamematel case-eri het` sksac arajin Case-ic\
                    a. ete arjeqy havasar che hastatunin, apa voronumy sharunakum e hajord case-um.
                    b. ete havasar e durs e galis voronman rejimic ev sksum e katarel cragiry sovorakan dzevov.
                    g. Ete voch mekin havasar che katarvum e defauletum grvac kody ankax nra dirqic.
                    d. defaulty partadir CASE che.


            BREAK Operators
            
            break;
            continue;
            return;
            return artahaytutyun;


            HomeWork
                Usery mutq e anum Binar tvabanakan artahaytutyun (5+5), cragiry ogtagorcelov Switch operatory hashvum ev cucadrum e ardyunqy:
                
            writeLine("Enter binary Ariphmetic expression");
            double n1 = double.Parse(ReadLine());
            char g = char.Parse(ReadLine());
            double n2 = double.Parse(ReadLine());
            double result = 0;

             */
            Random rn = new Random();
            start: int number = rn.Next(1, 7);
            
            switch (number)
            {
                case 1:
                    WriteLine(number + " | Yek");
                    break;
                case 2:
                    WriteLine(number + " | Du");
                    break;
                case 3:
                    WriteLine(number + " | Se");
                    break;
                case 4:
                    WriteLine(number + " | Jar");
                    break;
                case 5:
                    WriteLine(number + " | Panj");
                    break;
                case 6:
                    WriteLine(number + " | Shesh");
                    break;
            }

            WriteLine("\n Try again?? press Enter \n");
            if (ReadKey().Key == ConsoleKey.Enter)
            {
                goto start;
            }
            
        }
    }
}
