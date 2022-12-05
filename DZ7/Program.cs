

Console.WriteLine("Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, ");
Console.WriteLine("          и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberRows = 0;
int numberColumns = 0;

int[,] FillingArray(int numberRowsMass, int numberColumnsMass)
{
    int[,] mass = new int[numberRowsMass, numberColumnsMass];
    Console.WriteLine("Имеем массив: ");
    for (int i = 0; i < numberRowsMass; i++)
    {
        for (int j = 0; j < numberColumnsMass; j++)
        {
            mass[i, j] = new Random().Next(-100, 100);
            Console.Write($"{mass[i, j]}  ");

        }
        Console.WriteLine();
    }
    return mass;
}

switch (number)
{
    case 1:
        // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        Console.Write("Введите количество строк массива: ");
        numberRows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        numberColumns = Convert.ToInt32(Console.ReadLine());

        double[,] doublearray = new double[numberRows, numberColumns];
        for (int i = 0; i < numberRows; i++)
        {
            for (int j = 0; j < numberColumns; j++)
            {
                doublearray[i, j] = Math.Round((new Random().NextDouble() * 100), 2);
                Console.Write($"{doublearray[i, j]} ");
            }
            Console.WriteLine();
        }

        break;

    case 2:
        //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
        //и возвращает значение этого элемента или же указание, что такого элемента нет.

        Console.Write("Введите количество строк массива: ");
        numberRows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        numberColumns = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер строки массива: ");
        int linePosition = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца массива: ");
        int columnPosition = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[numberRows, numberColumns];
        array = FillingArray(numberRows, numberColumns);
        if (linePosition > numberRows)
        {
            Console.Write("Значение номера строки выходит за пределы массива");
        }
        else if (columnPosition > numberColumns)
        {
            Console.Write("Значение номера столбца выходит за пределы массива");
        }
        else
        {
            Console.Write($"Значение элемента массива: {array[linePosition - 1, columnPosition - 1]}");
        }

        break;

    case 3:
        //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        Console.Write("Введите количество строк массива: ");
        numberRows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        numberColumns = Convert.ToInt32(Console.ReadLine());

        int[,] arrayArithmeticMean = new int[numberRows, numberColumns];
        arrayArithmeticMean = FillingArray(numberRows, numberColumns);

        double summ = 0;
        double arithmeticMean = 0;

        for (int j = 0; j < numberColumns; j++)
        {
            for (int i = 0; i < numberRows; i++)
            {
                summ = summ + arrayArithmeticMean[i, j];
            }
            arithmeticMean = Math.Round(summ / numberRows, 2);
            //arithmeticMean = summ / numberRows;
            Console.WriteLine($"Среднее арифметическое элементов в {j + 1} столбце: {arithmeticMean} ");
            summ = 0;
        }
        break;

    default:
        Console.Write("Задачи с таким номером нет");
        break;
}