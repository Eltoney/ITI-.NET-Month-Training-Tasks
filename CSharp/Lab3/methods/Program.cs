using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static long factorial(int x)
        {
            long ans = 1;
            for (int i = 1; i < x; i++)
            {
                ans *= i;
            }
            return ans;
        }

        static long calcPower(int b, int p)
        {
            long ans = 1;
            for (int i = 0; i < p; i++)
            {
                ans *= b;
            }
            return ans;
        }


        static long calc(int x, int y, char op)
        {
            long ans = 0;
            switch (op)
            {
                case '+':
                    ans = x + y;
                    break;
                case '-':
                    ans = x - y;
                    break;
                case '*':
                    ans = x * y;
                    break;
                case '/':
                    ans = x / y;
                    break;
                default:
                    System.Console.WriteLine("You enterd a wrong operation");
                    break;
            }
            return ans;
        }
        static void swapNumber(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = x;
        }

        static void stringAnalyser(string str)
        {
            string[] arr = str.Split(" ");
            int wordCount = arr.Length, charCount = 0;
            foreach (string word in arr)
            {
                charCount += word.Length;
            }
            System.Console.WriteLine($"The string has {wordCount} words and {charCount} characters");

        }
    }
}
