// Определение строки с наименьшей суммой элементов

// Инструкция по использованию платформы



// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс Answer, который содержит следующие статические методы:

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

// Аргументы, передаваемые в метод/функцию:

// '9, 1, 7; 1, 2, 3; 4, 5, 6'
// На выходе:


// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   

// Сумма наименьшей строки (строка 2): 6

// Ожидаемый ответ:

// Исходная матрица:
// 9	1	7	
// 1	2	3	
// 4	5	6	

// Сумма наименьшей строки (строка 2): 6

// Ваш ответ:

// Исходная матрица:
// 9	1	7	
// 1	2	3	
// 4	5	6	

// Сумма наименьшей строки (строка 3): 15



int[,] matrix;
matrix = new int[,]
{
                {9, 5, 3},
                {9, 6, 2},
                {7, 6, 5}
};
Console.WriteLine("Исходная матрица:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

int[] minSumRow = MinimumSumRow(matrix);

Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

// Methods

static int SumOfRow(int[,] matrix, int row)
{
    // Введите свое решение ниже
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[row, i];
    }
    return sum;
}

static int[] MinimumSumRow(int[,] matrix)
{
    // Введите свое решение ниже
    int[] minRow = new int[2];
    int min = SumOfRow(matrix, 0);
    int minR = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (SumOfRow(matrix, i) < min)
        {
            min = SumOfRow(matrix, i);
            minR = i;
        }
    }
    minRow[0] = minR;
    minRow[1] = min;
    return minRow;
}