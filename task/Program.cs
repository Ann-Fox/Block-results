//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arr = new string[] { "12345", "-32", "hi", "world", "helloWorld" };
string[] arr1 = new string[] { ")))", "-32", "hi", "21", "helloWorld" };
string[] arr2 = new string[] { "12345", "-832", "hhhi", "world", "helloWorld" };


string[] SortArray(string[] array)
{
  string[] result = new string[array.Length];

  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      result[count] = array[i];
      count++;
    }
  }
  Array.Resize(ref result, count);
  return result;
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

PrintArray(arr);
PrintArray(SortArray(arr));

PrintArray(arr1);
PrintArray(SortArray(arr1));

PrintArray(arr2);
PrintArray(SortArray(arr2));