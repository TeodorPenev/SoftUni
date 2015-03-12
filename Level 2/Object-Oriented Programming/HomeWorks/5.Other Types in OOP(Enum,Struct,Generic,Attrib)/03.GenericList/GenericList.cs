using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.GenericList
{
    [Version(1.01)]
    public class GenericList<T>where T: IComparable<T>
    {
        const int DefaultCapacity = 16;
        public T[] elements;
        public int count=0;

        public GenericList(int capacity=DefaultCapacity)
        {
            elements=new T[DefaultCapacity];
        }

        public void Add(T element)
        {
            if (count==this.elements.Length)
            {
                T[] newList = new T[this.elements.Length * 2];
                for (int i = 0; i < this.count; i++)
                {
                    newList[i] = this.elements[i];
                }
                this.elements = newList;
            }

            this.elements[this.count] = element;
            this.count++;
        }

        public T this[int index]
        {
            get
            {
                this.IndexValidation(index);
                T result = elements[index];
                return result;
            }
        }

        public void RemoveAt(int index)
        {
            T[] newList = new T[this.elements.Length];
            for (int i = 0, position = 0; i < this.count; i++, position++)
            {
                if (i != index)
                {
                    newList[position] = this.elements[i];
                    continue;
                }

                position--;
            }

            this.elements = newList;
            this.count--;
        }

        public void InsertAt(int index, T value)
        {
            if (index >= this.count)
            {
                this.Add(value);
            }
            else
            {
                this.IndexValidation(index);
                this.elements[index] = value;
            }
        }

        public void Clear()
        {
            this.elements = new T[this.elements.Length];
            this.count = 0;
        }

        public T Max()
        {
            var max = this.elements[0];

            for (int i = 1; i < this.count; i++)
            {
                if (max.CompareTo(this.elements[i]) < 0)
                {
                    max = this.elements[i];
                }
            }

            return max;
        }

        public T Min()
        {
            var min = this.elements[0];

            for (int i = 1; i < this.count; i++)
            {
                if (min.CompareTo(this.elements[i]) > 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }

        public int? FindElementIndex(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }

            return null;
        }

        public bool Countains(T element)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                if (elements[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        private void IndexValidation(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < elements.Count(); i++)
            {
                result.Append(String.Format("{0}\n", elements[i]));
            }

            return result.ToString();
        }
    }
}
