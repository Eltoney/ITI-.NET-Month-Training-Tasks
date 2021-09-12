using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            System.Console.WriteLine("Enter the array numbers one by one in seperated line");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0, mxVal = arr[0], mnVal = arr[0];
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > mxVal)
                {
                    mxVal = arr[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < mnVal)
                {
                    mnVal = arr[i];
                }
            }
            System.Console.WriteLine($"The sum of your array is {sum}");
            System.Console.WriteLine($"The minumim number in the array is {mnVal}");
            System.Console.WriteLine($"The maximum number in the array is {mxVal}");
        }
    }
}
