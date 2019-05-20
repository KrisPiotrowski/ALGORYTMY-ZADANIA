using System;

namespace ETI06F1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution();
        }

        static void Solution()
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] tabFloat = Array.ConvertAll(tab, double.Parse);
            double r = tabFloat[0];
            double d = tabFloat[1];

            if (d >= 2 * r || d < 1 || 2 * r > 2000)
                throw new ArgumentException();

            double newR2 = r * r - Math.Pow((d / 2), 2);

            double result = Math.Round(3.141592654 * newR2,2);

            Console.WriteLine(result.ToString());
        }
    }
}
