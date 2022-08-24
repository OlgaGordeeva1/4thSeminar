

int GetSum(int A)
{
    int sum =0;
    for (int i = 0; i <= A; i++)
    {
        sum += i;
    }
return sum;
}
int a=10;
int sum = GetSum(a);
Console.WriteLine($"sum: {sum}");