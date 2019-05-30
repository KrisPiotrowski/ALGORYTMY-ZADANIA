using System;

namespace FR_09_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());

            long[,] tab = new long[2,Q];

            for (int i = 0; i < Q; i++)
            {
                long[] x = GetNumber1();
                tab[0, i] = x[0];
                tab[1, i] = x[1];
            }

            long currentMin = tab[1, Q - 1];
            bool isAdjacent = true;
            long cnt = 1;

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

        static long[] GetNumber1()
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(tab,long.Parse);
        }
    }
}
