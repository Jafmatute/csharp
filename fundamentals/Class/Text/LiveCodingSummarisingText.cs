using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace csharpFundamentals.Class.Text
{
    class LiveCodingSummarisingText
    {

        public void SummaryText()
        {
            var sentence = "This is going to be a really really really really long text";

            var summary = SummerizeText(sentence);
            Console.WriteLine(summary);
        }

        static string SummerizeText(string text, int maxLength=20)
        {
           
            if (text.Length < 20) return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength) break;
            }

            return String.Join(" ", summaryWords) + "....";
        }
    }
}
