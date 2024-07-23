# 2
  Блок 2. Выводит все элементы массива в обратном порядке.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}
