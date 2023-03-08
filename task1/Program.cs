// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Write("Введите количесто строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количесто столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] createArray()
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


int[,] SortArray(int[,] array)
{

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = column - 1; k >= 0; k--)
            {
                if (k > 0 && array[i, k] >= array[i, k - 1])
                {
                    array[i, k - 1] = array[i, k] + array[i, k - 1];// сделал без буффера перестановку значений в массиве 
                    array[i, k] = array[i, k - 1] - array[i, k];
                    array[i, k - 1] = array[i, k - 1] - array[i, k];
                }
            }
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    return array;
}

SortArray(createArray());

