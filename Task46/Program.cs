// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // rows < matrix.GetLength(0) Это первый ряд
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // columns < matrix.GetLength(1) Это второй ряд
        {
            matr[rows, columns] = new Random().Next(-10, 10); // [1,10)
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // rows < matrix.GetLength(0) Это первый ряд
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // columns < matrix.GetLength(1) Это второй ряд
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);