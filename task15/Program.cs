// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число:");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number == 6 | number == 7)
{
    Console.WriteLine("Выходной!");
}
else if (number<=5 & number>=1)
{
    Console.WriteLine("Рабочий:(");
}
else 
{
    Console.Write("В неделе всего 7 дней, попробуйте снова.");
}

