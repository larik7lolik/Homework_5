// Задача 34: Написать программу для замены элементов массива на противоположные.
int[] array = new int[10];
Random rand = new Random();
void FillArray(int[] arr)
{
    int index = 0;
    while(index < arr.Length)
    {
        arr[index] = rand.Next(-10,10);
        Console.Write($"{arr[index]} ");
        index++;
    }
}
    
void SwapArray(int[] arr)  //метод меняющий массив на противоположный
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
        Console.Write($"{arr[i]} ");
    }
}    

Console.WriteLine("Изначальный массив: ");
FillArray(array);
Console.WriteLine();
Console.WriteLine("Противоположный массив: ");
SwapArray(array);
