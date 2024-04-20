using System;
using TextUtilsLibrary;

class Program
{
    static void Main(string[] args)
    {
        string text = "А роза упала на лапу Азора";

        Console.WriteLine($"Строка \"{text}\" является палиндромом: {text.IsPalindrome()}");
        Console.WriteLine($"Количество слов в строке: {text.WordCount()}");
        Console.WriteLine($"Количество предложений в строке: {text.SentenceCount()}");
        Console.WriteLine($"Количество символов в строке: {text.CharacterCount()}");

        Console.ReadLine();
    }
}
