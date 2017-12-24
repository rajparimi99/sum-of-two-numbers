using System;

namespace CsharpPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            int z;
            int result;
            Console.Write("\n Enter the first number to be added: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the second number to be added: ");
            z = Convert.ToInt32(Console.ReadLine());
            result = x + z;
            Console.Write("\n The sum of two numbers is: " + result);
            Console.ReadLine();
        }
    }
}