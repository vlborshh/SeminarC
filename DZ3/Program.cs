Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Выберите задачу и введите ее порядковый номер: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 0;
//int count = 0;

switch (number)
{
    case 1:
        //Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        Console.Write("Введите пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
        int[] array = { 1, 2, 3, 4, 5 };
        int count = 4;
        num1 = number;
        while (count >= 0)
        {
            num2 = num1 % 10;
            num1 = num1 / 10;
            array[count] = num2;
            count = count - 1;

        }
        count = 0;
        bool res = false;
        num1 = 0;
        num2 = 4;
        while (count < 2)
        {
            if (array[num1] == array[num2])
            {
                res = true;
            }
            else
            {
                res = false;
            }
            num1 = num1 + 1;
            num2 = num2 - 1;
            count = count + 1;
        }
        if (res == true)
        {
            Console.Write($"Число {number} является палиндромом");
        }
        else
        {
            Console.Write($"Число {number} не является палиндромом");
        }
        break;

    case 2:
        string tochka = "первой";
        int[] arr = new int[6];
        double result;
        count = 0;
        while (count <= 5)
        {
            Console.WriteLine($"Ввод координат {tochka} точки: ");

            Console.Write("Введите координату 'Х': ");
            arr[count] = Convert.ToInt32(Console.ReadLine());
            count++;

            Console.Write("Введите координату 'Y': ");
            arr[count] = Convert.ToInt32(Console.ReadLine());
            count++;

            Console.Write("Введите координату 'Z': ");
            arr[count] = Convert.ToInt32(Console.ReadLine());
            count++;

            tochka = "второй";
        }
        count = 0;
        result = Math.Pow((arr[3] - arr[0]), 2) +
                 Math.Pow((arr[4] - arr[1]), 2) +
                 Math.Pow((arr[5] - arr[2]), 2);
        result = Math.Round(Math.Sqrt(result), 2);
        Console.WriteLine($"Расстояние равно {result}");
        break;

    case 3:
        //Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        int index = 0;

        while (index < number)
        {
            index++;
            Console.Write($"{Math.Pow(index, 3)} ");
        }

        break;

    default:
        Console.Write("Задачи с таким номером нет");
        break;
}