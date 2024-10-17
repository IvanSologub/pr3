using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Пример входного массива и номера серии K
        int[] inputArray = { 1, 1, 2, 2, 2, 3, 4, 4, 4, 5 };
        int K = 2; // Номер серии для удвоения

        // Преобразование массива
        int[] resultArray = DuplicateSeries(inputArray, K);

        // Вывод результата
        Console.WriteLine("Преобразованный массив:");
        Console.WriteLine(string.Join(", ", resultArray));
    }

    static int[] DuplicateSeries(int[] array, int K)
    {
        List<int> resultList = new List<int>();
        int n = array.Length;

        if (K <= 0) return array; // Если K <= 0, возвращаем исходный массив

        List<(int value, int count)> series = new List<(int value, int count)>();

        // Находим все серии
        for (int i = 0; i < n; )
        {
            int currentValue = array[i];
            int count = 0;

            // Считаем длину текущей серии
            while (i < n && array[i] == currentValue)
            {
                count++;
                i++;
            }

            series.Add((currentValue, count));
        }

        // Проверяем, существует ли серия с номером K
        if (K > series.Count) return array; // Если серий меньше K, возвращаем исходный массив

        // Удваиваем серию с номером K
        var targetSeries = series[K - 1]; // K-1, так как индексация начинается с 0

        for (int i = 0; i < series.Count; i++)
        {
            var (value, count) = series[i];

            if (i == K - 1) // Если это нужная серия
            {
                // Удваиваем длину серии
                for (int j = 0; j < count * 2; j++)
                {
                    resultList.Add(value);
                }
            }
            else
            {
                // Добавляем остальные серии без изменений
                for (int j = 0; j < count; j++)
                {
                    resultList.Add(value);
                }
            }
        }

        return resultList.ToArray();
    }
}
