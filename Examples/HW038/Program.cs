// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
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
int GetMaxNumber(int[] array)
{
    int maxArray = array[0];
    for (int i = 1; i < length; i++)
    {
        if (maxArray < array[i])
        {
            maxArray = array[i];
        }
    }
    return maxArray;
}
int GetMinNumber(int[] array)
{
    int minArray = array[0];
    for (int i = 1; i < length; i++)
    {
        if (minArray > array[i]) minArray = array[i];
    }
    return minArray;
}
if (GetMaxNumber(array) == GetMinNumber(array))
{
    Console.WriteLine("Наибольший элемент равен наименьшему");
}
Console.WriteLine(GetMaxNumber(array));
Console.WriteLine(GetMinNumber(array));
int divNumbers = GetMaxNumber(array) - GetMinNumber(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {divNumbers}");
