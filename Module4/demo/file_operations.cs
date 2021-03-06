using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_operation
{
    class Program
    {
        static void Main(string[] args)
        {

            string pathToFile = @"C:\sanchana\demo.txt"; //path of file

            //Create if it doesn't exists
            if (File.Exists(pathToFile))
            {
                //Yes file exists
                //create TextWriter object
                TextWriter writeFile = new StreamWriter(pathToFile);

                //write data into file
                writeFile.WriteLine("This is file operation program in c#");
                writeFile.Flush();
                writeFile.Close();


                //get file and create TextReader object
                TextReader tr = new StreamReader(pathToFile);

                Console.WriteLine(tr.ReadToEnd()); //read the data of file

                tr.Close();
            }
            else
            {
                //create the file test.txt 
                File.Create(pathToFile);
                Console.WriteLine("File 'demo' created");

            }
           
            using (StreamWriter sw = File.AppendText(pathToFile))//appending the text
            {
                sw.WriteLine("This is appended text");
                
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(pathToFile))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            //Reading all the lines one by one in a file
            String[] lines;
            lines = File.ReadAllLines(pathToFile);
            Console.WriteLine("Reading the lines one by one:");
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
               
             //get when the file was accessed last time 
            DateTime lastAccessTime = File.GetLastAccessTime(pathToFile);
            Console.WriteLine("Last Access time: {0}", lastAccessTime);

            //get when the file was written last time
            DateTime lastWriteTime = File.GetLastWriteTime(pathToFile);
            Console.WriteLine("Last time Written: {0}", lastWriteTime);

            string OriginalFile = @"C:\sanchana\demo.txt"; //path of file
            string DuplicateFile = @"C:\sanchana\copy_test.txt";   //duplicate file path 

            //COPYING a file
            File.Copy(OriginalFile, DuplicateFile);

            //MOVING file to another location
            string MoveFile = @"C:\src\demo.txt";
            File.Move(OriginalFile, MoveFile);

            //DELETE  a file
            string DeleteFile = @"C:\sanchana\copy_test.txt";//Get Location of file to delete
            File.Delete(DeleteFile);
           

            Console.ReadKey();

        }
    }
}
