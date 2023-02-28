// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
int[] array = CreatArray(8, 1, 99);
int[] CreatArray(int size, int minValue, int maxValue) // Создание массива, декларация переменных обозначающих размер, минимальное и максимальное значение массива
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result; 
}
Console.WriteLine($"Массив массив из 8 чисел: [{String.Join("; ", array)}]");
