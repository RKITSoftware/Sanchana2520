using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface content //creating interface
{
    void ReadContent();
    void WriteContent();
}

class ContentInfo : content 
{
    void content.ReadContent()
    {
        Console.WriteLine("Reading the content");
    }

    void content.WriteContent()
    {
        Console.WriteLine("Writing the content");
    }
    public void Search()
    {
        Console.WriteLine("Searching the content");
    }
    

        static void Main(string[] args)
        {
             //creating objects
            content obj1 = new ContentInfo();
            ContentInfo obj2 = new ContentInfo();

            obj1.ReadContent();
            obj1.WriteContent();
            //obj1.Search()//compile-time error 

            obj2.Search();
            //obj2.ReadContent(); //compile-time error 
            //obj2.WriteContent(); //compile-time error 

            Console.ReadKey();
        }
    }
}
