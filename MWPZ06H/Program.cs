using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWPZ06H
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {

            int Q = int.Parse(Console.ReadLine());

            if (Q < 1 || Q > 100)
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
            int num = Convert.ToInt32(Console.ReadLine());

            string[] tab = (Console.ReadLine()).Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] tabInt = Array.ConvertAll(tab, int.Parse);

            Array.Sort(tabInt);

            int max = tabInt[tabInt.Length - 1];
            int[] newTab = new int[tabInt.Length];
            int ind = tabInt.Length - 1;
            int cnt = 0;

            while(ind >= 0 && tabInt[ind] == max)
            {
                newTab[cnt] = max;
                cnt++;
                ind--;
            }

            int ind2 = 0;

            while(tabInt[ind2] < max)
            {
                newTab[cnt] = tabInt[ind2];
                cnt++;
                ind2++;
            }

            foreach(int x in newTab)
            {
                wynik.Append(x.ToString() + " ");
            }
            wynik.Append("\n");

        }

        }
    }
