// Задача 54: Задайте двумерный массив. Напишите программу, которая  
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

int[,] PrintMatrixPoYbivaniy(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minj = j;                                            
            for (int k = j + 1; k < array.GetLength(1); k++)                
            {
                if (array[i, k] > array[i, minj]) minj = k;    
            }
            int newarray = array[i, j];                                          
            array[i, j] = array[i, minj];                            
            array[i, minj] = newarray;                                    
        }
    }
    return array;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}




int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
Console.WriteLine($"Сформирован двумерный массив: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine($"Элементы каждой строки двумерного массива, расположенные по убыванию: ");
int[,] myMatrixPoYbivaniy = PrintMatrixPoYbivaniy(myMatrix);
PrintMatrix(myMatrix);