using System;
using System.Text;

namespace PTCLTZ
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

            int num = Convert.ToInt32(Console.ReadLine());
            int licznik = 0;
            int result = 0;

            while (1==1)
            {
                if (num == 1)
                {
                    result = licznik;
                    break;
                }
                else if (num % 2 == 0)
                    num /= 2;
                else
                    num = 3 * num + 1;
                licznik++;
            }
            
            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }
}
