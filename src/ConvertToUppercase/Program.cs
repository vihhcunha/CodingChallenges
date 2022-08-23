using System.Diagnostics;
using System.Text;

Console.WriteLine(" ------------------------------------------------");
Console.WriteLine(" Write a sentence and see convert it to uppercase");
Console.WriteLine(" ------------------------------------------------");

var sentence = Console.ReadLine();

Stopwatch stopwatch = Stopwatch.StartNew();

stopwatch.Stop();

var newSentence = ConvertToUppercase(sentence);

Console.WriteLine("\nNew sentence: " + newSentence);
Console.WriteLine("\n\nElapsed time in milliseconds: " + stopwatch.ElapsedMilliseconds);

static string ConvertToUppercase(string? sentence)
{
    var sentenceASCIIBytes = Encoding.ASCII.GetBytes(sentence);
    var newByteArraySentence = new byte[sentenceASCIIBytes.Length];

    for (var i = 0; i < sentenceASCIIBytes.Length; i++)
    {
        if (sentenceASCIIBytes[i] >= 'a' && sentenceASCIIBytes[i] <= 'z')
        {
            newByteArraySentence[i] = (byte)(sentenceASCIIBytes[i] - ('a' - 'A'));
        }
        else
        {
            newByteArraySentence[i] = sentenceASCIIBytes[i];
        }
    }

    return Encoding.ASCII.GetString(newByteArraySentence);
}