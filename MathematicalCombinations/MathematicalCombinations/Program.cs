using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите общее количество объектов (n) и количество выбираемых объектов (k) для расчета сочетаний:");

        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0 &&
            int.TryParse(Console.ReadLine(), out int k) && k >= 0 && k <= n)
        {
            long combinations = CalculateCombinations(n, k);
            Console.WriteLine($"Количество сочетаний из {n} по {k} = {combinations}");
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректные положительные числа, и k не должно превышать n.");
        }
    }

    static long CalculateCombinations(int n, int k)
    {
        return CalculateFactorial(n) / (CalculateFactorial(k) * CalculateFactorial(n - k));
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0) return 1;
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}