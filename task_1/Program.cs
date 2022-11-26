// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[5];

int count  = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    
    if(array[i] % 2 == 0)
    {
        count +=1;
    }
}
Console.WriteLine("Количество четных чисел в массиве: " + count);