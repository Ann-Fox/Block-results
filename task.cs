int[] GetArray(int size, int a, int b)
{

  // if (b < a)                                          
  // {
  //   Console.Write("Ввведен некорректный диапазон значений");
  // }

  {
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(a, b);
    }
    // Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
  }
}

void SumOddAr(int[] arr)
{
  int sum = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 == 1)
    {
      sum += arr[i];
    }
  }
  Console.WriteLine($"[{String.Join(", ", arr)}] -> {sum}");
  // return sum;
}

SumOddAr(GetArray(5, -10, 100));
SumOddAr(GetArray(4, -100, 100));
// SumOddAr(GetArray(4, 100, 0));
