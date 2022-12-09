

Console.WriteLine("Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки");
Console.WriteLine("          двумерного массива.");
Console.WriteLine("Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей ");
Console.WriteLine("          суммой элементов.");
Console.WriteLine("Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.WriteLine("Задача 4: Напишите программу, которая заполнит спирально массив 4 на 4.");
Console.WriteLine("Задача 5: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно ");
Console.WriteLine("          выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2");
Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberRows = 0;
int numberColumns = 0;
int numberColumnsTwo = 0;
int temp = 0;
int count = 0;
int index = 0;

int[,] FillingArray(int numberRowsMass, int numberColumnsMass)
{
    int[,] mass = new int[numberRowsMass, numberColumnsMass];
    Console.WriteLine("Имеем массив: ");
    for (int i = 0; i < numberRowsMass; i++)
    {
        for (int j = 0; j < numberColumnsMass; j++)
        {
            mass[i, j] = new Random().Next(0, 100);
            Console.Write($"{mass[i, j]}  ");

        }
        Console.WriteLine();
    }
    return mass;
}

void Result(int[,] mass)
{
    Console.WriteLine("Результат: ");
    for (int i = 0; i < numberRows; i++)
    {
        for (int j = 0; j < numberColumns; j++)
        {
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
}

switch (number)
{
    case 1:
        Console.Write("Введите количество строк массива: ");
        numberRows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        numberColumns = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[numberRows, numberColumns];
        array = FillingArray(numberRows, numberColumns);
        temp = 0;
        count = 0;
        for (int i = 0; i < numberRows; i++)
        {
            count = numberColumns - 1;
            for (int j = 0; j < numberColumns / 2; j++)
            {
                count = count - j;
                temp = array[i, j];
                array[i, j] = array[i, count]; ;
                array[i, count] = temp;
            }
        }
        Result(array);
        break;

    case 2:
        Console.Write("Введите количество строк и столбцов массива: ");
        numberRows = Convert.ToInt32(Console.ReadLine());
        numberColumns = numberRows;
        int[,] squareArray = new int[numberRows, numberColumns];
        squareArray = FillingArray(numberRows, numberColumns);

        for (int i = 0; i < numberRows; i++)
        {
            temp = 0;
            for (int j = 0; j < numberColumns; j++)
            {
                temp = temp + squareArray[i, j];
                if (i == 0)
                {
                    count = temp;
                }
            }
            if (count > temp)
            {
                count = temp;
                index = i;
            }
            Console.WriteLine($"Строка {i + 1} суммa элементов: {temp}");
        }
        index++;
        Console.Write($"Строка с наименьшей суммой элементов: {index}");
        break;

    case 3:
        //Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

        Console.Write("Введите количество строк первого массива: ");
        numberRows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов первого массива (и строк второго): ");
        int numberColumnsRowsTwo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов второго массива: ");
        numberColumnsTwo = Convert.ToInt32(Console.ReadLine());

        int[,] arrayOne = new int[numberRows, numberColumnsRowsTwo];
        int[,] arrayTwo = new int[numberColumnsRowsTwo, numberColumnsTwo];
        int[,] arrayResult = new int[numberRows, numberColumnsTwo];
        arrayOne = FillingArray(numberRows, numberColumnsRowsTwo);
        arrayTwo = FillingArray(numberColumnsRowsTwo, numberColumnsTwo);

        for (int i = 0; i < arrayResult.GetLength(0); i++)
        {
            for (int j = 0; j < arrayResult.GetLength(1); j++)
            {
                temp = 0;
                for (int n = 0; n < arrayOne.GetLength(1); n++)
                {
                    temp += arrayOne[i, n] * arrayTwo[n, j];
                }
                arrayResult[i, j] = temp;

            }
        }
        numberColumns = numberColumnsRowsTwo;
        Result(arrayResult);
        break;

    case 4:

        //Напишите программу, которая заполнит спирально массив 4 на 4.
        numberRows = 4;
        numberColumnsRowsTwo = 4;
        count = 0;

        int size = numberRows * numberColumnsRowsTwo;
        int[,] arr = new int[numberRows, numberColumnsRowsTwo];
        int numI = 0;
        int numJ = 0;

        temp = 1;
        for (count = 1; count <= size; count++)
        {
            arr[numI, numJ] = temp;
            temp++;

            if (numI <= numJ + 1 && numI + numJ < arr.GetLength(1) - 1)
            {
                numJ++;
            }
            else if (numI < numJ && numI + numJ >= arr.GetLength(0) - 1)
            {
                numI++;
            }
            else if (numI >= numJ && numI + numJ > arr.GetLength(1) - 1)
            {
                numJ--;
            }
            else
            {
                numI--;
            }
        }
        numberColumns = numberColumnsRowsTwo;
        Result(arr);
        break;
    case 5:
        //Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
        //добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
        int size3D = 2;
        int[,,] array3D = new int[size3D, size3D, size3D];

        int[] mas = new int[size3D * size3D * size3D];
        //number;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            mas[i] = new Random().Next(10, 100);
            number = mas[i];
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (mas[i] == mas[j])
                    {
                        mas[i] = new Random().Next(10, 100);
                        j = 0;
                        number = mas[i];
                    }
                    number = mas[i];
                }
            }
        }
        count = 0;
        for (int x = 0; x < size3D; x++)
        {
            for (int y = 0; y < size3D; y++)
            {
                for (int z = 0; z < size3D; z++)
                {
                    array3D[x, y, z] = mas[count]; //new Random().Next(10, 100);
                    count++;
                    Console.Write($"{array3D[x, y, z]}( {x}, {y}, {z}) ");
                }
                Console.WriteLine();
            }
        }
        break;

    default:
        Console.Write("Задачи с таким номером нет");
        break;
}
