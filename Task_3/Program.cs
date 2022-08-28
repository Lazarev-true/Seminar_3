// Напишите программу, которая принимает на вход число (N) 
// и помещает в массив таблицу кубов чисел от 1 до N. 
// Полученный массив вывести на экран.

Console.WriteLine("Введите число N");

int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

for (int i = 0; i < N; i++)
{
   array[i] = (int)Math.Pow((i + 1), 3);

   Console.WriteLine($"{i + 1}^3 = {array[i]}");
}

