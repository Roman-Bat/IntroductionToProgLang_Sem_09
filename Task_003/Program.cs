/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int n = 45;
int SumNumbers(int num)
{
    if (num / 10 == 0) return num;
    else return num % 10 + SumNumbers(num / 10);
}

Console.WriteLine($"Принимаем число: {n}\nПоразрядная сумма числа: \n {SumNumbers(n)}\n");