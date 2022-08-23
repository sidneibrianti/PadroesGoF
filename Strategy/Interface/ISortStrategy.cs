namespace Strategy.Interface
{
    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>

    public interface ISortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}

