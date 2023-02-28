// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int grade = Convert.ToInt32(Console.ReadLine());

int numberR = 0;// Число в степени
for ( int round = 0; round < grade; round++ )
{
    numberR = number * number;
}
Console.WriteLine($"Число {number} в степени {grade} равно : {numberR}");