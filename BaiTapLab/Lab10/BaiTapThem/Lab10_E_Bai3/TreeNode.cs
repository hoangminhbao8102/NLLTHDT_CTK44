using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_E_Bai3
{
    public class TreeNode
    {
        private IComparable data;
        private TreeNode leftChild;
        private TreeNode rightChild;

        public IComparable Data
        { 
            get { return data; }
            set { data = value; }
        }
        public TreeNode LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        public TreeNode RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }

        public TreeNode(IComparable data, TreeNode left, TreeNode right)
        {
            this.data = data;
            this.leftChild = left;
            this.rightChild = right;
        }

        public TreeNode(IComparable data) 
        {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }

        public TreeNode()
        {
            this.data = null;
            this.leftChild = null;
            this.rightChild = null;
        }
    }
}
