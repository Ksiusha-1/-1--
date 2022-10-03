// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа ");
Console.Write("Введите первое число : 5 ");
int a = int.Parse(Console.ReadLine ()!);
Console.Write("Введите второе число : 7 ");
int b = int.Parse(Console.ReadLine ()!);
Console.WriteLine($"Вычислить какое из двух чисел (max), а какое (min)");
 if (a<b)
{
    Console.WriteLine("Минимальное!");

}
else if (b>a)
{
    Console.WriteLine("Максимальное!");

}