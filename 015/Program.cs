// Программа которая определяет является ли день недели выходным
Console.WriteLine("Введите номер дня недели");

string? numberString1 = Console.ReadLine();

int number = int.Parse(numberString1!);

if (number == 1)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 2)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 3)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 4)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 5)
{
    Console.WriteLine("Рабочий день");
}
else if (number == 6)
{
    Console.WriteLine("Выходной день");
}
else if (number == 7)
{
    Console.WriteLine("Выходной день");
}
else 
{
   Console.WriteLine("Такого дня недели не существует");
}