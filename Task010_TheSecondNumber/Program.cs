// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показыввет вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

string str = number.ToString();
if (str.Length == 3)
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        array[i] = int.Parse(str[i].ToString());
    }
    Console.WriteLine(array[1]);
}
else
    Console.WriteLine("Вы ввели неверное число. Пожадуйста, введите трехзначное число");
