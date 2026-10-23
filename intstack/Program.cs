using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    class IntStack
    {
        private int[] _items = new int[4];
        public int Count { get; private set; }
        public int Capacity => _items.Length;

        public void Enlarge()
        {
            int newCapacity = Capacity;
            if (Count == Capacity)
            {
                newCapacity = Capacity * 2;
            }
            int[] newitems = new int[newCapacity];
            for (int i = 0; i < Count; i++)
            {
                newitems[i] = _items[i];
            }
            _items = newitems;
        }

        public void Push(int data)
        {
            if (Count == Capacity)
            {
                Enlarge();
            }
            _items[Count] = data;
            Count++;
        }
        public int Pop()
        {
            if (Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int data = _items[Count - 1];
            Count--;
            _items[Count] = 0;
            return data;
        }


        public int Peek()
        {
            if (Count == 0)
            {
                return -1;
            }
            return _items[Count - 1];
        }

        public void Print()
        {
            Console.Write("Stack: ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(_items[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        IntStack s = new IntStack();
        s.Push(1); s.Push(3); s.Push(4); s.Push(6);
        s.Print();
        Console.WriteLine($"Peek: {s.Peek()}");
        Console.WriteLine($"Pop: {s.Pop()}");
        s.Print();

        s.Push(7); s.Push(9);
        s.Print();
        Console.WriteLine($"Count: {s.Count}");
    }
}
