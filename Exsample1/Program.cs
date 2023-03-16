Console.WriteLine ($" Введите размер массива ");
int i = Convert.ToInt32 (Console.ReadLine ());
int[] newArray = newint();
Console.WriteLine(string.Join(" ", newArray));
Console.WriteLine($"Количество четных чисел в массиве = {even()} ");


int[] newint()
{
     int[] array = new int[i];
     for (int j = 0; j < i; j++)
     {
        array[j] = Random.Shared.Next(100, 1000);
     }
     return array;
}

int even()
{
    int count = 0;
    int []array = newArray;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    {
    count = count + 1;
    }
    }
    return count;
}