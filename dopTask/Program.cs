Console.Clear();
Console.Write("Введите число от 3 до 1000: ");
int countBushes = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество ягод которое может быть на одном кусте от 1 до 1000: ");
int[] mas = new int[countBushes];
for (int i = 0; i < countBushes; i++)
{
    mas[i] = Convert.ToInt32(Console.ReadLine());
}
int maxSum = 0;
for (int i = 0; i < countBushes; i++)
{
    int sum = mas[i % countBushes] + mas[(i + 1) % countBushes] + mas[(i + 2) % countBushes];
    if (sum > maxSum)
    {
        maxSum = sum;
    }
}
Console.WriteLine($"Максимально возможная сумма собраных ягод: {maxSum}");