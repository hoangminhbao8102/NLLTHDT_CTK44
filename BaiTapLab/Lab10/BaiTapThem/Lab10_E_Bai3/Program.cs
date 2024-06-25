using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new binary tree instance
            BinaryTree binaryTree = new BinaryTree();

            // Insert elements into the binary tree
            binaryTree.Insert(40);
            binaryTree.Insert(25);
            binaryTree.Insert(78);
            binaryTree.Insert(10);
            binaryTree.Insert(32);

            // Using PreOrder iterator directly in Main
            Console.WriteLine("PreOrder Traversal:");
            IEnumerator preOrderIterator = IteratorFactory.Create(binaryTree, TraversalOrder.PreOrder);
            while (preOrderIterator.MoveNext())
            {
                Console.WriteLine(preOrderIterator.Current);
            }
            preOrderIterator.Reset();  // Reset if you might reuse the iterator

            // Using InOrder iterator directly in Main
            Console.WriteLine("\nInOrder Traversal:");
            IEnumerator inOrderIterator = IteratorFactory.Create(binaryTree, TraversalOrder.InOrder);
            while (inOrderIterator.MoveNext())
            {
                Console.WriteLine(inOrderIterator.Current);
            }
            inOrderIterator.Reset();  // Reset if you might reuse the iterator

            // Using PostOrder iterator directly in Main
            Console.WriteLine("\nPostOrder Traversal:");
            IEnumerator postOrderIterator = IteratorFactory.Create(binaryTree, TraversalOrder.PostOrder);
            while (postOrderIterator.MoveNext())
            {
                Console.WriteLine(postOrderIterator.Current);
            }
            postOrderIterator.Reset();  // Reset if you might reuse the iterator

            Console.ReadKey();
        }
    }
}
