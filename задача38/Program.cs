// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[10];
double max = double.MinValue;
double min = double.MaxValue;
double difference = 0;
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    array[i] = random.NextDouble() * 100;
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
    difference = max - min;
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Максимальное число {max} Минимальное число {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {difference}");