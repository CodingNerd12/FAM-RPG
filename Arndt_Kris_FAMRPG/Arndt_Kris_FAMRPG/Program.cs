/*
 Project Name: Crew/Fam RPG

    Contribution:
        Kris Arndt

    Features from this file
        Special occurences: Data collection
        Nothing specifically changed

    Start & End dates
        Start: 2020/09/08
        End: 2020/09/14

    References used:
        N/A
    Links:
       

 */

using System;
using System.Collections.Generic;
using System.IO;

namespace PnP1Menu
{

    public static class BlackBoard
    {

        public static List<string> currentStrings;
        public static MenuOptions menuClass = new MenuOptions();
        public static Person p1 = new Person();
        public static Person p2 = new Person();
        public static Person p3 = new Person();
        public static Person p4 = new Person();

    }

    public class Program
    {
        public static List<string> currentStrings;
        public static MenuOptions menuClass = new MenuOptions();
        public static Person currentPerson = new Person();
        public static StreamReader sr;
        public static StreamWriter sw;

        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            int currentMenu = 0;

            Console.Clear();
            int status = menuClass.DisplayMenu(currentMenu);

            // Format a negative integer or floating-point number in various ways.
            //Console.WriteLine("Standard Numeric Format Specifiers");
            //Console.WriteLine(
            //	"(C) Currency: . . . . . . . . {0:C}\n" +
            //	"(D) Decimal:. . . . . . . . . {0:D}\n" +
            //	"(E) Scientific: . . . . . . . {1:E}\n" +
            //	"(F) Fixed point:. . . . . . . {1:F}\n" +
            //	"(G) General:. . . . . . . . . {0:G}\n" +
            //	"    (default):. . . . . . . . {0} (default = 'G')\n" +
            //	"(N) Number: . . . . . . . . . {0:N}\n" +
            //	"(P) Percent:. . . . . . . . . {1:P}\n" +
            //	"(R) Round-trip: . . . . . . . {1:R}\n" +
            //	"(X) Hexadecimal:. . . . . . . {0:X}\n",
            //	-123, -123.45f);

            //Console.ReadLine();

        }
    }
}
