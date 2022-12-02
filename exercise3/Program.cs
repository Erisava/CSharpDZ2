// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Является ли этот день выходным? ");

switch (num)
{
    case 1: Console.WriteLine("Понедельник - нет");
    break;
    case 2: Console.WriteLine("Вторник - нет");
    break;
    case 3: Console.WriteLine("Среда - нет");
    break;
    case 4: Console.WriteLine("Четверг - нет");
    break;
    case 5: Console.WriteLine("Пятница - нет");
    break;
    case 6: Console.WriteLine("Суббота - да");
    break;
    case 7: Console.WriteLine("Воскресенье - да");
    break;
    default: Console.WriteLine("Неправильно введенные данные");
    break;
}