// See https://aka.ms/new-console-template for more information
using System;

//Задание номер 1:

class Program
{
    //    static void Main()
    //    {

    //        Console.Write("Введите длину прямоугольника A (положительное целое число): ");
    //        int A = int.Parse(Console.ReadLine());

    //        Console.Write("Введите ширину прямоугольника B (положительное целое число): ");
    //        int B = int.Parse(Console.ReadLine());

    //        Console.Write("Введите сторону квадрата C (положительное целое число): ");
    //        int C = int.Parse(Console.ReadLine());


    //        if (C > A || C > B)
    //        {
    //            Console.WriteLine("Квадрат со стороной C не может быть размещен на прямоугольнике A*B.");
    //        }
    //        else
    //        {

    //            int countSquares = (A / C) * (B / C);

    //            int totalArea = A * B;
    //            int occupiedArea = countSquares * C * C;
    //            int unoccupiedArea = totalArea - occupiedArea;

    //            Console.WriteLine($"Максимальное количество квадратов: {countSquares}");
    //            Console.WriteLine($"Площадь незанятой части прямоугольника: {unoccupiedArea}");
    //        }
    //    }


    //Задание 3:
    //static void Main()
    //{
    //    Console.Write("Введите целое положительное число A (A < B): ");
    //    int A = int.Parse(Console.ReadLine());

    //    Console.Write("Введите целое положительное число B (A < B): ");
    //    int B = int.Parse(Console.ReadLine());
    //    if (A >= B)
    //    {
    //        Console.WriteLine("Ошибка: A должно быть меньше, чем B.");
    //        return;
    //    }
    //    for (int i = A; i <= B; i++)
    //    {
    //        Console.WriteLine(new string((char)('0' + i), i));
    //    }
    //}


    //Задание 4:
    static void Main()
    {
        Console.Write("Введите целое число N (больше 0): ");
        int N;
        while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.Write("Ошибка. Пожалуйста, введите целое число больше 0: ");
        }
        string reversedString = new string(N.ToString().ToCharArray().Reverse().ToArray());
        int reversedNumber = int.Parse(reversedString);
        Console.WriteLine("Число, полученное при прочтении числа N справа налево: " + reversedNumber);
    }
}