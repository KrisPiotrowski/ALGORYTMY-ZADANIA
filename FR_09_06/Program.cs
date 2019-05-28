using System;
using System.Text;

namespace FR_09_06
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());

            if (Q > 1000)
                throw new ArgumentException();

            for (int i = 1; i <= Q; i++)
            {
                bool num = false;
                if (i == Q)
                    num = true;
                Solution(num);
            }
            Console.WriteLine(wynik.ToString());
        }

        static void Solution(bool j)
        {
            string word = Console.ReadLine();
            if (word.Length > 1000)
                throw new ArgumentException();
            int MinVal = 26;
            int MaxVal = 1;
            int result = 0;

            foreach(char x in word)
            {
                //Console.WriteLine($"tO JEST LITERA {x} I JEJ POZYCJA TO {GetCharPosition(x)}");
                if (GetCharPosition(x) < MinVal)
                {
                    MinVal = GetCharPosition(x);
                    //Console.WriteLine($"PO WYKONANIU BLOKU  IF (WAR 1) DLA LITERY {x} MINVAL WYNOSI {MinVal} ");
                }

                if (GetCharPosition(x) > MaxVal)
                {
                    MaxVal = GetCharPosition(x);
                    //Console.WriteLine($"PO WYKONANIU BLOKU  IF (WAR 2) DLA LITERY {x} MAXVAL WYNOSI {MaxVal} ");
                }
            }

           // Console.WriteLine($"PRZED OBLICZENIEM RESULT MINVAL = {MinVal} AND MAXVAL = {MaxVal}");
            result = MaxVal - MinVal;


            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }

        static int GetCharPosition(char x)
        {

            switch (x)
            {
                case 'A':
                    return 1;
                    break;
                case 'B':
                    return 2;
                    break;
                case 'C':
                    return 3;
                    break;
                case 'D':
                    return 4;
                    break;
                case 'E':
                    return 5;
                    break;
                case 'F':
                    return 6;
                    break;
                case 'G':
                    return 7;
                    break;
                case 'H':
                    return 8;
                    break;
                case 'I':
                    return 9;
                    break;
                case 'J':
                    return 10;
                    break;
                case 'K':
                    return 11;
                    break;
                case 'L':
                    return 12;
                    break;
                case 'M':
                    return 13;
                    break;
                case 'N':
                    return 14;
                    break;
                case 'O':
                    return 15;
                    break;
                case 'P':
                    return 16;
                    break;
                case 'Q':
                    return 17;
                    break;
                case 'R':
                    return 18;
                    break;
                case 'S':
                    return 19;
                    break;
                case 'T':
                    return 20;
                    break;
                case 'U':
                    return 21;
                    break;
                case 'V':
                    return 22;
                    break;
                case 'W':
                    return 23;
                    break;
                case 'X':
                    return 24;
                    break;
                case 'Y':
                    return 25;
                    break;
                default:
                    return 26;
                    break;
            }
        }


    }
}
