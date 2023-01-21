//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
Console.Write("Введите число:");
int numberA = int.Parse(Console.ReadLine());
if (numberA > 99)
{
    if (numberA > 999)
    {
        while (numberA > 999)
        {
            numberA = numberA / 10;
        }
        Console.WriteLine(numberA % 10);
    }
    else
    {
        Console.WriteLine(numberA % 10);
    }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}