int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0 || result < 1)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 1) Console.WriteLine($"Введите целое число большое нуля, вы вввели {userLine}"); else break;
    }
    return result;
}

void printInConsoleWithColor(string information, ConsoleColor color)
{
     Console.ForegroundColor = color;
     Console.WriteLine(information);
     Console.ResetColor();
}

double getFactorial(int userNumber)
{
    if (userNumber == 1) return 1;
    else return userNumber * getFactorial(userNumber-1);
}

Console.WriteLine();
printInConsoleWithColor("Введите целое число большое нуля", ConsoleColor.DarkMagenta);
int userNumber = getNumberFromUser("");
double factorial = getFactorial(userNumber);
printInConsoleWithColor($"Произведение чисел от 1 до {userNumber} = {factorial}", ConsoleColor.DarkYellow);
Console.WriteLine();