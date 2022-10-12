/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0") Console.WriteLine($"Введите целое число, вы вввели {userLine}"); else break;
    }
    return result;
}

double getBigNumberFromUser(string userInformation)
{
    double result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out result);
        if (result == 0 && userLine != "0") Console.WriteLine($"Введите число, вы вввели {userLine}"); else break;
    }
    return result;
}

void printInConsoleWithColor(string information, ConsoleColor color)
{
     Console.ForegroundColor = color;
     Console.WriteLine(information);
     Console.ResetColor();
}

double printStepen (double number, int stepen)
{
    double result = number;
    if (number == 0) result = 0;
    if (number == 1 || stepen == 0) result = 1;
    if (stepen > 0) for (int i = 1; i < stepen; i++) result = result * number;
    else for (int i = 1; i < Math.Abs(stepen); i++) result = 1 / (result * number);
    return result;
}

Console.WriteLine();
double result = 0;
printInConsoleWithColor("Задайте число которое будете возводить в степень", ConsoleColor.DarkMagenta);
double userNumber = getBigNumberFromUser("");
printInConsoleWithColor("Задайте степень для возведения первого числа", ConsoleColor.DarkMagenta);
int stepen = getNumberFromUser("");
Console.WriteLine();
if (userNumber == 0 && stepen < 0) printInConsoleWithColor($"Невозможно {userNumber} возвести в отрицательную степень {stepen}, перезапустите программу и введите другие числа", ConsoleColor.DarkRed);
else 
{
    result = printStepen(userNumber, stepen);
    printInConsoleWithColor($"Число {userNumber} в степени {stepen} = {result}", ConsoleColor.DarkYellow);
}
Console.WriteLine();
