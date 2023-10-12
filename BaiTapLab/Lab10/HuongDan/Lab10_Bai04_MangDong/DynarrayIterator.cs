using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai04_MangDong
{
    internal class DynarrayIterator : IEnumerator
    {
        private int currIdx;

        private DynamicArray items;

        public DynarrayIterator(DynamicArray listItems)
        {
            this.items = listItems;
            this.currIdx = -1;
        }

        public bool MoveNext()
        {
            currIdx++;
            return currIdx < items.Count;
        }

        public void Reset()
        {
            currIdx = -1;
        }

        public object Current
        {
            get 
            { 
                if (currIdx < 0 || currIdx >= items.Count) 
                {
                    throw new IndexOutOfRangeException();
                }
                return items[currIdx];
            }
        }
    }
}
