using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    class IntQueue
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

        public void Enqueue(int data)
        {
            if (Count == Capacity)
            {
                Enlarge();
            }
            _items[Count] = data;
            Count++;
        }
        public int Dequeue()
        {
            if (Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            int data = _items[0];
            for (int i = 0; i < Count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            Count--;
            _items[Count] = 0;
            return data;
        }

        public void Print()
        {
            Console.Write("Queue: ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(_items[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        IntQueue q = new IntQueue();

        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(5);
        q.Print();

        q.Dequeue();
        q.Print();

        q.Dequeue();
        q.Print();
    }
}
