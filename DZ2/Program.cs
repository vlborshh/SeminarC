Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        //Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        Console.Write("Введите трехзначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
        number = number / 10;
        number = number % 10;
        Console.Write($"Вторая цифра числа: {number}");
        break;

    case 2:
        //Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number < 100)
        {
            Console.Write("Число не содержит третьей цифры");
        }
        else
        {
            int x = number;
            while (x > 99)
            {
                number = x;
                x = number / 10;
            }
            number = number % 10;
            Console.Write($"Третье число: {number}");
        }
        break;

    case 3:
        //Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        Console.Write("Введите число, обозначающее день недели: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0 & number < 8)
        {
            if (number == 6 || number == 7)
            {
                Console.Write($"Число {number} обозначает выходной день недели: ");
            }
            else
            {
                Console.Write($"Число {number} обозначает не выходной день недели: ");
            }
        }
        else
        {
            Console.Write($"Число {number} не обозначает день недели: ");
        }
        break;

    default:
        Console.Write("Задачи с таким номером нет");
        break;
}