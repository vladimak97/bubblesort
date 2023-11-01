using System;
using System.Collections.Generic;


namespace BubbleSort

{
    class Program
    
    {
        static void Main()
        
        {
            var numbersTab = Console.ReadLine().Split();
            var sortingNumbers = Console.ReadLine().Split();

            List<int> FirstNumbers = new List<int>();
            List<int> LastNumbers = new List<int>();
            List<int> AsSorted = new List<int>();

            for (int i = 0; i < Int32.Parse(sortingNumbers[0]); i++)
            {
                FirstNumbers.Add(Int32.Parse(numbersTab[i]));
            }

            for (int i = Int32.Parse(sortingNumbers[0]); i <= Int32.Parse(sortingNumbers[1]); i++)
            {
                AsSorted.Add(Int32.Parse(numbersTab[i]));
            }

            for (int i = Int32.Parse(sortingNumbers[1]) + 1; i <numbersTab.Length; i++)
            {
                LastNumbers.Add(Int32.Parse(numbersTab[i]));
            }

            int temp = 0;

            for (int i = 0; i < AsSorted.Count - 1; i++)
            {
                for (int j = 0; j < AsSorted.Count - 1 - i; j++)
                {
                    if (AsSorted[j] < AsSorted[j + 1])
                    {
                        temp = AsSorted[j];
                        AsSorted[j] = AsSorted[j + 1];
                        AsSorted[j + 1] = temp;
                    }
                }
            }