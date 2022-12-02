//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Через строку решать нельзя.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string sqrt = Convert.ToString(num);
if (sqrt.Length <= 3)
{
  Console.WriteLine($"Вторая цифра числа {num} это: {sqrt[1]}");
}
else
{
  Console.WriteLine("Введите трехзначное число!");
}