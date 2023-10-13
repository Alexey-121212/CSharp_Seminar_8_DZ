// Умножения двух матриц

// Инструкция по использованию платформы



// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB. Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply." В противном случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц matrixA и matrixB. Метод возвращает новую матрицу, которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// Если аргументы не переданы, программа использует матрицы по умолчанию. Если аргументы переданы, программа парсит их в двумерные массивы целых чисел и выполняет умножение матриц.

// Аргументы, передаваемые в метод/функцию:

// '1,2;3,4'
// На выходе:


// Исходная матрица:
// 1   2   
// 3   4   

// Matrix B:
// 5   6   
// 7   8   

// Multiplication result:
// 19  22  
// 43  50

// Ожидаемый ответ:

// Исходная матрица:
// 2	4	
// 1	3	
// 5	6	

// Matrix B:
// 5	6	
// 7	8	

// Multiplication result:
// 38	44	
// 26	30	
// 67	78


int[,] matrix;
matrix = new int[,]
{
                {5, 2},
                {8, 1}
};
Console.Clear();
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

Console.WriteLine("\nMatrix B:");
PrintMatrix(matrixB);

Console.WriteLine("\nMultiplication result:");

MultiplyIfPossible(matrix, matrixB);

// Methods

static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{ // Введите свое решение ниже
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.Write("It is impossible to multiply.");
    }
    else
    {
        PrintMatrix(MatrixMultiplication(matrixA, matrixB));
    }
}

static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{  // Введите свое решение ниже
    int rA = matrixA.GetLength(0);
    int cA = matrixA.GetLength(1);
    int cB = matrixB.GetLength(1);

    int temp;
    int[,] matrixMultiplicated = new int[rA, cB];
    for (int i = 0; i < rA; i++)
    {
        for (int j = 0; j < cB; j++)
        {
            temp = 0;
            for (int k = 0; k < cA; k++)
            {
                temp += matrixA[i, k] * matrixB[k, j];
            }
            matrixMultiplicated[i, j] = temp;
        }
    }
    return matrixMultiplicated;
}

static void PrintMatrix(int[,] matrix)
{  // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}