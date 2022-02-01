using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        { 
            //first question 
            Console.Write("ENTER THE STRING >> ");
            String str=Console.ReadLine();
            Console.WriteLine($"Length of {str} is {str.Length}");
            //second question
            Console.WriteLine($"\nENTER THE SENTENCE >> ");
            str=Console.ReadLine();
            if(str.EndsWith("."))
            {
                Console.WriteLine("Declarative sentence");
            }
            else if(str.EndsWith("?"))
            {
                Console.WriteLine("Interrogatory sentence");   
            }
            else if(str.EndsWith("!"))
            {
                Console.WriteLine("Exclamation snetence");
            }
            else
            Console.WriteLine("Not a sentence");

            //third-fourth question
            Console.Write("\nENTER YOUR NAME  >> ");
            str =  Console.ReadLine();
            int indexOfSpace = str.IndexOf(" ");
            if(indexOfSpace!=-1)
            Console.WriteLine($"WITH CHANGES  >> {str.Substring(indexOfSpace+1)}, {str.Substring(0,indexOfSpace)}");
            else
            Console.WriteLine("WITHOUT CHANGES >> {0}",str);


        }
    }
}
