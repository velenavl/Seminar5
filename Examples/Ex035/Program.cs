// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
Random random = new Random();
int[] array123 = new int[123];

for (int i = 0; i < array123.Length; i++)
{
    array123[i] = random.Next(1, 200);
}
printArray(array123);
System.Console.WriteLine();

System.Console.WriteLine(GetCount(array123));

int GetCount(int[] array)
{
    int counter = 0;
    foreach (var item in array)
    {
      if (item >= 10 && item <= 99)
      {
        counter++;
      }  
    }
    return counter;
}

void printArray(int[] array)
{
    foreach (int elem in array)
    {
        System.Console.Write($"{elem}, ");
    }
}