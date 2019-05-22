using System;
using System.Text;

namespace AL_17_02
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
            int len = Convert.ToInt32(Console.ReadLine());
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (len != tab.Length)
                throw new ArgumentException();
            int[] tabInt = Array.ConvertAll(tab, int.Parse);

            int result = 0;
            int singleLen = 0;
            int x1 = 0;
            int x2 = 0;

            if (len ==1)
            {
                result = 1;
            }
            else if(len == 2)
            {
                result = 2;
            }
            else
            {
                x1 = tabInt[0];
                x2 = tabInt[1];
                result = 2;
                singleLen = 2;
                for(int i = 2; i < tabInt.Length; i++)
                {
                    if (tabInt[i] == x1 || tabInt[i] == x2 || (x1 == x2 && x1 != tabInt[i]))
                        singleLen += 1;
                    else
                        singleLen = 2;

                    if (singleLen > result)
                        result = singleLen;

                    if((tabInt[i] != x1 && tabInt[i] != x2) ||(x1 == tabInt[i] && x2 != tabInt[i]))
                    {
                        x1 = x2;
                        x2 = tabInt[i];
                    }
                    else if (x1 == x2 && x1 != tabInt[i])
                    {
                        x2 = tabInt[i];
                    }
                }
            }

            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }
}
