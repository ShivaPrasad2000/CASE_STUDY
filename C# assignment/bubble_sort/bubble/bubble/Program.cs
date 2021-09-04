using System;

class GFG
{
    static void bubble(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
    }
    static void print(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(a[i] + " ");
        Console.WriteLine();
    }
     static void Main()
    {
        int[] arr = { 50,23,42,21,90 };
        bubble(arr);
        print(arr);
    }

}