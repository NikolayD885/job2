// Программа которая показывает вторую цифру трехзначного числа

Console.WriteLine("Введите число");

string? numberString1 = Console.ReadLine();

int number1 = int.Parse(numberString1!);

int number2 = ((number1 / 10) % 10);

Console.WriteLine("Вторая цифра числа " + number2);