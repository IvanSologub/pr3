using System;

class Program
{
    static void Main()
    {
        // Пример входных данных
        int M = 4; // Количество строк (четное)
        int N = 4; // Количество столбцов (четное)

        // Создание и заполнение матрицы
        int[,] matrix = new int[M, N];
        Random rand = new Random();
        
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(1, 10); // Заполнение случайными числами
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Размеры четвертей
        int halfM = M / 2;
        int halfN = N / 2;

        // Меняем местами левую нижнюю и правую верхнюю четверти
        for (int i = 0; i < halfM; i++)
        {
            for (int j = 0; j < halfN; j++)
            {
                // Временная переменная для обмена значениями
                int temp = matrix[i + halfM, j]; // Левый нижний элемент
                matrix[i + halfM, j] = matrix[i, j + halfN]; // Правый верхний элемент
                matrix[i, j + halfN] = temp; // Возвращаем значение в правый верхний элемент
            }
        }

        // Вывод измененной матрицы
        Console.WriteLine("\nИзмененная матрица:");
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
