/*	
 Project Name: Crew/Fam RPG

    Contribution:
        Kris Arndt

    Features from this file
        Storing information from the user
        Evaluating the data and printing it
        Creating unique design for each 'person'

    Start & End dates
        Start: 2020/09/08
        End: 2020/09/14

    References used:
	    C-Sharpcorner
        Docs.microsoft
        W3Schools
    Links:
       
*/
using System;
using System.Diagnostics;

namespace PnP1Menu
{

    public class BaseClass
    {
        public BaseClass()
        {

        }

    }

    public class Person : BaseClass
    {
        public string name;
        public int[] attributes;
        public string[] attributeNames;
        public int age;
        public float ac;
        public float hp;
        public float height;
        public float weight;
        public string friend;
        public string enemy;
        public ConsoleColor bg;
        public ConsoleColor fg;


        public Person()
        {
            attributes = new int[6];
            attributeNames = new string[] { "STR", "DEX", "CON", "WIS", "INT", "CHA" };
            name = "Person";
            age = 0;
            ac = 0;
            hp = 0;
            height = 0;
            weight = 0;
            friend = string.Empty;
            enemy = string.Empty;
            bg = ConsoleColor.DarkMagenta;
            fg = ConsoleColor.White;
        }

        public Person(string _name, int _age,
            int _str, int _dex, int _con, int _wis, int _int, int _cha,
            float _ac, float _hp,
            float _height, float _weight, string _f, string _e)
        {
            attributes[0] = _str;
            attributes[1] = _con;
            attributes[2] = _dex;
            attributes[3] = _wis;
            attributes[4] = _int;
            attributes[5] = _cha;
            name = _name;
            age = _age;
            ac = _ac;
            hp = _hp;
            height = _height;
            weight = _weight;
            friend = _f;
            enemy = _e;
        }

        public Person(Person other)
        {
            attributes[0] = other.attributes[0];
            attributes[1] = other.attributes[1];
            attributes[2] = other.attributes[2];
            attributes[3] = other.attributes[3];
            attributes[4] = other.attributes[4];
            attributes[5] = other.attributes[5];
            name = other.name;
            age = other.age;
            ac = other.ac;
            hp = other.hp;
            height = other.height;
            weight = other.weight;
            friend = other.friend;
            enemy = other.enemy;
        }
        public int ArithmeticSum()
        {
            int outputSum = 0;
            for (int i = 0; i < 6; i++)
            {
                outputSum += attributes[i];
            }
            return outputSum;
        }
        public float ArithmeticAverage()
        {
            float outputAvg = 0;
            for (int i = 0; i < 6; i++)
            {
                outputAvg += attributes[i];
            }
            return outputAvg / 6;
        }
        public string DisplayData()
        {
            Console.BackgroundColor = bg;
            Console.ForegroundColor = fg;
            string stringLine = "Name: ".PadLeft(9, ' ') + name + "\n";
            stringLine += "Age: ".PadLeft(9, ' ') + age.ToString() + "\n";
            for (int j = 0; j < attributes.Length; j++)
            {
                stringLine += (attributeNames[j] + ": ").PadLeft(9, ' ') + attributes[j] + "\n";
            }
            stringLine += "AC: ".PadLeft(9, ' ') + ac.ToString() + "\n";
            stringLine += "HP: ".PadLeft(9, ' ') + hp.ToString() + "\n";
            stringLine += "Height: ".PadLeft(9, ' ') + height.ToString() + "in \n";
            stringLine += "Weight: ".PadLeft(9, ' ') + weight.ToString() + "st \n";
            stringLine += "Enemy: ".PadLeft(9, ' ') + enemy + "\n";
            stringLine += "Friend: ".PadLeft(9, ' ') + friend;

            Console.WriteLine(stringLine);
            return stringLine;
        }

        public void EnterData()
        {
            char optionKey = (char)0;

            while (optionKey != (char)27)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Write($"{name}'s Menu:\n");
                Console.Write("Press the number in the parenthesis to choose.\n");
                Console.Write("(0). Enter Name\n");
                Console.Write("(1). Enter Age\n");
                Console.Write("(2). Enter Strength\n");
                Console.Write("(3). Enter Dexterity\n");
                Console.Write("(4). Enter Constitution\n");
                Console.Write("(5). Enter Wisdom\n");
                Console.Write("(6). Enter Intelligence\n");
                Console.Write("(7). Enter Charisma\n");
                Console.Write("(8). Enter Height\n");
                Console.Write("(9). Enter Weight\n");
                Console.Write("(A). Enter AC\n");
                Console.Write("(H). Enter Health\n");
                Console.Write("(E). Enter Enemy\n");
                Console.Write("(F). Enter Friend\n");
                Console.Write("(Space). Display Person's Info\n");
                Console.Write("(esc). To back out at any moment\n");
                optionKey = Console.ReadKey(true).KeyChar;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                switch (optionKey)
                {
                    case '0':
                        Console.WriteLine($"Enter {name}'s Name:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        name = Console.ReadLine().ToString();
                        break;
                    case '1':
                        Console.WriteLine($"Enter {name}'s Age:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case '2':
                        Console.WriteLine($"Enter {name}'s Strength:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        attributes[0] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case '3':
                        Console.WriteLine($"Enter {name}'s Dexterity:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        attributes[1] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case '4':
                        Console.WriteLine($"Enter {name}'s Constitution:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        attributes[2] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case '5':
                        Console.WriteLine($"Enter {name}'s Wisdom:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        attributes[3] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case '6':
                        Console.WriteLine($"Enter {name}'s Intelligence:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        attributes[4] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case '7':
                        Console.WriteLine($"Enter {name}'s Charisma:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        attributes[5] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case '8':
                        Console.WriteLine($"Enter {name}'s Height:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        height = float.Parse(Console.ReadLine());
                        break;
                    case '9':
                        Console.WriteLine($"Enter {name}'s Weight:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        weight = float.Parse(Console.ReadLine());
                        break;
                    case 'a':
                        Console.WriteLine($"Enter {name}'s AC:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        ac = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 'h':
                        Console.WriteLine($"Enter {name}'s HP:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        hp = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 'f':
                        Console.WriteLine($"Enter {name}'s Friend:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        friend = Console.ReadLine();
                        break;
                    case 'e':
                        Console.WriteLine($"Enter {name}'s Enemy:");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        enemy = Console.ReadLine();
                        break;
                    case ' ':
                        DisplayData();
                        Console.ReadKey(true);
                        break;
                    case (char)27:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                }

            }
        }
    }



}
