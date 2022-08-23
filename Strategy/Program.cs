using System;
using System.Collections.Generic;
using System.Linq;
using Strategy.Domain;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Two contexts following different strategies

            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ReverseSort());
            studentRecords.Sort();

            
            // Wait for user

            Console.ReadKey();
        }
    }
}

