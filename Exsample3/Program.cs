// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76\

Console.WriteLine ($" Введите размер массива ");
int i = Convert.ToInt32 (Console.ReadLine ());
int[] newArray = newint();
int Dif = max() - min();
Console.WriteLine(string.Join(" ", newArray));
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {Dif} ");


int[] newint()
{
     int[] array = new int[i];
     for (int j = 0; j < i; j++)
     {
        array[j] = Random.Shared.Next(1,101);
     }
     return array;
}

int max()
{
    int Max = 0;
    int [] array = newArray;
    for (int j = 0; j < i; j++)
    {
        if (array[j] > Max)
        Max = array[j];
    }
    return Max;
}

int min()
{
    int [] array2 = newArray;
    int Min = array2[0];
    for (int j = 0; j < i; j++)
    {
        if (array2[j] < Min)
        Min = array2[j];
    }
    return Min;
}