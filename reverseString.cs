/*  C# program used to reverse a given string
*/
using System;
using System.Collections.Generic;

public class ReverseString
{
	public static void Main()
	{
    //Get string from user
		Console.WriteLine("Enter your string");
		string name = Console.ReadLine();

    //Reverse the word
		string reverse = reverseWord(name);
		Console.WriteLine("Your reversed word is: " + reverse);
	}
  //Function to reverse a string
	static string reverseWord(string ourWord)
	{
		string reversedWord = "";
		int index = 0;

    //Add the characters one by one from the end of the string to the beginning
		for (int i = ourWord.Length - 1; i >= 0; i--)
		{
			reversedWord = reversedWord + ourWord[i];
			index++;
		}

		return reversedWord;
	}
  //Another way to reverse a string
  static string reverseWord2(string ourWord){
    string reversedWord = "";
    
    //Add the characters one by one before the string "reversedWord"
    for(int i = 0; i < ourWord.Length; i++){
        reversedWord = ourWord[i] +  reversedWord;
    }
    return reversedWord;
  }
}