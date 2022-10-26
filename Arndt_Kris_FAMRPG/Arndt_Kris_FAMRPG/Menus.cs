/*
 Project Name: Crew/Fam RPG

    Contribution:
        Kris Arndt

    Features from this file
        Displaying menu content
        Storing and presenting that data
        Changing the data to work with the program

    Start & End dates
        Start: 2020/09/08
        End: 2020/09/14

    References used:
	    C-Sharpcorner
        Docs.microsoft
        W3Schools
    Links:
       How to change foreground and background colors (https://www.c-sharpcorner.com/article/change-console-foreground-and-background-color-in-c-sharp/)
       Changing foreground and background color with user input(https://docs.microsoft.com/en-us/dotnet/api/system.console.backgroundcolor?view=netcore-3.1)
 */
using System;
using System.Security.Policy;
using System.Xml.Linq;

namespace PnP1Menu
{

    public class MenuOptions
    {

        public MenuOptions()
        {

        }

        public int DisplayMenu(int _cmenu)
        {
            switch (_cmenu)
            {
                case 0:
                    return MainMenu();
                case 1:
                    break;
            }
            return 0;
        }

        public int MainMenu()
        {
            char optionKey = (char)0;

            while (optionKey != 'q')
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Write("Hello Menu World!\nMAIN MENU:\n");
                Console.Write("Press the number in the parenthesis to choose.\n");
                if (Program.currentPerson == null)
                {
                    Console.Write("No one has been selected. Please select a person to edit.");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(Program.currentPerson.name + "\n");
                }
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("(1). Select a Person.");
                Console.WriteLine("(2). Display a Person.");
                Console.WriteLine("(3). Read File");
                Console.WriteLine("(4). Export All Persons to a file.");
                Console.WriteLine("(5). Calculate Average");
                Console.WriteLine("(6). Sum of numbers.");
                Console.WriteLine("(q). To quit the program.");
                Console.WriteLine("(esc). To back out at any moment.");

                optionKey = Console.ReadKey(true).KeyChar;
                int selection = 0;
                switch (optionKey)
                {
                    case '1':
                        Console.Write("Enter a number from 1 to 4:");
                        selection = Convert.ToInt32(Console.ReadKey(true).KeyChar);
                        switch (selection)
                        {
                            case (char)'1':
                                BlackBoard.p1.EnterData();
                                break;
                            case (char)'2':
                                BlackBoard.p2.EnterData();
                                break;
                            case (char)'3':
                                BlackBoard.p3.EnterData();
                                break;
                            case (char)'4':
                                BlackBoard.p4.EnterData();
                                break;
                            default:
                                break;
                        }
                        break;
                    case '2':
                        Console.Write("Enter a number from 1 to 4, or press 'A' to display all.");
                        selection = Convert.ToInt32(Console.ReadKey(true).KeyChar);
                        Console.Clear();
                        switch (selection)
                        {
                            case (char)'1':
                                BlackBoard.p1.bg = ConsoleColor.Black;
                                BlackBoard.p1.fg = ConsoleColor.Blue;
                                BlackBoard.p1.DisplayData();
                                break;
                            case (char)'2':
                                BlackBoard.p2.bg = ConsoleColor.Green;
                                BlackBoard.p2.fg = ConsoleColor.Magenta;
                                BlackBoard.p2.DisplayData();
                                break;
                            case (char)'3':
                                BlackBoard.p3.bg = ConsoleColor.DarkCyan;
                                BlackBoard.p3.fg = ConsoleColor.Black;
                                BlackBoard.p3.DisplayData();
                                break;
                            case (char)'4':
                                BlackBoard.p4.bg = ConsoleColor.DarkRed;
                                BlackBoard.p4.fg = ConsoleColor.White;
                                BlackBoard.p4.DisplayData();
                                break;
                            case (char)'a':
                                BlackBoard.p1.bg = ConsoleColor.Black;
                                BlackBoard.p1.fg = ConsoleColor.Blue;
                                BlackBoard.p1.DisplayData();
                                BlackBoard.p2.bg = ConsoleColor.Green;
                                BlackBoard.p2.fg = ConsoleColor.Magenta;
                                BlackBoard.p2.DisplayData();
                                BlackBoard.p3.bg = ConsoleColor.DarkCyan;
                                BlackBoard.p3.fg = ConsoleColor.Black;
                                BlackBoard.p3.DisplayData();
                                BlackBoard.p4.bg = ConsoleColor.DarkRed;
                                BlackBoard.p4.fg = ConsoleColor.White;
                                BlackBoard.p4.DisplayData();
                                break;
                            default:
                                break;
                        }
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case '3':
                        Console.WriteLine("Enter a name for the file to read.");
                        string readName = Console.ReadLine();
                        readName += ".csv";
                        Program.sr = new System.IO.StreamReader(readName, false);
                        while (!Program.sr.EndOfStream)
                        {
                            Console.WriteLine(Program.sr.ReadLine());
                        }
                        Program.sr.Close();
                        Console.ReadKey(true);
                        break;
                    case '4':
                        Console.WriteLine("Enter a name for the file to export");
                        string fileName = Console.ReadLine();
                        fileName += ".csv";
                        string stringLine = string.Empty;
                        Program.sw = new System.IO.StreamWriter(fileName, false);
                        for (int i = 0; i < 4; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Program.currentPerson = BlackBoard.p1;
                                    break;
                                case 1:
                                    Program.currentPerson = BlackBoard.p2;
                                    break;
                                case 2:
                                    Program.currentPerson = BlackBoard.p3;
                                    break;
                                case 3:
                                    Program.currentPerson = BlackBoard.p4;
                                    break;
                                default:
                                    break;
                            }
                            stringLine = Program.currentPerson.name + ",";
                            stringLine += Program.currentPerson.age.ToString();
                            for (int j = 0; j < Program.currentPerson.attributes.Length; j++)
                            {
                                stringLine += Program.currentPerson.attributes[j];
                                stringLine += ",";
                            }
                            stringLine += ",";
                            stringLine += Program.currentPerson.ac.ToString();
                            stringLine += ",";
                            stringLine += Program.currentPerson.hp.ToString();
                            stringLine += ",";
                            stringLine += Program.currentPerson.height.ToString();
                            stringLine += ",";
                            stringLine += Program.currentPerson.weight.ToString();
                            stringLine += ",";
                            stringLine += Program.currentPerson.enemy.ToString();
                            stringLine += ",";
                            stringLine += Program.currentPerson.friend.ToString();
                            Program.sw.WriteLine("{0:}", stringLine);

                        }
                        Program.sw.Close();
                        break;
                    case '5':
                        Console.WriteLine("Enter a number from 1 to 4:");
                        selection = Convert.ToInt32(Console.ReadKey(true).KeyChar);
                        switch (selection)
                        {
                            case (char)'1':
                                Program.currentPerson = BlackBoard.p1;
                                break;
                            case (char)'2':
                                Program.currentPerson = BlackBoard.p2;
                                break;
                            case (char)'3':
                                Program.currentPerson = BlackBoard.p3;
                                break;
                            case (char)'4':
                                Program.currentPerson = BlackBoard.p4;
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine($"{Program.currentPerson.name}'s average of attributes is {Program.currentPerson.ArithmeticAverage()}");
                        Console.ReadKey(true);
                        break;
                    case '6':
                        Console.WriteLine("Enter a number from 1 to 4:");
                        selection = Convert.ToInt32(Console.ReadKey(true).KeyChar);
                        switch (selection)
                        {
                            case (char)'1':
                                Program.currentPerson = BlackBoard.p1;
                                break;
                            case (char)'2':
                                Program.currentPerson = BlackBoard.p2;
                                break;
                            case (char)'3':
                                Program.currentPerson = BlackBoard.p3;
                                break;
                            case (char)'4':
                                Program.currentPerson = BlackBoard.p4;
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine($"{Program.currentPerson.name}'s sum of attributes is {Program.currentPerson.ArithmeticSum()}");
                        Console.ReadKey(true);
                        break;
                    case 'q':
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Thanks!");
                        break;
                }

            }
            return 0;
        }

    }


}

