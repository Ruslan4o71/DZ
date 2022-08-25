// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите цифру обозначающую день недели (от 1 до 7): ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 == 6 ^ number1 == 7)
{
Console.WriteLine("Это ВЫХОДНОЙ ДЕНЬ");
}

else
{
Console.WriteLine("Это БУДНИЙ ДЕНЬ");
}