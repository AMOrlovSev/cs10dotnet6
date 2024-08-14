using static System.Console;

int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}


string? password;
int attempt = 0;
do
{
    Write("Enter your password: ");
    password = ReadLine();
    attempt++;
    if (attempt==10)
    {
        break;
    }
}
while (password != "Pa$$w0rd");
if (attempt == 10)
{
    WriteLine("НЕВЕРНЫЙ ПАРОЛЬ!");
}
else
{
    WriteLine("Correct!");
    attempt = 0;
}


for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}


string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}