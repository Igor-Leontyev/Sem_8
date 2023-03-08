// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int column = 2;
int row = 2;
int list = 2;

int[,,] createArray()
{
    int[,,] array = new int[row, column, list];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < list; k++)
            {
                array[i, j, k] = new Random().Next(1, 10);
                Console.Write(array[i, j, k] + "(" + j + "," + k + "," + i + ")");
            }
            Console.WriteLine();
        }
    }
    return array;
}

createArray();