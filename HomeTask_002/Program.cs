/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int Sum(int m, int n)
  {
    if (m == n) return m;
    else return Sum(m, n-1) + n;
  }
 // Принимаем значения M и N от пользователя

Console.WriteLine("Введите M и N через пробел: ");
string input = Console.ReadLine();
string[] values = input.Split(' ');
int m = Convert.ToInt32(values[0]);
int n = Convert.ToInt32(values[1]);

Console.WriteLine($"Сумма натуральных чисел в диапазоне от {m} до {n} равна {Sum(m, n)}");