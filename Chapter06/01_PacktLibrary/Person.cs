using System.Threading;
using static System.Console;

namespace Packt.Shared;


public class Person : object, IComparable<Person>
{
    // поля
    public string? Name; // символ ? допускает нулевое значение
    public DateTime DateOfBirth;
    public List<Person> Children = new(); // C# 9 и более поздние версии
    
    // методы
    public virtual void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }
    // статический метод для "размножения"
    public static Person Procreate(Person p1, Person p2)
    {
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }
    // метод экземпляра для "размножения"
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }
    // операция "размножения"
    public static Person operator *(Person p1, Person p2)
    {
        return Person.Procreate(p1, p2);
    }

    // метод с локальной функцией
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
            $"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);
        int localFactorial(int localNumber)// локальная функция
        {
            if (localNumber < 1) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }


    // поле делегата
    public EventHandler? Shout;
    // поле данных
    public int AngerLevel;
    // метод
    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            // если что-то прослушивается...
            if (Shout != null)
            {
                // ...затем вызовите делегат
                Shout(this, EventArgs.Empty);
            }
        }
    }

    public int CompareTo(Person? other)
    {
        if (Name is null) return 0;
        return Name.CompareTo(other?.Name);
    }

    // переопределенные методы
    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}";
    }


    public void TimeTravel(DateTime when)
    {
        if (when <= DateOfBirth)
        {
            throw new PersonException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
        }
        else
        {
            WriteLine($"Welcome to {when:yyyy}!");
        }
    }
}



