using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            evenOroddCheck();
            degreeCheck();
            simpleCalculator();
            checkPrime();
            getFactorial();
        }


        static void evenOroddCheck()
        {
            Console.Write("Enter your number:");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is an even number");
            }
            else
            {
                Console.WriteLine("${x} is an odd number");
            }
        }


        static void degreeCheck()
        {
            Console.Write("Enter your degree:");
            int deg = int.Parse(Console.ReadLine());
            if (deg >= 90)
            {
                System.Console.WriteLine("You got an A");
            }
            else if (deg >= 80)
            {
                System.Console.WriteLine("You got an B");
            }
            else if (deg >= 60)
            {
                System.Console.WriteLine("You got an C");
            }
            else if (deg >= 50)
            {
                System.Console.WriteLine("You got an D");
            }
            else
            {
                System.Console.WriteLine("You got an F");
            }
        }

        static void simpleCalculator()
        {
            Console.Write("Enter your first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int y = int.Parse(Console.ReadLine());
            System.Console.Write("Enter your opeartion (*/-+): ");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                    System.Console.WriteLine($"{x} {op} {y} is {x + y}");
                    break;
                case '-':
                    System.Console.WriteLine($"{x} {op} {y} is {x - y}");
                    break;
                case '*':
                    System.Console.WriteLine($"{x} {op} {y} is {x * y}");
                    break;
                case '/':
                    System.Console.WriteLine($"{x} {op} {y} is {x / y}");
                    break;
                default:
                    System.Console.WriteLine("You enterd a wrong operation");
                    break;
            }
        }

        static void checkPrime()
        {
            Console.Write("Enter your number:");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.Write($"{n} is ");
            if (isPrime)
            {
                System.Console.WriteLine("a prime number");

            }
            else
            {
                System.Console.WriteLine("is not a prime number");
            }
        }
        static void getFactorial()
        {
            Console.Write("Enter your number:");
            int n = int.Parse(Console.ReadLine());
            int ans = 1;
            for (int i = 1; i <= n; i++)
            {
                ans *= i;
            }
            System.Console.WriteLine($"{n}! is {ans}");
        }
    }
}
