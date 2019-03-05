using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                    Random numbers
                    C#um patahakan tver generacnelu hhamar nax haytararum enq RANDOM dasi object. 

                    1. rd.Next() [0, 4milion]
                    2. rd.Next(a) [0, a-1]
                    3. rd.Next(a,b) [a, b-1]
                    4. rd.NextDouble() [0, 0.9]

            `           ReadKey()
                    kardum e keyboardi kochakneri infon
                    .key y parunakum e xosakkcakan anuny
                    vory haytararvac e consoleKey tvarkman mech, ConsoleKey-y maximal keyboardi  anunneri ev koderi tvarkumn e
                                                   
             */

            Random rand = new Random();
            
           start:  WriteLine("Enter players names");
            string p1n = ReadLine();
            string p2n = ReadLine();
            int p1_first = rand.Next(1, 7);
            int p1_second = rand.Next(1, 7);
            int p2_first = rand.Next(1, 7);
            int p2_second = rand.Next(1, 7);
            ForegroundColor = ConsoleColor.Red;
            WriteLine(p1n + "'s numbers : " + p1_first+" | "+p1_second);
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(p2n + "'s numbers : " + p2_first + " | " + p2_second + "\n");
            int p1 = p1_first + p1_second;
            int p2 = p2_first + p2_second;

            if (p1 > p2)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Wow great "+p1n + " you are win !!! \n");
                ForegroundColor = ConsoleColor.White;

            }
            else if (p2 > p1)
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Wow great " + p2n + " you are win !!! \n");
                ForegroundColor = ConsoleColor.White;
            }
            else
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine("Draw !!! \n");
            }
            
            WriteLine("You can play again, click on ENTER if you wont to play \n");
            
            if (ReadKey().Key == ConsoleKey.Enter)
            {
                goto start;
            }


        }
    }
}
