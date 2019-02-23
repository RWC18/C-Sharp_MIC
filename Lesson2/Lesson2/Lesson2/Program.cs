using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string x = "";
            
            //CursorLeft = WindowWidth/2;
            //CursorTop = WindowHeight / 2;
            SetCursorPosition(0, WindowHeight - 1);



            ForegroundColor = ConsoleColor.Green;
           
            
            WriteLine(DateTime.Now.ToLongTimeString());

            //WriteLine(Console.ForegroundColor+" | " + (int)Console.ForegroundColor);

            //Write("Write your name here : ");
            //x = ReadLine();
            //WriteLine("Welcome dear "+x);

            Thread.Sleep(2000);

            WindowHeight += 5;
            WindowWidth -= 10;
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            WriteLine("Window resize to : "+WindowHeight+"x"+WindowWidth);
        }
    }
}
