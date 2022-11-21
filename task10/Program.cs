// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number < 1000 & number > 99)
{
    int result = number % 100;
    int result2 = result / 10;
    Console.WriteLine(result2);
}
