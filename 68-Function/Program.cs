/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
*/

double Akkerman(double m, double n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

double akk = Akkerman(number1, number2);
Console.WriteLine($"Результат вычисления функции Аккермана А({number1}, {number2}) равен {akk}");
