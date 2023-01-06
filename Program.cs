// See https://aka.ms/new-console-template for more information

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    Console.WriteLine(num % 10);
}
else
{
    Console.Write("Число не трехзначное");
}