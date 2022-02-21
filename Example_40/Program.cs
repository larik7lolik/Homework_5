// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
Console.Clear();
double[] array = new double[10];
double max = array[0], min = 0, difference = 0;
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
    {
        //array[i] = rand.NextDouble()*100;
        array[i] = Math.Round(rand.NextDouble()*100, 2); // метод заполнения массива вещественными числами, 2 -число знаков после запятой.
        if(max >= array[i])
           min = array[i];
        else
            max = array[i];
        Console.Write($"{array[i]} ");
    }
for(int j = 0; j < array.Length; j++)
{
    if(min > array[j])
       min = array[j];
}
difference = max - min;
Console.WriteLine($"\nМаксимальное число равно {max} ");
Console.WriteLine($"Минимальное число равно {min} ");
Console.WriteLine($"Разница между максимальным и минимальным числами равна {difference}");


