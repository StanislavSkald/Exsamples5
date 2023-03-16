// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine ($" Введите размер массива ");
int i = Convert.ToInt32 (Console.ReadLine ());
int[] newArray = newint();
Console.WriteLine(string.Join(" ", newArray));
Console.WriteLine($"Количество четных чисел в массиве = {sum()} ");


int[] newint()
{
     int[] array = new int[i];
     for (int j = 0; j < i; j++)
     {
        array[j] = Random.Shared.Next(1,101);
     }
     return array;
}

int sum()
{
    int sum = 0;
    int []array = newArray;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 ==1)
    {
        sum = sum + newArray[i];
    }
    }
    return sum;
}