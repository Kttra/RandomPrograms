/*  C# program used to reverse a given string
*/
using System;
using System.Linq; //Needed for .ToArray()

public class AnagramChecker
{
	public static void Main()
	{
		string str1 = "babcdE";
		string str2 = "bbacde";
		//Set the strings to lower case and then sort the strings by alphabetical order
		str1 = SortString(str1.ToLower());
		str2 = SortString(str2.ToLower());
		
		//Check if each character is the same between the strings
		int index = 0;
		foreach (var letter in str1)
		{
			if (letter == str2[index])
			{
				index++;
			}
			else
			{
				break;
			}
		}

		//If we reached the last index, then the strings are anagrams
		if (index == str1.Length)
		{
			Console.WriteLine("The two strings are anagrams");
		}
		else
		{
			Console.WriteLine("The two strings are not anagrams");
		}
	}

    //Sort the string
	static string SortString(string input)
	{
		char[] characters = input.ToArray();
		Array.Sort(characters);
		return new string (characters);
	}
}