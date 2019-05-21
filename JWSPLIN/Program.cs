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

            if (Q > 100)
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

            string[] tab = (Console.ReadLine()).Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tabInt = Array.ConvertAll(tab, int.Parse);
            string result = "";

            double x1 = tabInt[0];
            double y1 = tabInt[1];
            double x2 = tabInt[2];
            double y2 = tabInt[3];
            double x3 = tabInt[4];
            double y3 = tabInt[5];
            double a = 0;
            double b = 0;

            if ((x1 == x2 && x2 == x3) || (y1 == y2 && y2 == y3))
                result = "TAK";
            else { 
                a = (y1 - y2) / (x1 - x2);
                b = y2 - x2 * a;

                if (y3 == a * x3 + b)
                    result += "TAK";
                else
                    result += "NIE"; 
        }

            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }
}
