using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Please enter the numerator? ");
            int numerator  = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the denominator? ");
            int denominator = Convert.ToInt32(Console.ReadLine());
            int quotient = numerator/denominator;
            int remainder =  numerator%denominator;
            Console.WriteLine($"Integer division result = {quotient} with remainder = {remainder}");
            double fdev =(double) numerator / denominator;
            Console.WriteLine($"Flaoting point division result = {fdev}");
            Console.WriteLine($"The result as a mixed fraction is {quotient}({remainder}/{denominator})");
            
            
        }
    }
}
