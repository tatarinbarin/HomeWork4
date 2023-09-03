// Задача 25: Напишите программу, которая на вход принимает два числа (А и В)
// и возводит число А в натуральную степень В.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.

// 3,5 -> 243 ("3" в "5-ой" степени)

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiate(int num1, int num2)
{
    int numA = a;
    int count = 0;
    int res = 1;
    while (count < b)
    {
        res = res * numA;
        count++;
    }
    return res;
}

int result = Exponentiate(a, b);
Console.WriteLine($"Число {a} возведённая в степень {b} = {result}");