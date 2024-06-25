using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai3
{
    public class InOrderIterator : TreeNodeIterator
    {
        public InOrderIterator(BinaryTree binTree) : base(binTree)
        {
        }

        protected override void CreateQueue()
        {
            if (tree.Root != null)
            {
                Stack<TreeNode> stack = new Stack<TreeNode>();
                TreeNode current = tree.Root;

                while (current != null || stack.Count > 0)
                {
                    // Reach the left most Node of the current Node
                    while (current != null)
                    {
                        // Place pointer to a tree node on the stack before traversing the node's left subtree
                        stack.Push(current);
                        current = current.LeftChild;
                    }

                    // Current must be null at this point
                    current = stack.Pop();
                    treeNodes.Enqueue(current);  // Add the node to the queue

                    // We have visited the node and its left subtree. Now, it's right subtree's turn
                    current = current.RightChild;
                }
            }
        }
    }
}
