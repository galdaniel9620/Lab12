public class Queue<T>
{
    private List<T> _elements;
    private int _maxCapacity;

    public Queue(int capacity)
    {
        _maxCapacity = capacity;
        _elements = new List<T>(capacity);
    }

    public void Enqueue(T item)
    {
        if (_elements.Count >= _maxCapacity)
        {
            throw new InvalidOperationException("Queue is full");
        }
        _elements.Add(item);
    }

    public T Dequeue()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        T item = _elements[0];
        _elements.RemoveAt(0);
        return item;
    }

    public int Count
    {
        get { return _elements.Count; }
    }
}


