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

int getSumOfRange(int startPoint, int endPoint)
{
    int result = 0;
    if (startPoint > endPoint)
    {
        printInConsoleWithColor($"Верхняя граница отрицательна {endPoint}", ConsoleColor.DarkYellow);
        int buffer = startPoint;
        startPoint = endPoint;
        endPoint = buffer;
    }
    for (int i = startPoint; i <= endPoint; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine();
printInConsoleWithColor($"Введите верхную границу для суммы ряда", ConsoleColor.DarkMagenta);
int userNumber = getNumberFromUser("");
int sumOfRange = getSumOfRange(1, userNumber);
Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {sumOfRange}");
Console.WriteLine();