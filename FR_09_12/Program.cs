using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_09_12
{
    class Program
    {

        static void Main(string[] args)
        {

            int Q = int.Parse(Console.ReadLine());

            int[,] tab = new int[2,Q];

            for (int i = 0; i < Q; i++)
            {
                int[] x = GetNumber1();
                tab[0, i] = x[0];
                tab[1, i] = x[1];
            }

            int currentMin = tab[1, Q - 1];
            bool isAdjacent = true;
            int cnt = 1;

            for (int i = Q-2; i >=0; i--)
            {
                if(isAdjacent == true)
                {
                    if (tab[0, i + 1] - tab[0, i] > 1)
                        isAdjacent = false;
                }

                if(tab[1,i] < currentMin)
                {
                    currentMin = tab[1, i];
                    cnt++;
                    isAdjacent = true; // do zweryfikowania
                }
                else if (tab[1, i] == currentMin && isAdjacent == false)
                {
                    cnt++;
                    isAdjacent = true;
                }
            }

            Console.WriteLine(cnt);
        }

        static int[] GetNumber1()
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(tab,int.Parse);
        }
    }
}
