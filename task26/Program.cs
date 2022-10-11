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

int getCountOfDigit(int userNumber)
{
    int count = 1;
    userNumber = Math.Abs(userNumber);
    while (userNumber / 10 > 0)
    {
        userNumber = userNumber / 10;
        count++;
    }
    return count;
}

Console.WriteLine();
printInConsoleWithColor("Введите целое число:", ConsoleColor.DarkMagenta);
int userNumber = getNumberFromUser("");
int countOfDigit = getCountOfDigit(userNumber);
Console.WriteLine($"Количество цифр в числе {userNumber} = {countOfDigit}");
Console.WriteLine();