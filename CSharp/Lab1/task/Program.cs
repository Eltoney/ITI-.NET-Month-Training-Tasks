using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            CharToAsci();
            AsciToChar();
            DECtoHex();
            minCalculator();
        }


        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        static void CharToAsci()
        {
            Console.Write("Enter your character: ");
            char x = Char.Parse(Console.ReadLine());
            int asc = (int)x;
            Console.WriteLine("The Ascii code of your character is: {0}", asc);
        }

        static void AsciToChar()
        {
            Console.Write("Enter your ASCII: ");
            int asc = int.Parse(Console.ReadLine());
            char x = (char)asc;
            Console.WriteLine("The character equivalent to your ascii code is: {0}", x);
        }


        static void DECtoHex()
        {
            Console.Write("Enter your number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} in hexadicimal form is {x:x}");
        }

        static void minCalculator()
        {
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum is: " + (x + y));
            Console.WriteLine("Dif is: " + (x - y));
            Console.WriteLine("Mul is: " + (x * y));
        }
    }
}
