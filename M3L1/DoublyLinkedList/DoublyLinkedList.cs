using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoublyLinkedList
{
    public class CustomDoublyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public CustomDoublyLinkedList()
        {
        }

        public CustomDoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                var current = _head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Value;
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                var current = _head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T value)
        {
            var node = new Node<T>(value);
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Previous = _tail;
                _tail.Next = node;
                _tail = node;
            }

            Count++;
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var current = _head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                _head = current.Next;
            }

            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                _tail = current.Previous;
            }

            Count--;
            return current.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
