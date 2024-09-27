using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wpisz liczbę od 1 do 40");
#pragma warning disable CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
        string liczba = Console.ReadLine();
        if (liczba == "")
        {
            Environment.Exit(0);
        }
#pragma warning restore CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
        int l = Convert.ToInt16(liczba);
        if (l == 0)
        {
            Environment.Exit(0);
        }
        else if (l < 0)
        {
            Environment.Exit(0);
        }
        else if (l > 40)
        {
            Environment.Exit(0);
        }
        else
        {
            for (int i = 0; i < l; i++)
            {
                int n = fib(l);
                for (int j = 0; j < n; j++)
                {
                    int m = fib(l);
                    Console.WriteLine(m);
                }
            }
        }

        static int fib(int l)
        {
            
                return (l <= 2) ? 1 : fib(l - 1) + fib(l - 2);
        }
    }
   
}