// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру ");
int num = Convert.ToInt32(Console.ReadLine());

if (1 > num || num > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной");
}
else 
{
    Console.WriteLine("Будний день");
}