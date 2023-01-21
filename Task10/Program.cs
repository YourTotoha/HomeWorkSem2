//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает
// вторую цифру этого числа
Console.Write("Введите число:");
int numberA = int.Parse(Console.ReadLine());
int FinalNumber = (numberA / 10) % 10;
    Console.WriteLine(FinalNumber);