//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите число для опредиления длины массива: ");


int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i+=2)
{
        sum += array[i];  
}
Console.WriteLine("Сумма чисел на нечетных позициях: " + sum);