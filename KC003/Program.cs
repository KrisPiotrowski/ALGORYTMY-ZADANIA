using System;
using System.Text;

namespace KC003
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
         
                Solution();
            Console.WriteLine(wynik.ToString());
        }

        static void Solution()
        {
            string result = "";
            while (1 == 1)
            {
                string text = Console.ReadLine().ToString();
                if (text != "")
                {
                    string[] tab = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    double[] tabDbl = Array.ConvertAll(tab, double.Parse);

                    if (tabDbl[0] + tabDbl[1] > tabDbl[2] && tabDbl[2] + tabDbl[1] > tabDbl[0] && tabDbl[0] + tabDbl[2] > tabDbl[1])
                        result += "1";
                    else
                        result += "0";

                    wynik.Append($"{result}\n");

                    result = "";
                }
                else
                {
                    break;
                }
            }
        }
    }
}
