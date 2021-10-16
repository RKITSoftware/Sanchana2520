using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = ""; //declaring a string 
            Console.WriteLine("Enter a string1");
            str1 = Console.ReadLine();

            Console.WriteLine("Enter a string2");
            string str2 = Console.ReadLine();

            //methods in string
            string str3 = string.Copy(str2); //copy method
            Console.WriteLine("string 3 is copied from string 2:" + str3);

            Console.WriteLine("Comparing strings:" + str2.CompareTo(str3)); // will compare string and return 0 if true else 1 for false

            Console.WriteLine("Contains A:" + str1.Contains("a")); // checks whether the string contains the specified value

            Console.WriteLine("Starts with A: " + str1.StartsWith("a")); //checks whether the string starts with specific value or not
            Console.WriteLine("Ends with A" + str1.EndsWith("a")); //checks whether the string ends with specific value or not


            Console.WriteLine("Equals:" + str1.Equals(str2)); // returns true if strings are equal

            Console.WriteLine("Hashcode:" + str1.GetHashCode()); //returns hashcode of string

            Console.WriteLine("Index of a:" + str1.IndexOf("a")); //returns the first index position of specified value

            Console.WriteLine("Last index of a:" + str1.LastIndexOf("a")); //returns the last index position of specified value

            Console.WriteLine("Inserting string:" + str1.Insert(0, "C#")); //Inserts specified string at specified index

            Console.WriteLine("Length of first string:"+ str1.Length); //returns length of string

            Console.WriteLine("Replacing character:" + str1.Replace('a', 'o')); // replaces the character

            Console.WriteLine("Substring:" + str1.Substring(1, 3)); // returns substring

            Console.WriteLine("String to character array:" + str1.ToCharArray()); //converts string to character array

            Console.WriteLine("Upper case:" + str1.ToUpper()); //converts the string to upper case
            Console.WriteLine("Lower case:" + str1.ToLower()); // converts the string to lower case

            Console.WriteLine("Trim: " + str1.Trim()); // removes starting and ending white spaces
            Console.WriteLine("Removing character:" + str1.Remove(3)); //removes all character from begining to specified index

            Console.ReadKey();
        }
    }
}
