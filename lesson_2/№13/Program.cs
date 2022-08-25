// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string number1 = Console.ReadLine();
if(number1.Length < 3)
{
Console.WriteLine("Третья цифра отсутствует");
}
else 
{
Console.WriteLine($"Третья цифра {Convert.ToInt32(new string(number1[2], 1))}");
}