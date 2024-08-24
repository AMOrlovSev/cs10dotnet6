using static System.Console;

// массив строк, реализующий IEnumerable<string>
string[] names = new[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };

WriteLine("Deferred execution");
// Вопрос: какие имена заканчиваются на букву m?
// (используем метод расширения LINQ)
var query1 = names.Where(name => name.EndsWith("m"));
// Вопрос: какие имена заканчиваются на букву m?
// (используем синтаксис написания запросов LINQ)
var query2 = from name in names where name.EndsWith("m") select name;

// ответ возвращается в виде массива строк, содержащих Pam и Jim
string[] result1 = query1.ToArray();
// ответ возвращается в виде списка строк, содержащих Pam и Jim
List<string> result2 = query2.ToList();

// ответ возвращается по мере перечисления результата
foreach (string name in query1)
{
    WriteLine(name); // вывод Pam
    names[2] = "Jimmy"; // изменение Jim на Jimmy
                        // на второй итерации Jimmy не заканчивается на букву M
}


WriteLine(new string('\n', 2));
WriteLine("Writing queries");
static bool NameLongerThanFour(string name)
{
    return name.Length > 4;
}

//var query = names.Where(new Func<string, bool>(NameLongerThanFour));
//var query = names.Where(NameLongerThanFour);
//var query = names.Where(name => name.Length > 4);

IOrderedEnumerable<string> query = names
    .Where(name => name.Length > 4)
    .OrderBy(name => name.Length)
    .ThenBy(name => name);

foreach (string item in query)
{
    WriteLine(item);
}


WriteLine(new string('\n', 2));
WriteLine("Filtering by type");
List<Exception> exceptions = new()
{
    new ArgumentException(),
    new SystemException(),
    new IndexOutOfRangeException(),
    new InvalidOperationException(),
    new NullReferenceException(),
    new InvalidCastException(),
    new OverflowException(),
    new DivideByZeroException(),
    new ApplicationException()
};

IEnumerable<ArithmeticException> arithmeticExceptionsQuery = exceptions.OfType<ArithmeticException>();

foreach (ArithmeticException exception in arithmeticExceptionsQuery)
{
    WriteLine(exception);
}
