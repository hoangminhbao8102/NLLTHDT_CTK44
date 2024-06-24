using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai4_Lab10_Bai04_MangDong_P2__
{
    public delegate bool CheckFunc(object item, object searchValue);
    public delegate int CompareFunc(object prev, object next);

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
            get { return capacity; }
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

        public void Clear()
        {
            items = new object[DEFAULT_SIZE];
            count = 0;
            capacity = DEFAULT_SIZE;
        }

        public bool Contains(CheckFunc function, object searchValue)
        {
            foreach (var item in items)
            {
                if (function(item, searchValue))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Contains(object x)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(x))
                {
                    return true;
                }
            }
            return false;
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

        public int IndexOf(CheckFunc function, object searchValue)
        {
            for (int i = 0; i < count; i++)
            {
                if (function(items[i], searchValue))
                {
                    return i;
                }
            }
            return -1;
        }

        public int IndexOf(object x)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(x))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, object x) 
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            if (count == capacity)
            {
                capacity *= 2;
                object[] temp = new object[capacity];
                Array.Copy(items, 0, temp, 0, count);
                items = temp;
            }

            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
            items[index] = x;
            count++;
        }

        public int LastIndexOf(CheckFunc function, object searchValue)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (function(items[i], searchValue))
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(object x)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (items[i].Equals(x))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(object x)
        {
            int index = Array.IndexOf(items, x, 0, count);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public DynamicArray RemoveAll(CheckFunc function, object searchValue)
        {
            DynamicArray result = new DynamicArray();
            for (int i = 0; i < count; i++)
            {
                if (!function(items[i], searchValue))
                {
                    result.Add(items[i]);
                }
            }
            return result;
        }

        public void RemoveAll(int index, int k) 
        {
            if (index < 0 || k < 0 || index + k > count)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = 0; i < k; i++)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAll(object x)
        {
            int index;
            while ((index = Array.IndexOf(items, x, 0, count)) >= 0)
            {
                RemoveAt(index);
            }
        }

        public void Reverse()
        {
            Array.Reverse(items, 0, count);
        }

        public DynamicArray Search(CheckFunc function, object searchValue)
        {
            DynamicArray result = new DynamicArray();
            foreach (var item in items)
            {
                if (function(item, searchValue))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public void Sort(CompareFunc function)
        {
            Array.Sort(items, 0, count, Comparer<object>.Create((x, y) => function(x, y)));
        }

        private void Swap(int i, int j)
        {
            if (i < 0 || i >= count || j < 0 || j >= count)
            {
                throw new IndexOutOfRangeException();
            }

            object temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        public DynamicArray Take(int index)
        {
            return Take(index, count - index);
        }

        public DynamicArray Take(int index, int k)
        {
            if (index < 0 || k < 0 || index + k > count)
            {
                throw new ArgumentOutOfRangeException();
            }

            DynamicArray result = new DynamicArray(k);
            for (int i = index; i < index + k; i++)
            {
                result.Add(items[i]);
            }
            return result;
        }
    }
}
