using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai3
{
    public class HanoiTower
    {
        private int numberOfDisks;
        private Stack<int> source;
        private Stack<int> auxiliary;
        private Stack<int> destination;

        public HanoiTower(int n)
        {
            numberOfDisks = n;
            source = new Stack<int>();
            auxiliary = new Stack<int>();
            destination = new Stack<int>();

            for (int i = n; i > 0; i--)
            {
                source.Push(i);
            }
        }

        public void Solve()
        {
            MoveDisks(numberOfDisks, source, destination, auxiliary);
        }

        private void MoveDisks(int n, Stack<int> source, Stack<int> destination, Stack<int> auxiliary)
        {
            if (n > 0)
            {
                MoveDisks(n - 1, source, auxiliary, destination);
                destination.Push(source.Pop());
                Console.WriteLine($"Move disk from source to destination");
                MoveDisks(n - 1, auxiliary, destination, source);
            }
        }
    }
}
