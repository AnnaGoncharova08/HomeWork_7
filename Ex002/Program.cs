// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Zadacha50()
{
Random random = new Random();
int rows = random.Next(1, 11);
int columns = random.Next(1, 11);
int[,] array = new int[rows, columns]; 
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите номер строки: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());
Element(array);

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

void Element(int[,] array)
{
int element;
if (numberRow <= rows && numberColumn <= columns)
{
    element = array[numberRow - 1, numberColumn - 1];
    Console.WriteLine($"Элемент массива = {element}");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
}
}
Zadacha50();