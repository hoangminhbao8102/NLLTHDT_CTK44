using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai3
{
    public class PreOrderIterator : TreeNodeIterator
    {
        public PreOrderIterator(BinaryTree binTree) : base(binTree)
        {
        }

        protected override void CreateQueue()
        {
            if (tree.Root != null)
            {
                Stack<TreeNode> stack = new Stack<TreeNode>();
                stack.Push(tree.Root);

                while (stack.Count > 0)
                {
                    TreeNode current = stack.Pop();
                    treeNodes.Enqueue(current);

                    // Right child is pushed first so that left child is processed first
                    if (current.RightChild != null)
                    {
                        stack.Push(current.RightChild);
                    }
                    if (current.LeftChild != null)
                    {
                        stack.Push(current.LeftChild);
                    }
                }
            }
        }
    }
}
