// See https://aka.ms/new-console-template for more information

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}