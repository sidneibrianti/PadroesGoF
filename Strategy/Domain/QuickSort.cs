using Strategy.Interface;

namespace Strategy.Domain
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    public class QuickSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();  // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}

