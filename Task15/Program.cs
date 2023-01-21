// Напишите программу, которая принимает на вход цифру, обозначаюшую день недели, и проверяет,
// является ли этот день выходным.
Console.Write("Введите цифру:");
int numberA = int.Parse(Console.ReadLine());
if (numberA == 6 || numberA == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}