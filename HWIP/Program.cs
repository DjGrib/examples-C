// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//int Prompt (string message)
//    {
//        Console.Write(message);
//        int result = Convert.ToInt32(Console.ReadLine());
//        return result;
//    }
//
//int NaturalNumb(int n, int m)
//    {   
//        if (n == m) return n;
//        else Console.Write($"{NaturalNumb(n, m +1)} ");
//        return m;
//    }

//int n = Prompt("Введите число:");
//if (n < 1) //На случай ввода отрицательного числа, или нуля
//    {
//        Console.WriteLine("Число должно быть положительным!");
//        return;   
//    }

//Console.WriteLine(NaturalNumb(n, 1));


// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
    {
        Console.Write(message);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
    }

int SumOfNumb(int n, int m)
    {
        if (n == m) return n;
        else return SumOfNumb(n +1, m) + n;
    }

int n = Prompt("Введите первое число:");
int m = Prompt("Введите второе число:");

Console.WriteLine(SumOfNumb(n, m));
