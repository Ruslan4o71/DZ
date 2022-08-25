// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// метод int

Console.WriteLine("Введите трехзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра { number1 / 10 % 10}");



// метод string

//Console.WriteLine("Введите трехзначное число: ");
//string number1 = Console.ReadLine();
//Console.WriteLine($"Вторая цифра {Convert.ToInt32(new string(number1[1], 1))}");