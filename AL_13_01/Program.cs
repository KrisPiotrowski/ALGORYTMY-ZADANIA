using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL_13_01
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());

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
            int x = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[x];
            int i = 1;
            bool w = true;
            string result = "";

            while (i <= x)
            {
                for(int k = 0; k < tab.Length; k++)
                {
                    if (tab[k] == 0)
                    {
                        if (w)
                        {
                            tab[k] = i;
                            i++;
                        }
                        w = (w == true) ? w = false : w = true;
                    }
                }
            }

            foreach(int y in tab)
            {
                result += y.ToString() + " ";
            }
            

            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }
}
