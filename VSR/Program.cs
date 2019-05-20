using System;
using System.Text;


    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());

            if (Q < 1 || Q > 1000)
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

            if (a < 1 || b < 1 || a > 10000 || b > 10000)
                throw new ArgumentException();

            result = (2 * a * b) / (a + b);

            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }

