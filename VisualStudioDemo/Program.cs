using System;

namespace VisualStudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 0, 5, 78, 56, 89, 78, 23, 56 };
            int[] oddNumbers = new int[8], evenNumbers = new int[8];
            int oddCount = 0, evenCount = 0;


            for(int i=0; i<arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    evenNumbers[evenCount] = arrayOfNumbers[i];
                    evenCount++;
                }
                else
                {
                    oddNumbers[oddCount]=arrayOfNumbers[i];
                    oddCount++;
                }

            }
            Console.WriteLine(evenCount);
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
            Console.WriteLine(oddCount);
            foreach (int oddNumber in evenNumbers)
            {
                Console.WriteLine(oddNumber);
            }
        }
    }
}
