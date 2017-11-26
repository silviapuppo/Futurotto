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

    public class SimpleList<T>
    {
        public ListNode<T> Start { get; set; }
        public int Count { get; set; }

        public SimpleList(ListNode<T> start)
        {
            Start = start;
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

        public void ListRemoveAt(int index)
        {
            ListNode<T> temp = Start;
            ListNode<T> prev = null;

            for (int i = 1; i <= index; i++)
            {
                prev = temp;
                temp = temp.Next;
            }


            if (temp.Next != null)
            {
                prev = temp.Next;
                Count--;
            }

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


    }
}
