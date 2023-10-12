using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai04_MangDong
{
    public class DynamicArray : IEnumerable
    {
        private const int DEFAULT_SIZE = 16;

        private object[] items;

        private int count;

        private int capacity;

        public int Count 
        { 
            get { return count; } 
        }

        public int Capacity 
        { 
            get { return capacity;} 
        }

        public object this[int index] 
        {
            get 
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public DynamicArray()
        {
            items = new object[DEFAULT_SIZE];
            capacity = DEFAULT_SIZE;
            count = 0;
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 2)
            {
                throw new ArgumentOutOfRangeException("capacity", "Mang phai chua toi thieu 2 phan tu");
            }
            this.capacity = capacity;
            items = new object[capacity];
            count = 0;
        }

        public void Add(object x)
        {
            if (x == null)
            {
                throw new ArgumentNullException("x");
            }

            if (count == capacity)
            {
                capacity *= 2;

                object[] temp = new object[capacity];

                Array.Copy(items, 0, temp, 0, count);

                items = temp;
            }

            items[count] = x;
            count++;
        }

        public void AddRange(object[] listItems)
        {
            if (count + listItems.Length > capacity)
            {
                capacity *= 2;

                object[] temp = new object[capacity];

                Array.Copy(items, 0, temp, 0, count);

                items = temp;
            }

            Array.Copy(listItems, 0, items, count, listItems.Length);
            count += listItems.Length;
        }

        public object RemoveAt(int index)
        {
            if (index < 0 || index >= count) 
            {
                throw new IndexOutOfRangeException();
            }

            object deleted = items[index];

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;

            if (count - 1 < capacity / 2)
            {
                capacity /= 2;

                object[] temp = new object[capacity];

                Array.Copy(items, 0, temp, 0, count);

                items = temp;
            }
            return deleted;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.AppendLine(items[i].ToString());
            }
            return sb.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return new DynarrayIterator(this);
        }
    }
}
