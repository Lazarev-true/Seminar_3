// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Число хранить в типе данных int, решать с помощью арифметических операций 
// (не рассматривая число как тип данных string)

Console.WriteLine("Введите пятизначное число");

int number = Convert.ToInt32(Console.ReadLine());

int a = number / 10000;
int b = number / 1000 % 10;
int c = number % 10;
int d = (number % 100) / 10;

if(number > 9999 && number < 100000)
{
    if(a == c && b == d)
    {
        Console.Write("Число " + number + " является палиндромом");
    }
    else
    {
        Console.Write(number + " не палиндром");
    }
}
else
{
    Console.Write("Число не пятизначное");
}