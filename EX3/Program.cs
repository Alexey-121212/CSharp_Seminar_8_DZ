﻿// Умножения двух матриц

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
// 💡 Поделиться мнением
// 🔥