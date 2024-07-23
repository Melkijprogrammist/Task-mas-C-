# 5 
  ## Программа сортировки массива
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
        // sorted 
        int temp;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length; j++) {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
        }
        Console.WriteLine("Вывод отсортированного массива: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
