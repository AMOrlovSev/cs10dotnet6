using static System.Console;

//for(int i = 1; i<=100; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//        Write("fizzbuzz ");
//    else if (i % 3 == 0)
//        Write("fizz ");
//    else if (i % 5 == 0)
//        Write("buzz ");
//    else
//        Write(i+" ");
//}


for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Write("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Write("Fizz");
    }
    else if (i % 5 == 0)
    {
        Write("Buzz");
    }
    else
    {
        Write(i);
    }

    // put a comma and space after every number except 100
    if (i < 100) Write(", ");

    // write a carriage-return after every ten numbers
    if (i % 10 == 0) WriteLine();
}
WriteLine();