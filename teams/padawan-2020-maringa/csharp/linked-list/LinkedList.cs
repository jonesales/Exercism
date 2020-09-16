using System;

public class Deque<T>
{
    private class Coisa
    {
        public T Value;
        public Coisa Next;
        public Coisa Prev;

        public Coisa() => Next = Prev = this;

        public void Add(T value) => Prev = Prev.Next = new Coisa { Value = value, Next = this, Prev = this.Prev };

        public T Remove()
        {
            Next.Prev = Prev;
            Prev.Next = Next;
            return Value;
        }
    }

    private Coisa _head = new Coisa();

    public void Push(T value) => _head.Add(value);

    public T Pop() => _head.Prev.Remove();

    public void Unshift(T value) => _head.Next.Add(value);

    public T Shift() => _head.Next.Remove();

    
}