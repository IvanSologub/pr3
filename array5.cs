using System;

class Program
{
    static void Main()
    {
        // Ввод данных
        Console.WriteLine("Введите целое число N (> 2):");
        int N = int.Parse(Console.ReadLine());

        // Проверка условия
        if (N <= 2)
        {
            Console.WriteLine("N должно быть больше 2.");
            return;
        }

        // Создание массива для хранения членов последовательности Фибоначчи
        int[] fibonacci = new int[N];

        // Инициализация первых двух членов
        fibonacci[0] = 1;
        fibonacci[1] = 1;

        // Заполнение массива
        for (int i = 2; i < N; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        // Вывод массива
        Console.WriteLine("Первые N членов последовательности Фибоначчи:");
        foreach (var item in fibonacci)
        {
            Console.WriteLine(item);
        }
    }
}
