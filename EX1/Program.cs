// Сортировка строк матрицы по убыванию

// Инструкция по использованию платформы



// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так, чтобы элементы в каждой строке шли по убыванию.

// Аргументы, передаваемые в метод/функцию:

// '9, 1, 7; 1, 2, 3; 4, 5, 6'

// На выходе:


// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Матрица с упорядоченными по убыванию строками:
// 9   7   1   
// 3   2   1   
// 6   5   4

using System.Security.Principal;

int[,] matrix;

matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
};

Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

SortRowsDescending(matrix);

Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
PrintMatrix(matrix);

static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


static void SortRowsDescending(int[,] matrix)
{
    bool sortingDone;
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sortingDone = false;
        while (!sortingDone)
        {
            sortingDone = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if ((j != 0) && (matrix[i, j] > matrix[i, j - 1]))
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j - 1]; ;
                    matrix[i, j - 1] = temp;
                    sortingDone = false;
                }
            }
        }
    }
}