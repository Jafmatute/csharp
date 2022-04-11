using System;
using System.Linq;

namespace CSharpAdvanced.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numbersOfWords)
        {
            if (numbersOfWords < 0) throw new ArgumentOutOfRangeException("numbersOfWords should be greater than or equal to 0.");
            if (numbersOfWords == 0) return "";

            var words = str.Split(" ");

            if (words.Length <= numbersOfWords) return str;

            return String.Join(" ", words.Take(numbersOfWords)) + "....";
        }
    }
}
