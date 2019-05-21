using System;
using System.Text;

namespace JPESEL
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {

            int Q = int.Parse(Console.ReadLine());

            //if (Q <= 0 || Q >= 11)
            //    throw new ArgumentException();

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

            string PESEL = Console.ReadLine();

            int add =  Convert.ToInt32(PESEL[0]) * 1
                        + Convert.ToInt32(PESEL[1]) * 3
                        + Convert.ToInt32(PESEL[2]) * 7
                        + Convert.ToInt32(PESEL[3]) * 9
                        + Convert.ToInt32(PESEL[4]) * 1
                        + Convert.ToInt32(PESEL[5]) * 3
                        + Convert.ToInt32(PESEL[6]) * 7
                        + Convert.ToInt32(PESEL[7]) * 9
                        + Convert.ToInt32(PESEL[8]) * 1
                        + Convert.ToInt32(PESEL[9]) * 3
                        + Convert.ToInt32(PESEL[10]) * 1;
            
            string result = "";

            if (add % 10 == 0)
                result += "D";
            else
                result += "N";

            if (!j)
                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }
    }
}