// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат записать в новом массиве.
int[] randomArray = FillArray(length: 7, from: -10, to: 10);
int[] pairProducts = GetPairProducts(array: randomArray);

Console.WriteLine($"Original array:");
printArray(randomArray);

Console.WriteLine($"It's pair products:");
printArray(pairProducts);

int[] GetPairProducts(int[] array)
{
    int len = array.Length;
    int productsLength = (len + 1) / 2;
    int[] products = new int[productsLength];

    for (int i = 0; i < productsLength; i++)
    {
        products[i] = array[i];
        if (i < len / 2)
        {
            products[i] *= array[len - 1 - i];
        }
    }
    return products;
}

int[] FillArray(int length, int from = int.MinValue, int to = int.MaxValue - 1)
{
    Console.WriteLine($"Generating array of {length} elements, from: {from}, to: {to}");
    int[] array = new int[length];

    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(from, to + 1);
    }
    return array;
}

void printArray(int[] array)
{
    foreach (int elem in array)
    {
        System.Console.Write($"{elem}, ");
    }
}