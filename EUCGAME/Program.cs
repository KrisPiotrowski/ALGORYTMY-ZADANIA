using System;
using System.Text;

namespace EUCGAME
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {

            int Q = int.Parse(Console.ReadLine());

            if (Q <= 0 || Q >= 11)
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

            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tabInt = Array.ConvertAll(tab, int.Parse);
            int a = tabInt[0];
            int b = tabInt[1];
            int result = 0;

            if (a <= 0 || b <= 0 || a >= 1000000001 || b >= 1000000001)
                throw new ArgumentException();

            while ((a > b && a - b > 0) || (b > a && b - a > 0))
            {
                if (a > b)
                    a -= b;
                else if (b > a)
                    b -= a;
            }

            result = a + b;

            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }
}