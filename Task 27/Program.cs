// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите целое положительное число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
