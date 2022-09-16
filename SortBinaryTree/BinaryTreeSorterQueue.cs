using System.Collections.Generic;

namespace SortBinaryTree;

public static class BinaryTreeSorterQueue
{
    public static IEnumerable<int> TreeByLevels(Node root)
    {
        var list = new List<int>();
        var queue = new Queue<Node>();
        if (root is not null)
        {
            queue.Enqueue(root);
        }

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            if (currentNode is null)
                continue;
            list.Add(currentNode.Value);
            queue.Enqueue(currentNode.Left);
            queue.Enqueue(currentNode.Right);
        }

        return list;
    }
}