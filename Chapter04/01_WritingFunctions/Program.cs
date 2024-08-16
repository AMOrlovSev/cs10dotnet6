using static System.Console;

TimesTable(6);

static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table:");
    for (int row = 1; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}");
    }
    WriteLine();
}




static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0M;
    switch (twoLetterRegionCode)
    {
        case "CH":// Швейцария
            rate = 0.08M;
            break;
        case "DK":// Дания
        case "NO": // Норвегия
            rate = 0.25M;
            break;
        case "GB":// Великобритания
        case "FR": // Франция
            rate = 0.2M;
            break;
        case "HU": // Венгрия
            rate = 0.27M;
            break;
        case "OR": // Орегон
        case "AK": // Аляска
        case "MT": // Монтана
            rate = 0.0M;
            break;
        case "ND": // Северная Дакота
        case "WI": // Висконсин
        case "ME": // Мэн
        case "VA": // Вирджиния
            rate = 0.05M;
            break;
        case "CA":// Калифорния
            rate = 0.0825M;
            break;
        default:// большинство штатов США
            rate = 0.06M;
            break;
    }
    return amount * rate;
}

WriteLine();
decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax.");


/// <summary>
/// Передайте 32-битное целое число, и оно будет преобразовано
/// в его порядковый эквивалент.
/// </summary>
/// <param name="number">Number is a cardinal value e.g. 1, 2, 3 and so on. </param>
/// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd and so on.
/// </ returns >
static string CardinalToOrdinal(int number)
{
    int lastTwoDigits = number % 100;
    switch (lastTwoDigits)
    {
        case 11:// особые случаи с 11-го по 13-й
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}

WriteLine();
static void RunCardinalToOrdinal()
{
    for (int number = 1; number <= 40; number++)
    {
        Write($"{CardinalToOrdinal(number)} ");
    }
    WriteLine();
}
RunCardinalToOrdinal();



static int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
        return number * Factorial(number - 1);
        }
    }
}

static void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch (System.OverflowException)
        {
            WriteLine($"{i}! is too big for a 32-bit integer.");
        }
    }
}

WriteLine();
RunFactorial();


static int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}

static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.", 
            arg0: CardinalToOrdinal(i), 
            arg1: FibImperative(term: i));
    }
}

WriteLine();
RunFibImperative();

static int FibFunctional(int term) =>
term switch
{
    1 => 0,
    2 => 1,
    _ => FibFunctional(term - 1) + FibFunctional(term - 2)
};

static void RunFibFunctional()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
        arg0: CardinalToOrdinal(i),
        arg1: FibFunctional(term: i));
    }
}

WriteLine();
RunFibFunctional();