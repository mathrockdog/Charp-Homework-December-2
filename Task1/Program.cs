// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1

int MidNumber(int result)
    {
        int div = result / 10;
        int rem = div % 10;
        return rem;
    }

Console.WriteLine("Введите трёхзначное число");
int value = Convert.ToInt32(Console.ReadLine());

int MidNumberResult = MidNumber(value);
Console.WriteLine(MidNumberResult);
