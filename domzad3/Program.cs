// **Задача 60.**
// Сформируйте трёхмерный массив неповторяющихся (*можно повторяющихся) двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GenerateMatrix(int[,,] matrix)
{
  int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
  int  number;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    array[i] = new Random().Next(10, 100);
    number = array[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        // while (array[i] == array[j])
        // {
        //   array[i] = new Random().Next(10, 100);
        //   j = 0;
        //   number = array[i];
        // }
        //   number = array[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix.GetLength(0); x++)
  {
    for (int y = 0; y < matrix.GetLength(1); y++)
    {
      for (int z = 0; z < matrix.GetLength(2); z++)
      {
        matrix[x, y, z] = array[count];
        count++;
      }
    }
  }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}  [{i},{j},{k}]  ");
            }
            Console.WriteLine();
        }
    }
}

int x = ReadInt("Введите размер массива X: ");
int y = ReadInt("Введите размер массива Y: ");
int z = ReadInt("Введите размер массива Z: ");
int[,,] myMatrix = new int[x, y, z];
GenerateMatrix(myMatrix);
PrintMatrix(myMatrix);