# 1 
  Блок 1. Выводит все элементы массива.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
