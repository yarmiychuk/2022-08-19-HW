/*
Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа в промежутке от M до N
*/

void ShowNumsForward(int min, int max)
{
    if (min != max) ShowNumsForward(min, max - 1);
    Console.Write(max + " ");
}

void ShowNumsBack(int max, int min)
{
    Console.Write(max + " ");
    if (min != max) ShowNumsBack(max - 1, min);
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2) ShowNumsForward(number1, number2);
else ShowNumsBack(number1, number2);
Console.WriteLine();