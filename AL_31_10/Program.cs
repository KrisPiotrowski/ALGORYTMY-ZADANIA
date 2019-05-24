using System;
using System.IO;
using System.Text;

namespace AL_31_10
{
    class Program
    {

        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
            try
            { 
            wynik.Append($"{Solution()}\n");
            Console.WriteLine(wynik.ToString());
            }
            catch(Exception e)
            {
                return;
            }
        }

        static string Solution()
        {
            string input = "";
            string txt;

            while ((txt = Console.ReadLine().ToString()) != null && txt != "")
            {
                input += txt;
            }
            
            // Console.WriteLine("input: " + input);

            string[] tab = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            
            for (int j = 0; j < tab.Length; j++)
            {
                string str = tab[j];
                int max = 0, max2 = 0, index = 0, index2 = 0;
                int[] freq = new int[26];

                for (int i = 0; i < str.Length; i++)
                {
                    int pos = GetCharPosition(str[i]);
                    if (pos >= 0 && GetCharPosition(str[i]) <= 25)
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
                //Console.WriteLine("max:  "+max); //test
                //Console.WriteLine("max2: "+max2); //test

                if (((double)max > 0 && (double)max2 == 0) || ((double)max / (double)max2 > 2))
                    result += (j + 1).ToString() + " - " + GetCharacter(index)+"\n";
                else
                    result += (j+1).ToString() + " - BRAK\n";
            }
            return result;
        }

        static int GetCharPosition(char x)
        {

            string str = x.ToString().ToUpper();

            switch (str)
            {
                case "A":
                    return 0;
                    break;
                case "B":
                    return 1;
                    break;
                case "C":
                    return 2;
                    break;
                case "D":
                    return 3;
                    break;
                case "E":
                    return 4;
                    break;
                case "F":
                    return 5;
                    break;
                case "G":
                    return 6;
                    break;
                case "H":
                    return 7;
                    break;
                case "I":
                    return 8;
                    break;
                case "J":
                    return 9;;
                    break;
                case "K":
                    return 10;
                    break;
                case "L":
                    return 11;
                    break;
                case "M":
                    return 12;
                    break;
                case "N":
                    return 13;
                    break;
                case "O":
                    return 14;
                    break;
                case "P":
                    return 15;
                    break;
                case "Q":
                    return 16;
                    break;
                case "R":
                    return 17;
                    break;
                case "S":
                    return 18;
                    break;
                case "T":
                    return 19;
                    break;
                case "U":
                    return 20;
                    break;
                case "V":
                    return 21;
                    break;
                case "W":
                    return 22;
                    break;
                case "X":
                    return 23;
                    break;
                case "Y":
                    return 24;
                    break;
                case "Z":
                    return 25;
                    break;
                default:
                    return 999;
                    break;
            }
        }

        static string GetCharacter(int x)
        {

            switch (x)
            {
                case 0:
                    return "a";
                    break;
                case 1:
                    return "b";
                    break;
                case 2:
                    return "c";
                    break;
                case 3:
                    return "d";
                    break;
                case 4:
                    return "e";
                    break;
                case 5:
                    return "f";
                    break;
                case 6:
                    return "g";
                    break;
                case 7:
                    return "h";
                    break;
                case 8:
                    return "i";
                    break;
                case 9:
                    return "j";
                    break;
                case 10:
                    return "k";
                    break;
                case 11:
                    return "l";
                    break;
                case 12:
                    return "m";
                    break;
                case 13:
                    return "n";
                    break;
                case 14:
                    return "o";
                    break;
                case 15:
                    return "p";
                    break;
                case 16:
                    return "q";
                    break;
                case 17:
                    return "r";
                    break;
                case 18:
                    return "s";
                    break;
                case 19:
                    return "t";
                    break;
                case 20:
                    return "u";
                    break;
                case 21:
                    return "v";
                    break;
                case 22:
                    return "w";
                    break;
                case 23:
                    return "x";
                    break;
                case 24:
                    return "y";
                    break;
                case 25:
                    return "z";
                    break;
                default:
                    return "";
                    break;
            }


        }

    }
}
