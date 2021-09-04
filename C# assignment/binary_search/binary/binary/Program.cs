using System;

namespace forgetCode
{
    class Program
    {
        public static void Main()
        {
            int[] a = { 10, 20, 30, 40, 50 };
            int x = a.Length;
            Console.WriteLine("Enter Search element");
            int key = int.Parse(Console.ReadLine());
            int low = 0;
            int high = x - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (key < a[mid])
                    high = mid - 1;
                else if (key > a[mid])
                    low = mid + 1;
                else if (key == a[mid])
                {
                    Console.WriteLine("element found");
                    return;
                }
            }
            Console.WriteLine("Element not found");
        }
    }
}