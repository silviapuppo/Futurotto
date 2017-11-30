using System;
using System.Collections.Generic;

namespace Exercise02
{
    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T value, ListNode<T> next)
        {
            Value = value;
            Next = next;
        }

    }

    public class SimpleList<T> where T : IEquatable<T>
    {
        public ListNode<T> Start { get; set; }
        public int Count { get; private set; }

        public SimpleList()
        {
            Start = null;
            Count = 0;
        }

        public void ListAdd(T value)
        {
            ListNode<T> temp = Start;

            if (Start == null)
            {
                Start = new ListNode<T>(value, null);

            }
            else
            {
                while (Start.Next != null)
                {
                    Start = Start.Next;
                }

                Start.Next = new ListNode<T>(value, null);
                Start = temp;
            }
            Count++;
        }

        public void ListRemove(T value)
        {
            ListNode<T> temp = Start;
            ListNode<T> prev = null;

            if (Start.Value.Equals(value))
            {
                Start = Start.Next;
                Count--;
            }
            else
            {
                Start = Start.Next;
                while (Start.Next != null && !(Start.Value.Equals(value)))
                {
                    prev = Start;
                    Start = temp.Next;
                }

                if (Start.Next != null)
                {
                    prev.Next = Start.Next;
                    Start = temp;
                    Count--;
                }
                else
                {
                    throw new ArgumentNullException("value", "Element not found");
                }
            }
        }

        public void ListRemoveAt(int index)
        {
            ListNode<T> temp = Start;
            ListNode<T> prev = null;

            if (index == 0)
            {
                Start = Start.Next;
            }
            else
            {
                for (int i = 1; i <= index; i++)
                {
                    prev = temp;
                    temp = temp.Next;
                }

                prev.Next = temp.Next;
            }

            Count--;
        }

        public T[] ListToArray()
        {
            T[] result = new T[Count];
            ListNode<T> temp = Start;

            for (int i = 0; i < Count; i++)
            {
                result[i] = temp.Value;
                temp = temp.Next;
            }
            return result;
        }

        public static SimpleList<T> ArrayToList(T[] array)
        {
            SimpleList<T> result = new SimpleList<T>();

            foreach (T value in array)
            {
                result.ListAdd(value);
            }

            return result;
        }

        public void ListReverse()
        {
            T[] array = ListToArray();
            Array.Reverse(array);
            Start = ArrayToList(array).Start;

        }

    }
}
