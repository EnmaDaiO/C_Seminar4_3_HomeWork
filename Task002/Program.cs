// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string arrayNumber = number.ToString(); // присваиваем отдельной переменной число которое конвентируем в string , что бы из него в последствии получить размер массива
int[] arraySize = new int [arrayNumber.Length]; // получаем размер массива. (Не понимаю дословно значение выражения " = new int [] " )
int sumNumber = 0;
for (int i = 0; i < arrayNumber.Length; i++)
{
    arraySize[i] = int.Parse(arrayNumber[i].ToString());// Convert.ToInt32(arrayNumber[i])  
}
Console.WriteLine($"Исходный массив: [{String.Join("; ", arraySize)}]");
for (int i = 0; i < arrayNumber.Length; i++)
{
    sumNumber = sumNumber + int.Parse(arrayNumber[i].ToString()); // или (int.Parse(arrayNumber[i].ToString())) + (int.Parse(arrayNumber[i+1].ToString()))
}
Console.WriteLine($"Сумма цифр числа {number} равна : {sumNumber} ");

//Ниже формула для перевода числа в массив, которую я нашел, проанализировал и встроил в свою задачу.

// int a = 1234;
// string str = a.ToString();
// int[] b = new int[str.Length];
// for( int i=0; i< str.Length; i++)
// {
//     b[i] = int.Parse(str[i].ToString());
// }
