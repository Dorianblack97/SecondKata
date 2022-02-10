using System;

namespace KataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ho detto un numero!");
            }

            Console.WriteLine();
            FizzBuzzCounter counter = new FizzBuzzCounter();
            counter.Counter(input).ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
