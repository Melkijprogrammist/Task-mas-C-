## 4
  #Инверсия массива

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

        int n = arr.Length;
        int k = n / 2;
        int temp;

        for (int i = 0; i < k; i++)
        {
            temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;
        }
        foreach(int i in arr)
        {
            Console.WriteLine($"{i} \t");
        }
    }
}
