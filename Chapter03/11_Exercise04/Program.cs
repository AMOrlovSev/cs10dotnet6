using static System.Console;

//Write("Enter a number between 0 and 255: ");
//string a = ReadLine();
//Write("Enter another number between 0 and 255: ");
//string b = ReadLine();
//int aa, bb;
//if (int.TryParse(a, out aa) &&  int.TryParse(b, out bb))
//{
//    WriteLine($"{aa} divided by {bb} is {aa / bb}");
//}
//else
//{
//    try
//    {
//        aa = int.Parse(a);
//        bb = int.Parse(b);
//    }
//    catch (Exception ex)
//    {
//        WriteLine($"{ex.GetType} - {ex.Message}");
//    }
//}

Write("Enter a number between 0 and 255: ");
string? n1 = ReadLine();

Write("Enter another number between 0 and 255: ");
string? n2 = ReadLine();

try
{
    byte a = byte.Parse(n1);
    byte b = byte.Parse(n2);

    int answer = a / b;

    WriteLine($"{a} divided by {b} is {answer}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}