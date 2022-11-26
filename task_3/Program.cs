// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Write("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(1, 100));
    Console.Write(array[i] + " ");
}


for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
    if (array[j] < min)
    {
        min = array[j];
    }
}
Console.WriteLine($"Максимальное значение = {max}, Минимальное значение = {min}");
Console.WriteLine($"Раазница между максимальным и миннимальным знначением = {max - min} ");