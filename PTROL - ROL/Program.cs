using System;
using System.Text;

namespace PTROL___ROL
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {

            int Q = int.Parse(Console.ReadLine());

            if (Q < 1 || Q > 100)
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

            string[] tab = (Console.ReadLine()).Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder textNew = new StringBuilder(100000);

            if (Convert.ToInt32(tab[0]) < 1 || Convert.ToInt32(tab[0]) > 100 || tab.Length != Convert.ToInt32(tab[0]) + 1)
                throw new ArgumentException();

            for (int i = 2; i < tab.Length; i++)
            {
                textNew.Append(tab[i] + " ");
            }

            textNew.Append( tab[1]);
            
            if (!j)
                wynik.Append($"{textNew}\n");
            else
                wynik.Append($"{textNew}");
        }
    }
}
