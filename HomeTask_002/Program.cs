/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int m = 1;
int n = 3;

// Метод который выведет все натуральные числа от М до N с помощью рекурсии

string ShowNumbers (int n)
{
    if(n == m) return $"{m} ";
    return ShowNumbers(n - 1) + $"{n} ";
}


Console.WriteLine();
Console.WriteLine($"\nСумма чисел от M до N: \n {ShowNumbers(n)}\n");