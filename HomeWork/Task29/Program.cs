// Задача 29: Напишите программу,
//  которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] NewArr(int n, int min, int max)
{
    int[] arr = new int [n];
    for (int i=0; i<n; i++)
    {
        arr[i] = new Random().Next(min,max);
    }
return arr;
}


string PrintArr(int[] arr)    
{
  string s = String.Empty;
  int size = arr.Length;
  for (int i = 0; i < size; i++)
  {
    s += Convert.ToString(arr[i]);
    Console.Write(arr[i]+" ");
  }
  return s;
}

int[] res = NewArr(8, 0, 100);
Console.Write("s: [");
string s = PrintArr(res);
Console.Write("]");


