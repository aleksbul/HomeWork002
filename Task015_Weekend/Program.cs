// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 0) Console.WriteLine("Такого дня недели не существует, введите, пожалуйста положительное число");
else if (day > 7) day = day % 7;

string result = "";

switch (day)
{
    case 1:
        result = "Monday - not weekend";
        break;
    case 2:
        result = "Tuesday - not weekend";
        break;
    case 3:
        result = "Wednesday - not weekend";
        break;
    case 4:
        result = "Thursday - not weekend";
        break;
    case 5:
        result = "Friday - not weekend";
        break;
    case 6:
        result = "Saturday - weekend";
        break;
    case 7:
        result = "Sunday - weekend";
        break;
}

Console.WriteLine(result);