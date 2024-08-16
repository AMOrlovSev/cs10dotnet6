using static System.Console;

static double Add(double a, double b)
{
    return a + b; // Преднамеренная ошибка!
}
int n = 1;
while (true)
{
    double a = 4.5;
    double b = 2.5;
    double answer = Add(a, b);
    WriteLine($"{n++}:{a} + {b} = {answer}");
    WriteLine("Press ENTER to end the app.");
    ReadLine(); // ожидание нажатия клавиши ENTER пользователем
}