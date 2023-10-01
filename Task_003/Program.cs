/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int n = 8;

// 

string ShowNumbers (int n)
{
    if(n == m) return $"{m} ";
    return ShowNumbers(n - 1) + $"{n} ";
}


Console.WriteLine();
Console.WriteLine($"\nНатуральные числа в промежутке от M до N: \n {ShowNumbers(n)}\n")