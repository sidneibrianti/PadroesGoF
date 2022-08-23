using Strategy.Interface;

namespace Strategy.Domain
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    public class ReverseSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Reverse();  
            Console.WriteLine("ReverseSorted list ");
        }
    }
}

