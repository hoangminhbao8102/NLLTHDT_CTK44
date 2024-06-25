using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai3
{
    public class BinaryTree
    {
        private TreeNode root;

        public TreeNode Root
        { 
            get { return root; }
            set { root = value; }
        }

        public BinaryTree() 
        {
            this.root = null;
        }

        public BinaryTree(TreeNode root)
        {
            this.root = root;
        }

        public bool Contains(IComparable item)
        {
            TreeNode current = root;
            while (current != null)
            {
                int result = item.CompareTo(current.Data);
                if (result == 0)
                {
                    return true;
                }
                else if (result < 0)
                {
                    current = current.LeftChild;
                }
                else
                {
                    current = current.RightChild;
                }
            }
            return false;
        }

        public void Clear()
        {
            this.root = null;
        }

        public bool Insert(IComparable item) 
        {
            if (root == null)
            {
                root = new TreeNode(item);
                return true;
            }
            else
            {
                TreeNode current = root;
                while (true)
                {
                    int result = item.CompareTo(current.Data);
                    if (result == 0)
                    {
                        return false; // Duplicate item
                    }
                    else if (result < 0)
                    {
                        if (current.LeftChild == null)
                        {
                            current.LeftChild = new TreeNode(item);
                            return true;
                        }
                        current = current.LeftChild;
                    }
                    else
                    {
                        if (current.RightChild == null)
                        {
                            current.RightChild = new TreeNode(item);
                            return true;
                        }
                        current = current.RightChild;
                    }
                }
            }
        }

        public bool Remove(IComparable item)
        {
            TreeNode current = root;
            TreeNode parent = null;
            bool isLeftChild = false;

            // First, find the node to remove (current) and its parent.
            while (current != null && current.Data.CompareTo(item) != 0)
            {
                parent = current;
                if (item.CompareTo(current.Data) < 0)
                {
                    isLeftChild = true;
                    current = current.LeftChild;
                }
                else
                {
                    isLeftChild = false;
                    current = current.RightChild;
                }
            }

            if (current == null) return false; // Item not found

            // Case 1: No children
            if (current.LeftChild == null && current.RightChild == null)
            {
                if (current == root)
                    root = null;
                else if (isLeftChild)
                    parent.LeftChild = null;
                else
                    parent.RightChild = null;
            }
            // Case 2: One child
            else if (current.RightChild == null)
            {
                if (current == root)
                    root = current.LeftChild;
                else if (isLeftChild)
                    parent.LeftChild = current.LeftChild;
                else
                    parent.RightChild = current.LeftChild;
            }
            else if (current.LeftChild == null)
            {
                if (current == root)
                    root = current.RightChild;
                else if (isLeftChild)
                    parent.LeftChild = current.RightChild;
                else
                    parent.RightChild = current.RightChild;
            }
            // Case 3: Two children
            else
            {
                // Find the successor (smallest node in the right subtree)
                TreeNode successor = current.RightChild;
                TreeNode successorParent = current;
                while (successor.LeftChild != null)
                {
                    successorParent = successor;
                    successor = successor.LeftChild;
                }

                // If successor is not the direct child of the node to be removed
                if (successorParent != current)
                {
                    successorParent.LeftChild = successor.RightChild;
                    successor.RightChild = current.RightChild;
                }

                // Replace the current node with the successor
                if (current == root)
                    root = successor;
                else if (isLeftChild)
                    parent.LeftChild = successor;
                else
                    parent.RightChild = successor;

                successor.LeftChild = current.LeftChild;
            }

            return true;
        }

        public IEnumerator GetEnumerator() 
        {
            return Traverse(TraversalOrder.InOrder);
        }

        public IEnumerator Traverse(TraversalOrder torder)
        {
            switch (torder)
            {
                case TraversalOrder.PreOrder:
                    return (IEnumerator)new PreOrderIterator(this);
                case TraversalOrder.InOrder:
                    return (IEnumerator)new InOrderIterator(this);
                case TraversalOrder.PostOrder:
                    return (IEnumerator)new PostOrderIterator(this);
                default:
                    throw new ArgumentOutOfRangeException(nameof(torder), "Unsupported traversal order");
            }
        }
    }
}
