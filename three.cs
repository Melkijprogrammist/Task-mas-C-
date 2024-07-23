## 3
 # Количество положительных чисел

using System;

class Program
{
    static void Main(string[] args)
    {
        int [] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
        int result = 0;

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                result++;
            }
        }
        Console.WriteLine($"Число элементов больше нуля: {result}");
    }
}
