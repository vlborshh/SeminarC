

Console.WriteLine("Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
Console.WriteLine("          Выполнить с помощью рекурсии.");
Console.WriteLine("Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов от M до N.");
Console.WriteLine("Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberM = 0;
int numberN = 0;

void Result(int num)
{
    if (num == 0)
        return;
    Console.Write(num + " ");
    Result(num - 1);
}
int sum = 0;
int ResultSum(int numM, int numN)
{

    if (numM == numN + 1)
        return numM;
    sum = sum + numM;
    ResultSum(numM + 1, numN);
    return sum;
}

int ResultAckerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return ResultAckerman(numM - 1, 1);
    if (numM > 0 && numN > 0) return ResultAckerman(numM - 1, ResultAckerman(numM, numN - 1));
    return ResultAckerman(numM, numN);
}

switch (number)
{
    case 1:

        Console.Write("Введите количество строк массива: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.Write("Введеное число не является натуральным!!!");
        }
        else
        {
            Console.Write("Результат: ");
            Result(number);
        }
        break;

    case 2:

        Console.Write("Введите 'М': ");
        numberM = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите 'N': ");
        numberN = Convert.ToInt32(Console.ReadLine());

        if (numberM == numberN)
        {
            Console.Write("ВЫ ввели одинаковые числа!!!");
        }
        else if (numberM < numberN)
        {
            Console.Write("Результат: ");
            Console.Write(ResultSum(numberM, numberN));
        }
        else if (numberM > numberN)
        {
            Console.Write("Результат: ");
            Console.Write(ResultSum(numberN, numberM));
        }
        break;

    case 3:
        Console.Write("Введите начальное число M: ");
        numberM = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите начальное число N: ");
        numberN = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Результат вычислений по функции Аккермана для чисел A({numberM},{numberN}): {ResultAckerman(numberM, numberN)}");
        break;

    default:
        Console.Write("Задачи с таким номером нет");
        break;
}
