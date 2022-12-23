// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
string numberString = Console.ReadLine()!;
int count = numberString.Length;
int number = Convert.ToInt32(numberString);

if (count < 3)
    {
        Console.WriteLine("Третьей цифры нету!");
    }

else
    {
        while (count > 3)
            {
                number = number / 10;
                count--;
            }
        Console.WriteLine(number % 10);
    }