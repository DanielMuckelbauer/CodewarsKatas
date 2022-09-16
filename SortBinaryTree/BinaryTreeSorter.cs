using System.Collections.Generic;
using System.Linq;

namespace SortBinaryTree;

public static class BinaryTreeSorter
{
    public static IEnumerable<int> TreeByLevels(Node root)
    {
        if (root is null)
        {
            return Enumerable.Empty<int>();
        }

        var height = GetHeight(root);
        var list = new List<int>();
        for (var level = 1; level <= height; level++)
        {
            AddLevelToList(root, level, list);
        }

        return list;
    }

    private static void AddLevelToList(Node node, int level, ICollection<int> list)
    {
        if (node is null)
        {
            return;
        }

        switch (level)
        {
            case 1:
                list.Add(node.Value);
                break;
            case > 1:
                AddLevelToList(node.Left, level - 1, list);
                AddLevelToList(node.Right, level - 1, list);
                break;
        }
    }

    private static int GetHeight(Node node)
    {
        if (node is null)
        {
            return 0;
        }

        var leftHeight = GetHeight(node.Left);
        var rightHeight = GetHeight(node.Right);

        return leftHeight > rightHeight
            ? ++leftHeight
            : ++rightHeight;
    }
}