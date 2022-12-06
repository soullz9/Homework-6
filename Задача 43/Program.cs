int[] array = GetArrayRandom(7, 0, 100);
Console.WriteLine($"Вывод массива в строку: [{String.Join(",",array)} ]");
Console.WriteLine($"Сортировка по возрастанию: [{String.Join(",", SotrArray(array))} ]");
int[] SotrArray(int[] array)
{
    int tempVar=0;
    bool flag=true;
    while (flag)
    {
        flag=false;
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j] > array[j + 1])
            {
                tempVar = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tempVar;
                flag = true;
            }
        }
    }
    return array;
}
int[] GetArrayRandom(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}