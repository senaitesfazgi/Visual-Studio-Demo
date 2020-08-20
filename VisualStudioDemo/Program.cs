using System;

namespace VisualStudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 0, 5, 78, 56, 89, 78, 23, 56, 89 };
            for(int i=0; i<arrayOfNumbers.Length; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }    
        }
    }
}
