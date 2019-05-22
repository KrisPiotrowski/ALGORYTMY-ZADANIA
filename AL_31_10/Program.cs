using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_31_10
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {

            wynik.Append($"{Solution()}\n");

            Console.WriteLine(wynik.ToString());
        }

        static string Solution()
        {
            string input = "";

            while(Console.ReadLine() != null)
            {
                input += Console.ReadLine();
            }

            string[] tab = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            for (int j = 1; j < tab.Length; j++)
            {
                string str = tab[j];
                int max = 0, max2 = 0, index = 0, index2 = 0;
                int[] freq = new int[26];

                for (int i = 0; i < str.Length; i++)
                {
                    int pos = GetCharPosition(str[i]);
                    if (pos < 1 && GetCharPosition(str[i]) > 26)
                        continue;
                    else
                        freq[pos] += 1;
                }

                for (int i = 0; i < freq.Length; i++)
                {
                    if (freq[i] > max)
                    {
                        max2 = max;
                        index2 = index;
                        max = freq[i];
                        index = i;
                    }
                    else if (freq[i] <= max && freq[i] > max2)
                    {
                        max2 = freq[i];
                        index2 = i;
                    }
                }

                if (((double)max > 0 && (double)max2 == 0) || ((double)max / (double)max2 > 2))
                    result += j.ToString() + " - " + GetCharacter(index);
                else
                    result += j.ToString() + " - BRAK";
            }

            return result;
        }

        static int GetCharPosition(char x)
        {

            string str = x.ToString().ToUpper();

            switch (str)
            {
                case "A":
                    return 1;
                    break;
                case "B":
                    return 2;
                    break;
                case "C":
                    return 3;
                    break;
                case "D":
                    return 4;
                    break;
                case "E":
                    return 5;
                    break;
                case "F":
                    return 6;
                    break;
                case "G":
                    return 7;
                    break;
                case "H":
                    return 8;
                    break;
                case "I":
                    return 9;
                    break;
                case "J":
                    return 10;
                    break;
                case "K":
                    return 11;
                    break;
                case "L":
                    return 12;
                    break;
                case "M":
                    return 13;
                    break;
                case "N":
                    return 14;
                    break;
                case "O":
                    return 15;
                    break;
                case "P":
                    return 16;
                    break;
                case "Q":
                    return 17;
                    break;
                case "R":
                    return 18;
                    break;
                case "S":
                    return 19;
                    break;
                case "T":
                    return 20;
                    break;
                case "U":
                    return 21;
                    break;
                case "V":
                    return 22;
                    break;
                case "W":
                    return 23;
                    break;
                case "X":
                    return 24;
                    break;
                case "Y":
                    return 25;
                    break;
                case "Z":
                    return 26;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        static string GetCharacter(int x)
        {

            switch (x)
            {
                case 1:
                    return "a";
                    break;
                case 2:
                    return "b";
                    break;
                case 3:
                    return "c";
                    break;
                case 4:
                    return "d";
                    break;
                case 5:
                    return "e";
                    break;
                case 6:
                    return "f";
                    break;
                case 7:
                    return "g";
                    break;
                case 8:
                    return "h";
                    break;
                case 9:
                    return "i";
                    break;
                case 10:
                    return "j";
                    break;
                case 11:
                    return "k";
                    break;
                case 12:
                    return "l";
                    break;
                case 13:
                    return "m";
                    break;
                case 14:
                    return "n";
                    break;
                case 15:
                    return "o";
                    break;
                case 16:
                    return "p";
                    break;
                case 17:
                    return "q";
                    break;
                case 18:
                    return "r";
                    break;
                case 19:
                    return "s";
                    break;
                case 20:
                    return "t";
                    break;
                case 21:
                    return "u";
                    break;
                case 22:
                    return "v";
                    break;
                case 23:
                    return "w";
                    break;
                case 24:
                    return "x";
                    break;
                case 25:
                    return "y";
                    break;
                case 26:
                    return "z";
                    break;
                default:
                    return "";
                    break;
            }
        }
    }
}
