// Задача 2
// Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
//   Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
using static Library;

Console.WriteLine("Введите длинну стороны AB");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны BC");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны CA");
int c = Convert.ToInt32(Console.ReadLine());

bool result = TriangleSidesCheck(a, b, c);

Console.WriteLine(PrintResult(a, b, c, result));