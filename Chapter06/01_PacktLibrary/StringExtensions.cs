using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Packt.Shared;
public static class StringExtensions
{
    public static bool IsValidEmail(this string input)
    {
        // используем простое регулярное выражение для проверки того,
        // что входная строка является действительным адресом
        // электронной почты
        return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}