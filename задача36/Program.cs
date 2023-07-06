// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 12;
int[] array = new int[size];
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100);
    if (i%2>0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");