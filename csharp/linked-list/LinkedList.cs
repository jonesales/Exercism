using System.Collections.Generic;
using System.Linq;

public class Deque<T>
{
    public LinkedList<T> lista { get; set; } = new LinkedList<T>();

    public void Push(T value) => lista.AddLast(value);

    public T Pop()
    {
        var value = lista.Last();
        lista.RemoveLast();
        return value;
    }

    public void Unshift(T value) => lista.AddFirst(value);


    public T Shift()
    {
        T value = lista.First();
        lista.RemoveFirst();
        return value;
    }
}