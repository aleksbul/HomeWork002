// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

string str = number.ToString();
if (str.Length >= 3)
{
    int[] array = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = int.Parse(str[i].ToString());
    }
    Console.WriteLine(array[2]);
}
else
    Console.WriteLine("В заданном числе третьей цифры нет");
