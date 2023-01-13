// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void PrintArrayCoordinates (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
int[,,]FillArray3D(int dimension1, int dimension2, int dimension3, int start, int end)
{
    int[,,] array = new int[dimension1, dimension2,dimension3];
    for(int i = 0; i < dimension1; i++)
    {
        for(int j = 0; j < dimension2; j++)
        {
            for(int k = 0; k < dimension3; k++)        
            {
                array[i,j,k] = new Random().Next(start, end + 1);
            }
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


//Задать трехмерный массив 
int dimension1 = EnterData("Введите размер 1: ");
int dimension2 = EnterData("Введите размер 2: ");
int dimension3 = EnterData("Введите размер 3: ");

int [,,] array3D  = FillArray3D(dimension1, dimension2, dimension3, 10, 99);
PrintArrayCoordinates(array3D);
//Вывести массив с добавлением координат элементов


//