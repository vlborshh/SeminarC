
Console.WriteLine("Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.");
Console.WriteLine("          Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Задача 2: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,");
Console.WriteLine("          значения которых лежат в отрезке[10, 99].");
Console.WriteLine("Задача 3: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,");
Console.WriteLine("          стоящих на нечётных позициях(индексах).");
Console.WriteLine("Задача 4: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и ");
Console.WriteLine("          минимальным элементов массива.");

Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
int num = 0;
int size = 0;

int count = 0;

switch (number)
{
    case 1:
        //Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами
        //          Напишите программу, которая покажет количество чётных чисел в массиве
        Console.Write("Введите размер массива: ");
        size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(100, 1000);
            Console.Write($"{arr[i]} ");
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine();
        Console.Write($"Количество четных чисел: {count}");
        break;

    case 2:
        //Задача 2: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
        //          значения которых лежат в отрезке[10, 99].
        size = 123;
        int[] array = new int[size];


        for (int i = 0; i < size; i++)
        {
            // в задании сказано задать массив из случайных чисел, но все таки
            // ограничим его некоторыми рамками
            array[i] = new Random().Next(-500, 501);
            Console.Write($"{array[i]} ");
            if (array[i] >= 10 & array[i] <= 99)
            {
                count++;
            }

        }
        Console.WriteLine();
        Console.Write($"Количество элементов: {count}");
        break;

    case 3:
        //Задача 3: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
        //          стоящих на нечётных позициях(индексах).
        Console.Write("Введите размер массива: ");
        size = Convert.ToInt32(Console.ReadLine());
        int[] mass = new int[size];
        count = 1;
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            // в задании сказано задать массив из случайных чисел, но все таки
            // ограничим его некоторыми рамками
            mass[i] = new Random().Next(-500, 501);
            Console.Write($"{mass[i]} ");
        }
        while (count < mass.Length)
        {
            sum = sum + mass[count];
            count = count + 2;
        }

        Console.WriteLine();
        Console.Write($"Сумма чисел находящихся в нечётных индексах массива: {sum}");
        break;
    case 4:
        //Задача 4: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и 
        //          минимальным элементов массива.
        Console.Write("Введите размер массива: ");
        size = Convert.ToInt32(Console.ReadLine());
        double[] doublearray = new double[size];

        for (int i = 0; i < size; i++)
        {
            double x = Math.Round((new Random().NextDouble() * 100), 2);
            doublearray[i] = x;
            Console.Write($"{doublearray[i]} ");
        }
        double min = doublearray[0];
        for (int i = 1; i < size; i++)
        {
            if (min > doublearray[i])
            {
                min = doublearray[i];
            }
        }
        double max = doublearray[0];
        for (int i = 1; i < size; i++)
        {
            if (max < doublearray[i])
            {
                max = doublearray[i];
            }
        }

        Console.WriteLine();
        Console.Write($"Min = {min}, max = {max}. Max - min = {max - min}");
        break;
    default:
        Console.Write("Задачи с таким номером нет");
        break;
}