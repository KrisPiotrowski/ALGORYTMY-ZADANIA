using System;
using System.Text;

namespace AL_17_02
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);
        static void Main(string[] args)
        {
            try
            {
                long Q = long.Parse(Console.ReadLine());

                for (long i = 1; i <= Q; i++)
                {
                    bool num = false;
                    if (i == Q)
                        num = true;
                    Solution(num);
                }
                Console.WriteLine(wynik.ToString());
            }
            catch(Exception e)
            {
                return;
            }
        }

        static void Solution(bool j)
        {
            long len = Convert.ToInt64(Console.ReadLine());
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (len != tab.Length)
                throw new ArgumentException();
            long[] tablong = Array.ConvertAll(tab, long.Parse);
            //Console.WriteLine("tabLong: ");
            //foreach(long xx in tablong)
            //{
            //    Console.Write(xx+" ");
            //}
            long result = 0;
            long singleLen = 0;
            long x1 = 0;
            long x2 = 0;

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
                x1 = tablong[0];
                x2 = tablong[1];
                result = 2;
                singleLen = 2;
                for(long i = 2; i < tablong.Length; i++)
                {
                    if (tablong[i] == x1 || tablong[i] == x2 || (x1 == x2 && x1 != tablong[i]))
                        singleLen += 1;
                    else
                        singleLen = 2;

                    if (singleLen > result)
                        result = singleLen;

                    if((tablong[i] != x1 && tablong[i] != x2) ||(x1 == tablong[i] && x2 != tablong[i]))
                    {
                        x1 = x2;
                        x2 = tablong[i];
                    }
                    else if (x1 == x2 && x1 != tablong[i])
                    {
                        x2 = tablong[i];
                    }
                }
            }
            if (!j)
                wynik.Append($"{result} 0 \n");
            else
                wynik.Append($"{result}");
        }
    }
}
