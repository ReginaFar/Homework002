//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Zadacha10()
{
    Console.WriteLine("Введите трёхзначное число");
    int Number = Convert.ToInt32(Console.ReadLine());
    if (Number > 99 && Number < 1000)
        {
        Console.WriteLine("Вторая цифра числа = " + (Number % 100) / 10);
        }
    else 
        {
         Console.WriteLine("Это не трёхзначное число");
        }
}
Zadacha10();

//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Zadacha13()
{
    Console.WriteLine("Введите число");
    int Number = Convert.ToInt32(Console.ReadLine());
    Number = Math.Abs(Number);
    if (Number > 99) 
        {
            while (Number > 999)
                {
                    Number = Number / 10;
                }
            Console.WriteLine("Третья цифра числа = " + Number % 10);
        }
    else
         {
            Console.WriteLine("Третьей цифры нет");
         }
}
Zadacha13();

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Zadacha15()
{  
    Console.WriteLine("Введите номер для недели");
    int DayOfTheWeek = Convert.ToInt32(Console.ReadLine());
    if (DayOfTheWeek == 6 || DayOfTheWeek == 7)
        {
        Console.WriteLine("Урра выходной!");
        }
    else if (DayOfTheWeek<1 || DayOfTheWeek>7)
        {
        Console.WriteLine("Это вообще не номер дня недели");
        }
    else 
        {
        Console.WriteLine("Будний день");
        }
}
Zadacha15();