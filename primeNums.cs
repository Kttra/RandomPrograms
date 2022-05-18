/*  C# program used to find prime numbers given
    a maximum value.
*/
using System;
using System.Collections.Generic;

public class PrimeNums
{
	public static void Main()
	{
        //Create our list
		List<int> primes = findPrimes(5);

        //Print out our list
		foreach (var num in primes)
		{
			Console.WriteLine(num + " ");
		}
	}
    //Check if the number is prime
	static bool isPrime(int num)
	{
        //Check the remainder of num/i
		for (int i = 2; i < num; i++)
		{
            //If num divided by i has no remainder, it is not prime
			if (num % i == 0)
			{
				return false;
			}
		}

		return true;
	}
    //Find all prime numbers equal to and less than maxNum
	static List<int> findPrimes(int maxNum)
	{
        //Create our list
		List<int> listRange = new List<int>();

        //If maxNum is less than 1, there are no prime numbers
		if (maxNum < 1)
		{
			return listRange;
		}
        
        //Check all numbers smaller than maxNum to see if they are prime
		for (int i = 2; i <= maxNum; i++)
		{
			if (isPrime(i))
			{
				listRange.Add(i);
			}
		}

		return listRange;
	}
}