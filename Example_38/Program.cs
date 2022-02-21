// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
// Вывести случайный массив.
// Сделать метод, который записывает сумму цифр на нечётных позициях.
// Счетчик увеличим на 2, тем самым будут браться нечетные цифры.
Console.Clear();
int[] array = new int[10];

void FillArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Сгенерированный массив: ");
FillArray();
Console.WriteLine();
int sum = 0;
int oddIndex = 0;
void PrintSum()
{
    for(int index = 1; index < array.Length; index = index + 2)
    {
       oddIndex = oddIndex + array[index];
       sum = sum + oddIndex;
      
    }
    Console.Write($"\nСумма чисел на нечётной позиции = {sum}");
}
PrintSum();


