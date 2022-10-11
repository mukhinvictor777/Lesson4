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

void printRandomArray(int userNumber)
{
    int[] array = new int[userNumber];
    Random rnd = new Random ();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("[");
    for (int i = 0; i < userNumber-1; i++)
    {
        array[i] = rnd.Next(0, 2);
        Console.Write($"{array[i]}, ");
    }
    array[userNumber-1] = rnd.Next(0, 2);
    Console.Write($"{array[userNumber-1]}");
    Console.Write("]");
    Console.ResetColor();
}

Console.WriteLine();
printInConsoleWithColor("Задайте число элементов массива", ConsoleColor.DarkMagenta);
int userNumber = getNumberFromUser("");
printRandomArray(userNumber);