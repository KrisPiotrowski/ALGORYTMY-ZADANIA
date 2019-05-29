using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_05_16
{
    class Program
    {
        static Stack<int> s = new Stack<int>();
        static void Main(string[] args)
        {
         
                int Q = int.Parse(Console.ReadLine());

                for (int i = 1; i <= Q; i++)
                {
                    string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (tab[0] == "1")
                    {
                        s.Push(Convert.ToInt32(tab[1]));
                    }
                    else
                    {
                        int x = s.Pop();
                        int y = s.Pop();
                        if (tab[1] == "*")
                            s.Push(y * x);
                        else if (tab[1] == "+")
                            s.Push(y + x);
                        else if (tab[1] == "/")
                            s.Push(y / x);
                        else if (tab[1] == "-")
                            s.Push(y - x);
                    //Console.WriteLine("szczyt stosu: "+s.Peek());
                    }
                }
                Console.WriteLine(s.Pop());
                Console.WriteLine("ONP");
      
        }
    }
}
