// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Введите количесто строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количесто столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int minRow = 0;
int minSum = 10000000;

int[,] createArray()  // сделал для любого масива даже если он не прямоугольный
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
    return array;
}

int SortArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i + 1;
        }
        sum = 0;
    }
    Console.WriteLine($"минемальная сумма в строке: {minSum}\nстрока: {minRow}");
    return minRow;
}

SortArray(createArray());