// Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Введите три числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if ((a+b) > c && (a+c) > b && (b+c) > a)
    Console.WriteLine ("Являются сторонами треугольника");
else
    Console.WriteLine ("НЕ являются сторонами треугольника"); 