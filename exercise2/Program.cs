// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string sqrt = Convert.ToString(num);

if (sqrt.Length > 2)
{
  Console.WriteLine($"Третья цифра числа {num} это: {sqrt[2]}");
}
else
{
  Console.WriteLine("Третьей цифры нет");
}