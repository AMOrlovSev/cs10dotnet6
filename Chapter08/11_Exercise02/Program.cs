using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static System.Console;

WriteLine("The default regular expression checks for at least one digit.");
while(true)
{
    string input = string.Empty;
    WriteLine("Enter a regular expression(or press ENTER to use the default): ^[a-z]+$");
    if (ReadKey().Key == ConsoleKey.Enter)
    {
        input = "apples";
    }
    else
    {
        input = ReadLine();
    }

    string regex = @"^[a-z]+$";
    WriteLine($"{input} matches ^[a-z]+$? {Regex.IsMatch(input, regex)}");

    WriteLine("Press ESC to end or any key to try again.");
    if (ReadKey().Key == ConsoleKey.Escape)
    {
        break;
    }
}