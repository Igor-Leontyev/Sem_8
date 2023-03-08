// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07;

Console.Write("Введите количесто строк и столбцов квадратного массива: ");
int size = Convert.ToInt32(Console.ReadLine());



int[,] createArray()
{
    int[,] array = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            array[i, j] = 0;
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int[,] SnakeArray(int[,] array)
{
    int i = 1;
    int x = 0;
    int y = -1;
    int moveRow = 0;// 1 0 -1
    int moveColumn = 1;

    while (i <= size * size)
    {
        if (0 <= x + moveRow && x + moveRow < size && 0 <= y + moveColumn && y + moveColumn < size && array[x + moveRow, y + moveColumn] == 0)
        {
            x = x + moveRow;
            y = y + moveColumn;
            array[x, y] = i;
            i++;
        }
        else
        {
            if (moveColumn == 1)
            {
                moveColumn = 0;
                moveRow = 1;
            }
            else if (moveRow == 1)
            {
                moveColumn = -1;
                moveRow = 0;
            }
            else if (moveColumn == -1)
            {
                moveColumn = 0;
                moveRow = -1;
            }
            else if (moveRow == -1)
            {
                moveRow = 0;
                moveColumn = 1;
            }
        }
    }
    return array;
}


void ShowArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
    Console.WriteLine();

}

ShowArray(SnakeArray(createArray()));













