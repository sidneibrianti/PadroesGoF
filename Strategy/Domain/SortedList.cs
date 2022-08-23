using Strategy.Interface;

namespace Strategy.Domain
{
    /// <summary>
    /// The 'Context' class
    /// </summary>

    public class SortedList
    {
        private List<string> list = new List<string>();
        private ISortStrategy? sortstrategy;

        public void SetSortStrategy(ISortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            sortstrategy?.Sort(list);

            // Iterate over list and display results

            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}

