using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai3
{
    public abstract class TreeNodeIterator
    {
        protected BinaryTree tree;
        protected Queue<TreeNode> treeNodes;

        public object Current
        {
            get
            {
                return treeNodes.Peek().Data;  // Returns the current element in the iteration
            }
        }

        protected TreeNodeIterator(BinaryTree binTree)
        {
            this.tree = binTree;
            this.treeNodes = new Queue<TreeNode>();
            this.CreateQueue(); // Populate the queue as soon as the iterator is created
        }

        protected abstract void CreateQueue();

        public bool MoveNext()
        {
            if (treeNodes.Count > 0)
            {
                treeNodes.Dequeue(); // Move to the next element in the queue
                return treeNodes.Count > 0;
            }
            return false;
        }

        public void Reset()
        {
            treeNodes.Clear(); // Clear the existing queue
            CreateQueue(); // Re-populate the queue based on the tree structure
        }
    }
}
