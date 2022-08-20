/*
Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
*/

int GetSum(int num1, int num2)
{
    if (num1 == num2)
        return num1;
    return num2 + GetSum(num1, num2 - 1);
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = 0;
if (number1 < number2) sum = GetSum(number1, number2);
else sum = GetSum(number2, number1);
Console.WriteLine($"Сумма чисел в промежутке от {number1} до {number2} равна {sum}");