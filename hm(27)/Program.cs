//Зачада 27:Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = 0;
    if (num < 0)
    {
        Console.WriteLine("Некорректные данные! Введите число > 0");
    }
    else
    {
        while (num > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
    }
    return sum;
}

int sumNum = SumNumbers(num);

Console.WriteLine(sumNum);