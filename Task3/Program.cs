// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. Не использовать строки

// 6 -> да
// 7 -> да
// 1 -> нет

void WeekEnd(int day)
    {
        if (day == 6 | day == 7)
            {
                Console.WriteLine("Выходной");
            }
        else
            {
                Console.WriteLine("Будний день");
            }    
    }

Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

WeekEnd(day);