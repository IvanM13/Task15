/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите  число:");
int day = int.Parse(Console.ReadLine());
int weekend = 6;
int max = 8;

if (day >= weekend && day >= max)
    Console.WriteLine(" Вы ввели неверное число!");

else if (day < weekend)

    Console.WriteLine(" Будний день");

else
    Console.WriteLine(" Выходной день");