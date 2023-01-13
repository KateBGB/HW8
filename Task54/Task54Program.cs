//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


void SortNumbersInRows(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int k =0; k <matrix.GetLength(1); k ++)
        {
            for(int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                if(matrix[i,j] < matrix[i, j+1])
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i, j+1];
                    matrix[i, j+1] = temp;
                }
            }
        }
    }   
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

//Задать размер массива
int rows = EnterData("Введение количество строк");
int columns = EnterData("Введение количество столбцов");

//Задать двумерный массив
int[,] mymatrix = FillArray(rows, columns, 0, 10 );
PrintArray(mymatrix);
Console.WriteLine();

//Пройтись по строкам и упорядочить элементы в них по убыванию
SortNumbersInRows(mymatrix);

//Вывести новый массив
PrintArray(mymatrix);


