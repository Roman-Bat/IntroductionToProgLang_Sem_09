/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int CalculateAkkermanFunction(int m, int n)
 {
 if (m == 0)
 return n + 1;
 if (n == 0)
 return CalculateAkkermanFunction(m - 1, 1);
 return CalculateAkkermanFunction(m - 1, CalculateAkkermanFunction(m, n - 1));
 }

Console.WriteLine("Введите M и N через пробел: ");
string input = Console.ReadLine();
string[] values = input.Split(' ');
int m = Convert.ToInt32(values[0]);
int n = Convert.ToInt32(values[1]);

Console.WriteLine($"Результатом вычисления функции Аккермана с помощью рекурсии, является {CalculateAkkermanFunction(m,n)}");
Console.ReadKey();