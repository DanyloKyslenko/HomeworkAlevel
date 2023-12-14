using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinaryTree
{
    public class BinarySearchTree : IEnumerable<int>
    {
        public Node Root;

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                InsertNode(Root, value);
            }
        }

        private void InsertNode(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    InsertNode(node.Left, value);
                }
            }
            else if (value > node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    InsertNode(node.Right, value);
                }
            }
        }

        public int Count()
        {
            return CountNodes(Root);
        }

        private int CountNodes(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return 1 + CountNodes(node.Left) + CountNodes(node.Right);
            }
        }

        public void Traversal(Action<int> action, TraversalOrder order = TraversalOrder.In)
        {
            switch (order)
            {
                case TraversalOrder.Pre:
                    PreorderTraversal(Root, action);
                    break;
                case TraversalOrder.In:
                    InorderTraversal(Root, action);
                    break;
                case TraversalOrder.Post:
                    PostorderTraversal(Root, action);
                    break;
            }
        }

        private void PreorderTraversal(Node node, Action<int> action)
        {
            if (node != null)
            {
                action(node.Value);
                PreorderTraversal(node.Left, action);
                PreorderTraversal(node.Right, action);
            }
        }

        private void InorderTraversal(Node node, Action<int> action)
        {
            if (node != null)
            {
                InorderTraversal(node.Left, action);
                action(node.Value);
                InorderTraversal(node.Right, action);
            }
        }

        private void PostorderTraversal(Node node, Action<int> action)
        {
            if (node != null)
            {
                PostorderTraversal(node.Left, action);
                PostorderTraversal(node.Right, action);
                action(node.Value);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            var stack = new Stack<Node>();
            stack.Push(Root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node == null)
                {
                    continue;
                }

                yield return node.Value;

                stack.Push(node.Right);
                stack.Push(node.Left);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public enum TraversalOrder
    {
        Pre,
        In,
        Post
    }
}
