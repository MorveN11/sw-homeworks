public class MyList<T>
{
    private T[] _items;
    private int _count;

    public MyList()
    {
        _items = new T[0];
        _count = 0;
    }

    public int Count => _count;
    public T this[int index] => _items[index];

    public void Add(T item)
    {
        T[] tempArray = _items;
        _items = new T[_count + 1];

        for (int i = 0; i < _count; i++)
        {
            _items[i] = tempArray[i];
        }

        _items[_count] = item;
        _count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new IndexOutOfRangeException();
        }

        int j = 0;
        T[] tempArray = _items;
        _items = new T[_count - 1];

        for (int i = 0; i < _count; i++)
        {
            if (i != index)
            {
                _items[j++] = tempArray[i];
            }
        }

        _count--;
    }

    public override string ToString()
    {
        string result = string.Empty;

        for (int i = 0; i < _count; i++)
        {
            result += _items[i] + " ";
        }

        return result;
    }
}
