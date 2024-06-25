using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai3
{
    public class IteratorFactory
    {
        public static IEnumerator Create(BinaryTree tree, TraversalOrder torder)
        {
            switch (torder)
            {
                case TraversalOrder.PreOrder:
                    return (IEnumerator)new PreOrderIterator(tree);
                case TraversalOrder.InOrder:
                    return (IEnumerator)new InOrderIterator(tree);
                case TraversalOrder.PostOrder:
                    return (IEnumerator)new PostOrderIterator(tree);
                default:
                    throw new NotImplementedException("Unsupported traversal order.");
            }
        }
    }
}
