/*
Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

// Метод задания числа
int GetNumber()
{
Random rand = new Random();
int number = rand.Next(1,10);
return number;
}

// Метод который выведет все натуральные числа от 1 до N с помощью рекурсии

string ShowNumbers (int GenerateNumber)
{
    if(GenerateNumber == 1) return "1 ";
    return ShowNumbers(GenerateNumber - 1) + $"{GenerateNumber} ";
}


Console.WriteLine();
int number = GetNumber();
Console.WriteLine($"Задаем значение N = {number}");
Console.WriteLine($"\nНатуральные числа в промежутке от 1 до N: \n {ShowNumbers(number)}\n");