// See https://aka.ms/new-console-template for more information

Console.Write("Введите число №1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Максимально число = "+num1);
    Console.WriteLine("Минимальное число = "+num2);
}
else
{
    Console.WriteLine("Максимально число = "+num2);
    Console.WriteLine("Минимальное число = "+num1);
}