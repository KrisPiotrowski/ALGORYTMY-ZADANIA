using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_09_12
{
    class Program
    {

        static void Main(string[] args)
        {

            int Q = int.Parse(Console.ReadLine());

            int[,] tab = new int[2,Q];

            for (int i = 0; i < Q; i++)
            {
                int[] x = GetNumber1();
                tab[0, i] = x[0];
                tab[1, i] = x[1];
            }

            Stack<int> s = new Stack<int>();
            s.Push(tab[1,0]);

            for (int i = 1; i < Q; i++)
            {
                if(tab[1,i] > s.Peek())
                {
                    s.Push(tab[1,i]);
                }
                else if (tab[1,i] == s.Peek() && (tab[0,i] - tab[0,i-1] > 1))
                {
                    s.Push(tab[1, i]);
                }
                else if (tab[1,i] < s.Peek())
                {
                    while (s.Count > 0 && s.Peek() > tab[1,i])
                    {
                        s.Pop();
                    }
                    s.Push(tab[1,i]);
                }
                //Console.WriteLine("i: " + i + ", s.Cnt: " + s.Count);
            }

            Console.WriteLine(s.Count);
        }

        static int[] GetNumber1()
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(tab,int.Parse);
        }
    }
}
