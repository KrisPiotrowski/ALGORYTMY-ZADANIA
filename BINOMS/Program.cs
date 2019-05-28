using System;
using System.Text;

namespace BINOMS
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
            try
            {
                int Q = int.Parse(Console.ReadLine());

                if (Q >= 10001)
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
            catch(Exception e)
            {

                Console.WriteLine(e);
                return;
            }
        }

        static void Solution(bool j)
        {

            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            decimal[] tabInt = Array.ConvertAll(tab, decimal.Parse);
            decimal a = tabInt[0];
            decimal b = tabInt[1];
            decimal result = 0;

            if (a < 0 || b < 0 || a > 1000 || b > 1000 || a < b)
                throw new ArgumentException();

            decimal l = 0;
            decimal m = 1;
            decimal iteratorL = a;
            decimal iteratorM = 0;
            decimal iteratorPoczL = 0;

            if (b > a - b)
            {
                l = b + 1;
                iteratorM = a - b;
                iteratorPoczL = b + 2;
            }
            else
            {
                l = a - b + 1;
                iteratorM = b;
                iteratorPoczL = a - b + 2;
            }

            if (a == 0 || b == 0 || a == b)
            {
                result = 1;
            }
            else
            {
                for (decimal i = iteratorPoczL; i <= iteratorL; i++)
                {
                    l *= i;
                    //Console.WriteLine("l: " + l.ToString());
                }

                for (decimal i = m + 1; i <= iteratorM; i++)
                {
                    m *= i;
                    //Console.WriteLine("m: " + m.ToString());
                }

                result = l / m;
            }

            if (!j)

                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }
}