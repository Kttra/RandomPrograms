/*  C# program used to find the Fibonacci numbers given
    a maximum value.
*/
using System;
using System.Collections.Generic;

public class Fibonacci
{
	public static void Main()
	{
        //Create a list
		List<int> fibonacci = findFibonacci(50);

        //Print out the list
		foreach (var num in fibonacci)
		{
			Console.Write(num + " ");
		}
	}

    //Calculate all the fibonacci numbers smaller than maxNum
	static List<int> findFibonacci(int maxNum)
	{
        //Create our list
		List<int> listRange = new List<int>();
		//Add the first two elements
        if (maxNum >= 1)
		{
			listRange.Add(1);
			listRange.Add(1);
		}
        //Return is maxNum is less than 1, there are no fibonacci numbers in this case
		else if (maxNum < 1)
		{
			return listRange;
		}
        //Continue until we hit maxNum
		for (int i = 0; i <= maxNum; i++)
		{   
            //Add the two adjacent numbers
			int nextFibonacci = listRange[i] + listRange[i + 1];
            //append it to the list if it's less than maxNum
			if (nextFibonacci < maxNum)
			{
				listRange.Add(nextFibonacci);
			}
			else
			{
				return listRange;
			}
		}

		return listRange;
	}
}