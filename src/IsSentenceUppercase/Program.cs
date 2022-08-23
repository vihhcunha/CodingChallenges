using System.Diagnostics;
using System.Text;

Console.WriteLine(" -------------------------------------------");
Console.WriteLine(" Write a sentence and see if it is uppercase");
Console.WriteLine(" -------------------------------------------");

var sentence = Console.ReadLine();

Stopwatch stopwatch = Stopwatch.StartNew();

stopwatch.Stop();

if (IsUppercaseSentence(sentence))
{
    Console.WriteLine("\nYour sentence is uppercase!!");
}
else
{
    Console.WriteLine("\nYour sentence is not uppercase!!");
}

Console.WriteLine("\n\nElapsed time in milliseconds: " + stopwatch.ElapsedMilliseconds);

static bool IsUppercaseSentence(string? sentence)
{
    var sentenceASCIIBytes = Encoding.ASCII.GetBytes(sentence);
    for (var i = 0; i < sentenceASCIIBytes.Length; i++)
    {
        if (sentenceASCIIBytes[i] < 65 || sentenceASCIIBytes[i] > 90)
        {
            return false;
        }
    }

    return true;
}