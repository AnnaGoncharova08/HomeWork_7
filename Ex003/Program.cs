// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void Zadacha52()
{
Random random = new Random();
int rows = random.Next(2, 5);
int columns = random.Next(2, 5);
int[,] array = new int[rows, columns]; 
FillArray(array);
PrintArray(array);
Average(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = random.Next(1,11);
        }
    }
}

void PrintArray(int[,] array)
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

void Average(int[,] array)
{
    int index = 1;
    double average = 0;
    for (int j = 0; j < columns; j++) 
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {   
            sum += array[i, j];
            average = Math.Round(sum/rows, 1);
        }
    Console.WriteLine($"Среднее арифметическое столбца {index} = {average}");
    index++;
    }
}
}
Zadacha52();