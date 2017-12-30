

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name?");
            string name = Console.ReadLine(); 
            Console.WriteLine("this is a test, " + name);

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age < 20)
            {
                Console.WriteLine("Wow, you are young!");
            }
            else
            {
                Console.WriteLine("Wow, you are old");
            }
        }
    }
}
