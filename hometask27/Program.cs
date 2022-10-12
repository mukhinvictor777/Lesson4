/*
    Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    452 -> 11

    82 -> 10

    9012 -> 12
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

void printInConsoleWithColor(string information, ConsoleColor color)
{
     Console.ForegroundColor = color;
     Console.WriteLine(information);
     Console.ResetColor();
}

int getSumOfDigit(int userNumber)
{
    int number = Math.Abs(userNumber);
    int sum = 0;
    if (number / 10 == 0) sum = number;
    else while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine();
printInConsoleWithColor("Введите целое число:", ConsoleColor.DarkMagenta);
int userNumber = getNumberFromUser("");
int sumOfDigit = getSumOfDigit(userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} = {sumOfDigit}");
Console.WriteLine();