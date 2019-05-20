using System;
using System.Text;


class Program
{
    static StringBuilder wynik = new StringBuilder(100000);

    static void Main(string[] args)
    {
        int Q = int.Parse(Console.ReadLine());

        if (Q < 1 || Q > 20)
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

        string text = Console.ReadLine();
        if (text.Length < 4 || text.Length > 20)
            throw new ArgumentException();
        string newText = "";

        for (int i = 0; i < text.Length; i++)
        {
            newText += ChangeLetter(text[i]);
        }

        if (!j)
            wynik.Append($"{newText}\n");
        else
            wynik.Append($"{newText}");
    }

    public static string ChangeLetter(char x)
    {

        if (x.ToString() == "A" || x.ToString() == "B" || x.ToString() == "C")
        {
            return "2";
        }
        else if (x.ToString() == "D" || x.ToString() == "E" || x.ToString() == "F")
        {
            return "3";
        }
        else if (x.ToString() == "G" || x.ToString() == "H" || x.ToString() == "I")
        {
            return "4";
        }
        else if (x.ToString() == "J" || x.ToString() == "K" || x.ToString() == "L")
        {
            return "5";
        }
        else if (x.ToString() == "M" || x.ToString() == "N" || x.ToString() == "O")
        {
            return "6";
        }
        else if (x.ToString() == "P" || x.ToString() == "Q" || x.ToString() == "R" || x.ToString() == "S")
        {
            return "7";
        }
        else if (x.ToString() == "T" || x.ToString() == "U" || x.ToString() == "V")
        {
            return "8";
        }
        else if (x.ToString() == "W" || x.ToString() == "X" || x.ToString() == "Y" || x.ToString() == "Z")
        {
            return "9";
        }
        else
        {
            return "";
        }
    }
}

