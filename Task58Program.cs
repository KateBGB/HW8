// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MatrixMultiplication(int[,] firstmatrix, int[,] secondmatrix)
{
    int[,] multmatrix = new int[firstmatrix.GetLength(0), secondmatrix.GetLength(1)];
    for(int i =0; i < firstmatrix.GetLength(0); i++)
    {
        for(int j =0; j<secondmatrix.GetLength(1); j++)
        {
            for(int k =0; k < firstmatrix.GetLength(0); k++)
            {
                multmatrix[i,j] += firstmatrix[i,k]*secondmatrix[k,j];
            }
        }
    }
    return multmatrix;
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int start, int end)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Задать размер матрицы
int rows = EnterData("Введение количество строк");
int columns = EnterData("Введение количество столбцов");
Console.WriteLine();

//Заполнить первую матрицу
int[,] firstmatrix = FillArray(rows, columns, 0, 10);
PrintArray(firstmatrix);
Console.WriteLine();

//Заполнить вторую матрицу
int[,] secondmatrix = FillArray(rows, columns, 0, 10);
PrintArray(secondmatrix);
Console.WriteLine();

//Найти произведение матриц
int[,] multmatrix = MatrixMultiplication(firstmatrix, secondmatrix);
PrintArray(multmatrix);
