// Напишите программу, которая выводит третью
// цифру заданного числа, или сообщает, что цифры нет.

// 645 -> 5
// 78 -> цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
string str = Console.ReadLine();
int num = Convert.ToInt32(str);

if(num > 99)
{
        Console.WriteLine(str[2]);     
}
else
{
        Console.WriteLine("Третьей цифры нет");   
}