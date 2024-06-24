using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai6_Lab10_Bai04_MangDong_P4__
{
    public class DynamicArray : IEnumerable
    {
        // Define delegates for events
        public delegate void AddedEventHandler(object sender, AddedEventArgs e);
        public delegate void RemovedEventHandler(object sender, RemovedEventArgs e);
        public delegate void SizeChangedEventHandler(object sender, SizeChangedEventArgs e);

        // Define events
        public event AddedEventHandler Added;
        public event RemovedEventHandler Removed;
        public event SizeChangedEventHandler SizeChanged;

        // Event arguments classes
        public class AddedEventArgs : EventArgs
        {
            public object Item { get; }
            public int Index { get; }

            public AddedEventArgs(object item, int index)
            {
                Item = item;
                Index = index;
            }
        }

        public class RemovedEventArgs : EventArgs
        {
            public object Item { get; }
            public int Index { get; }

            public RemovedEventArgs(object item, int index)
            {
                Item = item;
                Index = index;
            }
        }

        public class SizeChangedEventArgs : EventArgs
        {
            public int OldCapacity { get; }
            public int NewCapacity { get; }
            public int CurrentCount { get; }

            public SizeChangedEventArgs(int oldCapacity, int newCapacity, int currentCount)
            {
                OldCapacity = oldCapacity;
                NewCapacity = newCapacity;
                CurrentCount = currentCount;
            }
        }

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
            Added?.Invoke(this, new AddedEventArgs(x, count - 1));
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

        public bool Contains(IChecker checker, object searchValue)
        {
            foreach (var item in items)
            {
                if (checker.Check(item, searchValue))
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
            object deleted = items[index];

            Removed?.Invoke(this, new RemovedEventArgs(deleted, index));
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

        public int IndexOf(IChecker checker, object searchValue)
        {
            for (int i = 0; i < count; i++)
            {
                if (checker.Check(items[i], searchValue))
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
            Added?.Invoke(this, new AddedEventArgs(x, index));
        }

        public int LastIndexOf(IChecker checker, object searchValue)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (checker.Check(items[i], searchValue))
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

        public DynamicArray RemoveAll(IChecker checker, object searchValue)
        {
            DynamicArray result = new DynamicArray();
            for (int i = 0; i < count; i++)
            {
                if (!checker.Check(items[i], searchValue))
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

        public DynamicArray Search(IChecker checker, object searchValue)
        {
            DynamicArray result = new DynamicArray();
            foreach (var item in items)
            {
                if (checker.Check(item, searchValue))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(items, 0, count, Comparer<object>.Create((x, y) => comparer.Compare(x, y)));
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

        private void EnsureCapacity(int minCapacity)
        {
            if (capacity < minCapacity)
            {
                int oldCapacity = capacity;
                capacity *= 2;
                if (capacity < minCapacity) capacity = minCapacity;
                object[] temp = new object[capacity];
                Array.Copy(items, 0, temp, 0, count);
                items = temp;

                SizeChanged?.Invoke(this, new SizeChangedEventArgs(oldCapacity, capacity, count));
            }
        }
    }
}
