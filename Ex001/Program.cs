// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Zadacha47()
{
Random random = new Random();
int rows = random.Next(1, 11);
int columns = random.Next(1, 11);
double[,] array = new double[rows, columns]; 
FillArray(array);
PrintArray(array);

void FillArray(double[,] array)
{
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(random.NextDouble() * 100, 1);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {   
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
}
Zadacha47();
