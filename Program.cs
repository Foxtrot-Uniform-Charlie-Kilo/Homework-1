// See https://aka.ms/new-console-template for more information

Console.Write("Введите число №1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("Максимально число = "+num1);
}

if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("Максимально число = "+num2);
}
if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("Максимально число = "+num3);
}