﻿//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if(number>=100)
{
string str1 = number.ToString();
Console.WriteLine(str1[2]);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}