using System;

namespace Mamma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mamma is running now.....");
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Console Is Writing - " + i.ToString());
            }

            Console.ReadLine();
        }
    }
}
