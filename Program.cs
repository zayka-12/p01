// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите первое число");
string valueString1 = Console.ReadLine();

System.Console.WriteLine("Введите второе число");
string valueString2 = Console.ReadLine();


int value1 = Convert.ToInt32(valueString1);
int value2 = Convert.ToInt32(valueString2);

if (value1 > value2)
{
  System.Console.WriteLine($"Max = {value1}, Min = {value2}");
}
else
{
  System.Console.WriteLine($"Max = {value2}, Min = {value1}");
}



