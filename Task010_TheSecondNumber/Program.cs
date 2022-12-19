// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показыввет вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

string str = number.ToString();
if (str.Length == 3) Console.WriteLine(str[1]);
else
    Console.WriteLine("Вы ввели неверное число. Пожалуйста, введите трехзначное число");
