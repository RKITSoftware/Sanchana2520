using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        public void singledimension()
        {
            // single dimemsional array
            Console.WriteLine("Enter size of array for sinlge dimensional array:");
            int number = Convert.ToInt32(Console.ReadLine()); //taking size of array 

            Console.WriteLine("Enter numbers:\n");
            int[] array = new int[number];  //declaration of array

            for (int i = 0; i < number; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine()); // getting the elements of array from user
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array Index: " + i + " AND Array Item: " + array[i].ToString()); // printing index number and array elements
            }
        }

        public void multidimension()
        {    // Multi-dimensional array
            Console.Write("Enter Number to Define Rows & Column:- ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[,] arrayfirst = new int[arrayLength, arrayLength];
            int[,] arraySecond = new int[arrayLength, arrayLength];
            int[,] arraySum = new int[arrayLength, arrayLength];

            //taking the first array as input
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    arrayfirst[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //taking the second array as input
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    arraySecond[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //adding both the arrays
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    arraySum[i, j] = arrayfirst[i, j] + arraySecond[i, j];

                }

            }
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write( arraySum[i, j]);
                }
            }
           Console.WriteLine();  
        }

        public void jagged_array()
        {
            //jagged array
        int[][] arr = new int[3][]{  
        new int[] { 1,2,3,4 },  //assigning values at index
        new int[] { 7,7,5,9 },  
        new int[] { 2,5,0 }  
        };  
  
        // Traverse array elements  
        for (int i = 0; i < arr.Length; i++)  
        {  
            for (int j = 0; j < arr[i].Length; j++)  
            {  
                System.Console.Write(arr[i][j]+"");  
            }  
            System.Console.WriteLine();  
        }  
    }  
        
        static void Main(string[] args)
        {
         objProgram obj = new Program(); //creating object
        
            //calling all methods
           obj.singledimension();
           obj.multidimension();
           obj.jagged_array();

          

            Console.ReadKey();

        }
    }
}
