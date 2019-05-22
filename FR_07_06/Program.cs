using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_07_06
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());

            if (Q > 1000000 || Q < 1)
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
            long num = Convert.ToInt32(Console.ReadLine());

            if (num > 1000000 || num < 1)
                throw new ArgumentException();

            long result = (num*(num+1)*(2*num + 1))/6;
            
            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }
}
