/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
int a = 2;
int b = 3;
// Метод который рекурсивно возводит в степень
int SqurNumbers(int num_1, int num_2)
{
   if (num_2 == 0) return 1;
   return num_1 * SqurNumbers(num_1, num_2 - 1);
   
}

Console.WriteLine($"Возводим число {a} в степень {b} = {SqurNumbers(a, b)}");