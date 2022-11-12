
Console.WriteLine("Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.");
Console.WriteLine("Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());
int numA = 0;
int numB = 0;
int numC = 0;
int num = 0;

switch (number)
{
    case 1:
        //Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        Console.Write("Введите первое число: ");
        numA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        numB = Convert.ToInt32(Console.ReadLine());
        if (numA < numB)
        {
            Console.Write($"число {numA} меньше {numB}");
        }
        else if (numA > numB)
        {
            Console.Write($"число {numA} больше {numB}");
        }
        else
        {
            Console.Write($"число {numB} равно {numA}");
        }
        break;

    case 2:
        //Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        Console.Write("Введите первое число: ");
        numA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        numB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        numC = Convert.ToInt32(Console.ReadLine());
        int max = numA;
        if (max < numB) max = numB;
        if (max < numC) max = numC;
        Console.Write($"Максимальное число - {max}");
        break;

    case 3:
        //Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        num = num % 2;
        if (num == 0)
        {
            Console.Write("Число четное ");
        }
        else
        {
            Console.Write("Число нечетное");
        }
        break;
    case 4:
        //Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        int count = 2;
        while (count < num)
        {
            Console.Write($" {count}");
            count = count + 2;
        }
        break;
    default:
        Console.Write("Задачи с таким номером нет");
        break;
}