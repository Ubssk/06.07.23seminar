// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 12;
int[] array = new int[size];
int even = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    if ((array[i] % 2) == 0)
    {
        even++;
    }
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Количество четных чисел в массиве: {even}");