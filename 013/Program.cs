
   // Программа которая выводит третью цифру числа
   Console.WriteLine("Введите число");

   string? numberString1 = Console.ReadLine();

   int number = int.Parse(numberString1!);

    if (number < 99)
        {
            Console.WriteLine("Третьей цифры нет");
        }
    else
        {

            while (number >= 1000)
            {
                number = number / 10;
            }
            int number1 = number % 10;

            Console.WriteLine("Третья цифра числа " + number1);
        }
    