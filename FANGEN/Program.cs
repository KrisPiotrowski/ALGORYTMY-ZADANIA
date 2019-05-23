using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FANGEN
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);
        
        static void Main(string[] args)
        {
            string txt = "";
            while (1==1)
            {
                string rdln = Console.ReadLine().ToString();
                if (rdln == "0")
                    break;
                txt += rdln + "!";
            }
            //Console.WriteLine(txt);
            Solution(txt);
            Console.WriteLine(wynik.ToString());
        }

        static void Solution(string txt)
        {
            string[] tabArg = txt.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tabInt = Array.ConvertAll(tabArg, int.Parse);
            //Console.WriteLine("tabLen: "+tab.Length);
            //foreach(int x in tabInt)
            //{
            //    Console.WriteLine(x);
            //}
            foreach (int x in tabInt)
            {
                int num = x;
                bool czyPrawy = num < 0 ? true : false;
                num = Math.Abs(num);

                char[,] tab = new char[2 * num, 2 * num];

                char[,] tab1 = czyPrawy == false ? LewyGorny(num) : PrawyDolny(num);
                char[,] tab2 = czyPrawy == false ? LewyDolny(num) : PrawyGorny(num);
                char[,] tab3 = czyPrawy == false ? PrawyGorny(num) : LewyDolny(num);
                char[,] tab4 = czyPrawy == false ? PrawyDolny(num) : LewyGorny(num);

                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        tab[i, j] = tab1[i, j];
                    }
                }

                for (int i = num; i < 2 * num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        tab[i, j] = tab2[i-num, j];
                    }
                }

                for (int i = 0; i < num; i++)
                {
                    for (int j = num; j < 2 * num; j++)
                    {
                        tab[i, j] = tab3[i, j-num];
                    }
                }

                for (int i = num; i < 2 * num; i++)
                {
                    for (int j = num; j < 2 * num; j++)
                    {
                        tab[i, j] = tab4[i-num, j-num];
                    }
                }

                for (int i = 0; i < 2 * num; i++)
                {
                    for (int j = 0; j < 2 * num; j++)
                    {
                        Console.Write(tab[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static char[,] LewyGorny(int num)
        {
            char[,] tab = new char[num,num];
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    if (j <= i)
                        tab[i, j] = '*';
                    else
                        tab[i, j] = '.';
                }
            }
            return tab;
        }

        static char[,] PrawyDolny(int num)
        {
            char[,] tab = new char[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (j < i)
                        tab[i, j] = '.';
                    else
                        tab[i, j] = '*';
                }
            }
            return tab;
        }

        static char[,] PrawyGorny(int num)
        {
            char[,] tab = new char[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (j < num - i)
                        tab[i, j] = '*';
                    else
                        tab[i, j] = '.';
                }
            }
            return tab;
        }

        static char[,] LewyDolny(int num)
        {
            char[,] tab = new char[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (j < num - i-1)
                        tab[i, j] = '.';
                    else
                        tab[i, j] = '*';
                }
            }
            return tab;
        }


    }
}
