
Console.WriteLine("Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше '0' ввёл пользователь.");
Console.WriteLine("Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, ");
Console.WriteLine("          y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("Задача 3: Напишите программу для подсчета количества цифр в числе с помощью рекурсии.");

Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());
string str;
int count = 0;

void NumberВigits(int num1)
{
    if (num1 > 0)
    {
        count++;
        num1 = num1 / 10;
        NumberВigits(num1);
    }
    else
    {
        Console.Write($"Количесто цифр в числе равно: {count}");
    }

}
switch (number)
{
    case 1:
        //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше '0' ввёл пользователь.
        Console.Write("Введите числа (через пробел): ");
        str = Console.ReadLine();
        int[] array = Array.ConvertAll(str.Split(' '), int.Parse);
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        Console.Write($"Количество чисел > 0: {count}");
        break;

    case 2:
        //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, ");
        //y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        //Если y = k1 * x + b1 и y = k2 * x + b2 => k1 * x + b1 = k2 * x + b2 => x = (b2 - b1) / (k1 - k2)
        Console.Write("Введите значение k1: ");
        int k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение k2: ");
        int k2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение b1: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение b2: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        if (k1 / k2 == b1 / b2)
        {
            Console.WriteLine("Прямые параллельны");
        }
        else if (k1 == k2 & b1 == b2)
        {
            Console.WriteLine("Прямые сливаются");
        }
        else
        {
            double x = 0;
            double x1 = b2 - b1;
            double x2 = k1 - k2;
            x = Math.Round((x1 / x2), 2);
            double y = (k2 * x + b2);         // можно взять y = k1 * x + b1 результат не изменится
            y = Math.Round(y, 2);
            Console.Write($"Координаты точки пересечения прямых: ({x}, {y})");
        }
        break;

    case 3:
        //Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
        Console.Write("Введите число : ");
        number = Convert.ToInt32(Console.ReadLine());
        NumberВigits(Math.Abs(number));
        break;

    default:
        Console.Write("Задачи с таким номером нет");
        break;
}