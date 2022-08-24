// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// Еще раз зафиксируем: нужно написать именно ЦИКЛ, а не метод Math.Pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Step(int A, int B)
{
    int result = 1;
    for (int i = 1; i<= B; i++)
    {result = result*A;}
    return result;
}

Console.WriteLine(Step(3,5));

