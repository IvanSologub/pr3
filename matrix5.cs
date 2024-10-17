using System;

class Program
{
    static void Main()
    {
        // Пример входных данных
        int M = 3; // Количество строк
        int N = 4; // Количество столбцов
        int D = 5; // Шаг арифметической прогрессии
        int[] numbers = { 1, 2, 3 }; // Исходный набор чисел

        // Создание матрицы M x N
        int[,] matrix = new int[M, N];

        // Заполнение матрицы
        for (int i = 0; i < M; i++)
        {
            // Устанавливаем первый столбец
            matrix[i, 0] = numbers[i];

            // Заполняем остальные столбцы
            for (int j = 1; j < N; j++)
            {
                matrix[i, j] = matrix[i, j - 1] + D;
            }
        }

        // Вывод матрицы на экран
        Console.WriteLine("Сформированная матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
