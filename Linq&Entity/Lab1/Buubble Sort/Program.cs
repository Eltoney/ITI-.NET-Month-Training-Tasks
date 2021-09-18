using System;

namespace Buubble_Sort
{
    class bubSort
    {
        static bool Asc(int a, int b)
        {
            return a < b;
        }

        static bool Dsc(int a, int b)
        {
            return a > b;
        }


        delegate bool cmp(int a, int b);

        void bubleSort(int[] arr, cmp compare)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compare(arr[j], arr[j + 1]))
                    {
                        swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        private void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }

        public void bubleSortAsc(int[] arr)
        {

            cmp ascSort = Asc;
            bubleSort(arr, Asc);
        }

        public void bubleSortDsc(int[] arr)
        {


            cmp dscSort = Dsc;
            bubleSort(arr, Dsc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 10, 1, 5, 3 };
            bubSort b = new bubSort();
            b.bubleSortAsc(arr);
            System.Console.Write("Ascending  order is: ");
            foreach (int x in arr)
            {
                System.Console.Write($"{x} ");
            }
            System.Console.WriteLine();

            b.bubleSortDsc(arr);
            System.Console.Write("Descending order is: ");
            foreach (int x in arr)
            {
                System.Console.Write($"{x} ");
            }
             System.Console.WriteLine();
        }
    }
}
