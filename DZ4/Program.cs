
Console.WriteLine("Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");

Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
int num = 0;
int[] array = new int[2];
int cnt = 0;
int i = 0;

void Stepen(int count)
{
    Console.Write($"Введите {count + 1} число : ");
    array[count] = Convert.ToInt32(Console.ReadLine());
}

int Summ(int ii, int num1)
{
    while (ii >= 0)
    {
        num2 = num1 % 10;
        num1 = num1 / 10;
        array[ii] = num2;
        num = num + array[ii];
        ii--;
    }
    return num;
}

switch (number)
{
    case 1:
        //Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

        for (i = 0; i < 2; i++) // В задании сказано сделать через цикл 
        {
            Stepen(i); // и как небольшой пример использования метода(void)
        }
        Console.Write($"Результат: {Math.Pow(array[0], array[1])}");
        break;

    case 2:
        //Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

        Console.Write($"Введите число : ");
        string str = Console.ReadLine();
        cnt = str.Length;
        Array.Resize(ref array, cnt);
        number = Convert.ToInt32(str);
        cnt--;
        num = Summ(cnt, number); // и как небольшой пример использования метода(c возвратом значения)
        Console.Write($"Сумма цифр числа {number} равна: {num}");
        break;

    case 3:
        //Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

        cnt = 8;
        Array.Resize(ref array, cnt);
        for (i = 0; i < cnt; i++)
        {
            array[i] = new Random().Next(); // диапазон значений элементов в задании не указан, следовательно не задаем его
            Console.WriteLine(array[i]);
        }
        break;
    default:
        Console.Write("Задачи с таким номером нет");
        break;
}