/*  C# program used to split a string
*/
using System;
using System.Collections.Generic;

public class SplitString
{
	public static void Main()
	{
    //Get a line from the user
		Console.WriteLine("Type in a phrase: ");
		string phrase = Console.ReadLine();

    //Split up the words into an array
		string[] words = phrase.Split(' ');

    //Print out the words to the user
		int wordCount = 1;
		foreach (var word in words)
		{
			System.Console.WriteLine($"Word{wordCount}: {word}");
			wordCount++;
		}
	}
}