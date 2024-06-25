using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai3
{
    public class PostOrderIterator : TreeNodeIterator
    {
        public PostOrderIterator(BinaryTree binTree) : base(binTree)
        {
        }

        protected override void CreateQueue()
        {
            if (tree.Root != null)
            {
                Stack<TreeNode> stack1 = new Stack<TreeNode>();
                Stack<TreeNode> stack2 = new Stack<TreeNode>();
                TreeNode current = tree.Root;

                // Push root to the first stack
                stack1.Push(current);

                // Run while first stack is not empty
                while (stack1.Count > 0)
                {
                    // Pop an item from stack1 and push it to stack2
                    current = stack1.Pop();
                    stack2.Push(current);

                    // Push left and right children of removed item to stack1
                    if (current.LeftChild != null)
                    {
                        stack1.Push(current.LeftChild);
                    }
                    if (current.RightChild != null)
                    {
                        stack1.Push(current.RightChild);
                    }
                }

                // All nodes are pushed to stack2 in reversed post order. Now pop all items from stack2
                // and push them to the queue
                while (stack2.Count > 0)
                {
                    TreeNode node = stack2.Pop();
                    treeNodes.Enqueue(node);
                }
            }
        }
    }
}
