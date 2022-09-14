// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber && length <= 1)
{
    Console.WriteLine("Не верно");
    return;
}

int[] array = FillArray(length);
PrintArray(array);

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++) array[i] = random.Next(0, 100);
    return array;
}

void PrintArray(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Что то пошло не так");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}
int OddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < length; i = i + 2)
    {
       sum = sum + array[i];
    }
    return sum;
}
int oddNumber = OddNumbers(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {oddNumber}");