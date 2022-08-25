// Задача 27: Напишите программу, которая
// принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Sum(int val)
{
    int result = 0;
    while (val > 0)
    {
        int mod = val % 10;
        result = result + mod;
        val = val / 10;
    }

    return result;
}
int val = 599;

int result = Sum(val);

Console.Write($"result: {result}");