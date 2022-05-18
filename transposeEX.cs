/*  C# program used to transpose a 2-D array into a 2-D list
*/
using System;
using System.Collections.Generic;

public class transpose  
   {  
     public static void Main(string[] args)  
      {  
        List<List<int>> matrix = new List<List<int>>();
        int[,] numberGrid = {{1, 2},
                             {3, 4},
                             {5, 6}
        };

        //Print each value at each index
        //For number of cols, 2 in this case
        for (int i = 0; i < numberGrid.GetLength(1); i++){
            List<int> temp = new List<int>();
            //For number of rows, 3 in this case
            for(int j = 0; j < numberGrid.GetLength(0); j++){
                //Console.WriteLine($"j[{j}]i[{i}] = {numberGrid[j,i]}");
                temp.Add(numberGrid[j,i]);
            }
            matrix.Add(temp);
        }

        //Print out the list
        Console.WriteLine();
        Console.WriteLine("Here is our list:");

        for (int i = 0; i < numberGrid.GetLength(1); i++)
        {
            for (int j = 0; j < numberGrid.GetLength(0); j++)
            {
                Console.Write($"{numberGrid[j,i]} ");
            }
            Console.WriteLine();
        }

        //Add line in between the 2-D array and the 2-D list
        Console.WriteLine();
        Console.WriteLine("Here is our list:");

        //Print out our list
        //For each row of our matrix, 3
        for (int i = 0; i < matrix[0].Count; i++)
        {
            //For each col of our matrix, 2
            for (int j = 0; j < matrix.Count; j++)
            {
                Console.Write($"{matrix[j][i]} ");
            }
            Console.WriteLine();
        }
    }  
 }  