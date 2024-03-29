﻿// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)},");
  return m;
}

int n = Prompt("Введите число: ");
if (n < 1)
{
  Console.WriteLine("Число должно быть положительным!!!");
  return;
}
Console.WriteLine(NaturalNumber(n, 1));
