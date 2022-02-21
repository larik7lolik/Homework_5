// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.
int[] arr = new int [10];
int index = 0;
int positive = 0;
int negative = 0;
void FillArray()
{
    for(int i = 0; i < arr.Length; i++)
  {
      arr[i] = new Random().Next(100, 1000);
      Console.Write($"{arr[i]} ");
  }
}
FillArray();
while(index < arr.Length)
{
    if(arr[index] % 2 ==0)
    {
        positive++;
    }
    else
    {
      negative++;
    }
    index++;
}
Console.WriteLine();
Console.Write($"Чётные числа {positive} ");
Console.Write($"Нечётные числа {negative} ");
