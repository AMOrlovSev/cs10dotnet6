using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public partial class Person
    {
        private string favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");
                }
            }
        }
        // свойство, определенное с помощью синтаксиса C# 1–5
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        // два свойства, определенные с помощью синтаксиса
        // лямбда-выражений C# 6+
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;
        public string FavoriteIceCream { get; set; } // автосинтаксис

        // индексаторы
        public Person this[int index]
        {
            get
            {
                return Children[index]; // передача индексатору List<T>
            }
            set
            {
                Children[index] = value;
            }
        }
    }
}
